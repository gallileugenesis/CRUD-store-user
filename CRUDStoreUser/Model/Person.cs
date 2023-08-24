using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDStoreUser.Model
{
    public class Person
    {
        public Guid Id { get; set; } // pq usou Guid e não int?
        public string Name { get; set; }
        public string BrithDate { get; set; }
        public string Email { get; set; }

       
    }


}