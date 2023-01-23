using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace DXApplication1
{
    public class DataAccess
    {
        public  List<TenorService> GetAllData()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("SampleDB")))
            {
                var output = connection.Query<TenorService>($"select * from TenorPanel").ToList();
                return output;
            }
        }
    }
}
