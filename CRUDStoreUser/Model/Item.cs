using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDStoreUser.Model
{
    public class Item : BaseClass
    {
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Item(int id, string name) : base(id, name)
        {

        }
    }
}