using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Configuration;


namespace test
{
    public class Database
    {
        static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BudgetManager"].ConnectionString);

        public static DBTransactions()
        {

            try
            {
                trans
                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand("SELECT Category.[Name], Transactions.[Value], Transactions.[Date], Transactions.[Text]" + 
                   " FROM Category INNER JOIN Transactions ON  Category.ID = Transactions.FK_CatID", connection);
                connection.Open();
                dt.Load(command.ExecuteReader());

                foreach (DataRow row in dt.Rows)
                {
                    in Name = int.Parse(row["ID"].ToString());
                    string tempString = Convert.ToString(row["Name"]);
                    
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}