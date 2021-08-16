using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS
{
    class DAO
    {
        private IDbConnection con;

        public DAO()
        {
            
        }

        public IDbConnection Connection
        {
            get { return con; }
            set { con = value; }
        }

        public string getConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }

    }
}
