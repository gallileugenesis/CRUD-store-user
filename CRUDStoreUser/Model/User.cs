using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDStoreUser.Model
{
    public class User : Person // Falar mais sobre herança
    {
        // Variáveis
        public string Password { get; set; }
        public bool Valid { get; set; }

        // Métodos
        public User()
        {

        }

    }
}