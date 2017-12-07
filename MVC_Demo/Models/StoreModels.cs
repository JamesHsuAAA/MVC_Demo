using MVC_Demo.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Dapper;
using System.Data.SqlClient;

namespace MVC_Demo.Models
{
    public class StoreModels : IStoreModels<Store>
    {
        public List<Store> GetList()
        {
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Drama"].ConnectionString))
            {
                List<Store> stores = conn.Query<Store>("select * from Store").ToList();

                return stores;
            }
        }
    }
}