using ow.img;
using ow.manager;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ow.control
{
    public partial class option : UserControl
    {
        public delegateManager.valueUpdataDelegate _valueUpdata;

        public static option ins = null;

        public option()
        {
            ins = this;
            InitializeComponent();
            _valueUpdata += valueUpdata;
            loadAllImage();
            lbl_gmkey.ContextMenu = new ContextMenu();
            lbl_mkey.ContextMenu = new ContextMenu();
            num_dpi.ContextMenu = new ContextMenu();
            num_game.ContextMenu = new ContextMenu();
            var gamein = globalManager.instance.ow;
            nbtn_fw.ON = gamein.isFront;
            nbtn_loop.ON = gamein.isLoop;
            lbl_mkey.Text = gamein.cenKey.tokeyname();
            lbl_gmkey.Text = gamein.directionKey.tokeyname();
            num_dpi.Text = gamein.mouseSpeed.ToString();
            num_game.Text = gamein.mouseSpeedInGame.ToString();
            direction_change();
        }
        private void valueUpdata(dataType dt, object newobj)
        {
            switch (dt)
            {
                case dataType.front:
                    globalManager.instance.ow.isFront = (bool)newobj;
                    break;
                case dataType.loop:
                    globalManager.instance.ow.isLoop = (bool)newobj;
                    break;
                case dataType.cenkey:
                    globalManager.instance.ow.cenKey = (int)newobj;
                    break;
                case dataType.dirkey:
                    globalManager.instance.ow.directionKey = (int)newobj;
                    break;
                case dataType.mspeed:
                    globalManager.instance.ow.mouseSpeed = (int)newobj;
                    break;
                case dataType.gmspeed:
                    globalManager.instance.ow.mouseSpeedInGame = (int)newobj;
                    break;
                case dataType.dir:
                    globalManager.instance.ow.cenDirection = (Direction)newobj;
                    direction_change();
                    break;
            }
        }
        private void direction_change()
        {
            img_left.Image = globalManager.instance.ow.cenDirection == Direction.left ? icons.Read["left"] : icons.Read["left1"];
            img_right.Image = globalManager.instance.ow.cenDirection == Direction.right ? icons.Read["right"] : icons.Read["right1"];
        }
        private void loadAllImage()
        {
            img_cen.Image = icons.Read["keybord"];
            img_qie.Image = icons.Read["keybord"];
            img_mouse.Image = icons.Read["mouse"];
            img_mouse1.Image = icons.Read["mouse"];

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar >= 57) && (e.KeyChar != 8) && (e.KeyChar == 46))
                e.Handled = true;
        }

        private void num_game_TextChanged(object sender, EventArgs e)
        {
            if (num_game.Text == "")
            {
                num_game.Text = "0";
            }
            else if (int.Parse(num_game.Text) > 100)
            {
                num_game.Text = "100";
            }
            else
            {
                num_game.Text = int.Parse(num_game.Text).ToString();
                valueUpdata(dataType.gmspeed, int.Parse(num_game.Text));
            }
        }

        private void num_dpi_TextChanged(object sender, EventArgs e)
        {
            if (num_dpi.Text == "")
            {
                num_dpi.Text = "0";
            }
            else if (int.Parse(num_dpi.Text) > 20000)
            {
                num_dpi.Text = "20000";
            }
            else
            {
                num_dpi.Text = int.Parse(num_dpi.Text).ToString();
                valueUpdata(dataType.mspeed, int.Parse(num_dpi.Text));
            }
        }

        private void nButton2_Click(object sender, EventArgs e)
        {
            globalManager.instance.ow.save();
            msgTootip.show("保存成功");
        }

        bool keyChange = false;

        private void key_DoubleClick(object sender, EventArgs e)
        {
            var lbl = sender as TextBox;
            pressKeyTimer.Enabled = true;
            changetext = lbl;
            changetext.ForeColor = kt ? Color.Gray : Color.Black;
            lbl.Text = "pressKey";
        }
        private void key_KeyDown(object sender, object e)
        {
            var lbl = sender as TextBox;
            PreviewKeyDownEventArgs key = e as PreviewKeyDownEventArgs;
            MouseEventArgs mKey = e as MouseEventArgs;
            if (key != null && keyChange)
            {
                lbl.Text = key.KeyCode.ToString();
                lbl.ForeColor = Color.Gold;
                keyChange = false;
                valueUpdata(!lbl.Name.Contains("gmkey") ? dataType.cenkey : dataType.dirkey, key.KeyValue);
            }
            else
            if (mKey != null && keyChange)
            {

                lbl.Text = mKey.Button.ToString();
                lbl.ForeColor = Color.Gold;
                keyChange = false;
                valueUpdata(!lbl.Name.Contains("gmkey") ? dataType.cenkey : dataType.dirkey, mKey.Button);
            }
            else if (lbl.Text == "presskey".ToUpper())
            {
                keyChange = true;
            }

        }
        TextBox changetext = null;
        bool kt = false;
        private void pressKeyTimer_Tick(object sender, EventArgs e)
        {
            if (keyChange && changetext != null)
            {
                //changetext.Focus();
                changetext.ForeColor = kt ? Color.Gray : Color.Black;
                kt = !kt;
            }
        }

        private void nbtn_loop_Click(object sender, bool nval)
        {
            valueUpdata(dataType.loop, nval);
            nbtn_loop.Text = nval ? "持续循环" : "一次循环";
        }
        private void nbtn_fw_Click(object sender, bool nval)
        {
            valueUpdata(dataType.front, nval);
            nbtn_fw.Text = nval ? "正面蹭留" : "侧面蹭留";
        }

        private void img_right_Click(object sender, EventArgs e)
        {
            var img = sender as PictureBox;
            var dir = img.Name.Contains("right") ? Direction.right : Direction.left;
            valueUpdata(dataType.dir, dir);
        }

        private void mMouseHover(object sender, EventArgs e)
        {
            globalManager.instance.waitInput = true;
        }

        private void mMouseLeave(object sender, EventArgs e)
        {
            globalManager.instance.waitInput = false;
        }
    }
}
