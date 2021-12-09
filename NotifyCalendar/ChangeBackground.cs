using Microsoft.Win32;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;

namespace NotifyCalendar
{
    public static class ChangeBackground
    {
        private static string currentDirectory = Directory.GetCurrentDirectory();

        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public static void Set(Image image, BackgroundStyle backgroundStyle)
        {
            var path = currentDirectory + @"\Image.png";

            try
            {
                image.Save(path);//ToDo ExternalException (0x80004005) A generic error occurred in GDI+

                var key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

                switch (backgroundStyle)
                {
                    case BackgroundStyle.Tiled:
                        key.SetValue(@"WallpaperStyle", 1.ToString());
                        key.SetValue(@"TileWallpaper", 1.ToString());
                        break;
                    case BackgroundStyle.Centered:
                        key.SetValue(@"WallpaperStyle", 1.ToString());
                        key.SetValue(@"TileWallpaper", 0.ToString());
                        break;
                    case BackgroundStyle.Stretched:
                        key.SetValue(@"WallpaperStyle", 2.ToString());
                        key.SetValue(@"TileWallpaper", 0.ToString());
                        break;
                    default:
                        break;
                }

                SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
            }
            catch (ExternalException e)
            {
                //ToDo (0x80004005) A generic error occurred in GDI+
            }
        }
    }

    public enum BackgroundStyle : int
    {
        Tiled,
        Centered,
        Stretched
    }
}
