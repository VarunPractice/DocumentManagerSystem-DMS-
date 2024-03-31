using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DCM_ver1.DAL
{
    public class DMSLogin
    {
        public DMSLogin()
        {
                
        }
        public bool AuthenticateUser(string loginId, string loginPassword, SqlConnection connection)
        {
                using (var command = new SqlCommand("spAuthenticateUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LoginID", loginId);
                    command.Parameters.AddWithValue("@LoginPassword", loginPassword);

                    var result = (int)command.ExecuteScalar();
                    return result == 1;
                }
        }

    }
}
