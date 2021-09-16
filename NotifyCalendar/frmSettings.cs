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
using NotifyCalendar.Properties;

namespace NotifyCalendar
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
            FixFormSize();
            LoadData();
        }

        private void FixFormSize()
        {
            MinimumSize = Size;
            MaximumSize = Size;
        }

        private void LoadData()
        {
            cmbHijriAdjustment.SelectedIndex = defaultSettings.HijriAdjustment + 2;

            cmbCalendarType.SelectedIndex = defaultSettings.CalendarShowType - 1;

            chkIsShowPersianCalendar.Checked = defaultSettings.IsShowPersianCalendar;
            chkIsShowHijriCalendar.Checked = defaultSettings.IsShowHijriCalendar;
            chkIsShowGregorianCalendar.Checked = defaultSettings.IsShowGregorianCalendar;
            
            chkDefaultPath.Checked = defaultSettings.IsDefaultPth;
            folder.SelectedPath = defaultSettings.Path;
            chkDefaultPath_CheckedChanged(null, null);

            chkIsTimerOn.Checked = defaultSettings.IsTimerOn;
            numInterval.Value = defaultSettings.Interval;
            cmbIntervalType.SelectedIndex = defaultSettings.IntervalType - 1;

            cmbBackgroundLocation.SelectedIndex = defaultSettings.BackgroundLocation - 1;
            cmbBackgroundLocation_SelectedIndexChanged(null, null);
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

        private void chkDefaultPath_CheckedChanged(object sender, EventArgs e)
        {
            txtPath.Enabled = !GetIsDefaultPathFromCHK();
            var selectedPath = GetSelectedPathFromFolderDialog();
            txtPath.Text = selectedPath;
            folder.SelectedPath = selectedPath;
        }

        private string GetSelectedPathFromFolderDialog()
        {
            return txtPath.Enabled ? folder.SelectedPath : string.Empty;
        }

        private bool GetIsDefaultPathFromCHK()
        {
            return chkDefaultPath.Checked;
        }

        private void chkIsTimerOn_CheckedChanged(object sender, EventArgs e)
        {
            var isTimerOn = GetIsTimerOnFromCHK();
            numInterval.Value = isTimerOn ? GetIntervalFromNUM() : 0;
            numInterval.Enabled = isTimerOn;
            cmbIntervalType.SelectedIndex = isTimerOn ? GetIntervalTypeFromCMB() -1 : -1;
            cmbCalendarType.Enabled = isTimerOn;
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var result = folder.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                chkDefaultPath.Checked = false;
                chkDefaultPath_CheckedChanged(null, null);
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
                defaultSettings.HijriAdjustment = GetHijriAdjustmentFromCMB();
                defaultSettings.CalendarShowType = GetCalendarTypeFromCMB();
                defaultSettings.IsDefaultPth = GetIsDefaultPathFromCHK();
                defaultSettings.Path = GetSelectedPathFromFolderDialog();
                defaultSettings.IsTimerOn = GetIsTimerOnFromCHK();
                defaultSettings.Interval = GetIntervalFromNUM();
                defaultSettings.IntervalType = GetIntervalTypeFromCMB();
                defaultSettings.IsShowPersianCalendar = chkIsShowPersianCalendar.Checked;
                defaultSettings.IsShowHijriCalendar = chkIsShowHijriCalendar.Checked;
                defaultSettings.IsShowGregorianCalendar = chkIsShowGregorianCalendar.Checked;
                defaultSettings.BackgroundLocation = GetBackgroundLocationFromCMB();
                defaultSettings.Save();
                DialogResult = DialogResult.OK;
                btnCancel_Click(null, null);
            }
        }

        private bool ControlData()
        {
            var selectedPath = GetSelectedPathFromFolderDialog();
            if (!GetIsDefaultPathFromCHK() && (string.IsNullOrEmpty(selectedPath) || !Directory.Exists(selectedPath)))
            {
                ShowError(message: "لطفا مسیر آلبوم تصاویر را از تب 'پس زمینه' انتخاب نمائید");
                return false;
            }

            
            if (GetIsTimerOnFromCHK() && (GetIntervalFromNUM() == 0 || GetIntervalTypeFromCMB() == 0))
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
    }
}
