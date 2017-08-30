using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Transactions
    {
        public int TransID { get; set; }
        public float TransValue { get; set; }
        public DateTime TransDateTime { get; set; }
        public string TransText { get; set; }
        public int Trans_FK_CatID { get; set; }

        public int CatID { get; set; }
        public string CatName { get; set; }
        public int Cat_FK_CatID { get; set; }
        
    }
}