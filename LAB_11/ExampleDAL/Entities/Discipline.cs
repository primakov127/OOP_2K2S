using ExampleDAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDAL.Entities
{
    public class Discipline : CustomNotifyPropertyChanged
    {
        private int id;
        private string disciplineName;
        private int course;

        public int Id
        {
            get => id;
            set => Set(ref id, value);
        }

        public string DisciplineName
        {
            get => disciplineName;
            set => Set(ref disciplineName, value);
        }

        public int Course
        {
            get => course;
            set => Set(ref course, value);
        }
    }
}
