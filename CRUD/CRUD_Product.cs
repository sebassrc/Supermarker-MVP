using Supermarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Business
{
        internal class CRUD_Product
        {
            private readonly Dictionary<int, Productt> ProductList;
            private static int productSecuencial;

            public CRUD_Product()
            {
                ProductList = new Dictionary<int, Productt>();
                productSecuencial = 0;
            }

            public bool AddProduct(Productt product)
            {
                try
                {
                    product.Id = ++productSecuencial;
                    ProductList.Add((int)product.Id, product);
                }
                catch (ArgumentException)
                {
                    return false;
                }
                return true;
            }

            public bool RemoveProduct(int id)
            {
                bool idExists = ProductList.ContainsKey(id);
                if (idExists)
                {
                    ProductList.Remove(id);
                    return true;
                }
                return false;
            }

            public Productt? GetProduct(int id)
            {
                bool idExists = ProductList.ContainsKey(id);
                if (idExists)
                {
                    Productt product = ProductList[id];
                    return product;
                }
                return null;
            }

            public bool UpdateProduct(int id, Productt product)
            {
                bool idExists = ProductList.ContainsKey(id);
                if (idExists)
                {
                    try
                    {
                        ProductList[id] = product;
                        return true;
                    }
                    catch (KeyNotFoundException)
                    {
                        return false;
                    }
                }
                return false;
            }

            public Dictionary<int, Productt> GetProduct()
            {
                return ProductList;
            }
       

    }
    
}
