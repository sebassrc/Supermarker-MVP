using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model
{
    internal class Categoriess
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public string Desc { get; set; }
        public char Envase { get; set; }

        public Categoriess(int? id, string name, string desc, char envase )
        {
            Id = id;
            Name = name;
            Desc = desc;
            Envase = envase;
        }
    }
}
