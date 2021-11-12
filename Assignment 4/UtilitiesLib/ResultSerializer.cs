using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace UtilitiesLib
{
    public class ResultSerializer <T>
    {
     
        /// <summary>
        /// Serializing the T value to filename file as an Xml
        /// </summary>
        /// <param name="value"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        static public string serializeToXml(T value, string filepath)
        {
            if (value == null)
            {
                return string.Empty; 
            }
            try
            {
                var xmlSer = new XmlSerializer(typeof(T));
                var stringWriter = new StringWriter();
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    xmlSer.Serialize(writer, value);
                    writer.Flush();
                    return stringWriter.ToString();
                }

            }
            catch(Exception e)
            {
                throw new Exception("Error occured when saving the result to an xml file", e);
            }
        }

        /// <summary>
        /// This functions loads an object from the xml file
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>

        static public T importFromXml(string filename)
        {
            T t = default(T);
            var stream = File.OpenText(filename);
            using (stream)
            {
                var serializer = new XmlSerializer(typeof(T));
                t = (T)serializer.Deserialize(stream);
                return t;
            }
        }
    }
}
