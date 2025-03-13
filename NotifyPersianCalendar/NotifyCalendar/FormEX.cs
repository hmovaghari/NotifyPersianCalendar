using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyPersianCalendar
{
    public static class FormEX
    {
        public static void ShowOnTop(this Form form)
        {
            form.Show();

            if (form.WindowState == FormWindowState.Minimized)
            {
                form.WindowState = FormWindowState.Normal;
            }

            form.TopMost = true;
            form.TopMost = false;
        }

        public static void FixFormSize(this Form form)
        {
            form.MinimumSize = form.Size;
            form.MaximumSize = form.Size;
        }
    }
}
