using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace UzEx.TMQ.Helpers
{
    public static class IOHelper
    {

        public static string XmlEncode<T>(T t)
        {
            var s = new StringBuilder();

            try
            {
                var serializer = new XmlSerializer(t.GetType());
                var writer = new StringWriter(s);

                serializer.Serialize(writer, t);
            }
            catch (Exception)
            {
                //TODO:
            }

            return s.ToString();
        }

        public static T XmlDecode<T>(string s)
        {

            var t = default(T);

            try
            {
                var doc = new XmlDocument();
                doc.LoadXml(s);

                var reader = new XmlNodeReader(doc.DocumentElement);
                var serializer = new XmlSerializer(typeof(T));
                var employeeData = serializer.Deserialize(reader);

                t = (T)employeeData; 
            }
            catch (Exception)
            {
                //TODO:
            }

            return t;
        }
    }
}