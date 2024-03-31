using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCM_ver1.Interfaces
{
    internal interface IWriteOnlyDocuments: IReadOnlyDocuments
    {
        void EditDoc(string DocPath);
        bool UpdateDoc(string content);
    }
}
