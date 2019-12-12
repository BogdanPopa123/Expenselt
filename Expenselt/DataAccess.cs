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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection("Data Source=DESKTOP-EBUNPQL;Initial Catalog=ExpenseIt2;Integrated Security=True"))
            {
                var output = connection.Query<PersonModel>("select * from [dbo].[ExpenseIt2table];").ToList();
                return output;
            }
        }
    }
}
