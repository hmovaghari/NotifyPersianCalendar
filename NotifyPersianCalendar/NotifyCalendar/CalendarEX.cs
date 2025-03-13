using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persian.Calendar.Library;

namespace  NotifyPersianCalendar
{
    internal static class CalendarEX
    {
        internal static string Text(this Calendar calendar, byte calendarShowType)
        {
            var result = new StringBuilder();
            result.AppendLine(GetPersianDate(calendar, calendarShowType));
            result.AppendLine(GetHijriDate(calendar, calendarShowType));
            result.AppendLine(GetGregorianDate(calendar, calendarShowType));
            return result.ToString();
        }

        internal static int? GetHijriAdjustmentOnlie(this Calendar calendar)
        {
            var hijriAdjustmentOnjline = new int?();
            try
            {
                hijriAdjustmentOnjline = Calendar.GetHijriAdjustmentOnline(calendar.SelectedDateTime);
            }
            catch { }
            return hijriAdjustmentOnjline;
        }


        private static string GetPersianDate(Calendar calendar, byte calendarType)
        {
            var persianDate = new StringBuilder();

            persianDate.Append(calendar.PersianDayOfWeek);
            persianDate.Append(" ");

            if (calendarType == 1 || calendarType == 3)
            {
                persianDate.Append(calendar.PersianDay.ToPersianOrdinalNumber());
                persianDate.Append(" ");
                persianDate.Append(calendar.PersianMonthTitle);
                persianDate.Append(" ");
                persianDate.Append(calendar.PersianYear.ToPersianNumber());

                if (calendarType == 3)
                {
                    persianDate.Append(" -- ");
                    persianDate.Append(GetPersianDate(calendar));
                }
            }
            else
            {
                persianDate.Append(GetPersianDate(calendar));
            }

            return persianDate.ToString();
        }

        private static string GetPersianDate(Calendar calendar)
        {
            return calendar.PersianYear.ToPersianNumber() + "/" +
                calendar.PersianMonth.ToString("00").ToPersianNumber() + "/" +
                calendar.PersianDay.ToString("00").ToPersianNumber();
        }

        internal static string GetHijriDate(this Calendar calendar, int hijriAdjustment)
        {
            calendar.HijriAdjustment = hijriAdjustment;
            return GetHijriDate(calendar, calendarType: 3);
        }

        private static string GetHijriDate(Calendar calendar, byte calendarType)
        {
            var hijriDate = new StringBuilder();

            if (calendarType == 1 || calendarType == 3)
            {
                hijriDate.Append(calendar.HijriDay.ToPersianOrdinalNumber());
                hijriDate.Append(" ");
                hijriDate.Append(calendar.HijriMonthTitle);
                hijriDate.Append(" ");
                hijriDate.Append(calendar.HijriYear.ToPersianNumber());

                if (calendarType == 3)
                {
                    hijriDate.Append(" -- ");
                    hijriDate.Append(GetHijriDate(calendar));
                }
            }
            else
            {
                hijriDate.Append(GetHijriDate(calendar));
            }

            return hijriDate.ToString();
        }

        private static string GetHijriDate(Calendar calendar)
        {
            return calendar.HijriYear.ToPersianNumber() + "/" +
                calendar.HijriMonth.ToString("00").ToPersianNumber() + "/" +
                calendar.HijriDay.ToString("00").ToPersianNumber();
        }

        private static string GetGregorianDate(Calendar calendar, byte calendarType)
        {
            var gregorianDate = new StringBuilder();

            if (calendarType == 1 || calendarType == 3)
            {
                gregorianDate.Append(calendar.GregorianDay.ToPersianOrdinalNumber());
                gregorianDate.Append(" ");
                gregorianDate.Append(calendar.GregorianMonthTiltePersian);
                gregorianDate.Append(" ");
                gregorianDate.Append(calendar.GregorianYear.ToPersianNumber());

                if (calendarType == 3)
                {
                    gregorianDate.Append(" -- ");
                    gregorianDate.Append(GetGregorianDate(calendar));
                }
            }
            else
            {
                gregorianDate.Append(GetGregorianDate(calendar));
            }

            return gregorianDate.ToString();
        }

        private static string GetGregorianDate(Calendar calendar)
        {
            return calendar.GregorianYear.ToPersianNumber() + "/" +
                calendar.GregorianMonth.ToString("00").ToPersianNumber() + "/" +
                calendar.GregorianDay.ToString("00").ToPersianNumber();
        }

        internal static Icon GetIcon(this Calendar calendar)
        {
            var day = calendar.PersianDay;
            switch (day)
            {
                case 1:
                    return Properties.Resources.D01;
                case 2:
                    return Properties.Resources.D02;
                case 3:
                    return Properties.Resources.D03;
                case 4:
                    return Properties.Resources.D04;
                case 5:
                    return Properties.Resources.D05;
                case 6:
                    return Properties.Resources.D06;
                case 7:
                    return Properties.Resources.D07;
                case 8:
                    return Properties.Resources.D08;
                case 9:
                    return Properties.Resources.D09;
                case 10:
                    return Properties.Resources.D10;
                case 11:
                    return Properties.Resources.D11;
                case 12:
                    return Properties.Resources.D12;
                case 13:
                    return Properties.Resources.D13;
                case 14:
                    return Properties.Resources.D14;
                case 15:
                    return Properties.Resources.D15;
                case 16:
                    return Properties.Resources.D16;
                case 17:
                    return Properties.Resources.D17;
                case 18:
                    return Properties.Resources.D18;
                case 19:
                    return Properties.Resources.D19;
                case 20:
                    return Properties.Resources.D20;
                case 21:
                    return Properties.Resources.D21;
                case 22:
                    return Properties.Resources.D22;
                case 23:
                    return Properties.Resources.D23;
                case 24:
                    return Properties.Resources.D24;
                case 25:
                    return Properties.Resources.D25;
                case 26:
                    return Properties.Resources.D26;
                case 27:
                    return Properties.Resources.D27;
                case 28:
                    return Properties.Resources.D28;
                case 29:
                    return Properties.Resources.D29;
                case 30:
                    return Properties.Resources.D30;
                default:
                    return Properties.Resources.D31;
            }
        }
    }
}
