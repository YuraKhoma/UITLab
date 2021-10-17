using System;

namespace WebShop.Common.Models
{
    /// <summary>
    /// Odrer class
    /// </summary>
    public class Order : BaseModel
    {
        public Guid UserId { get; set; }

        public Guid ItemId { get; set; }

        public int NumberOfItems { get; set; }

        public OrderStatus OrderStatus { get; set; }
    }
}
