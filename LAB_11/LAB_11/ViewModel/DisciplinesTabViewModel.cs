using ExampleConnectedLayer;
using ExampleDAL.Abstract;
using ExampleDAL.Entities;
using LAB_11.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_11.ViewModel
{
    public class DisciplinesTabViewModel : CustomNotifyPropertyChanged
    {
        private ObservableCollection<Discipline> disciplines;
        private Discipline selectedDiscipline;
        private DisciplineDAL db;
        private int page = 1;

        public DisciplinesTabViewModel(DisciplineDAL db)
        {
            this.db = db;
            UpdateDataGrid(null);

            UpdateDisciplineCommand = new Command(UpdateDiscipline, x => SelectedDiscipline.Id != 0);
            AddDisciplineCommand = new Command(AddDiscipline, x => !String.IsNullOrEmpty(SelectedDiscipline.DisciplineName) && SelectedDiscipline.Course != 0);
            DeleteDisciplineCommand = new Command(DeleteDiscipline, x => SelectedDiscipline.Id != 0);
            UpdateDataGridCommand = new Command(UpdateDataGrid, x => true);
            NextPageCommand = new Command(NextPage, x => true);
            PrevPageCommand = new Command(PrevPage, x => true);
        }

        public Command UpdateDisciplineCommand { get; set; }
        public Command AddDisciplineCommand { get; set; }
        public Command DeleteDisciplineCommand { get; set; }
        public Command UpdateDataGridCommand { get; set; }
        public Command NextPageCommand { get; set; }
        public Command PrevPageCommand { get; set; }

        public int[] ComboBoxCourse { get; } = { 1, 2, 3, 4 };

        public ObservableCollection<Discipline> Disciplines
        {
            get => disciplines;
            set => Set(ref disciplines, value);
        }

        public Discipline SelectedDiscipline
        {
            get => selectedDiscipline;
            set => Set(ref selectedDiscipline, value);
        }

        public int Page
        {
            get => page;
            set
            {
                if (value > 0)
                {
                    page = value;
                    UpdateDataGrid(null);
                }
            }
        }


        private void UpdateDiscipline(object param)
        {
            db.OpenConnection();
            db.UpdateDiscipline(selectedDiscipline);
            db.CloseConnection();
            UpdateDataGrid(null);
        }

        private void UpdateDataGrid(object param)
        {
            db.OpenConnection();
            Disciplines = new ObservableCollection<Discipline>(db.GetAllDisciplines(page));
            db.CloseConnection();
            SelectedDiscipline = new Discipline();
        }

        private void AddDiscipline(object param)
        {
            db.OpenConnection();
            db.CreateDiscipline(selectedDiscipline);
            db.CloseConnection();
            UpdateDataGrid(null);
        }

        private void DeleteDiscipline(object param)
        {
            db.OpenConnection();
            db.DeleteDiscipline(selectedDiscipline.Id);
            db.CloseConnection();
            UpdateDataGrid(null);
        }

        private void NextPage(object param)
        {
            Page += 1;
        }

        private void PrevPage(object param)
        {
            Page -= 1;
        }
    }
}
