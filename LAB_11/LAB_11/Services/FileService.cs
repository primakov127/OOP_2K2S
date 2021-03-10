using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_11.Services
{
    public sealed class FileService
    {
        public string GetFileName(string defaultExtension, string filter)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.DefaultExt = defaultExtension;
            fd.Filter = filter;
            
            bool? result = fd.ShowDialog();

            return result.Value ? fd.FileName : null;
        }
    }
}
