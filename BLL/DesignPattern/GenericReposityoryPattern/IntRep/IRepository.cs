using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DesignPattern.GenericReposityoryPattern.IntRep
{
    public interface IRepository<T> where T: BaseEntity
    {

        List<T> GetAll();
        T Find(int id);

        List<T> GetActives();

        List<T> GetPassives();

        List<T> GetUpdateds();

        
        void Add(T item); 
        void Update(T item); 
        void Delete(T item);
        void Destroy(T item);
        void Save();


        List<T> Where(Expression<Func<T, bool>> exp);

        T GetDefault(Expression<Func<T, bool>> exp);

        bool Any(Expression<Func<T, bool>> exp);

        object Select(Expression<Func<T, object>> exp);
    }
}
