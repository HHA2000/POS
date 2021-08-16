using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class SaleDAO
    {
        DAO dao = new DAO();
        public int getTodaySaleCount()
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.Query("select * from invoices where date(datetime) = date('now');").Count();
            }
        }

        public int getTodaySale()
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.QuerySingle<int>("select sum(total_price) from invoices where date(datetime) = date('now');");
            }
        }

        public int getSalebyDate(string date)
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.QuerySingle<int>("select sum(total_price) from invoices where date(datetime) = @date;", new { date = date });
            }
        }

        public List<Sale> getSaleDetail(string date)
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.Query<Sale>(
                    "select products.name, sum(productTransaction.quantity) as Quantity, sum(productTransaction.price) as Price from invoices" +
                    " join productTransaction on productTransaction.invoice_id = invoices.id" +
                    " join products on products.id = productTransaction.product_id" +
                    " where date(invoices.datetime) = @date group by products.id;", new { date = date }).ToList();
            }
        }
    }
}
