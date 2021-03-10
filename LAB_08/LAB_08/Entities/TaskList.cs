using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_08.Entities
{
    public class TaskList
    {
        public TaskList()
        {
            
        }

        public TaskList(string nameParam)
        {
            this.ListName = nameParam;
            this.Tasks = new ObservableCollection<Task>();
        }

        public string ListName { get; set; }
        public ObservableCollection<Task> Tasks { get; set; }
    }
}
