using Persian.Calendar.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyCalendar
{
    public partial class frmBackground : Form
    {
        static frmBackground sForm;

        private static Properties.Settings defaultSettings = Properties.Settings.Default;

        private frmBackground(string imagePath)
        {
            InitializeComponent();

            var image = GetImage(imagePath);

            SetPanelImage(image);

            ChangeSize(image.Width, image.Height);

            AddCalendar();
        }

        internal static Image TakeScreenshot(string imagePath)
        {
            sForm = new frmBackground(imagePath);
            Bitmap bitmap = new Bitmap(sForm.pnlBackground.Width, sForm.pnlBackground.Height);
            sForm.Show();
            sForm.pnlBackground.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            sForm.Hide();
            return bitmap;
        }

        private static Image GetImage(string imagePath)
        {
            return Image.FromFile(imagePath);
        }

        private void SetPanelImage(Image image)
        {
            pnlBackground.BackgroundImage = image;
        }

        private void ChangeSize(int width, int height)
        {
            Width = 0;
            Height = 0;
            pnlBackground.Width = width;
            pnlBackground.Height = height;
        }

        private void AddCalendar()
        {
            ClearAllpictureBoxes();

            var pictureBoxes = GetPictureBoxesByBackgroundLocation(defaultSettings.BackgroundLocation);

            if (pictureBoxes.Count > 0)
            {
                var now = DateTime.Now;
                var hijriAdjustment = Properties.Settings.Default.HijriAdjustment;

                var index = -1;

                if (defaultSettings.IsShowPersianCalendar)
                {
                    index = SetImageForPictureBox(pictureBoxes, now, index, CalendarType.PersianCalendar);
                }

                if (defaultSettings.IsShowHijriCalendar)
                {
                    index = SetImageForPictureBox(pictureBoxes, now, index, CalendarType.HijriCalendar, hijriAdjustment);
                }

                if (defaultSettings.IsShowGregorianCalendar)
                {
                    index = SetImageForPictureBox(pictureBoxes, now, index, CalendarType.GregorianCalendar);
                }
            }
        }

        private int SetImageForPictureBox(List<PictureBox> pictureBoxes, DateTime dateTime, int index,
            CalendarType calendarType, int? hijriAdjustment = null)
        {
            ++index;
            pictureBoxes[index].Image = GenerateUICalendar(calendarType, dateTime, hijriAdjustment);
            pictureBoxes[index].Visible = true;
            return index;
        }

        private List<PictureBox> GetPictureBoxesByBackgroundLocation(byte backgroundLocation)
        {
            switch (backgroundLocation)
            {
                case 1:
                    return new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3 };
                case 2:
                    return new List<PictureBox> { pictureBox1, pictureBox13, pictureBox14 };
                case 3:
                    return new List<PictureBox> { pictureBox4, pictureBox5, pictureBox6 };
                case 4:
                    return new List<PictureBox> { pictureBox4, pictureBox17, pictureBox18 };
                case 5:
                    return new List<PictureBox> { pictureBox10, pictureBox11, pictureBox12 };
                case 6:
                    return new List<PictureBox> { pictureBox10, pictureBox15, pictureBox16 };
                case 7:
                    return new List<PictureBox> { pictureBox7, pictureBox8, pictureBox9 };
                case 8:
                    return new List<PictureBox> { pictureBox7, pictureBox19, pictureBox20 };
                default:
                    return new List<PictureBox>();
            }
        }

        private void ClearAllpictureBoxes()
        {
            foreach (var item in pnlBackground.Controls)
            {
                var pictureBox = item as PictureBox;
                if (pictureBox != null)
                {
                    pictureBox.Visible = false;
                    pictureBox.Image = null;
                }
            }
        }

        private Image GenerateUICalendar(CalendarType calendarType, DateTime nowDateTime, int? hijriAdjustment = null)
        {
            UICalendar uiCalendar = new UICalendar();
            uiCalendar.CalendarType = calendarType;
            uiCalendar.HijriAdjustment = hijriAdjustment;
            uiCalendar.SelectedDateTime = nowDateTime;
            return uiCalendar.GetScreenShot();
        }
    }
}
