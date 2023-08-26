using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDStoreUser.Model
{
    public class Store  
    {
        public string Description { get; set; }
        public DateTime Creationdate { get; set; }
        public bool Valid { get; set; }
        
        
        public virtual List<Person> Employers { get; set; }
        public virtual List<Item> Items { get; set; } // pq virtual?

    }
}