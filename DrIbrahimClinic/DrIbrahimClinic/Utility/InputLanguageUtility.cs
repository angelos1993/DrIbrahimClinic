using System;
using System.Linq;
using System.Windows.Forms;

namespace DrIbrahimClinic.Utility
{
    public static class InputLanguageUtility
    {
        private static InputLanguage Arabic => InputLanguage.InstalledInputLanguages.Cast<InputLanguage>()
            .FirstOrDefault(inputLanguage => inputLanguage.LayoutName?.Contains("Arabic") ?? false);

        private static InputLanguage English => InputLanguage.InstalledInputLanguages.Cast<InputLanguage>()
            .FirstOrDefault(inputLanguage => inputLanguage.LayoutName?.Contains("English") ?? false);

        public static void SetArabicInputLanguage(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = Arabic;
        }

        public static void SetEnglishInputLanguage(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = English;
        }
    }
}