
namespace  NotifyPersianCalendar
{
    partial class frmSettings
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
            btnBrowsePicturesAlbumPath.Image.Dispose();
            picBackgroundLocation.Image.Dispose();
            picBackgroundLocation.ErrorImage.Dispose();
            btnSave.Image.Dispose();
            btnCancel.Image.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDesktop = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDefaultBackgroundDirectory = new System.Windows.Forms.CheckBox();
            this.btnBackgroundDirectory = new System.Windows.Forms.Button();
            this.txtBackgroundDirectory = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cmbBackgroundStyle = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.picBackgroundLocation = new System.Windows.Forms.PictureBox();
            this.cmbBackgroundLocation = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkIsShowGregorianCalendar = new System.Windows.Forms.CheckBox();
            this.chkIsShowHijriCalendar = new System.Windows.Forms.CheckBox();
            this.chkIsShowPersianCalendar = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbBackgroundChangeMode = new System.Windows.Forms.ComboBox();
            this.cmbIntervalType = new System.Windows.Forms.ComboBox();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.chkIsTimerOn = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBrowsePicturesAlbumPath = new System.Windows.Forms.Button();
            this.txtPicturesAlbumPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkDefaultPicturesAlbumPath = new System.Windows.Forms.CheckBox();
            this.tabCalendar = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCalendarType = new System.Windows.Forms.Label();
            this.cmbCalendarType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkIsCalculateHijriAdjustmentOnline = new System.Windows.Forms.CheckBox();
            this.lblHijriAdjustment = new System.Windows.Forms.Label();
            this.cmbHijriAdjustment = new System.Windows.Forms.ComboBox();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.folderPicturesAlbum = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBackground = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabDesktop.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackgroundLocation)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabCalendar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDesktop);
            this.tabControl1.Controls.Add(this.tabCalendar);
            this.tabControl1.Controls.Add(this.tabEvents);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 569);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDesktop
            // 
            this.tabDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.tabDesktop.Controls.Add(this.groupBox8);
            this.tabDesktop.Controls.Add(this.groupBox7);
            this.tabDesktop.Controls.Add(this.groupBox6);
            this.tabDesktop.Controls.Add(this.groupBox5);
            this.tabDesktop.Controls.Add(this.groupBox4);
            this.tabDesktop.Controls.Add(this.groupBox3);
            this.tabDesktop.Location = new System.Drawing.Point(4, 22);
            this.tabDesktop.Name = "tabDesktop";
            this.tabDesktop.Padding = new System.Windows.Forms.Padding(3);
            this.tabDesktop.Size = new System.Drawing.Size(471, 543);
            this.tabDesktop.TabIndex = 1;
            this.tabDesktop.Text = "پس زمینه";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label2);
            this.groupBox8.Controls.Add(this.chkDefaultBackgroundDirectory);
            this.groupBox8.Controls.Add(this.btnBackgroundDirectory);
            this.groupBox8.Controls.Add(this.txtBackgroundDirectory);
            this.groupBox8.Location = new System.Drawing.Point(8, 109);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(451, 85);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "مسیر ذخیره پس زمینه";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "مسیر انتخابی";
            // 
            // chkDefaultBackgroundDirectory
            // 
            this.chkDefaultBackgroundDirectory.AccessibleDescription = "";
            this.chkDefaultBackgroundDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDefaultBackgroundDirectory.AutoSize = true;
            this.chkDefaultBackgroundDirectory.Location = new System.Drawing.Point(351, 22);
            this.chkDefaultBackgroundDirectory.Name = "chkDefaultBackgroundDirectory";
            this.chkDefaultBackgroundDirectory.Size = new System.Drawing.Size(87, 17);
            this.chkDefaultBackgroundDirectory.TabIndex = 5;
            this.chkDefaultBackgroundDirectory.Text = "مسیر پیفرض";
            this.chkDefaultBackgroundDirectory.UseVisualStyleBackColor = true;
            this.chkDefaultBackgroundDirectory.CheckedChanged += new System.EventHandler(this.chkDefaultBackgroundDirectory_CheckedChanged);
            // 
            // btnBackgroundDirectory
            // 
            this.btnBackgroundDirectory.Image = global::NotifyPersianCalendar.Properties.Resources.Browse;
            this.btnBackgroundDirectory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackgroundDirectory.Location = new System.Drawing.Point(253, 16);
            this.btnBackgroundDirectory.Name = "btnBackgroundDirectory";
            this.btnBackgroundDirectory.Size = new System.Drawing.Size(90, 23);
            this.btnBackgroundDirectory.TabIndex = 4;
            this.btnBackgroundDirectory.Text = "انتخاب مسیر";
            this.btnBackgroundDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackgroundDirectory.UseVisualStyleBackColor = true;
            this.btnBackgroundDirectory.Click += new System.EventHandler(this.btnBackgroundDirectory_Click);
            // 
            // txtBackgroundDirectory
            // 
            this.txtBackgroundDirectory.Location = new System.Drawing.Point(7, 49);
            this.txtBackgroundDirectory.Name = "txtBackgroundDirectory";
            this.txtBackgroundDirectory.ReadOnly = true;
            this.txtBackgroundDirectory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBackgroundDirectory.Size = new System.Drawing.Size(338, 21);
            this.txtBackgroundDirectory.TabIndex = 3;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cmbBackgroundStyle);
            this.groupBox7.Location = new System.Drawing.Point(9, 275);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(451, 58);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "نمایش تصویر پس زمینه";
            // 
            // cmbBackgroundStyle
            // 
            this.cmbBackgroundStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBackgroundStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackgroundStyle.FormattingEnabled = true;
            this.cmbBackgroundStyle.Location = new System.Drawing.Point(224, 24);
            this.cmbBackgroundStyle.Name = "cmbBackgroundStyle";
            this.cmbBackgroundStyle.Size = new System.Drawing.Size(213, 21);
            this.cmbBackgroundStyle.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.picBackgroundLocation);
            this.groupBox6.Controls.Add(this.cmbBackgroundLocation);
            this.groupBox6.Location = new System.Drawing.Point(9, 422);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(451, 107);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "محل قرارگیری تقویم";
            // 
            // picBackgroundLocation
            // 
            this.picBackgroundLocation.Image = global::NotifyPersianCalendar.Properties.Resources.Desktop0;
            this.picBackgroundLocation.Location = new System.Drawing.Point(36, 30);
            this.picBackgroundLocation.Name = "picBackgroundLocation";
            this.picBackgroundLocation.Size = new System.Drawing.Size(92, 61);
            this.picBackgroundLocation.TabIndex = 4;
            this.picBackgroundLocation.TabStop = false;
            // 
            // cmbBackgroundLocation
            // 
            this.cmbBackgroundLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBackgroundLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackgroundLocation.FormattingEnabled = true;
            this.cmbBackgroundLocation.Items.AddRange(new object[] {
            "حالت 1",
            "حالت 2",
            "حالت 3",
            "حالت 4",
            "حالت 5",
            "حالت 6",
            "حالت 7",
            "حالت 8"});
            this.cmbBackgroundLocation.Location = new System.Drawing.Point(225, 30);
            this.cmbBackgroundLocation.Name = "cmbBackgroundLocation";
            this.cmbBackgroundLocation.Size = new System.Drawing.Size(212, 21);
            this.cmbBackgroundLocation.TabIndex = 3;
            this.cmbBackgroundLocation.SelectedIndexChanged += new System.EventHandler(this.cmbBackgroundLocation_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkIsShowGregorianCalendar);
            this.groupBox5.Controls.Add(this.chkIsShowHijriCalendar);
            this.groupBox5.Controls.Add(this.chkIsShowPersianCalendar);
            this.groupBox5.Location = new System.Drawing.Point(9, 341);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(451, 73);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "نمایش تقویم";
            // 
            // chkIsShowGregorianCalendar
            // 
            this.chkIsShowGregorianCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsShowGregorianCalendar.AutoSize = true;
            this.chkIsShowGregorianCalendar.Location = new System.Drawing.Point(36, 30);
            this.chkIsShowGregorianCalendar.Name = "chkIsShowGregorianCalendar";
            this.chkIsShowGregorianCalendar.Size = new System.Drawing.Size(59, 17);
            this.chkIsShowGregorianCalendar.TabIndex = 5;
            this.chkIsShowGregorianCalendar.Text = "میلادی";
            this.chkIsShowGregorianCalendar.UseVisualStyleBackColor = true;
            this.chkIsShowGregorianCalendar.CheckedChanged += new System.EventHandler(this.ShowCalendar_CheckedChanged);
            // 
            // chkIsShowHijriCalendar
            // 
            this.chkIsShowHijriCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsShowHijriCalendar.AutoSize = true;
            this.chkIsShowHijriCalendar.Location = new System.Drawing.Point(196, 30);
            this.chkIsShowHijriCalendar.Name = "chkIsShowHijriCalendar";
            this.chkIsShowHijriCalendar.Size = new System.Drawing.Size(86, 17);
            this.chkIsShowHijriCalendar.TabIndex = 4;
            this.chkIsShowHijriCalendar.Text = "هجری قمری";
            this.chkIsShowHijriCalendar.UseVisualStyleBackColor = true;
            this.chkIsShowHijriCalendar.CheckedChanged += new System.EventHandler(this.ShowCalendar_CheckedChanged);
            // 
            // chkIsShowPersianCalendar
            // 
            this.chkIsShowPersianCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsShowPersianCalendar.AutoSize = true;
            this.chkIsShowPersianCalendar.Location = new System.Drawing.Point(337, 30);
            this.chkIsShowPersianCalendar.Name = "chkIsShowPersianCalendar";
            this.chkIsShowPersianCalendar.Size = new System.Drawing.Size(100, 17);
            this.chkIsShowPersianCalendar.TabIndex = 3;
            this.chkIsShowPersianCalendar.Text = "هجری شمسی";
            this.chkIsShowPersianCalendar.UseVisualStyleBackColor = true;
            this.chkIsShowPersianCalendar.CheckedChanged += new System.EventHandler(this.ShowCalendar_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbBackgroundChangeMode);
            this.groupBox4.Controls.Add(this.cmbIntervalType);
            this.groupBox4.Controls.Add(this.numInterval);
            this.groupBox4.Controls.Add(this.chkIsTimerOn);
            this.groupBox4.Location = new System.Drawing.Point(9, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(451, 65);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "تغییر اوتومات تصاویر";
            // 
            // cmbBackgroundChangeMode
            // 
            this.cmbBackgroundChangeMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBackgroundChangeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBackgroundChangeMode.FormattingEnabled = true;
            this.cmbBackgroundChangeMode.Items.AddRange(new object[] {
            "تغییر تصاویر تصادفی باشد",
            "تغییر تصاویر به ترتیب باشد"});
            this.cmbBackgroundChangeMode.Location = new System.Drawing.Point(6, 23);
            this.cmbBackgroundChangeMode.Name = "cmbBackgroundChangeMode";
            this.cmbBackgroundChangeMode.Size = new System.Drawing.Size(213, 21);
            this.cmbBackgroundChangeMode.TabIndex = 3;
            // 
            // cmbIntervalType
            // 
            this.cmbIntervalType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIntervalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIntervalType.FormattingEnabled = true;
            this.cmbIntervalType.Items.AddRange(new object[] {
            "دقیقه",
            "ساعت"});
            this.cmbIntervalType.Location = new System.Drawing.Point(225, 22);
            this.cmbIntervalType.Name = "cmbIntervalType";
            this.cmbIntervalType.Size = new System.Drawing.Size(57, 21);
            this.cmbIntervalType.TabIndex = 2;
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(288, 23);
            this.numInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(54, 21);
            this.numInterval.TabIndex = 1;
            this.numInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkIsTimerOn
            // 
            this.chkIsTimerOn.AutoSize = true;
            this.chkIsTimerOn.Location = new System.Drawing.Point(364, 26);
            this.chkIsTimerOn.Name = "chkIsTimerOn";
            this.chkIsTimerOn.Size = new System.Drawing.Size(73, 17);
            this.chkIsTimerOn.TabIndex = 0;
            this.chkIsTimerOn.Text = "فعال باشد";
            this.chkIsTimerOn.UseVisualStyleBackColor = true;
            this.chkIsTimerOn.CheckedChanged += new System.EventHandler(this.chkIsTimerOn_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnBrowsePicturesAlbumPath);
            this.groupBox3.Controls.Add(this.txtPicturesAlbumPath);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.chkDefaultPicturesAlbumPath);
            this.groupBox3.Location = new System.Drawing.Point(9, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 87);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "آلبوم تصاویر";
            // 
            // btnBrowsePicturesAlbumPath
            // 
            this.btnBrowsePicturesAlbumPath.Image = global::NotifyPersianCalendar.Properties.Resources.Browse;
            this.btnBrowsePicturesAlbumPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowsePicturesAlbumPath.Location = new System.Drawing.Point(254, 18);
            this.btnBrowsePicturesAlbumPath.Name = "btnBrowsePicturesAlbumPath";
            this.btnBrowsePicturesAlbumPath.Size = new System.Drawing.Size(90, 23);
            this.btnBrowsePicturesAlbumPath.TabIndex = 1;
            this.btnBrowsePicturesAlbumPath.Text = "انتخاب مسیر";
            this.btnBrowsePicturesAlbumPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrowsePicturesAlbumPath.UseVisualStyleBackColor = true;
            this.btnBrowsePicturesAlbumPath.Click += new System.EventHandler(this.btnBrowsePicturesAlbumPath_Click);
            // 
            // txtPicturesAlbumPath
            // 
            this.txtPicturesAlbumPath.Location = new System.Drawing.Point(6, 48);
            this.txtPicturesAlbumPath.Name = "txtPicturesAlbumPath";
            this.txtPicturesAlbumPath.ReadOnly = true;
            this.txtPicturesAlbumPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPicturesAlbumPath.Size = new System.Drawing.Size(337, 21);
            this.txtPicturesAlbumPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "مسیر انتخابی";
            // 
            // chkDefaultPicturesAlbumPath
            // 
            this.chkDefaultPicturesAlbumPath.AccessibleDescription = "";
            this.chkDefaultPicturesAlbumPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkDefaultPicturesAlbumPath.AutoSize = true;
            this.chkDefaultPicturesAlbumPath.Location = new System.Drawing.Point(350, 22);
            this.chkDefaultPicturesAlbumPath.Name = "chkDefaultPicturesAlbumPath";
            this.chkDefaultPicturesAlbumPath.Size = new System.Drawing.Size(87, 17);
            this.chkDefaultPicturesAlbumPath.TabIndex = 0;
            this.chkDefaultPicturesAlbumPath.Text = "مسیر پیفرض";
            this.chkDefaultPicturesAlbumPath.UseVisualStyleBackColor = true;
            this.chkDefaultPicturesAlbumPath.CheckedChanged += new System.EventHandler(this.chkDefaultPicturesAlbumPath_CheckedChanged);
            // 
            // tabCalendar
            // 
            this.tabCalendar.BackColor = System.Drawing.SystemColors.Control;
            this.tabCalendar.Controls.Add(this.groupBox2);
            this.tabCalendar.Controls.Add(this.groupBox1);
            this.tabCalendar.Location = new System.Drawing.Point(4, 22);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalendar.Size = new System.Drawing.Size(471, 543);
            this.tabCalendar.TabIndex = 0;
            this.tabCalendar.Text = "تقویم";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCalendarType);
            this.groupBox2.Controls.Add(this.cmbCalendarType);
            this.groupBox2.Location = new System.Drawing.Point(14, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "نوع نمایش تقویم";
            // 
            // lblCalendarType
            // 
            this.lblCalendarType.AutoSize = true;
            this.lblCalendarType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendarType.Location = new System.Drawing.Point(6, 69);
            this.lblCalendarType.Name = "lblCalendarType";
            this.lblCalendarType.Size = new System.Drawing.Size(84, 13);
            this.lblCalendarType.TabIndex = 2;
            this.lblCalendarType.Text = "lblCalendarType";
            // 
            // cmbCalendarType
            // 
            this.cmbCalendarType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCalendarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalendarType.FormattingEnabled = true;
            this.cmbCalendarType.Items.AddRange(new object[] {
            "حالت 1",
            "حالت 2",
            "حالت 3"});
            this.cmbCalendarType.Location = new System.Drawing.Point(229, 35);
            this.cmbCalendarType.Name = "cmbCalendarType";
            this.cmbCalendarType.Size = new System.Drawing.Size(201, 21);
            this.cmbCalendarType.TabIndex = 1;
            this.cmbCalendarType.SelectedIndexChanged += new System.EventHandler(this.cmbCalendarType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkIsCalculateHijriAdjustmentOnline);
            this.groupBox1.Controls.Add(this.lblHijriAdjustment);
            this.groupBox1.Controls.Add(this.cmbHijriAdjustment);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اختلاف روز قمری";
            // 
            // chkIsCalculateHijriAdjustmentOnline
            // 
            this.chkIsCalculateHijriAdjustmentOnline.AccessibleDescription = "";
            this.chkIsCalculateHijriAdjustmentOnline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkIsCalculateHijriAdjustmentOnline.AutoSize = true;
            this.chkIsCalculateHijriAdjustmentOnline.Location = new System.Drawing.Point(6, 21);
            this.chkIsCalculateHijriAdjustmentOnline.Name = "chkIsCalculateHijriAdjustmentOnline";
            this.chkIsCalculateHijriAdjustmentOnline.Size = new System.Drawing.Size(199, 17);
            this.chkIsCalculateHijriAdjustmentOnline.TabIndex = 4;
            this.chkIsCalculateHijriAdjustmentOnline.Text = "اختلاف روز بصورت آنلاین محاسبه شود";
            this.chkIsCalculateHijriAdjustmentOnline.UseVisualStyleBackColor = true;
            this.chkIsCalculateHijriAdjustmentOnline.CheckedChanged += new System.EventHandler(this.chkIsOnlineHijriAdjustment_CheckedChanged);
            // 
            // lblHijriAdjustment
            // 
            this.lblHijriAdjustment.AutoSize = true;
            this.lblHijriAdjustment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHijriAdjustment.Location = new System.Drawing.Point(6, 46);
            this.lblHijriAdjustment.Name = "lblHijriAdjustment";
            this.lblHijriAdjustment.Size = new System.Drawing.Size(90, 13);
            this.lblHijriAdjustment.TabIndex = 3;
            this.lblHijriAdjustment.Text = "lblHijriAdjustment";
            // 
            // cmbHijriAdjustment
            // 
            this.cmbHijriAdjustment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbHijriAdjustment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHijriAdjustment.FormattingEnabled = true;
            this.cmbHijriAdjustment.Items.AddRange(new object[] {
            "دو روز جلوتر است",
            "یک روز جلوتر است",
            "مشکلی ندارد",
            "یک روز عقب تر است",
            "دو روز عقب تر است"});
            this.cmbHijriAdjustment.Location = new System.Drawing.Point(229, 19);
            this.cmbHijriAdjustment.Name = "cmbHijriAdjustment";
            this.cmbHijriAdjustment.Size = new System.Drawing.Size(201, 21);
            this.cmbHijriAdjustment.TabIndex = 0;
            this.cmbHijriAdjustment.SelectedIndexChanged += new System.EventHandler(this.cmbHijriAdjustment_SelectedIndexChanged);
            // 
            // tabEvents
            // 
            this.tabEvents.BackColor = System.Drawing.SystemColors.Control;
            this.tabEvents.Location = new System.Drawing.Point(4, 22);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Size = new System.Drawing.Size(471, 543);
            this.tabEvents.TabIndex = 2;
            this.tabEvents.Text = "رویدادها";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(485, 635);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 578);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 54);
            this.panel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Image = global::NotifyPersianCalendar.Properties.Resources.Cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(143, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::NotifyPersianCalendar.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(238, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(89, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "ذخیره";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(485, 635);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDesktop.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBackgroundLocation)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabCalendar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDesktop;
        private System.Windows.Forms.TabPage tabCalendar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbHijriAdjustment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCalendarType;
        private System.Windows.Forms.Label lblCalendarType;
        private System.Windows.Forms.Label lblHijriAdjustment;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBrowsePicturesAlbumPath;
        private System.Windows.Forms.TextBox txtPicturesAlbumPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkDefaultPicturesAlbumPath;
        private System.Windows.Forms.FolderBrowserDialog folderPicturesAlbum;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkIsTimerOn;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.ComboBox cmbIntervalType;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkIsShowPersianCalendar;
        private System.Windows.Forms.CheckBox chkIsShowGregorianCalendar;
        private System.Windows.Forms.CheckBox chkIsShowHijriCalendar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox picBackgroundLocation;
        private System.Windows.Forms.ComboBox cmbBackgroundLocation;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.CheckBox chkIsCalculateHijriAdjustmentOnline;
        private System.Windows.Forms.ComboBox cmbBackgroundChangeMode;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cmbBackgroundStyle;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox txtBackgroundDirectory;
        private System.Windows.Forms.Button btnBackgroundDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBackground;
        private System.Windows.Forms.CheckBox chkDefaultBackgroundDirectory;
        private System.Windows.Forms.Label label2;
    }
}