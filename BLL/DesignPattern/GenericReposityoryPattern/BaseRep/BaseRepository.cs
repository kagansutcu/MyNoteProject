using BLL.DesignPattern.GenericReposityoryPattern.IntRep;
using BLL.DesignPattern.SingeltonPattern;
using DAL.Context;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DesignPattern.GenericReposityoryPattern.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected MyContext db;
        public BaseRepository()
        {
            db = DBTool.DBInstance;
        }
        public void Add(T item)
        {
            db.Set<T>().Add(item);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
            item.Status = Model.Enums.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            Save();
        }

        public void Destroy(T item)
        {
            db.Set<T>().Remove(item);
            Save();
        }

        public T Find(int id)
        {
            return db.Set<T>().Find(id);
        }

        public List<T> GetActives()
        {
            return Where(x => x.Status != Model.Enums.DataStatus.Deleted);
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetDefault(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().FirstOrDefault(exp);
        }

        public List<T> GetPassives()
        {
            return Where(x => x.Status == Model.Enums.DataStatus.Deleted);
        }

        public List<T> GetUpdateds()
        {
            return Where(x => x.Status == Model.Enums.DataStatus.Modified);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return db.Set<T>().Select(exp).ToList();
        }

        public void Update(T item)
        {
            item.ModifiedDate = DateTime.Now;
            item.Status = Model.Enums.DataStatus.Modified;
            T guncellencek = Find(item.ID);
            db.Entry(guncellencek).CurrentValues.SetValues(item);
            Save();
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return db.Set<T>().Where(exp).ToList();
        }

        
    }
}
