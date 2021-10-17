using System;

namespace WebShop.Common.Models
{

    /// <summary>
    /// Class with goods descriotion
    /// </summary>
    public class Item : BaseModel
    {
        public string Title { get; set; }

        public int Price { get; set; }

        public ItemCategory Category { get; set; }

        public string Description { get; set; }

        public ItemStatus ItemStatus { get; set; }

    }
}
