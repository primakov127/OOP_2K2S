using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_05.Classes
{
    [Serializable]
    public class Lecturer
    {
        public string Name { get; set; }
        public string Pulpit { get; set; }
        public string AuditoriumNum { get; set; }

        public Lecturer() { }

        public Lecturer(string name, string pulpit, string auditorium)
        {
            Name = name;
            Pulpit = pulpit;
            AuditoriumNum = auditorium;
        }
    }
}
