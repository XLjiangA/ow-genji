using ow.img;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ow.control
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
            cImg_about.Image = icons.Read["about"];
            img_qq.Image = icons.Read["qq"];
            img_git.Image = icons.Read["git"];
            img_bili.Image = icons.Read["bili"];
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
            i = i >= 6 ? 0 : i + 1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://jq.qq.com/?_wv=1027&k=JeCYil63");
        }

        private void img_git_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/XLjiangA");
        }

        private void img_bili_Click(object sender, EventArgs e)
        {
            Process.Start("https://space.bilibili.com/25796529");
        }

        private void img_qq_Click(object sender, EventArgs e)
        {
            Process.Start("tencent://message/?uin=1723955942");
        }
    }
}
