
namespace ow.control
{
    partial class about
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
            this.label2 = new System.Windows.Forms.Label();
            this.tim_rgb = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cImg_avatar = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.img_qq = new System.Windows.Forms.PictureBox();
            this.img_git = new System.Windows.Forms.PictureBox();
            this.img_bili = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cImg_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_qq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_git)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bili)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(128, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "艾莉丝#51209";
            // 
            // tim_rgb
            // 
            this.tim_rgb.Interval = 16;
            this.tim_rgb.Tick += new System.EventHandler(this.tim_rgb_Tick);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // cImg_avatar
            // 
            this.cImg_avatar.Location = new System.Drawing.Point(155, 59);
            this.cImg_avatar.Name = "cImg_avatar";
            this.cImg_avatar.Size = new System.Drawing.Size(50, 50);
            this.cImg_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cImg_avatar.TabIndex = 3;
            this.cImg_avatar.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(230, 345);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(155, 12);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "源氏跑酷交流群: 241328872";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // img_qq
            // 
            this.img_qq.Location = new System.Drawing.Point(234, 297);
            this.img_qq.Name = "img_qq";
            this.img_qq.Size = new System.Drawing.Size(25, 25);
            this.img_qq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_qq.TabIndex = 7;
            this.img_qq.TabStop = false;
            this.img_qq.Click += new System.EventHandler(this.img_qq_Click);
            // 
            // img_git
            // 
            this.img_git.Location = new System.Drawing.Point(271, 297);
            this.img_git.Name = "img_git";
            this.img_git.Size = new System.Drawing.Size(25, 25);
            this.img_git.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_git.TabIndex = 8;
            this.img_git.TabStop = false;
            this.img_git.Click += new System.EventHandler(this.img_git_Click);
            // 
            // img_bili
            // 
            this.img_bili.Location = new System.Drawing.Point(307, 297);
            this.img_bili.Name = "img_bili";
            this.img_bili.Size = new System.Drawing.Size(25, 25);
            this.img_bili.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_bili.TabIndex = 9;
            this.img_bili.TabStop = false;
            this.img_bili.Click += new System.EventHandler(this.img_bili_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(63, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 60);
            this.label1.TabIndex = 10;
            this.label1.Text = "哇你看她会发光诶#5776 - 制作软件的想法来源\r\n\r\nMasterZ - 提供侧面蹭墙留爬宏文件以及实现思路\r\n\r\n宠坏万千少女#5212 - 提供正面蹭墙留" +
    "爬思路\r\n";
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_bili);
            this.Controls.Add(this.img_git);
            this.Controls.Add(this.img_qq);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cImg_avatar);
            this.Controls.Add(this.label2);
            this.Name = "about";
            this.Size = new System.Drawing.Size(398, 374);
            ((System.ComponentModel.ISupportInitialize)(this.cImg_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_qq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_git)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bili)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tim_rgb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox cImg_avatar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox img_qq;
        private System.Windows.Forms.PictureBox img_git;
        private System.Windows.Forms.PictureBox img_bili;
        private System.Windows.Forms.Label label1;
    }
}
