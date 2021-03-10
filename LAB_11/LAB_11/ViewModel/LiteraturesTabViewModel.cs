using ExampleConnectedLayer;
using ExampleDAL.Abstract;
using ExampleDAL.Entities;
using LAB_11.Services;
using LAB_11.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_11.ViewModel
{
    public class LiteraturesTabViewModel : CustomNotifyPropertyChanged
    {
        private ObservableCollection<Literature> literatures;
        private Literature selectedLiterature;
        private LiteratureDAL db;
        private DisciplineDAL dis;
        private ObservableCollection<int> disciplines;

        public LiteraturesTabViewModel(LiteratureDAL db, DisciplineDAL dis)
        {
            this.db = db;
            this.dis = dis;
            UpdateDataGrid(null);

            OpenFileCommand = new Command(OpenFile, x => true);
            UpdateDataGridCommand = new Command(UpdateDataGrid, x => true);
            AddLiteratureCommand = new Command(AddLiterature, x => !String.IsNullOrEmpty(SelectedLiterature.LiteratureName) && SelectedLiterature.DisciplineId != 0 && SelectedLiterature.Picture != null);
            UpdateLiteratureCommand = new Command(UpdateLiterature, x => SelectedLiterature.Id != 0);
            DeleteLiteratureCommand = new Command(DeleteLiterature, x => SelectedLiterature.Id != 0);
        }


        public Command OpenFileCommand { get; set; }
        public Command UpdateDataGridCommand { get; set; }
        public Command AddLiteratureCommand { get; set; }
        public Command UpdateLiteratureCommand { get; set; }
        public Command DeleteLiteratureCommand { get; set; }


        public ObservableCollection<Literature> Literatures
        {
            get => literatures;
            set => Set(ref literatures, value);
        }

        public Literature SelectedLiterature
        {
            get => selectedLiterature;
            set => Set(ref selectedLiterature, value);
        }

        public ObservableCollection<int> Disciplines
        {
            get => disciplines;
            set => Set(ref disciplines, value);
        }


        private void AddLiterature(object param)
        {
            db.OpenConnection();
            db.CreateLiterature(selectedLiterature);
            db.CloseConnection();
            UpdateDataGrid(null);
        }

        private void UpdateLiterature(object param)
        {
            db.OpenConnection();
            db.UpdateLiterature(selectedLiterature);
            db.CloseConnection();
            UpdateDataGrid(null);
        }

        private void DeleteLiterature(object param)
        {
            db.OpenConnection();
            db.DeleteLiterature(selectedLiterature.Id);
            db.CloseConnection();
            UpdateDataGrid(null);
        }

        private void UpdateComboBox()
        {
            dis.OpenConnection();
            Disciplines = new ObservableCollection<int>(dis.GetAllDisciplines().Select(x => x.Id));
            dis.CloseConnection();
        }

        private void UpdateDataGrid(object param)
        {
            db.OpenConnection();
            Literatures = new ObservableCollection<Literature>(db.GetAllLiteratures());
            db.CloseConnection();
            SelectedLiterature = new Literature();
            UpdateComboBox();
        }

        private void OpenFile(object param)
        {
            FileService fileService = new FileService();
            string filePath = fileService.GetFileName("*.jpg|*.jpeg|*.png", "Image files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png");
            if (!String.IsNullOrEmpty(filePath))
                SelectedLiterature.Picture = GetPhoto(filePath);
        }

        private byte[] GetPhoto(string filePath)
        {
            FileStream stream = new FileStream(
                filePath, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(stream);

            byte[] photo = reader.ReadBytes((int)stream.Length);

            reader.Close();
            stream.Close();

            return photo;
        }
    }
}
