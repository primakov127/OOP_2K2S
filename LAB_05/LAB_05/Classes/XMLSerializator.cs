﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LAB_05.Classes
{
    static class XMLSerializator
    {
        public static void Serialize<T>(T obj, string filename)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate)) { formatter.Serialize(fs, obj); }
        }

        public static T Deserialize<T>(string filename)
        {
            T obj; using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate)) { XmlSerializer formatter = new XmlSerializer(typeof(T)); obj = (T)formatter.Deserialize(fs); }

            return obj;
        }
    }
}
