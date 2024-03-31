using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCM_ver1.Models
{
    public class LoginModel
    {
        public string LoginID { get; set; }
        public string LoginName { get; set; } = string.Empty;
        public string LoginPassword { get; set; }
    }
}
