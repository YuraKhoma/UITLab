using System;
using System.Collections.Generic;
using WebShop.Common.Models;

namespace WebShop.DataAccess.Abstractions
{
    /// <summary>
    /// Base repository that is implemented by all repositories
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
        where T : BaseModel
    {
        T GetById(Guid itemId);

        List<T> GetAll();

        void Create(T item);

        void Delete(Guid id);
    }
}
