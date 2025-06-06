namespace NotifyPersianCalendar
{
    partial class frmConvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConvert));
            this.lblCalendar = new System.Windows.Forms.Label();
            this.txtFaCalendar = new System.Windows.Forms.MaskedTextBox();
            this.txtEnCalendar = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enPictureBox = new System.Windows.Forms.PictureBox();
            this.faPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCalendar
            // 
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendar.Location = new System.Drawing.Point(9, 81);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(72, 13);
            this.lblCalendar.TabIndex = 3;
            this.lblCalendar.Text = "lblFaCalendar";
            // 
            // txtFaCalendar
            // 
            this.txtFaCalendar.Location = new System.Drawing.Point(12, 12);
            this.txtFaCalendar.Mask = "00/00/0000";
            this.txtFaCalendar.Name = "txtFaCalendar";
            this.txtFaCalendar.Size = new System.Drawing.Size(265, 20);
            this.txtFaCalendar.TabIndex = 5;
            this.txtFaCalendar.ValidatingType = typeof(System.DateTime);
            this.txtFaCalendar.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // txtEnCalendar
            // 
            this.txtEnCalendar.Location = new System.Drawing.Point(12, 44);
            this.txtEnCalendar.Mask = "00/00/0000";
            this.txtEnCalendar.Name = "txtEnCalendar";
            this.txtEnCalendar.Size = new System.Drawing.Size(265, 20);
            this.txtEnCalendar.TabIndex = 6;
            this.txtEnCalendar.ValidatingType = typeof(System.DateTime);
            this.txtEnCalendar.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 19);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "تاریخ شمسی :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 47);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "تاریخ میلادی :";
            // 
            // enPictureBox
            // 
            this.enPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enPictureBox.Location = new System.Drawing.Point(12, 140);
            this.enPictureBox.Name = "enPictureBox";
            this.enPictureBox.Size = new System.Drawing.Size(166, 166);
            this.enPictureBox.TabIndex = 10;
            this.enPictureBox.TabStop = false;
            // 
            // faPictureBox
            // 
            this.faPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.faPictureBox.Location = new System.Drawing.Point(191, 140);
            this.faPictureBox.Name = "faPictureBox";
            this.faPictureBox.Size = new System.Drawing.Size(166, 166);
            this.faPictureBox.TabIndex = 9;
            this.faPictureBox.TabStop = false;
            // 
            // frmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 320);
            this.Controls.Add(this.enPictureBox);
            this.Controls.Add(this.faPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnCalendar);
            this.Controls.Add(this.txtFaCalendar);
            this.Controls.Add(this.lblCalendar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(385, 359);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(385, 359);
            this.Name = "frmConvert";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تبدیل تاریخ";
            this.Load += new System.EventHandler(this.frmConvert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.MaskedTextBox txtFaCalendar;
        private System.Windows.Forms.MaskedTextBox txtEnCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox enPictureBox;
        private System.Windows.Forms.PictureBox faPictureBox;
    }
}