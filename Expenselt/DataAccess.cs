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
    public class DataAccess
    {
        public static List<PersonModel> GetPeople()
        {
            string connectionString = @"Data Source=DESKTOP-EBUNPQL;Initial Catalog=ExpenseIt2;Integrated Security=True";
            SqlConnection db = new SqlConnection(connectionString);
            List<PersonModel> output = db.Query<PersonModel>("Select * from [ExpenseIt2].[dbo].[ExpenseIt2table]").ToList();
            //  output e numele variabilei careia ii dau return 
            return output;
        }
     /*   public static DataSet GetExpenses()
        {
            string connectionString = @"Data Source=DESKTOP-EBUNPQL;Initial Catalog=ExpenseIt2;Integrated Security=True";
            SqlConnection db = new SqlConnection(connectionString);
            DataSet output = db.Query 
        }
        */
       

        public static DataSet GetExpenses()
        {
            string connectionString = @"Data Source=DESKTOP-EBUNPQL;Initial Catalog=ExpenseIt2;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("Select ExpenseType, ExpenseAmount, id, from [ExpenseIt2].[dbo].[ExpenseIt2table] " +
                "where id=@index", con);
            var index = cmd.Parameters.AddWithValue("@index", PersonModel.id );
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            var dt = new DataSet();
            ad.Fill(dt);
            return dt;
        }
        
    }
}
