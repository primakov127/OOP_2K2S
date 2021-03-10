using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDAL.Abstract
{
    public class DAO
    {
        protected SqlConnection connection = null;
        protected string connectionString = null;

        public DAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public virtual void OpenConnection()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public virtual void CloseConnection()
        {
            connection.Close();
        }
    }
}
