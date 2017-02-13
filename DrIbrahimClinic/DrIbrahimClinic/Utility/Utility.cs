using System.Collections.Generic;
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
            var treatmentsStringBuilder = new StringBuilder();
            foreach (var treatment in treatments)
                treatmentsStringBuilder.Append($"{treatment.Name}, ");
            return treatmentsStringBuilder.ToString();
        }

        public static string ToDiagnosisListString(this IEnumerable<Diagnosi> diagnosis)
        {
            var diagnosisStringBuilder = new StringBuilder();
            foreach (var diagnosi in diagnosis)
                diagnosisStringBuilder.Append($"{diagnosi.Name}, ");
            return diagnosisStringBuilder.ToString();
        }
    }
}