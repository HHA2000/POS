using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class CategoryDAO
    {
        DAO dao = new DAO();
        public List<Category> getCategories()
        {
            using(dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.Query<Category>("select * from categories").ToList();
            }
        }

        public Category getCategoryByID(int id)
        {
            using(dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.QueryFirst<Category>("select * from categories where id = @id", new { id = id });
            }
        }

        public int addCategory(Category category)
        {
            using(dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.Execute("insert into categories(name) values (@Name);", category);
            }
        }
    }
}
