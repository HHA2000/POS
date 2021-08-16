using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class UserDAO
    {
        DAO dao = new DAO();
        public User getApproveUser(User user)
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.QuerySingle<User>(
                   "select * from users where username = @username and password = @password and isApprove = 1;",
                    new { username = user.Username, password = user.Password });
            }
        }

        public List<User> getEmployee()
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.Query<User>("select id, username, type from users where isApprove = 1;").ToList();
            }
        }

        public List<User> getNotApproveUsers()
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.Query<User>(
                   "select * from users where isApprove = 0").ToList();
            }
        }

        public void addUser(User user)
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                dao.Connection.Execute(
                    "insert into users (username, password, type, isApprove) values (@username, @password, @type, 0);", 
                    new { username = user.Username, password = user.Password, type = user.Type });
            }
        }

        public void deleteUser(int id)
        {
            using(dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                dao.Connection.Execute("delete from users where id = @id", new { id });
            }
        }

        public bool existUsername(string username)
        {
            using(dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.ExecuteScalar<bool>("select * from users where username = @username", new { username = username });
            }
        }

        public bool checkUsernameAndPassword(User user)

        {
            using(dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                return dao.Connection.ExecuteScalar<bool>(
                    "select id, username as Name, password, type from users" +
                    " where username=@username and password = @password and isApprove = 1;",
                    new { username = user.Username, password = user.Password });
            }
        }

        public void approveUser(int id)
        {
            using (dao.Connection = new SQLiteConnection(dao.getConnectionString()))
            {
                dao.Connection.Execute("update users set isApprove = 1 where id = @id;", new { id });
            }
        }
    }
}
