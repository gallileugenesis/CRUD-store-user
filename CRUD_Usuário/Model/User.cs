using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDUserStore.Model
{
    public class User
    {
        // Variáveis
        public Guid Id { get; set; } // pq não termina com ;? 
        public string Name { get; set; } // Falar mais sobre get e set
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Valid { get; set; }

        // Métodos
        public User()
        {

        }

    }
}