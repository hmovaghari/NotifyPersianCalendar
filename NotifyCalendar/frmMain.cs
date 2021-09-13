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
        private static Properties.Settings defaultSettings = Properties.Settings.Default;
        private bool isFirstRun = true;

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
            StrartTimer();
        }

        private void StrartTimer()
        {
            if (defaultSettings.IsTimerOn)
            {
                
                timer.Interval = GetInterval();
                timer.Start();
            }
            else
            {
                timer.Stop();
            }

            if (isFirstRun || defaultSettings.IsTimerOn)
            {
                BackgroundChenger(null, null);

                if (isFirstRun)
                {
                    isFirstRun = false;
                }
            }
        }

        private static int GetInterval()
        {
            var intervalType = defaultSettings.IntervalType;
            var interval = defaultSettings.Interval;

            if (intervalType == 1)
            {
                return interval * 60000;
            }
            else if (intervalType == 2)
            {
                return interval * 3600000;
            }
            return 0;
        }

        private void BackgroundChenger(object sender, EventArgs e)
        {
            var gallery = new Gallery();

            List<string> galleryFiles = gallery.GetGalleryFiles();

            CheckGalleryError(gallery);

            gallery.ChangeDesktopBackground(galleryFiles);

            CheckGalleryError(gallery);
        }

        private void CheckGalleryError(Gallery gallery)
        {
            if (gallery.Error != null)
            {
                ShowError(message: gallery.Error);

                if (!gallery.ForceClose)
                {
                    gallery.Error = null;
                }
                else
                {
                    frmMain_Leave(null, null);
                }
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, @"خطایی رخ داده!", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
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
                var error = "لطفا تاریخ سیستم را به میلادی (انگلیسی) تغییر دهید" + Environment.NewLine +
                    "سپس مجددا نرم‌افزار را اجرا کنید";
                ShowError(error);
                frmMain_Leave(null, null);
            }
        }

        private void GetDate()
        {
            calendar.SelectedDateTime = DateTime.Now;
            calendar.HijriAdjustment = defaultSettings.HijriAdjustment;
        }

        private void ChangeTextOfNotifity()
        {
            var calendarType = defaultSettings.CalendarShowType;
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
            frmAbount frmAbount = new frmAbount();
            frmAbount.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            calendar.SelectedDateTime = DateTime.Now;
            frmSettings frmSettings = new frmSettings(calendar);
            notify.ContextMenuStrip.Enabled = false;
            var result = frmSettings.ShowDialog();
            notify.ContextMenuStrip.Enabled = true;
            if (result == DialogResult.OK)
            {
                LoadCalendar();
                StrartTimer();
            }
            frmSettings.Dispose();
        }
    }
}
