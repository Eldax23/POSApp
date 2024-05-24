﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApp.DB.Entites
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public string Phone { get; set; }
        public string Company{ get; set; }
        public string Email { get; set; }
        public bool? isActive { get; set; }
        public string Image { get; set; }
        
    }
}
