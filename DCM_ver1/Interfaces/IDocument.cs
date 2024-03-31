using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCM_ver1.Interfaces
{
    public interface IDocument
    {
        void Create(string name, string path, string type);
        void Open(string path, string type);
        void Close(string path);
        void Print(string path, string content);

        string DocPath { get; set; }
        string DocName { get; set; }
        string DocContent { get; set; }
    }
}
