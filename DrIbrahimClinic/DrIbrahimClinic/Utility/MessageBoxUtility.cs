using System.Windows.Forms;
namespace DrIbrahimClinic.Utility
{
    static class MessageBoxUtility
    {
        public static void ShowErrorMsg(string msg)
        {
            MessageBox.Show(msg, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowWarningMsg(string msg)
        {
            MessageBox.Show(msg, "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowInfoMsg(string msg)
        {
            MessageBox.Show(msg, "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}