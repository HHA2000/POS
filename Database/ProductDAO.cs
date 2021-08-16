using Dapper;
using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class ProductDAO
    {
        DAO dao = new DAO();
        public List<Product> getProduct()
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.Query<Product>("select * from products").ToList();
            }
        }

        public List<Product> getProduct(int category_id)
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.Query<Product>("select * from products where category_id = @categoryid", new { categoryid = category_id }).ToList();
            }
        }

        public int addProduct(Product product)
        {
            using(dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.Execute(
                    "insert into products(name,quantity,price,category_id,image)" +
                    " values (@Name,@Quantity,@Price,@Category_ID,@Image);", product);
            }
        }

        public void updateProduct(Product product)
        {
            using(dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                dao.Connection.Execute(
                    "update products set name=@name, quantity=@quantity, price=@price, category_id = @category_id where id=@id;", product);
            }
        }

        public void deleteProduct(int id)
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                dao.Connection.Execute("delete from products where id = @id;", new { id = id });
            }
        }

        public void updateProductQuantity(int productid, int transactionid)
        {
            using(dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                dao.Connection.Execute("update products set quantity = quantity - (select quantity from productTransaction where id = @transactionid) " +
                    "where id = @productid;", new { productid = productid, transactionid = transactionid});
            }
        }
    }
}
