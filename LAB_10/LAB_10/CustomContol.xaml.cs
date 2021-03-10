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
    /// Логика взаимодействия для CustomContol.xaml
    /// </summary>
    public partial class CustomContol : UserControl
    {
        public CustomContol()
        {
            InitializeComponent();
        }

        public int MyData
        {
            get { return (int)GetValue(MyDataProperty); }
            set { SetValue(MyDataProperty, value); }
        }

        static FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata(
            new PropertyChangedCallback(ChangedCallbackMethod), new CoerceValueCallback(CoerceValueCallbackMethod));

        // Using a DependencyProperty as the backing store for MyData.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyDataProperty =
            DependencyProperty.Register("MyData", typeof(int), typeof(CustomContol), metadata, new ValidateValueCallback(ValidateValueCallbackMethod));
            
        static object CoerceValueCallbackMethod(DependencyObject d, object baseValue)
        {
            if ((int)baseValue <= 100)
                return baseValue;
            return 100;
        }

        static bool ValidateValueCallbackMethod(object value)
        {
            if ((int)value < 0)
                return false;
            return true;
        }

        static void ChangedCallbackMethod(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //Application.Current.MainWindow.Title = e.NewValue.ToString(); 
        }

    }
}
