using System.Windows.Forms;
using DrIbrahimClinic.BLL;
using static DrIbrahimClinic.Utility.MessageBoxUtility;

namespace DrIbrahimClinic.PL
{
    public partial class FrmBackupAndRestore : MasterForm
    {
        public FrmBackupAndRestore()
        {
            InitializeComponent();
        }

        #region Properties

        private DatabaseManager _databaseManager;
        private DatabaseManager DatabaseManager => _databaseManager ?? (_databaseManager = new DatabaseManager());

        #endregion

        #region Events

        private void btnBackup_Click(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var folderBrowserDialog = new FolderBrowserDialog
            {
                Description = @"من فضلك قم بإختيار المكان الذي تريد نسخ قاعدة البيانات فية"
            };
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                DatabaseManager.Backup(folderBrowserDialog.SelectedPath);
            ShowInfoMsg("تم نسخ قاعدة البيانات بنجاح");
            Close();
        }

        private void btnRestore_Click(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            var openFileDialog = new OpenFileDialog
            {
                Title = @"من فضلك قم بإختيار ملف قاعدة البيانات الذي تريد إسترجاعة",
                Filter = @"bak files (.bak)|*.bak",
                Multiselect = false
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                DatabaseManager.Restore(openFileDialog.FileName);
            ShowInfoMsg("تم إستعادة قاعدة البيانات بنجاح");
            Close();
        }

        #endregion
    }
}