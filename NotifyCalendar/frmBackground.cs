using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotifyCalendar
{
    public partial class frmBackground : Form
    {
        static frmBackground sForm;

        private frmBackground()
        {

        }

        private frmBackground(string imagePath)
        {
            InitializeComponent();

            var image = GetImage(imagePath);
            
            SetFormImage(image);

            ChangeFormSize(image.Width, image.Height);
        }

        private static new void Show(IWin32Window owner = null)
        {

        }

        private static new void ShowDialog(IWin32Window owner = null)
        {

        }

        internal static Image TakeScreenshot(string imagePath)
        {
            sForm = new frmBackground(imagePath);
            sForm.Activate();
            Bitmap bitmap = new Bitmap(sForm.Width, sForm.Height);
            sForm.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            return bitmap;
        }

        private static Image GetImage(string imagePath)
        {
            return Image.FromFile(imagePath);
        }

        private void SetFormImage(Image image)
        {
            BackgroundImage = image;
        }

        private void ChangeFormSize(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
