﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDStoreUser.Model
{
    public class BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BaseClass(int id, string name)
        {
            this.Id = id;
            this.Name = name;   
        }
    }
}