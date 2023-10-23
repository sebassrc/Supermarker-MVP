using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model
{
    internal class Productt
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }

        public Productt(int? id, string name, int price, int stock, string category)
        {
            Id = id;           
            Name = name;
            Price = price;
            Stock = stock;
            Category = category;
        }
    }
}
