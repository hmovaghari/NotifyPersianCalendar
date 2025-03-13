using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace  NotifyPersianCalendar
{
    public static class ChangeBackground
    {
        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public static void Set(string backgroundPath, Image image, BackgroundStyle backgroundStyle)
        {
            try
            {
                image.Save(backgroundPath);//ToDo ExternalException (0x80004005) A generic error occurred in GDI+

                var key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

                switch (backgroundStyle)
                {
                    case BackgroundStyle.Tile:
                        key.SetValue(@"WallpaperStyle", 0.ToString());
                        key.SetValue(@"TileWallpaper", 1.ToString());
                        break;
                    case BackgroundStyle.Center:
                        key.SetValue(@"WallpaperStyle", 0.ToString());
                        key.SetValue(@"TileWallpaper", 0.ToString());
                        break;
                    case BackgroundStyle.Stretch:
                        key.SetValue(@"WallpaperStyle", 2.ToString());
                        key.SetValue(@"TileWallpaper", 0.ToString());
                        break;
                    case BackgroundStyle.Fill:
                        key.SetValue(@"WallpaperStyle", 10.ToString());
                        key.SetValue(@"TileWallpaper", 0.ToString());
                        break;
                    case BackgroundStyle.Fit:
                        key.SetValue(@"WallpaperStyle", 6.ToString());
                        key.SetValue(@"TileWallpaper", 0.ToString());
                        break;
                    case BackgroundStyle.Span:
                        key.SetValue(@"WallpaperStyle", 22.ToString());
                        key.SetValue(@"TileWallpaper", 0.ToString());
                        break;
                    default:
                        break;
                }

                SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, backgroundPath, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
            }
            catch (ExternalException e)
            {
                //ToDo (0x80004005) A generic error occurred in GDI+
            }
        }
    }
}
