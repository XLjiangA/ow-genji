
namespace control
{
    partial class option
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.img_cen = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_mkey = new System.Windows.Forms.TextBox();
            this.lbl_gmkey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.img_qie = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.img_mouse = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.img_mouse1 = new System.Windows.Forms.PictureBox();
            this.num_dpi = new System.Windows.Forms.TextBox();
            this.num_game = new System.Windows.Forms.TextBox();
            this.img_left = new System.Windows.Forms.PictureBox();
            this.img_right = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nbtn_save = new custom.nButton(this.components);
            this.nbtn_loop = new custom.nButton(this.components);
            this.pressKeyTimer = new System.Windows.Forms.Timer(this.components);
            this.nBtn_fw = new custom.nButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.img_cen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_qie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_mouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_mouse1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_right)).BeginInit();
            this.SuspendLayout();
            // 
            // img_cen
            // 
            this.img_cen.Location = new System.Drawing.Point(27, 24);
            this.img_cen.Name = "img_cen";
            this.img_cen.Size = new System.Drawing.Size(25, 25);
            this.img_cen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_cen.TabIndex = 0;
            this.img_cen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(56, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "蹭墙留爬:";
            // 
            // lbl_mkey
            // 
            this.lbl_mkey.BackColor = System.Drawing.Color.White;
            this.lbl_mkey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_mkey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_mkey.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_mkey.ForeColor = System.Drawing.Color.Gold;
            this.lbl_mkey.Location = new System.Drawing.Point(116, 27);
            this.lbl_mkey.MaxLength = 20;
            this.lbl_mkey.Name = "lbl_mkey";
            this.lbl_mkey.ReadOnly = true;
            this.lbl_mkey.Size = new System.Drawing.Size(60, 16);
            this.lbl_mkey.TabIndex = 2;
            this.lbl_mkey.Text = "mouse1";
            this.lbl_mkey.DoubleClick += new System.EventHandler(this.key_DoubleClick);
            this.lbl_mkey.MouseLeave += new System.EventHandler(this.mMouseLeave);
            this.lbl_mkey.MouseHover += new System.EventHandler(this.mMouseHover);
            this.lbl_mkey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_KeyDown);
            this.lbl_mkey.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.key_KeyDown);
            // 
            // lbl_gmkey
            // 
            this.lbl_gmkey.BackColor = System.Drawing.Color.White;
            this.lbl_gmkey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_gmkey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_gmkey.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_gmkey.ForeColor = System.Drawing.Color.Gold;
            this.lbl_gmkey.Location = new System.Drawing.Point(116, 61);
            this.lbl_gmkey.MaxLength = 20;
            this.lbl_gmkey.Name = "lbl_gmkey";
            this.lbl_gmkey.ReadOnly = true;
            this.lbl_gmkey.Size = new System.Drawing.Size(60, 16);
            this.lbl_gmkey.TabIndex = 5;
            this.lbl_gmkey.Text = "mouse1";
            this.lbl_gmkey.DoubleClick += new System.EventHandler(this.key_DoubleClick);
            this.lbl_gmkey.MouseLeave += new System.EventHandler(this.mMouseLeave);
            this.lbl_gmkey.MouseHover += new System.EventHandler(this.mMouseHover);
            this.lbl_gmkey.MouseUp += new System.Windows.Forms.MouseEventHandler(this.key_KeyDown);
            this.lbl_gmkey.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.key_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(56, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "方向变更:";
            // 
            // img_qie
            // 
            this.img_qie.Location = new System.Drawing.Point(27, 55);
            this.img_qie.Name = "img_qie";
            this.img_qie.Size = new System.Drawing.Size(25, 25);
            this.img_qie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_qie.TabIndex = 3;
            this.img_qie.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(56, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "游戏灵敏度:";
            // 
            // img_mouse
            // 
            this.img_mouse.Location = new System.Drawing.Point(27, 124);
            this.img_mouse.Name = "img_mouse";
            this.img_mouse.Size = new System.Drawing.Size(25, 25);
            this.img_mouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_mouse.TabIndex = 6;
            this.img_mouse.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(56, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "鼠标灵敏度:";
            // 
            // img_mouse1
            // 
            this.img_mouse1.Location = new System.Drawing.Point(27, 91);
            this.img_mouse1.Name = "img_mouse1";
            this.img_mouse1.Size = new System.Drawing.Size(25, 25);
            this.img_mouse1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_mouse1.TabIndex = 8;
            this.img_mouse1.TabStop = false;
            // 
            // num_dpi
            // 
            this.num_dpi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_dpi.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_dpi.ForeColor = System.Drawing.Color.Gold;
            this.num_dpi.Location = new System.Drawing.Point(133, 97);
            this.num_dpi.MaxLength = 5;
            this.num_dpi.Name = "num_dpi";
            this.num_dpi.Size = new System.Drawing.Size(43, 16);
            this.num_dpi.TabIndex = 10;
            this.num_dpi.Text = "1200";
            this.num_dpi.TextChanged += new System.EventHandler(this.num_dpi_TextChanged);
            this.num_dpi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // num_game
            // 
            this.num_game.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_game.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.num_game.ForeColor = System.Drawing.Color.Gold;
            this.num_game.Location = new System.Drawing.Point(133, 132);
            this.num_game.MaxLength = 3;
            this.num_game.Name = "num_game";
            this.num_game.Size = new System.Drawing.Size(43, 16);
            this.num_game.TabIndex = 11;
            this.num_game.Text = "15";
            this.num_game.TextChanged += new System.EventHandler(this.num_game_TextChanged);
            this.num_game.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // img_left
            // 
            this.img_left.Location = new System.Drawing.Point(231, 55);
            this.img_left.Name = "img_left";
            this.img_left.Size = new System.Drawing.Size(50, 50);
            this.img_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_left.TabIndex = 14;
            this.img_left.TabStop = false;
            this.img_left.Click += new System.EventHandler(this.img_right_Click);
            // 
            // img_right
            // 
            this.img_right.Location = new System.Drawing.Point(298, 55);
            this.img_right.Name = "img_right";
            this.img_right.Size = new System.Drawing.Size(50, 50);
            this.img_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_right.TabIndex = 15;
            this.img_right.TabStop = false;
            this.img_right.Click += new System.EventHandler(this.img_right_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(238, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "当前蹭留方向";
            // 
            // nbtn_save
            // 
            this.nbtn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nbtn_save.IsRest = true;
            this.nbtn_save.Location = new System.Drawing.Point(181, 210);
            this.nbtn_save.Name = "nbtn_save";
            this.nbtn_save.ON = false;
            this.nbtn_save.Size = new System.Drawing.Size(100, 25);
            this.nbtn_save.TabIndex = 13;
            this.nbtn_save.Text = "保存设置";
            this.nbtn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nbtn_save.Click += new System.EventHandler(this.nButton2_Click);
            // 
            // nbtn_loop
            // 
            this.nbtn_loop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nbtn_loop.IsRest = false;
            this.nbtn_loop.Location = new System.Drawing.Point(27, 210);
            this.nbtn_loop.Name = "nbtn_loop";
            this.nbtn_loop.ON = true;
            this.nbtn_loop.Size = new System.Drawing.Size(100, 25);
            this.nbtn_loop.TabIndex = 12;
            this.nbtn_loop.Text = "持续循环";
            this.nbtn_loop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nbtn_loop.Click += new System.EventHandler(this.nbtn_loop_Click);
            // 
            // pressKeyTimer
            // 
            this.pressKeyTimer.Interval = 330;
            this.pressKeyTimer.Tick += new System.EventHandler(this.pressKeyTimer_Tick);
            // 
            // nBtn_fw
            // 
            this.nBtn_fw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nBtn_fw.IsRest = false;
            this.nBtn_fw.Location = new System.Drawing.Point(25, 172);
            this.nBtn_fw.Name = "nBtn_fw";
            this.nBtn_fw.ON = false;
            this.nBtn_fw.Size = new System.Drawing.Size(100, 25);
            this.nBtn_fw.TabIndex = 17;
            this.nBtn_fw.Text = "正面蹭留";
            this.nBtn_fw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nBtn_fw.Click += new System.EventHandler(this.nBtn_fw_Click);
            // 
            // option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.nBtn_fw);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.img_right);
            this.Controls.Add(this.img_left);
            this.Controls.Add(this.nbtn_save);
            this.Controls.Add(this.nbtn_loop);
            this.Controls.Add(this.num_game);
            this.Controls.Add(this.num_dpi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.img_mouse1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.img_mouse);
            this.Controls.Add(this.lbl_gmkey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.img_qie);
            this.Controls.Add(this.lbl_mkey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_cen);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "option";
            this.Size = new System.Drawing.Size(398, 374);
            ((System.ComponentModel.ISupportInitialize)(this.img_cen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_qie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_mouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_mouse1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_right)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_cen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lbl_mkey;
        private System.Windows.Forms.TextBox lbl_gmkey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox img_qie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox img_mouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox img_mouse1;
        private System.Windows.Forms.TextBox num_dpi;
        private System.Windows.Forms.TextBox num_game;
        private custom.nButton nbtn_loop;
        private custom.nButton nbtn_save;
        private System.Windows.Forms.PictureBox img_left;
        private System.Windows.Forms.PictureBox img_right;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer pressKeyTimer;
        private custom.nButton nBtn_fw;
    }
}
