using Supermarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Business
{
    internal class CRUD_Categories
    {
        private readonly Dictionary<int, Categoriess> CategoriesList;
        private static int CategorieSecuencial;

        public CRUD_Categories()
        {
            CategoriesList = new Dictionary<int, Categoriess>();
            CategorieSecuencial = 0;
        }


        public bool AddCategories(Categoriess categories)
        {
            try
            {
                categories.Id = ++CategorieSecuencial;
                CategoriesList.Add((int)categories.Id, categories);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        } 

        public bool RemoveCategories(int id)
        {
            bool idExists = CategoriesList.ContainsKey(id);
            if (idExists)
            {
                CategoriesList.Remove(id);
                return true;
            }
            return false;
        } 
        public Categoriess? GetCategories(int id)
        {

            bool idExists = CategoriesList.ContainsKey(id);
            if (idExists)
            {
                Categoriess categories = CategoriesList[id];
                return categories;
            }
            return null;
        } 


        public bool UpdateCategories(int id, Categoriess categories)
        {
            bool idExists = CategoriesList.ContainsKey(id);
            if (idExists)
            {
                try
                {
                    CategoriesList[id] = categories;
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }
            return false;

        } 


        public Dictionary<int, Categoriess> GetCategories()
        {
            return CategoriesList;
        }



    }
}
