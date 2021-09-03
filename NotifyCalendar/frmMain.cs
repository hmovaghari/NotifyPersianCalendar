using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persian.Calendar.Library;

namespace NotifyCalendar
{
    public partial class frmMain : Form
    {
        Calendar calendar = new Calendar();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Leave(object sender, EventArgs e)
        {
            notify.Visible = false;
            notify.Dispose();
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HideForm();
            LoadCalendar();
        }

        private void HideForm()
        {
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Black;
            TransparencyKey = Color.Black;
            Size = new Size(0, 0);
            this.WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        private void LoadCalendar()
        {
            if (CalendarFanctions.IsValidRegion())
            {
                GetDate();
                ChangeTextOfNotifity();
                ChageIconOfNotifity();
            }
            else
            {
                MessageBox.Show(
                @"لطفا تاریخ سیستم را به میلادی (انگلیسی) تغییر دهید" + Environment.NewLine +
                "سپس مجددا نرم‌افزار را اجرا کنید",
                @"", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                frmMain_Leave(null, null);
            }
        }

        private void GetDate()
        {
            calendar.DateTime = DateTime.Now;
            calendar.HijriAdjustment = Properties.Settings.Default.HijriAdjustment;
        }

        private void ChangeTextOfNotifity()
        {
            var calendarType = Properties.Settings.Default.CalendarType;
            var text = CalendarFanctions.GetCalendar(calendar, calendarType);
            
            if (text.ToString().Length >= 128)
            {
                throw new ArgumentOutOfRangeException("Text limited to 127 characters");
            }

            Type t = typeof(NotifyIcon);
            BindingFlags hidden = BindingFlags.NonPublic | BindingFlags.Instance;
            t.GetField("text", hidden).SetValue(notify, text.ToString());
            if ((bool)t.GetField("added", hidden).GetValue(notify))
            {
                t.GetMethod("UpdateIcon", hidden).Invoke(notify, new object[] { true });
            }
        }

        private void ChageIconOfNotifity()
        {
            notify.Icon = CalendarFanctions.GetIcon(calendar);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"ساخته شده توسط حامد موقری" + Environment.NewLine + @"آدرس اینترنتی : http://hmovaghari.rozblog.com",
                @"", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            calendar.DateTime = DateTime.Now;
            frmSettings frmSettings = new frmSettings(calendar);
            frmSettings.ShowDialog();
            LoadCalendar();
            frmSettings.Dispose();
        }
    }
}
