using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persian.Calendar.Library;
using System.IO;
using NotifyPersianCalendar.Properties;
using System.Threading;

namespace  NotifyPersianCalendar
{
    public partial class frmSettings : Form
    {
        private Calendar calendar;
        private Settings defaultSettings = Settings.Default;

        public frmSettings(Calendar calendar)
        {
            InitializeComponent();
            tabEvents.Dispose();
            this.calendar = calendar;
            DialogResult = DialogResult.None;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            this.FixFormSize();
            LoadData();
        }

        private void LoadData()
        {
            cmbHijriAdjustment.SelectedIndex = defaultSettings.HijriAdjustment + 2;
            chkIsCalculateHijriAdjustmentOnline.Checked = defaultSettings.IsCalculateHijriAdjustmentOnlie;

            cmbCalendarType.SelectedIndex = defaultSettings.CalendarShowType - 1;

            chkIsShowPersianCalendar.Checked = defaultSettings.IsShowPersianCalendar;
            chkIsShowHijriCalendar.Checked = defaultSettings.IsShowHijriCalendar;
            chkIsShowGregorianCalendar.Checked = defaultSettings.IsShowGregorianCalendar;
            
            chkDefaultPicturesAlbumPath.Checked = defaultSettings.IsDefaultPicturesAlbumPath;
            folderPicturesAlbum.SelectedPath = defaultSettings.PicturesAlbumPath;
            chkDefaultPicturesAlbumPath_CheckedChanged(null, null);

            chkIsTimerOn.Checked = defaultSettings.IsTimerOn;
            numInterval.Value = defaultSettings.Interval;
            cmbIntervalType.SelectedIndex = defaultSettings.IntervalType - 1;
            cmbBackgroundChangeMode.SelectedIndex = defaultSettings.BackgroundChangeMode - 1;

            cmbBackgroundLocation.SelectedIndex = defaultSettings.BackgroundLocation - 1;
            cmbBackgroundLocation_SelectedIndexChanged(null, null);

            var backgroundStyles = Enums.GetBackgroundStyleList();
            cmbBackgroundStyle.DisplayMember = "Name";
            cmbBackgroundStyle.Items.AddRange(backgroundStyles.ToArray());
            cmbBackgroundStyle.SelectedIndex = defaultSettings.BackgroundStyle - 1;

            chkDefaultBackgroundDirectory.Checked = defaultSettings.IsDefaultBackgroundDirectory;
            folderBackground.SelectedPath = defaultSettings.BackgroundDirectory;
            chkDefaultBackgroundDirectory_CheckedChanged(null, null);

            chkIsCheckUpdateAtStart.Checked = defaultSettings.IsCheckUpdateAtStart;
        }

        private async void chkIsOnlineHijriAdjustment_CheckedChanged(object sender, EventArgs e)
        {
            var isOnline = GetIsCalculateHijriAdjustmentOnlineFromCHK();
            cmbHijriAdjustment.Enabled = !isOnline;
            if (isOnline)
            {
                var _frmPleaseWait = new frmPleaseWait(Location.X + 35, Location.Y + 90);
                Thread pleaseWaitThread = new Thread(_frmPleaseWait.Start);
                pleaseWaitThread.Start();
                var onlineijriAdjustmen = new int?();
                try
                {
                    onlineijriAdjustmen = await GetHijriAdjustmentOnline();
                }
                catch {}
                SendKeys.SendWait("{Esc}");//Close _frmPleaseWait
                pleaseWaitThread.Abort();
                if (onlineijriAdjustmen.HasValue)
                {
                    cmbHijriAdjustment.SelectedIndex = (int)(onlineijriAdjustmen + 2);
                    cmbHijriAdjustment_SelectedIndexChanged(null, null);
                }
                else
                {
                    TopMost = false;
                    chkIsCalculateHijriAdjustmentOnline.Checked = false;
                    chkIsOnlineHijriAdjustment_CheckedChanged(null, null);
                    ShowError("ارتباط با اینترنت وجود ندارد");
                    TopMost = true;
                }
            }
        }

        private static async Task<int?> GetHijriAdjustmentOnline()
        {
            return await Calendar.GetHijriAdjustmentOnline(DateTime.Now);
        }

        private bool GetIsCalculateHijriAdjustmentOnlineFromCHK()
        {
            return chkIsCalculateHijriAdjustmentOnline.Checked;
        }

        private void cmbCalendarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var calendarType = GetCalendarTypeFromCMB();
            lblCalendarType.Text = calendar.Text(calendarType);
        }

        private byte GetCalendarTypeFromCMB()
        {
            return (byte)(cmbCalendarType.SelectedIndex + 1);
        }

        private int GetBackgroundStyleFromCMB()
        {
            return cmbBackgroundStyle.SelectedIndex + 1;
        }

        private void cmbHijriAdjustment_SelectedIndexChanged(object sender, EventArgs e)
        {
            var _calendar = new Calendar();
            _calendar.SelectedDateTime = DateTime.Now;
            lblHijriAdjustment.Text = _calendar.GetHijriDate(GetHijriAdjustmentFromCMB());
        }

        private int GetHijriAdjustmentFromCMB()
        {
            return cmbHijriAdjustment.SelectedIndex - 2;
        }

        private void chkDefaultPicturesAlbumPath_CheckedChanged(object sender, EventArgs e)
        {
            txtPicturesAlbumPath.Enabled = !GetIsDefaultPicturesAlbumPathFromCHK();
            var selectedPath = GetSelectedPicturesAlbumPathFromFolderDialog();
            txtPicturesAlbumPath.Text = selectedPath;
            folderPicturesAlbum.SelectedPath = selectedPath;
        }

        private string GetSelectedPicturesAlbumPathFromFolderDialog()
        {
            return txtPicturesAlbumPath.Enabled ? folderPicturesAlbum.SelectedPath : string.Empty;
        }

        private bool GetIsDefaultPicturesAlbumPathFromCHK()
        {
            return chkDefaultPicturesAlbumPath.Checked;
        }

        private void chkIsTimerOn_CheckedChanged(object sender, EventArgs e)
        {
            var isTimerOn = GetIsTimerOnFromCHK();
            numInterval.Value = isTimerOn ? GetIntervalFromNUM() : 0;
            numInterval.Enabled = isTimerOn;
            cmbIntervalType.Enabled = isTimerOn;
            cmbIntervalType.SelectedIndex = isTimerOn ? GetIntervalTypeFromCMB() - 1 : -1;
            cmbBackgroundChangeMode.Enabled = isTimerOn;
            cmbBackgroundChangeMode.SelectedIndex = isTimerOn ? GetBackgroundChangeMode() - 1 : -1;
            cmbCalendarType.Enabled = isTimerOn;
        }

        private byte GetBackgroundChangeMode()
        {
            return (byte)(cmbBackgroundChangeMode.SelectedIndex + 1);
        }

        private int GetIntervalFromNUM()
        {
            return (int)numInterval.Value;
        }

        private byte GetIntervalTypeFromCMB()
        {
            return (byte)(cmbIntervalType.SelectedIndex + 1);
        }

        private bool GetIsTimerOnFromCHK()
        {
            return chkIsTimerOn.Checked;
        }

        private void btnBrowsePicturesAlbumPath_Click(object sender, EventArgs e)
        {
            var result = folderPicturesAlbum.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                chkDefaultPicturesAlbumPath.Checked = false;
                chkDefaultPicturesAlbumPath_CheckedChanged(null, null);
            }
        }

        private void ShowCalendar_CheckedChanged(object sender, EventArgs e)
        {
            if (!IsShowCalendarsChecked())
            {
                cmbBackgroundLocation.Enabled = false;
                cmbBackgroundLocation.SelectedIndex = -1;
                cmbBackgroundLocation_SelectedIndexChanged(null, null);
            }
            else
            {
                cmbBackgroundLocation.Enabled = true;
            }
        }

        private bool IsShowCalendarsChecked()
        {
            return chkIsShowPersianCalendar.Checked ||
                chkIsShowHijriCalendar.Checked ||
                chkIsShowGregorianCalendar.Checked;
        }

        private void cmbBackgroundLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            picBackgroundLocation.Image.Dispose();
            switch (GetBackgroundLocationFromCMB())
            {
                case 1:
                    picBackgroundLocation.Image = Resources.Desktop1;
                    break;
                case 2:
                    picBackgroundLocation.Image = Resources.Desktop2;
                    break;
                case 3:
                    picBackgroundLocation.Image = Resources.Desktop3;
                    break;
                case 4:
                    picBackgroundLocation.Image = Resources.Desktop4;
                    break;
                case 5:
                    picBackgroundLocation.Image = Resources.Desktop5;
                    break;
                case 6:
                    picBackgroundLocation.Image = Resources.Desktop6;
                    break;
                case 7:
                    picBackgroundLocation.Image = Resources.Desktop7;
                    break;
                case 8:
                    picBackgroundLocation.Image = Resources.Desktop8;
                    break;
                default:
                    picBackgroundLocation.Image = Resources.Desktop0;
                    break;
            }
        }

        private byte GetBackgroundLocationFromCMB()
        {
            return (byte)(cmbBackgroundLocation.SelectedIndex + 1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ControlData())
            {
                defaultSettings.IsCalculateHijriAdjustmentOnlie = GetIsCalculateHijriAdjustmentOnlineFromCHK();
                defaultSettings.HijriAdjustment = GetHijriAdjustmentFromCMB();
                defaultSettings.CalendarShowType = GetCalendarTypeFromCMB();
                defaultSettings.IsDefaultPicturesAlbumPath = GetIsDefaultPicturesAlbumPathFromCHK();
                defaultSettings.PicturesAlbumPath = GetSelectedPicturesAlbumPathFromFolderDialog();
                defaultSettings.IsTimerOn = GetIsTimerOnFromCHK();
                defaultSettings.Interval = GetIntervalFromNUM();
                defaultSettings.IntervalType = GetIntervalTypeFromCMB();
                defaultSettings.BackgroundChangeMode = GetBackgroundChangeMode();
                defaultSettings.IsShowPersianCalendar = chkIsShowPersianCalendar.Checked;
                defaultSettings.IsShowHijriCalendar = chkIsShowHijriCalendar.Checked;
                defaultSettings.IsShowGregorianCalendar = chkIsShowGregorianCalendar.Checked;
                defaultSettings.BackgroundLocation = GetBackgroundLocationFromCMB();
                defaultSettings.BackgroundStyle = GetBackgroundStyleFromCMB();
                defaultSettings.IsDefaultBackgroundDirectory = GetIsDefaultBackgroundDirectoryCHK();
                defaultSettings.BackgroundDirectory = GetSelectedBackgroundDirectoryFromFolderDialog();
                defaultSettings.IsCheckUpdateAtStart = GetIsCheckUpdateAtStart();
                defaultSettings.Save();
                DialogResult = DialogResult.OK;
                btnCancel_Click(null, null);
            }
        }

        private bool GetIsCheckUpdateAtStart()
        {
            return chkIsCheckUpdateAtStart.Checked;
        }

        private bool ControlData()
        {
            var selectedAlbumPath = GetSelectedPicturesAlbumPathFromFolderDialog();
            if (!GetIsDefaultPicturesAlbumPathFromCHK() && (string.IsNullOrEmpty(selectedAlbumPath) || !Directory.Exists(selectedAlbumPath)))
            {
                ShowError(message: "لطفا مسیر آلبوم تصاویر را از تب 'پس زمینه' انتخاب نمائید");
                return false;
            }

            var selectedBackgroundFolder = GetSelectedBackgroundDirectoryFromFolderDialog();
            if (!GetIsDefaultBackgroundDirectoryCHK() && (string.IsNullOrEmpty(selectedBackgroundFolder) || !Directory.Exists(selectedBackgroundFolder)))
            {
                ShowError(message: "لطفا مسیر ذخیره پس زمینه را از تب 'پس زمینه' انتخاب نمائید");
                return false;
            }

            
            if (GetIsTimerOnFromCHK() && (GetIntervalFromNUM() == 0 || GetIntervalTypeFromCMB() == 0 || GetBackgroundChangeMode() == 0))
            {
                ShowError(message: "لطفا نحوه‌ی تغییر اوتومات تصاویر را از تب 'پس زمینه' انتخاب نمائید");
                return false;
            }

            if (IsShowCalendarsChecked() && GetBackgroundLocationFromCMB() == 0)
            {
                ShowError(message: "لطفا محل قرارگیری تقویم را از تب 'پس زمینه' انتخاب نمائید");
                return false;
            }

            return true;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, @"خطایی رخ داده!", MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (DialogResult == DialogResult.None)
            {
                DialogResult = DialogResult.Cancel;
            }
            this.Close();
        }

        private void btnBackgroundDirectory_Click(object sender, EventArgs e)
        {
            var result = folderBackground.ShowDialog();

            if (result == DialogResult.OK)
            {
                chkDefaultBackgroundDirectory.Checked = false;
                chkDefaultBackgroundDirectory_CheckedChanged(null, null);
            }
        }

        private void chkDefaultBackgroundDirectory_CheckedChanged(object sender, EventArgs e)
        {
            txtBackgroundDirectory.Enabled = !GetIsDefaultBackgroundDirectoryCHK();
            var selectedPath = GetSelectedBackgroundDirectoryFromFolderDialog();
            txtBackgroundDirectory.Text = selectedPath;
            folderBackground.SelectedPath = selectedPath;
        }

        private string GetSelectedBackgroundDirectoryFromFolderDialog()
        {
            return txtBackgroundDirectory.Enabled ? folderBackground.SelectedPath : string.Empty;
        }

        private bool GetIsDefaultBackgroundDirectoryCHK()
        {
            return chkDefaultBackgroundDirectory.Checked;
        }
    }
}
