using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class InvoiceDAO
    {
        DAO dao = new DAO();
        public int createInvoice()
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.ExecuteScalar<int>("insert into invoices(id) values(null);select last_insert_rowid();");
            }
        }

        public void addInvoice(int invoice_id, int total_price)
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                dao.Connection.Execute(
                    "update invoices set datetime = datetime('now'), total_price = @totalprice where id = @invoiceid;",
                    new { invoiceid = invoice_id, totalprice = total_price });
            }
        }

        public invoice getInvoicebyID(int id)
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.QueryFirst<invoice>("select total_price, date(datetime) as datetime from invoices where id = @id", new { id = id });
            }
        }
    }
}
