using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace control
{
    public partial class about : UserControl
    {
        Color[] Colors = null;
        int i = 0;
        public about()
        {
            InitializeComponent();
            tim_rgb.Enabled = true;
            cImg_avatar.Image = icons.Read["avatar"];
            Colors = new Color[]
        {
            Color.Red,
            Color.Orange,
            Color.Yellow,
            Color.Green,
            Color.Cyan,
            Color.Blue,
            Color.Purple
        };

        }

        private void tim_rgb_Tick(object sender, EventArgs e)
        {

            label2.ForeColor = Colors[i];
            i++;
            if (i > 6)
            {
                i = 0;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jq.qq.com/?_wv=1027&k=JeCYil63");
        }
    }
}
