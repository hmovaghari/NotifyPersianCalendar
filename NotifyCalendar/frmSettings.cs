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

namespace NotifyCalendar
{
    public partial class frmSettings : Form
    {
        private Calendar Calendar;
        private Properties.Settings defaultSettings = Properties.Settings.Default;

        public frmSettings(Calendar calendar)
        {
            InitializeComponent();
            Calendar = calendar;
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
            cmbCalendarType.SelectedIndex = defaultSettings.CalendarType - 1;
            
            chkDefaultPath.Checked = defaultSettings.IsDefaultPth;
            folder.SelectedPath = defaultSettings.Path;
            chkDefaultPath_CheckedChanged(null, null);

            chkIsTimerOn.Checked = defaultSettings.IsTimerOn;
            numInterval.Value = defaultSettings.Interval;
            cmbIntervalType.SelectedIndex = defaultSettings.IntervalType - 1;
        }

        private void cmbCalendarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var calendarType = GetCalendarTypeFromCMB();
            lblCalendarType.Text = CalendarFanctions.GetCalendar(Calendar, calendarType).ToString();
        }

        private byte GetCalendarTypeFromCMB()
        {
            return (byte)(cmbCalendarType.SelectedIndex + 1);
        }

        private void cmbHijriAdjustment_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hijriAdjustment = GetHijriAdjustmentFromCMB();
            lblHijriAdjustment.Text = CalendarFanctions.GetHijriDate(hijriAdjustment);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ControlData())
            {
                defaultSettings.HijriAdjustment = GetHijriAdjustmentFromCMB();
                defaultSettings.CalendarType = GetCalendarTypeFromCMB();
                defaultSettings.IsDefaultPth = GetIsDefaultPathFromCHK();
                defaultSettings.Path = GetSelectedPathFromFolderDialog();
                defaultSettings.IsTimerOn = GetIsTimerOnFromCHK();
                defaultSettings.Interval = GetIntervalFromNUM();
                defaultSettings.IntervalType = GetIntervalTypeFromCMB();
                defaultSettings.Save();
                btnCancel_Click(null, null);
            }
        }

        private bool ControlData()
        {
            var selectedPath = GetSelectedPathFromFolderDialog();
            if (!GetIsDefaultPathFromCHK() && (string.IsNullOrEmpty(selectedPath) || !Directory.Exists(selectedPath)))
            {
                ShowError(message: "لطفا مسیر آلبوم تصاویر را انتخاب نمائید", caption: "خطا");
                return false;
            }

            
            if (GetIsTimerOnFromCHK() && (GetIntervalFromNUM() == 0 || GetIntervalTypeFromCMB() == -1))
            {
                ShowError(message: "لطفا نحوه‌ی تغییر اوتومات تصاویر را انتخاب نمائید", caption: "خطا");
                return false;
            }

            return true;
        }

        private void ShowError(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
