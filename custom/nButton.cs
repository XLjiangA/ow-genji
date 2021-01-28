using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
namespace custom
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
        public bool ON
        {
            get
            {

                return _on;
            }
            set
            {
                ONChange(value);
                _on = value;
            }
        }
        protected void ONChange(bool newvalue)
        {
            try
            {
                if (newvalue)
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
