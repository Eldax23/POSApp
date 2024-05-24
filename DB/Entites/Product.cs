﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSApp.DB.Entites
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }

        public string Notes { get; set; }
        public string Image { get ; set; }  

    }
}