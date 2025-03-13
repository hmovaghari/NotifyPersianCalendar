namespace NotifyPersianCalendar
{
    partial class frmUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdate));
            this.lblUpdated = new System.Windows.Forms.Label();
            this.lblNeedUpdate = new System.Windows.Forms.Label();
            this.btnGetUpdate = new System.Windows.Forms.Button();
            this.lblNoConnection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.Location = new System.Drawing.Point(39, 12);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(90, 13);
            this.lblUpdated.TabIndex = 0;
            this.lblUpdated.Text = "نسخه آپدیت است";
            // 
            // lblNeedUpdate
            // 
            this.lblNeedUpdate.AutoSize = true;
            this.lblNeedUpdate.Location = new System.Drawing.Point(24, 12);
            this.lblNeedUpdate.Name = "lblNeedUpdate";
            this.lblNeedUpdate.Size = new System.Drawing.Size(121, 13);
            this.lblNeedUpdate.TabIndex = 1;
            this.lblNeedUpdate.Text = "آپدیت نسخه موجود است";
            // 
            // btnGetUpdate
            // 
            this.btnGetUpdate.Location = new System.Drawing.Point(33, 37);
            this.btnGetUpdate.Name = "btnGetUpdate";
            this.btnGetUpdate.Size = new System.Drawing.Size(102, 23);
            this.btnGetUpdate.TabIndex = 2;
            this.btnGetUpdate.Text = "دریافت آپدیت";
            this.btnGetUpdate.UseVisualStyleBackColor = true;
            // 
            // lblNoConnection
            // 
            this.lblNoConnection.AutoSize = true;
            this.lblNoConnection.Location = new System.Drawing.Point(28, 12);
            this.lblNoConnection.Name = "lblNoConnection";
            this.lblNoConnection.Size = new System.Drawing.Size(117, 13);
            this.lblNoConnection.TabIndex = 3;
            this.lblNoConnection.Text = "ارتباط با سرور وجود ندارد";
            // 
            // frmUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 72);
            this.Controls.Add(this.lblNoConnection);
            this.Controls.Add(this.btnGetUpdate);
            this.Controls.Add(this.lblNeedUpdate);
            this.Controls.Add(this.lblUpdated);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بررسی آپدیت نسخه";
            this.Load += new System.EventHandler(this.frmUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.Label lblNeedUpdate;
        private System.Windows.Forms.Button btnGetUpdate;
        private System.Windows.Forms.Label lblNoConnection;
    }
}