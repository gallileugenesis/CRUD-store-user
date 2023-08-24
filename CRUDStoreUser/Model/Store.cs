using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDStoreUser.Model
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Creationdate { get; set; }
        public bool Valid { get; set; }
        public Person
        public virtual List<Item> Items { get; set; } // pq virtual?

    }
}