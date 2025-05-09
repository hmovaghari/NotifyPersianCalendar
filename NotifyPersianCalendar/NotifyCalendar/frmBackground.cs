using Persian.Calendar.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  NotifyPersianCalendar
{
    public partial class frmBackground : UserControl
    {
        static frmBackground sForm;
        private Properties.Settings defaultSettings = Properties.Settings.Default;
        private static string currentDirectory = Directory.GetCurrentDirectory();
        private Image background = null;
        private Image CalendarImage1 = null;
        private Image CalendarImage2 = null;
        private Image CalendarImage3 = null;
        internal string Error = null;
        internal bool ForseClose = false;

        private frmBackground(string imagePath)
        {
            InitializeComponent();

            background = GetImage(imagePath);

            if (background != null)
            {
                SetPanelImage(background);

                ChangePanelSize(background.Width, background.Height);

                AddCalendar();
            }
            else
            {
                Error = "فایل آلبوم خوانده نشد لطفا نرم‌افزار را مجددا اجرا کنید";
                ForseClose = true;
            }
        }

        internal static frmBackground GenerateForm(string imagePath)
        {
            sForm = new frmBackground(imagePath);
            return sForm;
        }

        internal Image TakeScreenshot()
        {
            Bitmap bitmap = new Bitmap(sForm.pnlBackground.Width, sForm.pnlBackground.Height);
            sForm.pnlBackground.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            return bitmap;
        }

        private Image GetImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                return Image.FromFile(imagePath);
            }
            return null;
        }

        private void SetPanelImage(Image image)
        {
            pnlBackground.BackgroundImage = image;
        }

        private void ChangePanelSize(int width, int height)
        {
            pnlBackground.Width = width;
            pnlBackground.Height = height;
        }

        private void AddCalendar()
        {
            if (defaultSettings.BackgroundLocation == 0)
            {
                return;
            }

            var pictureBoxes = GetPictureBoxesByBackgroundLocation(defaultSettings.BackgroundLocation);

            if (pictureBoxes.Count > 0)
            {
                var nowDateTime = DateTime.Now;
                var hijriAdjustment = defaultSettings.HijriAdjustment;

                var index = -1;

                if (defaultSettings.IsShowPersianCalendar)
                {
                    index = SetImageForPictureBox(out CalendarImage1, pictureBoxes, nowDateTime, index, CalendarType.PersianCalendar);
                }

                if (defaultSettings.IsShowHijriCalendar)
                {
                    index = SetImageForPictureBox(out CalendarImage2, pictureBoxes, nowDateTime, index, CalendarType.HijriCalendar,
                        hijriAdjustment);
                }

                if (defaultSettings.IsShowGregorianCalendar)
                {
                    index = SetImageForPictureBox(out CalendarImage3, pictureBoxes, nowDateTime, index, CalendarType.GregorianCalendar);
                }
            }
            else
            {
                Error = "لطفا تنظیمات نرم‌افزار را بررسی نمائید";
            }
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

        public int SetImageForPictureBox(out Image calendarImage, List<PictureBox> pictureBoxes, DateTime nowDateTime, int index,
            CalendarType calendarType, int? hijriAdjustment = null)
        {
            ++index;
            calendarImage = SetImageForPictureBoxStatic(nowDateTime, index, calendarType, hijriAdjustment);
            if (calendarImage != null)
            {
                pictureBoxes[index].Image = calendarImage;
                pictureBoxes[index].Visible = true;
            }
            else
            {
                Error = "در خواندن تقویم مشکلی رخ داده لطفا مجددا نرم‌افزار اجرا کنید";
                ForseClose = true;
            }
            return index;
        }

        public static Image SetImageForPictureBoxStatic(DateTime nowDateTime, int index, CalendarType calendarType, int? hijriAdjustment = null)
        {
            string imagePath = $@"{currentDirectory}\Calendar{index}.png";
            var stream = GetUICalendarScreenShotStream(calendarType, nowDateTime, hijriAdjustment);
            return Image.FromStream(stream);
        }

        public static MemoryStream GetUICalendarScreenShotStream(CalendarType calendarType, DateTime nowDateTime,
            int? hijriAdjustment = null)
        {
            var cultureInfo = Persian.Calendar.Library.Calendar.GetCultureInfo(calendarType);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultureInfo);
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture;
            UICalendar uiCalendar = new UICalendar();
            uiCalendar.CalendarType = calendarType;
            uiCalendar.HijriAdjustment = hijriAdjustment;
            uiCalendar.SelectedDateTime = nowDateTime;
            var image = uiCalendar.GetScreenShot();
            var imageConverter = new ImageConverter();
            var bytes = (byte[])imageConverter.ConvertTo(image, typeof(byte[]));
            var stream = new MemoryStream(bytes);
            uiCalendar.Dispose();
            return stream;
        }
    }
}
