using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DrIbrahimClinic.DAL.Model;

namespace DrIbrahimClinic.DAL
{
    interface IRepository<T> : IDisposable where T : class
    {
        DrIbrahimClinicEntities Context { get; }
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save();
        IQueryable<T> GatAll();
        T GatById(int id);
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
    }

    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        #region Properties

        private DrIbrahimClinicEntities _context;

        public DrIbrahimClinicEntities Context
        {
            get { return _context ?? (_context = new DrIbrahimClinicEntities()); }
            private set { _context = value; }
        }

        private DbSet<T> _dbSet;
        public DbSet<T> DbSet => _dbSet ?? (_dbSet = Context.Set<T>());

        #endregion

        #region Methods

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            DbSet.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }

        public IQueryable<T> GatAll()
        {
            return DbSet;
        }

        public T GatById(int id)
        {
            return DbSet.Find(id);
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return GatAll().Where(predicate);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            if (Context == null) return;
            Context.Dispose();
            Context = null;
        }

        #endregion
    }
}