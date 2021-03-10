using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_08.Entities
{
    public enum Repeat
    {
        None = 1,
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    public enum Priority
    {
        Highest = 1,
        Normal,
        Lowest
    }

    public class Task
    {
        public Task()
        {
            this.Description = "";
            this.IsCompleted = false;
        }

        public string Text { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public Repeat? Repeat { get; set; }
        public Priority? Priority { get; set; }
        public bool IsCompleted { get; set; }
    }
}
