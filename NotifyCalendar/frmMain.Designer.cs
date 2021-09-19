
namespace NotifyCalendar
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEvents = new System.Windows.Forms.ToolStripMenuItem();
            this.ایجادرویدادجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تغییرصفحهنمایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تبدیلتاریخToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnOpenAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notify
            // 
            this.notify.ContextMenuStrip = this.menu;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Notify Calendar";
            this.notify.Visible = true;
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEvents,
            this.ایجادرویدادجدیدToolStripMenuItem,
            this.تغییرصفحهنمایشToolStripMenuItem,
            this.btnOpenAlbum,
            this.تبدیلتاریخToolStripMenuItem,
            this.btnSettings,
            this.btnAbout,
            this.btnExit});
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(181, 202);
            // 
            // btnEvents
            // 
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(180, 22);
            this.btnEvents.Text = "رویداد امروز";
            this.btnEvents.Visible = false;
            // 
            // ایجادرویدادجدیدToolStripMenuItem
            // 
            this.ایجادرویدادجدیدToolStripMenuItem.Name = "ایجادرویدادجدیدToolStripMenuItem";
            this.ایجادرویدادجدیدToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ایجادرویدادجدیدToolStripMenuItem.Text = "ایجاد رویداد جدید";
            this.ایجادرویدادجدیدToolStripMenuItem.Visible = false;
            // 
            // تغییرصفحهنمایشToolStripMenuItem
            // 
            this.تغییرصفحهنمایشToolStripMenuItem.Name = "تغییرصفحهنمایشToolStripMenuItem";
            this.تغییرصفحهنمایشToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.تغییرصفحهنمایشToolStripMenuItem.Text = "تغییر پس زمینه";
            this.تغییرصفحهنمایشToolStripMenuItem.Click += new System.EventHandler(this.BackgroundChenger);
            // 
            // تبدیلتاریخToolStripMenuItem
            // 
            this.تبدیلتاریخToolStripMenuItem.Name = "تبدیلتاریخToolStripMenuItem";
            this.تبدیلتاریخToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.تبدیلتاریخToolStripMenuItem.Text = "تبدیل تاریخ";
            this.تبدیلتاریخToolStripMenuItem.Visible = false;
            // 
            // btnSettings
            // 
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(180, 22);
            this.btnSettings.Text = "تنظیمات";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(180, 22);
            this.btnAbout.Text = "درباره";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 22);
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.frmMain_Leave);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.BackgroundChenger);
            // 
            // btnOpenAlbum
            // 
            this.btnOpenAlbum.Name = "btnOpenAlbum";
            this.btnOpenAlbum.Size = new System.Drawing.Size(180, 22);
            this.btnOpenAlbum.Text = "آلبوم تصاویر پس‌زمینه";
            this.btnOpenAlbum.Click += new System.EventHandler(this.btnOpenAlbum_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 124);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Notify Calendar";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Leave += new System.EventHandler(this.frmMain_Leave);
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem btnEvents;
        private System.Windows.Forms.ToolStripMenuItem btnSettings;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem تغییرصفحهنمایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ایجادرویدادجدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem تبدیلتاریخToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnOpenAlbum;
    }
}

