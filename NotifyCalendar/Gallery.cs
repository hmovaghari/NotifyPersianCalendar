using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyCalendar
{
    public class Gallery
    {
        private static Properties.Settings defaultSettings = Properties.Settings.Default;
        private string defaultGallery = $@"{Directory.GetCurrentDirectory()}\Gallery";
        internal string Error = null;

        internal List<string> GetGalleryFiles()
        {
            if (defaultSettings.IsDefaultPth || !Directory.Exists(defaultSettings.Path))
            {
                if (!defaultSettings.IsDefaultPth && !Directory.Exists(defaultSettings.Path))
                {
                    ChangeToDefaultPath();
                    Error = "آلبوم تصاویر یافت نشد" + Environment.NewLine +
                        "آلبوم تصاویر به حالت پیشفرض تغییر نمود";
                }

                if (!Directory.Exists(defaultGallery))
                {
                    Directory.CreateDirectory(defaultGallery);
                }

                return CreateIfNotExistsAndGetGalleryImages(defaultGallery);
            }
            else
            {
                return CreateIfNotExistsAndGetGalleryImages(defaultSettings.Path);
            }

        }

        private List<string> CreateIfNotExistsAndGetGalleryImages(string path)
        {
            var galleryFiles = GetGalleryFiles(path);
            if (galleryFiles.Count == 0)
            {
                galleryFiles = CreateAndGetDefaultGalleryFiles(path);
            }
            return galleryFiles;
        }

        private List<string> CreateAndGetDefaultGalleryFiles(string path)
        {
            var galleryFiles = new List<string>();
            ImageConverter converter = new ImageConverter();
            var resourceImages = new List<Bitmap>
            {
                new Bitmap(Properties.Resources.FlowerInWomanHands)
                {
                    Tag = "FlowerInWomanHands.png"
                },
                new Bitmap(Properties.Resources.Gratisography_301H)
                {
                    Tag = "Gratisography_301H.png"
                }
            };
            resourceImages.ForEach(x => File.WriteAllBytes($@"{path}\{x.Tag}", (byte[])converter.ConvertTo(x, typeof(byte[]))));
            resourceImages.ForEach(x => galleryFiles.Add($@"{path}\{x.Tag}"));
            return galleryFiles;
        }

        private static void ChangeToDefaultPath()
        {
            defaultSettings.IsDefaultPth = true;
            defaultSettings.Path = string.Empty;
            defaultSettings.Save();
        }

        private List<string> GetGalleryFiles(string path)
        {
            var extensions = new List<string> { ".jpg", ".jpeg", ".png", ".gif", ".tiff" };
            return Directory.GetFiles(path).Where(x => extensions.Any(y => x.EndsWith(y))).ToList();
        }

        internal void ChangeDesktopBackground(List<string> imagePaths)
        {
            var imagePath = GetRadnomImagePath(imagePaths);
            var image = frmBackground.TakeScreenshot(imagePath);
            ChangeBackground.Set(image);
        }

        private string GetRadnomImagePath(List<string> imagePath)
        {
            Random random = new Random();
            var index = random.Next(imagePath.Count);
            return imagePath[index];
        }
    }
}
