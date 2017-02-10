using System.Text.RegularExpressions;

namespace DrIbrahimClinic.Utility
{
    public static class StringExtensions
    {
        public static string FullTrim(this string str)
        {
            return Regex.Replace(str, @"\s+", " ");
        }
    }
}