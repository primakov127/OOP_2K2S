using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace LAB_11.Services
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            BitmapImage img = new BitmapImage();

            using (MemoryStream stream = new MemoryStream(value as byte[]))
            {
                img.BeginInit();
                img.StreamSource = stream;
                img.CacheOption = BitmapCacheOption.OnLoad;
                img.EndInit();
            }
            
            return img;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                (value as BitmapImage).StreamSource.CopyTo(stream);
                return stream.ToArray();
            }
        }
    }
}
