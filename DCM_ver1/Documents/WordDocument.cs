using DCM_ver1.Interfaces;
using Microsoft.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCM_ver1.Documents
{
    public class WordDocument : IWriteOnlyDocuments
    {
        public WordDocument() { }

        public string DocPath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DocName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DocContent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Close(string path)
        {
            throw new NotImplementedException();
        }

        public void Create(string name, string path, string type)
        {
            throw new NotImplementedException();
        }

        public void EditDoc(string DocPath)
        {
            throw new NotImplementedException();
        }

        public void Open(string path, string type)
        {
            throw new NotImplementedException();
        }

        public void Print(string path, string content)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDoc(string content)
        {
            throw new NotImplementedException();
        }

        public void Watermark(string text)
        {
            throw new NotImplementedException();
        }
    }
}
