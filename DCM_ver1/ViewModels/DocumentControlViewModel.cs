using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using DCM_ver1.Models;
using System;
using Microsoft.Win32;

namespace DCM_ver1.ViewModels
{
    public class DocumentControlViewModel : ViewModelBase
    {
        private DocumentControlModel _documentModel;

        public string DocumentPath
        {
            get => _documentModel.DocumentPath;
            set
            {
                if (_documentModel.DocumentPath != value)
                {
                    _documentModel.DocumentPath = value;
                    RaisePropertyChanged(nameof(DocumentPath));
                }
            }
        }

        public RelayCommand CreateCommand { get; private set; }
        public RelayCommand OpenCommand { get; private set; }
        public RelayCommand EditCommand { get; private set; }
        public RelayCommand DeleteCommand { get; private set; }
        public RelayCommand UploadCommand { get; private set; }

        public DocumentControlViewModel()
        {
            _documentModel = new DocumentControlModel();

            CreateCommand = new RelayCommand(CreateDocument);
            OpenCommand = new RelayCommand(OpenDocument);
            EditCommand = new RelayCommand(EditDocument);
            UploadCommand = new RelayCommand(UploadPath);
            DeleteCommand = new RelayCommand(DeleteDocument);
        }
        private string _selectedDocType;

        public string SelectedDocType
        {
            get => _selectedDocType;
            set => Set(ref _selectedDocType, value);
        }
        private void UploadPath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Office Files|*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx|" +
                  "Word Documents|*.doc;*.docx|" +
                  "Excel Worksheets|*.xls;*.xlsx|" +
                  "PowerPoint Presentations|*.ppt;*.pptx|" +
                  "All Files|*.*"
            };

            bool? result = openFileDialog.ShowDialog();
            if (result == true)
            {
                DocumentPath = openFileDialog.FileName;
              
            }
        }
   

        private void CreateDocument()
        {
            string[] _split = _selectedDocType.Split(':');
            switch (_split[1].Trim())
            {
                case "Word":
                    System.Windows.Forms.MessageBox.Show(_split[1].Trim() + "is created");
                    break;
                case "Excel":
                    System.Windows.Forms.MessageBox.Show(_split[1].Trim() + "is created");

                    // Logic to create an Excel document
                    break;
                case "PowerPoint":
                    System.Windows.Forms.MessageBox.Show(_split[1].Trim() + "is created"); break;
                default:
                    System.Windows.Forms.MessageBox.Show(_split[1].Trim() + "is created");

                    break;
                    
            }
        }


        private void OpenDocument()
        {
            // Logic to open a document
        }

        private void EditDocument()
        {
            // Logic to edit a document
        }

        private void DeleteDocument()
        {
            // Logic to delete a document
        }
    }
}
