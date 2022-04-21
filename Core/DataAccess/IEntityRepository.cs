using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //NuGet den  Microsoft.EntityFrameworkCore.SqlServer 5.0.16 yüklenir
    public interface IEntityRepository<T> where T : class, IEntity
    {
        // Fitre yazarak getir
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
