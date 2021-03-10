using LAB_08.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB_08
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<TaskList> taskList = new ObservableCollection<TaskList>();
        TaskList currentTaskList = null;
        Task currentTask;
        //Task CurrentTask { get { return currentTask; } set { currentTask = value; } }

        public string g { get { return currentTask.Text; } }
        
        public MainWindow()
        {
            InitializeComponent();


            
            jsonFileDeserialization();
            gridLists.ItemsSource = taskList;


            priorityComboBox.ItemsSource = priorityChangeComboBox.ItemsSource = Enum.GetValues(typeof(Priority)).Cast<Priority>();
            repeatComboBox.ItemsSource = repeatChangeComboBox.ItemsSource = Enum.GetValues(typeof(Repeat)).Cast<Repeat>();
            

            
        }

        public void AddNewList(string listName)
        {
            if (String.IsNullOrEmpty(newListNameTextBox.Text)) { return; }

            taskList.Add(new TaskList(listName));
        }

        public void DeleteList()
        {
            taskList.Remove(currentTaskList);
            currentTaskList = null;
        }

        public void AddNewTask(Task task)
        {
            if (currentTaskList == null || String.IsNullOrEmpty(task.Text)) { return; }
            currentTaskList.Tasks.Add(task);
        }

        public void DeleteTask()
        {
            currentTaskList.Tasks.RemoveAt(gridTasks.SelectedIndex);
        }

        private void NewListButton_Click(object sender, RoutedEventArgs e)
        {
            AddNewList(newListNameTextBox.Text);
            newListNameTextBox.Text = "";
        }

        private void GridLists_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(e.AddedItems.Count == 0)
            {
                gridTasks.ItemsSource = null;
                listNameLabel.Content = "Create a new list";
                return;
            }
            currentTaskList = (e.AddedItems[0] as TaskList);
            gridTasks.ItemsSource = currentTaskList.Tasks;
            listNameLabel.Content = currentTaskList.ListName;
        }

        private void NewTaskButton_Click(object sender, RoutedEventArgs e)
        {
            Task newTask = new Task()
            {
                Text = newTaskNameTextBox.Text,
                Priority = (Priority)Enum.Parse(typeof(Priority), priorityComboBox.SelectedValue.ToString()),
                Repeat = (Repeat)Enum.Parse(typeof(Repeat), repeatComboBox.SelectedValue.ToString()),
                Date = newTaskDatePicker.SelectedDate
            };
            newTaskNameTextBox.Text = "";
            AddNewTask(newTask);
        }

        private void DeleteListMenuItem_Click(object sender, RoutedEventArgs e)
        {
            DeleteList();
        }

        private void DeleteTaskMenuItem_Click(object sender, RoutedEventArgs e)
        {
            DeleteTask();
        }

        private void HideListButton_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as ToggleButton).IsChecked == false)
            {
                DoubleAnimation doubleAnimationMenu = new DoubleAnimation(200, 35, new Duration(TimeSpan.FromSeconds(0.3)));
                DoubleAnimation doubleAnimationGridList = new DoubleAnimation(200, 0, new Duration(TimeSpan.FromSeconds(0.3)));
                DoubleAnimation doubleAnimationAddList = new DoubleAnimation(200, 0, new Duration(TimeSpan.FromSeconds(0.3)));
                DoubleAnimation doubleAnimationsearchDate = new DoubleAnimation(1, 0, new Duration(TimeSpan.FromSeconds(0.3)));
                gridLeft.BeginAnimation(WidthProperty, doubleAnimationMenu);
                gridLists.BeginAnimation(WidthProperty, doubleAnimationGridList);
                gridAddList.BeginAnimation(WidthProperty, doubleAnimationAddList);
                searchTaskDatePicker.BeginAnimation(OpacityProperty, doubleAnimationsearchDate);
            }
            else
            {
                DoubleAnimation doubleAnimationMenu = new DoubleAnimation(35, 200, new Duration(TimeSpan.FromSeconds(0.3)));
                DoubleAnimation doubleAnimationGridList = new DoubleAnimation(0, 200, new Duration(TimeSpan.FromSeconds(0.3)));
                DoubleAnimation doubleAnimationAddList = new DoubleAnimation(0, 200, new Duration(TimeSpan.FromSeconds(0.3)));
                DoubleAnimation doubleAnimationsearchDate = new DoubleAnimation(0, 1, new Duration(TimeSpan.FromSeconds(0.3)));
                gridLeft.BeginAnimation(WidthProperty, doubleAnimationMenu);
                gridLists.BeginAnimation(WidthProperty, doubleAnimationGridList);
                gridAddList.BeginAnimation(WidthProperty, doubleAnimationAddList);
                searchTaskDatePicker.BeginAnimation(OpacityProperty, doubleAnimationsearchDate);
            }
            
        }

        private void showTaskForm()
        {
            DoubleAnimation doubleAnimationTaskForm = new DoubleAnimation(0, 200, new Duration(TimeSpan.FromSeconds(0.3)));
            gridTaskEdit.BeginAnimation(WidthProperty, doubleAnimationTaskForm);
        }

        private void hideTaskForm()
        {
            DoubleAnimation doubleAnimationTaskForm = new DoubleAnimation(200, 0, new Duration(TimeSpan.FromSeconds(0.3)));
            gridTaskEdit.BeginAnimation(WidthProperty, doubleAnimationTaskForm);
        }

        private void GridTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(e.AddedItems.Count == 0)
            {
                hideTaskForm();
                currentTask = null;
                return;
            }
            else if (currentTask == null)
            {
                showTaskForm();
            }

            currentTask = (e.AddedItems[0] as Task);
            taskFormStackPanel.DataContext = currentTask;
            
        }

        private void changeLanguage(string lang)
        {
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri(String.Format("Resources/lang{0}.xaml", lang), UriKind.Relative);

            ResourceDictionary oldDict = (from d in Application.Current.Resources.MergedDictionaries
                                          where d.Source != null && d.Source.OriginalString.StartsWith("Resources/lang.")
                                          select d).First();
            if (oldDict != null)
            {
                int ind = Application.Current.Resources.MergedDictionaries.IndexOf(oldDict);
                Application.Current.Resources.MergedDictionaries.Remove(oldDict);
                Application.Current.Resources.MergedDictionaries.Insert(ind, dict);
            }
            else
            {
                Application.Current.Resources.MergedDictionaries.Add(dict);
            }
        }

        private void ChangeLanguageButton_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)(sender as ToggleButton).IsChecked)
            {
                changeLanguage(".ru-RU");
            }
            else
            {
                changeLanguage("");
            }
        }

        private void GridTasks_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                (sender as DataGrid).SelectedItem = null;
            }
        }

        public IEnumerable<Task> getDayTask(DateTime date)
        {
            return taskList.SelectMany(x => x.Tasks.Where(y => y.Date == date));
        }

        private void TodayButton_Click(object sender, RoutedEventArgs e)
        {
            gridLists.SelectedItem = null;
            listNameLabel.Content = (((sender as Button).Content as StackPanel).Children[1] as TextBlock).Text;
            gridTasks.ItemsSource = getDayTask(DateTime.Now.Date);
        }

        private void SelectedDateButton_Click(object sender, RoutedEventArgs e)
        {
            if (searchTaskDatePicker.SelectedDate == null) { return; }
            
            gridLists.SelectedItem = null;
            listNameLabel.Content = (((sender as Button).Content as StackPanel).Children[1] as TextBlock).Text;
            gridTasks.ItemsSource = getDayTask((DateTime)searchTaskDatePicker.SelectedDate);
        }

        private void jsonFileSerialization()
        {
            using (FileStream cout = new FileStream("data.json", FileMode.OpenOrCreate))
            {
                string data = JsonSerializer.Serialize<ObservableCollection<TaskList>>(taskList);
                byte[] bytes = Encoding.UTF8.GetBytes(data);
                cout.Write(bytes, 0, bytes.Length);
            }
        }

        private void jsonFileDeserialization()
        {
            using (FileStream cout = new FileStream("data.json", FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(cout))
                {
                    string data = reader.ReadToEnd();
                    taskList = JsonSerializer.Deserialize<ObservableCollection<TaskList>>(data);
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            jsonFileSerialization();
        }

    }
}
