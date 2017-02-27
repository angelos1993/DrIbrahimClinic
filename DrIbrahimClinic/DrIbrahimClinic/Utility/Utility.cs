using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DrIbrahimClinic.DAL.Model;

namespace DrIbrahimClinic.Utility
{
    public static class Utility
    {
        public static void SetAutoCompleteSourceForTextBox(TextBox textBox, AutoCompleteStringCollection collection)
        {
            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteCustomSource = collection;
        }

        public static string ToTreatmentsListString(this IEnumerable<Treatment> treatments)
        {
            var enumerable = treatments as IList<Treatment> ?? treatments.ToList();
            if (!enumerable.Any())
                return string.Empty;
            switch (enumerable.Count)
            {
                case 1:
                    return enumerable[0].Name;
                case 2:
                    return $"{enumerable[0].Name} and {enumerable[1].Name}";
                default:
                    var result = new StringBuilder();
                    for (var i = 0; i < enumerable.Count - 1; i++)
                        result.Append($"{enumerable[i].Name}, ");
                    result.Append($"and {enumerable[enumerable.Count - 1].Name}");
                    return result.ToString();
            }
        }

        public static string ToDiagnosisListString(this IEnumerable<Diagnosi> diagnosis)
        {
            var enumerable = diagnosis as IList<Diagnosi> ?? diagnosis.ToList();
            if (!enumerable.Any())
                return string.Empty;
            switch (enumerable.Count)
            {
                case 1:
                    return enumerable[0].Name;
                case 2:
                    return $"{enumerable[0].Name} and {enumerable[1].Name}";
                default:
                    var result = new StringBuilder();
                    for (var i = 0; i < enumerable.Count - 1; i++)
                        result.Append($"{enumerable[i].Name}, ");
                    result.Append($"and {enumerable[enumerable.Count - 1].Name}");
                    return result.ToString();
            }
        }
    }
}