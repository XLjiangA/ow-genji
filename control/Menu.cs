using ow.img;
using ow.manager;
using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ow.control
{
    enum FormState
    {
        none,
        about,
        option
    }
    public partial class menu : Form
    {

        private FormState formState = FormState.none;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        [DllImport("dwmapi.dll")]
        private static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        private static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;

        private const int CS_DROPSHADOW = 0x00020000;

        private const int WM_NCPAINT = 0x0085;

        private const int WM_ACTIVATEAPP = 0x001C;

        private struct MARGINS
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:
                case WM_ACTIVATEAPP:
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)
                m.Result = (IntPtr)HTCAPTION;

        }
        private void SelectButton(Button button)
        {
            MethodInfo methodinfo = button.GetType().GetMethod("SetStyle", BindingFlags.NonPublic | BindingFlags.Instance);
            methodinfo.Invoke(button, BindingFlags.NonPublic, null, new object[] { ControlStyles.Selectable, false }, null);
        }
        public menu()
        {
            m_aeroEnabled = false;
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            notifyIcon1.Text = lbl_tile.Text;
            notifyIcon1.Icon = Icon;
            typeof(msgTootip).GetProperty("_notifyIcon", BindingFlags.NonPublic | BindingFlags.Static).SetValue(null, notifyIcon1);
            SelectButton(btn_option);
            SelectButton(btn_about);
            loadAllImage();
            globalManager.Init();
        }
        public void loadAllImage()
        {
            icons.Read = new icons();
            this.img_ico.Image = Icon.ToBitmap();
            this.btn_close.Image = icons.Read["close"];
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            var btn = sender as Button;
            var state = btn.Name.Contains("option") ? FormState.option : FormState.about;
            if (formState == state) return;
            UpdateForm(state);
        }

        private about _about = null;

        private option _option = null;

        private void Menu_Load(object sender, System.EventArgs e)
        {
            FormShow();
            _about = new about();
            _about.Dock = DockStyle.Fill;
            _about.Visible = false;
            main_pnl.Controls.Add(_about);
            _option = new option();
            _option.Dock = DockStyle.Fill;
            _option.Visible = false;
            main_pnl.Controls.Add(_option);
            UpdateForm(FormState.none);
        }
        private void UpdateForm(FormState state)
        {
            formState = state;
            var flag = formState == FormState.option;
            _about.Visible = !flag;
            _option.Visible = flag;


        }

        private void mouseHover(object sender, System.EventArgs e)
        {
            var img = sender as PictureBox;
            img.BackColor = Color.White;
            img.Image = icons.Read["close1"];
        }

        private void mouseLeave(object sender, System.EventArgs e)
        {
            var img = sender as PictureBox;
            img.BackColor = Color.White;
            img.Image = icons.Read["close"];
        }
        private bool formMove = false;
        private Point formPoint;

        private void tilebar_pnl_MouseDown(object sender, MouseEventArgs e)
        {
            formPoint = new Point();
            int xOffset;
            int yOffset;
            if (e.Button == MouseButtons.Left)
            {
                xOffset = -(left_pnl.Width + e.X + SystemInformation.FrameBorderSize.Width);
                yOffset = -(e.Y - SystemInformation.FrameBorderSize.Height);
                formPoint = new Point(xOffset, yOffset);
                formMove = true;
            }

        }

        private void tilebar_pnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (formMove)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(formPoint.X, formPoint.Y);
                Location = mousePos;
            }
        }

        private void tilebar_pnl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                formMove = false;
            }
        }

        private void btn_close_Click(object sender, System.EventArgs e)
        {
            Visible = false;
            msgTootip.show("已最小化置托盘");
        }

        private void FormShow()
        {
            Visible = true;
            Activate();
        }
        private void 显示设置ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormShow();
            UpdateForm(FormState.option);
        }

        private void 关于ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            FormShow();
            UpdateForm(FormState.about);

        }

        private void 退出ToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            globalManager.instance.ow.save();
            msgTootip.tipHide();
            Environment.Exit(0);
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            FormShow();
        }
    }

}