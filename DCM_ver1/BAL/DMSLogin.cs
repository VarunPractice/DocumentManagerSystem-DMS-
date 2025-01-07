using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL = DCM_ver1.DAL.DMSLogin;
using System.Windows;
namespace DCM_ver1.BAL
{
    public class DMSLogin:Window
    {
        DAL.DMSLogin _dal;
        public DMSLogin()
        {
            _dal = new DAL.DMSLogin();
        }
        public bool AuthenticateUser(string loginId, string loginPassword, SqlConnection connection)
        {
            return _dal.AuthenticateUser(loginId, loginPassword, connection);
        }
    }
}
