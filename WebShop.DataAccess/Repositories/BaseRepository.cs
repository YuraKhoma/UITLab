using System;
using System.Collections.Generic;
using System.Linq;
using WebShop.Common.Models;
using WebShop.DataAccess.Abstractions;

namespace WebShop.DataAccess.Repositories
{
    /// <summary>
    /// Implementation if IBaseRepository Interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseRepository<T> : IRepository<T>
        where T: BaseModel
    {
        protected static List<T> storage = new List<T>();

        /// <summary>
        /// Method that creates new item
        /// </summary>
        /// <param name="item"></param>
        public void Create(T item)
        {
            storage.Add(item);
        }

        /// <summary>
        /// Method that deletes item by id
        /// </summary>
        /// <param name="id"></param>
        public void Delete(Guid id)
        {
            var item = this.GetById(id);
            storage.Remove(item);
        }

        /// <summary>
        /// Returns all items
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return storage;
        }

        /// <summary>
        /// Returns item by if
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public T GetById(Guid itemId)
        {
            var item = storage.FirstOrDefault(x => x.Id == itemId);
            return item;
        }

    }
}
