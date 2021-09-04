using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyCalendar
{
    public partial class frmBackground : Form
    {
        static frmBackground sForm;

        private frmBackground(string imagePath)
        {
            InitializeComponent();

            var image = GetImage(imagePath);

            SetPanelImage(image);

            ChangeSize(image.Width, image.Height);
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
    }
}
