using ExampleConnectedLayer;
using ExampleDAL.Entities;
using LAB_11.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB_11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            string clientsConnectionString = ConfigurationManager.ConnectionStrings["clients"].ConnectionString;

            DisciplineTab.DataContext = new DisciplinesTabViewModel(new DisciplineDAL(connectionString));
            LiteratureTab.DataContext = new LiteraturesTabViewModel(new LiteratureDAL(connectionString), new DisciplineDAL(connectionString));
            

        }
    }
}
