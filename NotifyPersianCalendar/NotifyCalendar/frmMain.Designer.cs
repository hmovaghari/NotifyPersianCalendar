
namespace  NotifyPersianCalendar
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
            this.btnAddEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBackgroundChenger = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenAlbum = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenBackgroundDirectory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDateConvert = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundTimer = new System.Windows.Forms.Timer(this.components);
            this.calendarTimer = new System.Windows.Forms.Timer(this.components);
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notify
            // 
            this.notify.ContextMenuStrip = this.menu;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "Notify Calendar";
            this.notify.Visible = true;
            this.notify.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoadCalendar);
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEvents,
            this.btnAddEvent,
            this.btnBackgroundChenger,
            this.btnOpenAlbum,
            this.btnOpenBackgroundDirectory,
            this.btnDateConvert,
            this.btnCheckUpdate,
            this.btnSettings,
            this.btnAbout,
            this.btnExit});
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menu.Size = new System.Drawing.Size(178, 224);
            // 
            // btnEvents
            // 
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(177, 22);
            this.btnEvents.Text = "رویداد امروز";
            this.btnEvents.Visible = false;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(177, 22);
            this.btnAddEvent.Text = "ایجاد رویداد جدید";
            this.btnAddEvent.Visible = false;
            // 
            // btnBackgroundChenger
            // 
            this.btnBackgroundChenger.Name = "btnBackgroundChenger";
            this.btnBackgroundChenger.Size = new System.Drawing.Size(177, 22);
            this.btnBackgroundChenger.Text = "تغییر پس زمینه";
            this.btnBackgroundChenger.Click += new System.EventHandler(this.BackgroundChenger);
            // 
            // btnOpenAlbum
            // 
            this.btnOpenAlbum.Name = "btnOpenAlbum";
            this.btnOpenAlbum.Size = new System.Drawing.Size(177, 22);
            this.btnOpenAlbum.Text = "آلبوم تصاویر پس‌زمینه";
            this.btnOpenAlbum.Click += new System.EventHandler(this.btnOpenAlbum_Click);
            // 
            // btnOpenBackgroundDirectory
            // 
            this.btnOpenBackgroundDirectory.Name = "btnOpenBackgroundDirectory";
            this.btnOpenBackgroundDirectory.Size = new System.Drawing.Size(177, 22);
            this.btnOpenBackgroundDirectory.Text = "مسیر پس‌زمینه";
            this.btnOpenBackgroundDirectory.Click += new System.EventHandler(this.btnOpenBackgroundDirectory_Click);
            // 
            // btnDateConvert
            // 
            this.btnDateConvert.Name = "btnDateConvert";
            this.btnDateConvert.Size = new System.Drawing.Size(177, 22);
            this.btnDateConvert.Text = "تبدیل تاریخ";
            this.btnDateConvert.Visible = false;
            // 
            // btnCheckUpdate
            // 
            this.btnCheckUpdate.Name = "btnCheckUpdate";
            this.btnCheckUpdate.Size = new System.Drawing.Size(177, 22);
            this.btnCheckUpdate.Text = "دریافت آپدیت";
            this.btnCheckUpdate.Click += new System.EventHandler(this.btnCheckUpdate_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(177, 22);
            this.btnSettings.Text = "تنظیمات";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(177, 22);
            this.btnAbout.Text = "درباره";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 22);
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.frmMain_Leave);
            // 
            // backgroundTimer
            // 
            this.backgroundTimer.Tick += new System.EventHandler(this.BackgroundChenger);
            // 
            // calendarTimer
            // 
            this.calendarTimer.Interval = 1000;
            this.calendarTimer.Tick += new System.EventHandler(this.LoadCalendar);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 124);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Timer backgroundTimer;
        private System.Windows.Forms.ToolStripMenuItem btnBackgroundChenger;
        private System.Windows.Forms.ToolStripMenuItem btnAddEvent;
        private System.Windows.Forms.ToolStripMenuItem btnDateConvert;
        private System.Windows.Forms.ToolStripMenuItem btnOpenAlbum;
        private System.Windows.Forms.Timer calendarTimer;
        private System.Windows.Forms.ToolStripMenuItem btnOpenBackgroundDirectory;
        private System.Windows.Forms.ToolStripMenuItem btnCheckUpdate;
    }
}

