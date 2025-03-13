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
    public partial class frmPleaseWait : Form
    {
        public frmPleaseWait(int x, int y)
        {
            InitializeComponent();
            Location = new Point(x, y);
        }

        private void frmPleaseWait_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        internal void Start()
        {
            ShowDialog();
        }

        private void frmPleaseWait_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
