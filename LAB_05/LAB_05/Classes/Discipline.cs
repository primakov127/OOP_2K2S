using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LAB_05.Classes
{
    [Serializable]
    public class Discipline
    {
        [Required(ErrorMessage = "Введите название дисциплины")]
        public string Name { get; set; }
        [Semester]
        public string Semester { get; set; }
        [Range(1,4, ErrorMessage = "Выберите курс")]
        public int Course { get; set; }
        [Required(ErrorMessage = "Выберите специальность")]
        public string Speciality { get; set; }
        [Range(1,99,ErrorMessage = "Введите количество лекций")]
        public int LecturesCount { get; set; }
        [Range(1, 99, ErrorMessage = "Введите количество лабораторных")]
        public int LabsCount { get; set; }
        [Required(ErrorMessage = "Выберите тип контроля")]
        public string ControlType { get; set; }
        public Lecturer Lecturer;
        [Required(ErrorMessage = "Введите ФИО лектора")]
        [RegularExpression(@"[A-ZА-Я]{1}[a-zа-я]+\s[A-ZА-Я]{1}[a-zа-я]+\s[A-ZА-Я]{1}[a-zа-я]+", ErrorMessage = "Некоректный ввод ФИО")]
        public string LecturerName
        {
            get
            {
                return Lecturer.Name;
            }
        }
        [Required(ErrorMessage = "Введите название кафедры")]
        public string PulpitName
        {
            get
            {
                return Lecturer.Pulpit;
            }
        }
        [Required(ErrorMessage = "Введите номер аудитории")]
        public string AuditoriumNum
        {
            get
            {
                return Lecturer.AuditoriumNum;
            }
        }
        
        
        public Discipline()
        {

        }

        public Discipline(string name, string semester, int course, string speciality, int lecturesCount, int labsCount, string controlType,
            string lecturerName, string pulpitName, string auditorium)
        {
            Name = name;
            Semester = semester;
            Course = course;
            Speciality = speciality;
            LecturesCount = lecturesCount;
            LabsCount = labsCount;
            ControlType = controlType;
            Lecturer = new Lecturer(lecturerName, pulpitName, auditorium);
        }

        public override string ToString()
        {
            return $"Название дисциплины:{Name} | Семестр:{Semester} | Курс:{Course} | Специальность:{Speciality} | Кол-во лекций:{LecturesCount}" +
                $" | Кол-во лаб:{LabsCount} | Тип контроля:{ControlType} | Имя лектора:{LecturerName} | Кафедра:{PulpitName} | Аудитория:{AuditoriumNum}";
        }
    }
}
