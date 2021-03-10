using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB_05.Classes;
using System.Windows.Forms;
using System.ComponentModel;

namespace LAB_05.Controllers
{
    static class InstanceManager
    {
        public static BindingList<Discipline> disciplines = new BindingList<Discipline>();

        public static void serializeInstance(string file)
        {
            XMLSerializator.Serialize<BindingList<Discipline>>(disciplines, file);
        }

        public static void deserializeInstanse(string file)
        {
            disciplines = XMLSerializator.Deserialize<BindingList<Discipline>>(file);
            
        }

        private static string getInfFromGroupBox(GroupBox box)
        {
            try
            {
                return box.Controls.OfType<RadioButton>().First(a => a.Checked).Text;
            }
            catch(Exception e)
            {
                return "";
            }
            
        }

        private static string getInfFromCheckedListBox(CheckedListBox box)
        {
            string result = "";
            foreach(int i in box.CheckedIndices)
            {
                
                result += Convert.ToString(i + 1);
            }
            return result;
        }

        public static Discipline createInstance(MaskedTextBox discipline, CheckedListBox semestr, GroupBox course,
            ComboBox speciality, NumericUpDown lectures, NumericUpDown labs, GroupBox controlType, TextBox lecturerName,
            TextBox pulpit, MaskedTextBox auditorium)
        {
            int param = 0;
            int.TryParse(getInfFromGroupBox(course), out param);
            Discipline result = new Discipline(discipline.Text, getInfFromCheckedListBox(semestr), param,
                speciality.Text, (int)lectures.Value, (int)labs.Value, getInfFromGroupBox(controlType), lecturerName.Text, pulpit.Text, auditorium.Text);
            //disciplines.Add(result);
            return result;
        }

        public static void addDiscipline(Discipline disc)
        {
            disciplines.Add(disc);
        }

        
    }
}
