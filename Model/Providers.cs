﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model
{
    internal class Providerss
    {
        public int? Id { get; set; }
        public string Providers { get; set; }

        public Providerss(int? id, string name)
        {
            Id = id;
            Providers = name;


        }
    }
}
