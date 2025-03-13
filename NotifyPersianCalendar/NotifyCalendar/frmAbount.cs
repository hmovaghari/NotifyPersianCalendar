using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  NotifyPersianCalendar
{
    public partial class frmAbount : Form
    {
        public frmAbount()
        {
            InitializeComponent();
        }

        private void btnRepository_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/hmovaghari?tab=repositories");
            frmAbount_FormClosed(null, null);
        }

        private void frmAbount_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
