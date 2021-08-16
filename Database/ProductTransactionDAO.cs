using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class ProductTransactionDAO
    {
        DAO dao = new DAO();
        public int addTransaction(ProductTransaction productTransaction)
        {
            using(dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.ExecuteScalar<int>(
                    "insert into productTransaction(product_id,invoice_id,quantity,price)" +
                    " values (@productid, @invoiceid,@quantity,@price);select last_insert_rowid();", productTransaction);
            }
        }

        public List<ProductTransaction> GetProductTransactionsByInvoiceID(int invoice_id)
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.Query<ProductTransaction>(
                    "select p.name as productname, pt.quantity, pt.price from productTransaction as pt join products as p on p.id = pt.product_id" +
                    " where pt.invoice_id = @invoice_id;", 
                    new { invoice_id = invoice_id }).ToList();
            }
        }
    }
}
