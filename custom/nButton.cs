using ow.img;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ow.custom
{
    public partial class nButton : Label
    {
        public nButton()
        {
            InitializeComponent();
            ImageAlign = ContentAlignment.MiddleLeft;
            TextAlign = ContentAlignment.MiddleRight;
            ON = false;
            IsRest = false;
            Size = new Size(100, 25);

        }
        public bool IsRest { get; set; }

        private bool _on = false;

        public delegate void nButton_ONchangeDelegate(object sender, bool nval);

        public event nButton_ONchangeDelegate nButton_ONchange;

        public bool ON
        {
            get
            {

                return _on;
            }
            set
            {
                if (nButton_ONchange == null)
                {
                    nButton_ONchange += ONChange;
                }
                nButton_ONchange(this, value);
                _on = value;
            }
        }
        public void ONChange(object sender, bool nval)
        {
            try
            {
                if (nval)
                {
                    Image = new Bitmap(icons.Read["on"], new Size(40, 40));

                }
                else
                {
                    Image = new Bitmap(icons.Read["off"], new Size(40, 40));
                }
            }
            catch
            {

            }

        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.X <= Width / 2 && e.Y <= Height && e.Button == MouseButtons.Left)
            {
                ON = !ON;
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && IsRest)
            {
                ON = false;
            }
        }

        public nButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

        }
    }
}
