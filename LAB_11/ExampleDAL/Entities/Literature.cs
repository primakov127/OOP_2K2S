using ExampleDAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDAL.Entities
{
    public class Literature : CustomNotifyPropertyChanged
    {
        private int id;
        private string literatureName;
        private byte[] picture = null;
        private int disciplineId;

        public int Id
        {
            get => id;
            set => Set(ref id, value);
        }

        public string LiteratureName
        {
            get => literatureName;
            set => Set(ref literatureName, value);
        }

        public byte[] Picture
        {
            get => picture;
            set => Set(ref picture, value);
        }

        public int DisciplineId
        {
            get => disciplineId;
            set => Set(ref disciplineId, value);
        }
    }
}
