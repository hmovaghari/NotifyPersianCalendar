using FarsiLibrary.Win.Controls;
using Persian.Calendar.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyPersianCalendar
{
    public partial class frmConvert : StaticForm
    {
        private static frmConvert sForm;
        private Calendar calendar = new Calendar();

        private frmConvert()
        {
            InitializeComponent();
        }

        public static frmConvert GetInstance()
        {
            if (sForm == null || sForm.IsDisposed)
            {
                sForm = new frmConvert();
            }

            return sForm;
        }

        private void frmConvert_Load(object sender, EventArgs e)
        {
            SetDateTimeNow();
        }

        private void SetDateTimeNow()
        {
            calendar.SelectedDateTime = DateTime.Now;
            txtFaCalendar.Text = $"{calendar.PersianDay.ToString("00")}/{calendar.PersianMonth.ToString("00")}/{calendar.PersianYear}";
        }

        private void TextChanged(object sender, EventArgs e)
        {
            var maskedTextBox = sender as MaskedTextBox;
            if (maskedTextBox != null )
            {
                var isMiladi = maskedTextBox.Name == txtEnCalendar.Name;
                try
                {
                    var date = new List<int>();
                    maskedTextBox.Text.Split('/').ToList().ForEach(x => date.Add(int.Parse(x)));
                    if (isMiladi)
                    {
                        calendar.SelectedDateTime = new DateTime(year: date[2], month: date[1], day: date[0]);
                        txtFaCalendar.Text = $"{calendar.PersianDay.ToString("00")}/{calendar.PersianMonth.ToString("00")}/{calendar.PersianYear}";
                    }
                    else
                    {
                        calendar.SelectedDateTime = CalendarFunctions.PersianCalendarToDateTime(year: date[2], month: date[1], day: date[0]);
                        txtEnCalendar.Text = $"{calendar.GregorianDay.ToString("00")}/{calendar.GregorianMonth.ToString("00")}/{calendar.GregorianYear}";
                    }
                    lblCalendar.Text = calendar.Text(3);
                    faPictureBox.Image = frmBackground.SetImageForPictureBoxStatic(calendar.SelectedDateTime, 4, CalendarType.PersianCalendar);
                    enPictureBox.Image = frmBackground.SetImageForPictureBoxStatic(calendar.SelectedDateTime, 5, CalendarType.GregorianCalendar);
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
