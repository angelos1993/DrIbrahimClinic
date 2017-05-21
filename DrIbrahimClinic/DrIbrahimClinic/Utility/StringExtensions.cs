using System;
using System.Text.RegularExpressions;

namespace DrIbrahimClinic.Utility
{
    public static class StringExtensions
    {
        public static string FullTrim(this string str)
        {
            return Regex.Replace(str.TrimStart().TrimEnd().Trim(), @"\s+", " ");
        }

        public static DateTime ToDateTimeFromArabicFormattedDate(this string str)
        {
            var dateParts = str.Split(' ');
            int monthNumbre;
            switch (dateParts[1])
            {
                case "يناير":
                    monthNumbre = 1;
                    break;
                case "فبراير":
                    monthNumbre = 2;
                    break;
                case "مارس":
                    monthNumbre = 3;
                    break;
                case "أبريل":
                    monthNumbre = 4;
                    break;
                case "مايو":
                    monthNumbre = 5;
                    break;
                case "يونيو":
                    monthNumbre = 6;
                    break;
                case "يوليه":
                    monthNumbre = 7;
                    break;
                case "أغسطس":
                    monthNumbre = 8;
                    break;
                case "سبتمبر":
                    monthNumbre = 9;
                    break;
                case "أكتوبر":
                    monthNumbre = 10;
                    break;
                case "نوفمبر":
                    monthNumbre = 11;
                    break;
                case "ديسمبر":
                    monthNumbre = 12;
                    break;
                default:
                    monthNumbre = 0;
                    break;
            }
            return new DateTime(int.Parse(dateParts[2]), monthNumbre, int.Parse(dateParts[0]));
        }
    }
}