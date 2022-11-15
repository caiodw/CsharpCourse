﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDados
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }

        public Beer(int id, string name, int brandId)
        {
            Id = id;
            Name = name;
            BrandId = brandId;
        }

        public Beer( string name, int brandId)
        {
            Name = name;
            BrandId = brandId;
        }
    }
}
