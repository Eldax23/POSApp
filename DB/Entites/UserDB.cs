using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApp.DB.Entites
{
    public class UserDB
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? Image { get; set; }
    }
}
