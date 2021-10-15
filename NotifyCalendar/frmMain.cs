using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        private Calendar calendar = new Calendar();
        private Properties.Settings defaultSettings = Properties.Settings.Default;
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
            SetRunDate();
            LoadCalendar(null, null);
            StrartTimer();
        }

        private void SetRunDate()
        {
            defaultSettings.RunDate = DateTime.Now.Date;
            defaultSettings.Save();
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

        private int GetInterval()
        {
            var intervalType = defaultSettings.IntervalType;
            var interval = defaultSettings.Interval;

            switch (intervalType)
            {
                case 1:
                    return interval * 60000;
                case 2:
                    return interval * 3600000;
                default:
                    return 0;
            }
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

        private void LoadCalendar(object sender, MouseEventArgs e)
        {
            if (Calendar.IsValidRegion)
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
            calendar.HijriAdjustment = GetHijriAdjustment();
        }

        private int GetHijriAdjustment()
        {
            if (defaultSettings.IsCalculateHijriAdjustmentOnlie &&
                (
                    isFirstRun ||
                    (
                        calendar.SelectedDateTime >= defaultSettings.RunDate.AddDays(1))
                    )
                )
            {
                var hijriAdjustmentOnjline = new int?();
                try
                {
                    hijriAdjustmentOnjline = Calendar.GetHijriAdjustmentOnline(calendar.SelectedDateTime);
                }
                catch {}
                if (hijriAdjustmentOnjline != null)
                {
                    defaultSettings.HijriAdjustment = (int)hijriAdjustmentOnjline;
                    defaultSettings.RunDate = calendar.SelectedDateTime.Date;
                    defaultSettings.Save();
                }
                else
                {
                    defaultSettings.IsCalculateHijriAdjustmentOnlie = false;
                    defaultSettings.Save();
                    ShowError("ارتباط با اینترنت وجود ندارد!" +
                        Environment.NewLine + 
                        "تنظیمات مربوط به محاسبه آنلاین اختلاف روز قمری به حالت پیشفرض تغییر نمود!");
                }
            }
            return defaultSettings.HijriAdjustment;
        }

        private void ChangeTextOfNotifity()
        {
            var calendarShowType = defaultSettings.CalendarShowType;
            var text = calendar.Text(calendarShowType);

            if (text.ToString().Length >= 128)
            {
                throw new ArgumentOutOfRangeException("Text limited to 127 characters");
            }

            Type t = typeof(NotifyIcon);
            BindingFlags hidden = BindingFlags.NonPublic | BindingFlags.Instance;
            t.GetField("text", hidden).SetValue(notify, text);
            if ((bool)t.GetField("added", hidden).GetValue(notify))
            {
                t.GetMethod("UpdateIcon", hidden).Invoke(notify, new object[] { true });
            }
        }

        private void ChageIconOfNotifity()
        {
            notify.Icon = calendar.GetIcon();
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
                LoadCalendar(null, null);
                StrartTimer();
            }
            frmSettings.Dispose();
        }

        private void btnOpenAlbum_Click(object sender, EventArgs e)
        {
            var gallery = new Gallery();
            Process.Start(gallery.GetGalleryPath());
        }
    }
}
