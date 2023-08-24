using CRUDStoreUser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Usuário.Model
{
    public class ShopCart
    {
        public User User { get; set; }
        public List<Item> itens { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }


    }
}