using GalaSoft.MvvmLight;
using Microsoft.VisualStudio.PlatformUI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models = DCM_ver1.Models.LoginModel;
using DB = DCM_ver1.SQLConnection.DMSConnection;
using BAL = DCM_ver1.BAL.DMSLogin;
namespace DCM_ver1.ViewModels
{
    public class LoginViewModel: ViewModelBase
    {
        #region Properties
        public string LoginName { get; set; } = string.Empty;
        public string LoginPassword { get; set; }
        #endregion
        #region Declaration
        BAL.DMSLogin _bal;// new DCM_ver1.BAL.DMSLogin();

        Models.LoginModel LoginModel { get; set; } = new Models.LoginModel();
        public DelegateCommand LoginCommand { get; private set; }

        #endregion
        #region Constroctor
        public LoginViewModel() 
        {
            _bal = new DCM_ver1.BAL.DMSLogin();
            LoginCommand = new DelegateCommand(GetLogin);
         
        }

         
        #endregion
        #region Methods

        

         

        public void GetLogin()
        {
            bool _isSuccessful = _bal.AuthenticateUser(LoginName, LoginPassword, DB.GetInstance.GetDBMConnection(ConfigurationManager.ConnectionStrings["DMSConnectionString"].ConnectionString));

            if (_isSuccessful)
            {
               MainWindow main = new MainWindow();
                main.Show();
            }
        }
        #endregion

    }
}