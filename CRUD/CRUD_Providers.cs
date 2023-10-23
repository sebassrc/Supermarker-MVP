using Supermarket.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Business
{
    internal class CRUD_Providers
    {
        private readonly Dictionary<int, Providerss> ProvidersList;
        private static int ProviderSecuencial;

        public CRUD_Providers()
        {
            ProvidersList = new Dictionary<int, Providerss>();
            ProviderSecuencial = 0;
        }

        public bool Addproviders(Providerss providers)
        {
            try
            {
                providers.Id = ++ProviderSecuencial;
                ProvidersList.Add((int)providers.Id, providers);
            }
            catch (ArgumentException)
            {
                return false;
            }
            return true;
        } 

        public bool RemoveProviders(int id)
        {
            bool idExists = ProvidersList.ContainsKey(id);
            if (idExists)
            {
                ProvidersList.Remove(id);
                return true;
            }
            return false;
        } 


        public Providerss? GetProviders(int id)
        {

            bool idExists = ProvidersList.ContainsKey(id);
            if (idExists)
            {
                Providerss providers = ProvidersList[id];
                return providers;
            }
            return null;
        } 

        public bool UpdateProviders(int id, Providerss providers)
        {
            bool idExists = ProvidersList.ContainsKey(id);
            if (idExists)
            {
                try
                {
                    ProvidersList[id] = providers;
                    return true;
                }
                catch (KeyNotFoundException)
                {
                    return false;
                }
            }
            return false;

        } 
        public Dictionary<int, Providerss> GetProviders()
        {
            return ProvidersList;
        }

    }
}
