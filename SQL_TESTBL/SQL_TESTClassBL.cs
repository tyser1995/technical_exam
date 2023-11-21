using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQL_TESTDAL;

namespace SQL_TESTBL
{
    public class SQL_TESTClassBL
    {
        SQL_TESTClassDAL sql_test_dal= new SQL_TESTClassDAL();

        public List<SearchProductByIDResult> GetSearchProductByIDResult(int prodID)
        {
            return sql_test_dal.GetSearchProductByIDResult(prodID).ToList();
        }
        public void AddTransactions(
            string ProdName,
            decimal Cost,
            int Qty)
        {
            sql_test_dal.AddTransactions(
                ProdName,
                Cost,
                Qty);
        }
    }
}
