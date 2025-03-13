
namespace  NotifyPersianCalendar
{
    partial class frmAbount
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
            btnRepository.Image.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbount));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRepository = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(553, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ساخته شده توسط hmovaghari - قدرت گرفته از کامپوننت Farsi.Library 2.7.0  هادی اسکن" +
    "دری";
            // 
            // btnRepository
            // 
            this.btnRepository.Image = global::NotifyPersianCalendar.Properties.Resources.github;
            this.btnRepository.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRepository.Location = new System.Drawing.Point(235, 57);
            this.btnRepository.Name = "btnRepository";
            this.btnRepository.Size = new System.Drawing.Size(79, 23);
            this.btnRepository.TabIndex = 1;
            this.btnRepository.Text = "نمونه کارها";
            this.btnRepository.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepository.UseVisualStyleBackColor = true;
            this.btnRepository.Click += new System.EventHandler(this.btnRepository_Click);
            // 
            // frmAbount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 97);
            this.Controls.Add(this.btnRepository);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "درباره برنامه نویس";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAbount_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRepository;
    }
}