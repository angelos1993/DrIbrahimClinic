using System;
using System.Windows.Forms;
using DrIbrahimClinic.Utility;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using static DrIbrahimClinic.Utility.MessageBoxUtility;
using static DrIbrahimClinic.Utility.Constants;

namespace DrIbrahimClinic.PL
{
    public partial class FrmBackupAndRestore : MasterForm
    {
        public FrmBackupAndRestore()
        {
            InitializeComponent();
        }

        #region Events

        private void FrmBackupAndRestore_Load(object sender, EventArgs e)
        {
            ShowOrHideControls(false);
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            BackupDatabase();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            RestoreDatabase();
        }

        private void PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Value = e.Percent;
            lblProgress.Text = $"{e.Percent}%";
        }

        private void Backup_Complet(object sender, ServerMessageEventArgs e)
        {
            Cursor = Cursors.Default;
            ShowOrHideControls(false);
            ShowInfoMsg("تم نسخ قاعدة البيانات بنجاح");
            Close();
        }

        private void Restore_Complete(object sender, ServerMessageEventArgs e)
        {
            Cursor = Cursors.Default;
            ShowOrHideControls(false);
            ShowInfoMsg("تم إستعادة قاعدة البيانات بنجاح");
            Close();
        }

        #endregion

        #region Methods

        private void BackupDatabase()
        {
            try
            {
                var folderBrowserDialog = new FolderBrowserDialog
                {
                    Description = @"من فضلك قم بإختيار المكان الذي تريد نسخ قاعدة البيانات فية"
                };
                if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                    return;
                ShowOrHideControls(true);
                var server = new Server(new ServerConnection(ServerName, LoginName, Password));
                var backup = new Backup {Action = BackupActionType.Database, Database = DatabaseName};
                backup.Devices.AddDevice(
                    $@"{folderBrowserDialog.SelectedPath}\{DatabaseName} - {DateTime.Now.ToFormattedDate()}.bak",
                    DeviceType.File);
                backup.Initialize = true;
                backup.PercentComplete += PercentComplete;
                backup.Complete += Backup_Complet;
                backup.SqlBackupAsync(server);
            }
            catch
            {
                Cursor = Cursors.Default;
                ShowErrorMsg("حدث خطأ ما، من فضلك حاول مرة أخري ... قم بتغيير المكان");
            }
        }

        private void RestoreDatabase()
        {
            try
            {
                var openFileDialog = new OpenFileDialog
                {
                    Title = @"من فضلك قم بإختيار ملف قاعدة البيانات الذي تريد إسترجاعة",
                    Filter = @"bak files (.bak)|*.bak",
                    Multiselect = false
                };
                if (openFileDialog.ShowDialog() != DialogResult.OK)
                    return;
                ShowOrHideControls(true);
                var server = new Server(new ServerConnection(ServerName, LoginName, Password));
                var restore = new Restore
                {
                    Database = DatabaseName,
                    Action = RestoreActionType.Database,
                    ReplaceDatabase = true,
                    NoRecovery = false
                };
                restore.Devices.AddDevice($@"{openFileDialog.FileName}", DeviceType.File);
                restore.PercentComplete += PercentComplete;
                restore.Complete += Restore_Complete;
                restore.SqlRestoreAsync(server);
            }
            catch
            {
                Cursor = Cursors.Default;
                ShowErrorMsg("حدث خطأ ما، من فضلك حاول مرة أخري ... قم بتغيير ملف الاسترجاع");
            }
        }

        private void ShowOrHideControls(bool isVisible)
        {
            progressBar.Visible = isVisible;
            lblProgress.Visible = isVisible;
            lblProgress.Text = @"0%";
        }

        #endregion
    }
}