using DrIbrahimClinic.DAL;

namespace DrIbrahimClinic.BLL
{
    public class DatabaseManager : BaseManager
    {
        #region Properties

        private DatabaseRepository _databaseRepository;

        private DatabaseRepository DatabaseRepository
            => _databaseRepository ?? (_databaseRepository = new DatabaseRepository());

        #endregion

        #region Methods

        public void Backup(string bacFolderPath)
        {
            DatabaseRepository.Backup(bacFolderPath);
        }

        public void Restore(string bakFilePath)
        {
            DatabaseRepository.Restore(bakFilePath);
        }

        #endregion
    }
}