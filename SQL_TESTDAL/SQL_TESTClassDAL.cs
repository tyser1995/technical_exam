using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_TESTDAL
{
    public class SQL_TESTClassDAL
    {
        SQL_TESTDataClassDataContext sql_test = new SQL_TESTDataClassDataContext();

        public List<SearchProductByIDResult> GetSearchProductByIDResult(int prodID)
        {
            return sql_test.SearchProductByID(prodID).ToList();
        }
        public void AddTransactions(
            string ProdName,
            decimal Cost,
            int Qty)
        {
           sql_test.AddTransactions(
               ProdName, 
               Cost,
               Qty);
        }
    }
}
