using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB_05.Classes;
using LAB_05.Controllers;

namespace LAB_05
{
    public partial class Form1 : Form
    {
        Timer timer;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = InstanceManager.disciplines;
            InstanceManager.disciplines.ListChanged += data_Count;
            dataGridView1.DataSourceChanged += data_Count;

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
            
        }

        void data_Count(object sender, EventArgs e)
        {
            toolStripStatusLabelCount.Text = "Кол-во элементов: " + Convert.ToString(InstanceManager.disciplines.Count());
        }


        void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTime.Text = "Время: " + DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            dataGridView1.Update();
        }

        private void DisciplineValid(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(DisciplineName.Text))
            {
                errorProvider1.SetError(DisciplineName, "Не указано название!");
            }
            else if (DisciplineName.Text.Length < 4)
            {
                errorProvider1.SetError(DisciplineName, "Слишком короткое название!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void SemestrValid(object sender, CancelEventArgs e)
        {
            if (Semestr.CheckedItems.Count == 0) { errorProvider1.SetError(Semestr, "Не выбран семестр!"); }
        }

        private void CourseValid(object sender, CancelEventArgs e)
        {
            if (Course.Controls.OfType<RadioButton>().First(a => a.Checked) == null)
            {
                errorProvider1.SetError(Semestr, "Не выбран курс!");
            }
        }

        private void SpecialityValid(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Speciality.Text))
            {
                errorProvider1.SetError(Speciality, "Не выбрана специальность!");
            }
        }

        private void ControlTypeValid(object sender, CancelEventArgs e)
        {
            if (ControlType.Controls.OfType<RadioButton>().First(a => a.Checked) == null)
            {
                errorProvider1.SetError(ControlType, "Не выбран вид контроля!");
            }
            
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            toolStripStatusLabelLastAction.Text = "Последнее действие: " + (sender as Control).Text;
            Discipline dis = InstanceManager.createInstance(DisciplineName, Semestr, Course,
            Speciality, LecturesCount, LabsCount, ControlType, LecturerName, PulpitName, maskedTextBox2);

            var results = new List<ValidationResult>();
            var context = new ValidationContext(dis);

            if (!Validator.TryValidateObject(dis, context, results, true))
            {
                string err = "";
                foreach (var error in results)
                {
                    err += error.ErrorMessage + "\n";
                }
                MessageBox.Show(err);
            }
            else
                InstanceManager.addDiscipline(dis);

            

            //try
            //{
            //    InstanceManager.createInstance(DisciplineName, Semestr, Course,
            //Speciality, LecturesCount, LabsCount, ControlType, LecturerName, PulpitName, maskedTextBox2);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Неверные данные");
            //}
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                toolStripStatusLabelLastAction.Text = "Последнее действие: " + (sender as ToolStripMenuItem).Text;
            }
            
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            InstanceManager.deserializeInstanse(openFileDialog1.FileName);
            dataGridView1.DataSource = InstanceManager.disciplines;

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                toolStripStatusLabelLastAction.Text = "Последнее действие: " + (sender as ToolStripMenuItem).Text;
            }
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            InstanceManager.serializeInstance(saveFileDialog1.FileName);
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by primakov127");
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InstanceManager.disciplines.Count != 0)
            {
                Form2 searchingForm = new Form2(InstanceManager.disciplines.ToList());
                searchingForm.ShowDialog();
            }
            else
                MessageBox.Show("Отсутствую данные для поиска");

            toolStripStatusLabelLastAction.Text = "Последнее действие: " + (sender as ToolStripMenuItem).Text;
        }

        private void onLectCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InstanceManager.disciplines.Count != 0)
            {
                InstanceManager.disciplines = new BindingList<Discipline>(InstanceManager.disciplines.OrderByDescending(x => x.LecturesCount).ToList<Discipline>());
                dataGridView1.DataSource = InstanceManager.disciplines;
            }
            else
                MessageBox.Show("Отсутствую данные для сортировки");
        }

        private void onControlTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (InstanceManager.disciplines.Count != 0)
            {
                InstanceManager.disciplines = new BindingList<Discipline>(InstanceManager.disciplines.OrderByDescending(x => x.ControlType).ToList<Discipline>());
                dataGridView1.DataSource = InstanceManager.disciplines;
            }
            else
                MessageBox.Show("Отсутствую данные для сортировки");
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabelLastAction.Text = "Последнее действие: " + (sender as ToolStripMenuItem).Text;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ToolPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStrip1.Visible)
                toolStrip1.Visible = false;
            else
                toolStrip1.Visible = true;
        }
    }
}
