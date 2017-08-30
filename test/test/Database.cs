using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using test.Models;


namespace test
{
    public class Database
    {
        

        static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["BudgetManager"].ConnectionString);

        public static Transactions transactionsDB(Transactions trans)
        {
            

            try
            {
             
                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand("SELECT Category.[Name], Transactions.[Value], Transactions.[Date], Transactions.[Text]" + 
                   " FROM Category INNER JOIN Transactions ON  Category.ID = Transactions.FK_CatID", connection);
                connection.Open();
                dt.Load(command.ExecuteReader());

                foreach (DataRow row in dt.Rows)
                {
                   
                    trans.CatName = Convert.ToString(row["Name"]);
                    trans.TransValue = float.Parse(row["Value"].ToString());
                    trans.TransDateTime = Convert.ToDateTime("Date");
                    trans.TransText = Convert.ToString(row["Text"]);
                }


            }
            catch (Exception)
            {

                throw;
            }
            return trans;
        }
    }
}