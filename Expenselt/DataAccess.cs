using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNet.SignalR.Infrastructure;

namespace Expenselt
{
    class DataAccess
    {
        public static List<PersonModel> GetPeople()
        {
            using (IDbConnection connection = new SqlConnection("Data Source=DESKTOP-EBUNPQL;Initial Catalog=ExpenseIt;Integrated Security=True"))
            {
                var output = connection.Query<PersonModel>("select * from [dbo].[ExpenseIt];").ToList();
                return output;
                
            }
        }
    }
}
