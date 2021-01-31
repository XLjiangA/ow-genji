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
    public partial class Menu : Form
    {
        [DllImport("user32.dll", EntryPoint = "AnimateWindow")]
        private static extern bool AnimateWindow(IntPtr handle, int ms, int flags);

        public const Int32 AW_HOR_POSITIVE = 0x00000001;

        public const Int32 AW_HOR_NEGATIVE = 0x00000002;

        public const Int32 AW_VER_POSITIVE = 0x00000004;

        public const Int32 AW_VER_NEGATIVE = 0x00000008;

        public const Int32 AW_CENTER = 0x00000010;

        public const Int32 AW_HIDE = 0x00010000;

        public const Int32 AW_ACTIVATE = 0x00020000;

        public const Int32 AW_SLIDE = 0x00040000;

        public const Int32 AW_BLEND = 0x00080000;

        private FormState formState = FormState.none;

        public Menu()
        {
            InitializeComponent();
            notifyIcon1.Text = lbl_tile.Text;
            notifyIcon1.Icon = Icon;
            typeof(msgTootip).GetProperty("_notifyIcon", BindingFlags.NonPublic | BindingFlags.Static).SetValue(null, notifyIcon1);
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
            img.BackColor = Color.DeepSkyBlue;
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
            AnimateWindow(this.Handle, 300, AW_HIDE + AW_CENTER);
            msgTootip.show("已最小化置托盘");
        }

        private void FormShow()
        {
            AnimateWindow(this.Handle, 300, AW_ACTIVATE + AW_CENTER);
            var area = Screen.GetWorkingArea(Point.Empty);
            Location = new Point(area.Width - Width, area.Height - Height);
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


    }

}