

partial class Menu
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

    #region Windows 窗体设计器生成的代码

    /// <summary>
    /// 设计器支持所需的方法 - 不要修改
    /// 使用代码编辑器修改此方法的内容。
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.left_pnl = new System.Windows.Forms.Panel();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_option = new System.Windows.Forms.Button();
            this.top_pnl = new System.Windows.Forms.Panel();
            this.lbl_tile = new System.Windows.Forms.Label();
            this.img_ico = new System.Windows.Forms.PictureBox();
            this.tilebar_pnl = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.main_pnl = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.left_pnl.SuspendLayout();
            this.top_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_ico)).BeginInit();
            this.tilebar_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // left_pnl
            // 
            this.left_pnl.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.left_pnl.Controls.Add(this.btn_about);
            this.left_pnl.Controls.Add(this.btn_option);
            this.left_pnl.Controls.Add(this.top_pnl);
            this.left_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_pnl.Location = new System.Drawing.Point(0, 0);
            this.left_pnl.Name = "left_pnl";
            this.left_pnl.Size = new System.Drawing.Size(100, 398);
            this.left_pnl.TabIndex = 0;
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.Transparent;
            this.btn_about.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_about.FlatAppearance.BorderSize = 0;
            this.btn_about.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btn_about.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Location = new System.Drawing.Point(0, 112);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(100, 42);
            this.btn_about.TabIndex = 3;
            this.btn_about.Text = "关 于";
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.Button_Click);
            // 
            // btn_option
            // 
            this.btn_option.BackColor = System.Drawing.Color.Transparent;
            this.btn_option.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_option.FlatAppearance.BorderSize = 0;
            this.btn_option.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btn_option.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_option.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_option.Location = new System.Drawing.Point(0, 70);
            this.btn_option.Name = "btn_option";
            this.btn_option.Size = new System.Drawing.Size(100, 42);
            this.btn_option.TabIndex = 2;
            this.btn_option.Text = "设 置";
            this.btn_option.UseVisualStyleBackColor = false;
            this.btn_option.Click += new System.EventHandler(this.Button_Click);
            // 
            // top_pnl
            // 
            this.top_pnl.Controls.Add(this.lbl_tile);
            this.top_pnl.Controls.Add(this.img_ico);
            this.top_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_pnl.Location = new System.Drawing.Point(0, 0);
            this.top_pnl.Name = "top_pnl";
            this.top_pnl.Size = new System.Drawing.Size(100, 70);
            this.top_pnl.TabIndex = 1;
            // 
            // lbl_tile
            // 
            this.lbl_tile.AutoSize = true;
            this.lbl_tile.ForeColor = System.Drawing.Color.White;
            this.lbl_tile.Location = new System.Drawing.Point(18, 46);
            this.lbl_tile.Name = "lbl_tile";
            this.lbl_tile.Size = new System.Drawing.Size(65, 12);
            this.lbl_tile.TabIndex = 1;
            this.lbl_tile.Text = "蹭墙小助手";
            // 
            // img_ico
            // 
            this.img_ico.Location = new System.Drawing.Point(30, 5);
            this.img_ico.Margin = new System.Windows.Forms.Padding(0);
            this.img_ico.Name = "img_ico";
            this.img_ico.Size = new System.Drawing.Size(34, 34);
            this.img_ico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_ico.TabIndex = 0;
            this.img_ico.TabStop = false;
            // 
            // tilebar_pnl
            // 
            this.tilebar_pnl.BackColor = System.Drawing.Color.White;
            this.tilebar_pnl.Controls.Add(this.btn_close);
            this.tilebar_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tilebar_pnl.Location = new System.Drawing.Point(100, 0);
            this.tilebar_pnl.Name = "tilebar_pnl";
            this.tilebar_pnl.Size = new System.Drawing.Size(398, 24);
            this.tilebar_pnl.TabIndex = 1;
            this.tilebar_pnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tilebar_pnl_MouseDown);
            this.tilebar_pnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tilebar_pnl_MouseMove);
            this.tilebar_pnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tilebar_pnl_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.Location = new System.Drawing.Point(374, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 24);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 0;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseLeave += new System.EventHandler(this.mouseLeave);
            this.btn_close.MouseHover += new System.EventHandler(this.mouseHover);
            // 
            // main_pnl
            // 
            this.main_pnl.BackColor = System.Drawing.Color.White;
            this.main_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_pnl.Location = new System.Drawing.Point(100, 24);
            this.main_pnl.Name = "main_pnl";
            this.main_pnl.Size = new System.Drawing.Size(398, 374);
            this.main_pnl.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示设置ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 70);
            // 
            // 显示设置ToolStripMenuItem
            // 
            this.显示设置ToolStripMenuItem.Name = "显示设置ToolStripMenuItem";
            this.显示设置ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.显示设置ToolStripMenuItem.Text = "显示主界面";
            this.显示设置ToolStripMenuItem.Click += new System.EventHandler(this.显示设置ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 398);
            this.Controls.Add(this.main_pnl);
            this.Controls.Add(this.tilebar_pnl);
            this.Controls.Add(this.left_pnl);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(2560, 1440);
            this.Name = "Menu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.left_pnl.ResumeLayout(false);
            this.top_pnl.ResumeLayout(false);
            this.top_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_ico)).EndInit();
            this.tilebar_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel left_pnl;
    private System.Windows.Forms.Panel top_pnl;
    private System.Windows.Forms.Button btn_about;
    private System.Windows.Forms.Button btn_option;
    private System.Windows.Forms.PictureBox img_ico;
    private System.Windows.Forms.Label lbl_tile;
    private System.Windows.Forms.Panel tilebar_pnl;
    private System.Windows.Forms.PictureBox btn_close;
    private System.Windows.Forms.Panel main_pnl;
    private System.Windows.Forms.NotifyIcon notifyIcon1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem 显示设置ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
}


