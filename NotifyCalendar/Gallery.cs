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
        private Properties.Settings defaultSettings = Properties.Settings.Default;
        private string defaultGallery = $@"{Directory.GetCurrentDirectory()}\Gallery";
        internal string Error = null;
        internal bool ForceClose = false;

        internal List<string> GetGalleryFiles()
        {
            if (defaultSettings.IsDefaultPicturesAlbumPath || !Directory.Exists(defaultSettings.PicturesAlbumPath))
            {
                if (!defaultSettings.IsDefaultPicturesAlbumPath && !Directory.Exists(defaultSettings.PicturesAlbumPath))
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
                return CreateIfNotExistsAndGetGalleryImages(defaultSettings.PicturesAlbumPath);
            }
        }

        internal string GetGalleryPath()
        {
            if (defaultSettings.IsDefaultPicturesAlbumPath)
            {
                return defaultGallery;
            }
            return defaultSettings.PicturesAlbumPath;
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

        private void ChangeToDefaultPath()
        {
            defaultSettings.IsDefaultPicturesAlbumPath = true;
            defaultSettings.PicturesAlbumPath = string.Empty;
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
            var _frmBackground = frmBackground.GenerateForm(imagePath);
            if (_frmBackground.Error == null)
            {
                var image = _frmBackground.TakeScreenshot();
                ChangeBackground.Set(image, BackgroundStyle.Stretch);
                image.Dispose();
            }
            else
            {
                Error = _frmBackground.Error;
                ForceClose = _frmBackground.ForseClose;
            }
            _frmBackground.Dispose();
        }

        private string GetRadnomImagePath(List<string> imagePath)
        {
            Random random = new Random();
            var index = random.Next(imagePath.Count);
            return imagePath[index];
        }
    }
}
