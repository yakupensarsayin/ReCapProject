using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // Class: Referans tipi alabilir. 
    // IEntity: IEntity olmak zorundadır.
    // new() : new()'lanabilen bir şey olması gerekiyor o yüzden IEntity'nin kendisi olamaz ancak onu implement eden class'lar olabilir.
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
