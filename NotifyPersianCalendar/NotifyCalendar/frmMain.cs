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

namespace  NotifyPersianCalendar
{
    public partial class frmMain : Form
    {
        private Calendar calendar = new Calendar();
        private Properties.Settings defaultSettings = Properties.Settings.Default;
        private bool isFirstRun = true;
        private Guid zeroGuid = new Guid();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Leave(object sender, EventArgs e)
        {
            notify.Visible = false;
            notify.Icon.Dispose();
            notify.Dispose();
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HideForm();
            CheckUpdate(isRunNewForm: false);
            SetRunDate();
            SetBackgroundLocation();
            StartCalendarTimer();
            StrartBackgroundTimer();
            SetIsFirstRun(false);
        }

        private void CheckUpdate(bool isRunNewForm)
        {
            var _frmUpdate = frmUpdate.GetInstance(isRunNewForm);
            if (_frmUpdate != null)
            {
                _frmUpdate.ShowOnTop();
            }
        }

        private void SetBackgroundLocation()
        {
            SetBackgroundFilename();
        }

        private void SetBackgroundFilename()
        {
            if (defaultSettings.BackgroundGuidName == zeroGuid)
            {
                defaultSettings.BackgroundGuidName = Guid.NewGuid();
                defaultSettings.Save();
            }
        }

        private void SetIsFirstRun(bool @bool)
        {
            isFirstRun = @bool;
        }

        private void SetRunDate()
        {
            defaultSettings.RunDate = DateTime.Now.Date;
            defaultSettings.Save();
        }

        private void StrartBackgroundTimer()
        {
            if (defaultSettings.IsTimerOn)
            {
                backgroundTimer.Interval = GetInterval();
                backgroundTimer.Start();
                BackgroundChenger(null, null);
            }
            else
            {
                backgroundTimer.Stop();
            }
        }

        private void StartCalendarTimer()
        {
            LoadCalendar(null, null);
            calendarTimer.Start();
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

            var galleryFiles = gallery.GetGalleryFiles();
            CheckGalleryError(gallery);

            var backgroundPath = gallery.GetValidBackgroundPath();
            CheckGalleryError(gallery);

            gallery.ChangeDesktopBackground(backgroundPath, galleryFiles);

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

        private void LoadCalendar(object sender, EventArgs e)
        {
            //if (Calendar.IsValidRegion)
            //{
            GetDate();
            ChangeTextOfNotifity();
            ChageIconOfNotifity();
            //}
            //else
            //{
            //    var error = "لطفا تاریخ سیستم را به میلادی (انگلیسی) تغییر دهید" + Environment.NewLine +
            //        "سپس مجددا نرم‌افزار را اجرا کنید";
            //    ShowError(error);
            //    frmMain_Leave(null, null);
            //}
        }

        private async Task GetDate()
        {
            calendar.SelectedDateTime = DateTime.Now;
            calendar.HijriAdjustment = await GetHijriAdjustment();
        }

        private async Task<int> GetHijriAdjustment()
        {
            if (GetIsCalculateHijriAdjustmentOnlie() &&
                (
                    isFirstRun ||
                    calendar.SelectedDateTime >= defaultSettings.RunDate.AddDays(1))
                )
            {
                var hijriAdjustmentOnjline = await calendar.GetHijriAdjustmentOnlie();
                if (hijriAdjustmentOnjline != null)
                {
                    defaultSettings.HijriAdjustment = (int)hijriAdjustmentOnjline;
                    defaultSettings.RunDate = calendar.SelectedDateTime.Date;
                    defaultSettings.Save();
                }
                else
                {
                    if (defaultSettings.IsCalculateHijriAdjustmentOnlie)
                    {
                        defaultSettings.IsCalculateHijriAdjustmentOnlie = false;
                        defaultSettings.Save();
                        ShowError("ارتباط با اینترنت وجود ندارد!" +
                            Environment.NewLine +
                            "تنظیمات مربوط به محاسبه آنلاین اختلاف روز قمری به حالت پیشفرض تغییر نمود!");
                    }
                }
            }
            return defaultSettings.HijriAdjustment;
        }

        private bool GetIsCalculateHijriAdjustmentOnlie()
        {
            return defaultSettings.IsCalculateHijriAdjustmentOnlie;
        }

        private void ChangeTextOfNotifity()
        {
            var calendarShowType = defaultSettings.CalendarShowType;
            var text = calendar.Text(calendarShowType);

            /*if (text.ToString().Length >= 128)
            {
                throw new ArgumentOutOfRangeException("Text limited to 127 characters");
            }*/

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
            notify.Icon.Dispose();
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
            var isCalculateHijriAdjustmentOffline = GetIsCalculateHijriAdjustmentOnlie() == false;
            frmSettings _frmSettings = new frmSettings(calendar);
            notify.ContextMenuStrip.Enabled = false;
            if (defaultSettings.IsTimerOn)
            {
                backgroundTimer.Stop();
            }
            var result = _frmSettings.ShowDialog();
            notify.ContextMenuStrip.Enabled = true;
            if (result == DialogResult.OK)
            {
                SetIsFirstRun(isCalculateHijriAdjustmentOffline && GetIsCalculateHijriAdjustmentOnlie());
                LoadCalendar(null, null);
                StrartBackgroundTimer();
                SetIsFirstRun(false);
            }
            _frmSettings.Dispose();
        }

        private void btnOpenAlbum_Click(object sender, EventArgs e)
        {
            var gallery = new Gallery();
            Process.Start(gallery.GetGalleryPath());
        }

        private void btnOpenBackgroundDirectory_Click(object sender, EventArgs e)
        {
            var gallery = new Gallery();
            Process.Start(gallery.GenerateBackgroundDirecory());
        }

        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {
            CheckUpdate(isRunNewForm: true);
        }
    }
}
