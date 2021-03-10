using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace LAB_10
{
    /// <summary>
    /// Логика взаимодействия для CustomButton.xaml
    /// </summary>
    public partial class CustomButton : UserControl
    {
        public CustomButton()
        {
            InitializeComponent();
        }

        private void BtnClickMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Outer Button");
        }

        private void InnerButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Inner Button");
        }

        private void BtnClickMe_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Outer Button double click");
        }

        private void InnerButton_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Inner Button double click");
        }
    }
}
