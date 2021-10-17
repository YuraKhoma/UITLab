using System;

namespace WebShop.Common.Models
{
    /// <summary>
    /// Base model which allows to use id to T
    /// </summary>
    public class BaseModel
    {
        public Guid Id { get; set; }
    }
}
