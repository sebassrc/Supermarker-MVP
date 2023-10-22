using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface IPayModeRepository
    {
        string connectionString { get; set; }

        void add(PayModeModel payModeModel);
        void Delete(int id);
        void Edit(PayModeModel payModeModel);

        IEnumerable<PayModeModel> GetAll();
        IEnumerable<PayModeModel> GetByValue(string value);
    }
}
