using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  NotifyPersianCalendar
{
    public class Enums
    {
        public int? ID => GetID();
        public string Name => GetName();
        public object Value { get; set; }

        private string GetName()
        {
            if (Value != null)
            {
                if (Value.GetType() == BackgroundStyle.Fill.GetType())
                {
                    //return ((BackgroundStyle)Value).ToString();
                    return Enum.GetName(typeof(BackgroundStyle), ((BackgroundStyle)Value));
                }
            }

            return null;
        }

        private int? GetID()
        {
            if (Value != null)
            {
                if (Value.GetType() == BackgroundStyle.Fill.GetType())
                {
                    return (int)(BackgroundStyle)Value;
                }
            }

            return null;
        }

        public static List<Enums> GetBackgroundStyleList()
        {
            return new List<Enums>()
            {
                new Enums(){Value = BackgroundStyle.Fill },
                new Enums(){Value = BackgroundStyle.Fit },
                new Enums(){Value = BackgroundStyle.Stretch },
                new Enums(){Value = BackgroundStyle.Tile },
                new Enums(){Value = BackgroundStyle.Center },
                new Enums(){Value = BackgroundStyle.Span }
            };
        }
    }

    public enum BackgroundStyle : int
    {
        Fill = 1,
        Fit = 2,
        Stretch = 3,
        Tile = 4,
        Center = 5,
        Span = 6
    }
}
