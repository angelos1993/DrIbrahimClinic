using System;
using System.Data.Entity;
using static DrIbrahimClinic.Utility.Constants;
using static DrIbrahimClinic.Utility.DateTimeExtensions;

namespace DrIbrahimClinic.DAL
{
    public class DatabaseRepository : RepositoryBase<object>
    {

        #region Methods

        public void Backup(string bacFolderPath)
        {
            Context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction,
                $"BACKUP DATABASE {DatabaseName} TO DISK = '{bacFolderPath}\\{DatabaseName} - {DateTime.Now.ToFormattedDate()}.bak'");
        }

        public void Restore(string bakFilePath)
        {
            Context.Database.ExecuteSqlCommand("");
        }

        #endregion
    }
}