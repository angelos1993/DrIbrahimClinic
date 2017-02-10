using System.Windows.Forms;

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
    }
}