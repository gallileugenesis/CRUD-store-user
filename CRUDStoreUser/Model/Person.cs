using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDStoreUser.Model
{
    public class Person: BaseClass
    {
        public string BrithDate { get; set; }
        public string Email { get; set; }

        public Person(int id, string name) : base(id, name)
        {

        }


    }


}