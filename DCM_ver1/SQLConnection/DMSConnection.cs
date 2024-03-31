using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DCM_ver1.SQLConnection
{
  public  sealed class DMSConnection
    {
        private  SqlConnection _connection = null;
        private DMSConnection() { }

        private static DMSConnection _instance;

        public static DMSConnection GetInstance
        {
            get { 
            if(_instance == null) return new DMSConnection();
            return _instance;
            }
        }

        public SqlConnection GetDBMConnection(string connectionStr)
        {
            _connection = new SqlConnection(connectionStr);

            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
            return _connection;
        }

    }
}
