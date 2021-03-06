using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization; 

namespace Real_Estate_Agent.Program.Main
{
    
    /// <summary>
    /// This class includes two methods, serializing the estate object and transmitting it to a binary format in a file, 
    /// and deserializing an estate object from a file and coverting to an estate object. 
    /// 
    /// 
    /// It is implemented as a generic class and can be used for any object serialization and deserialization. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class EstateSerializer<T>
    {
        
        /// <summary>
        /// This function transmits the object to binary format 
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="filePath"></param>
        static public void BinarySerialize(T obj, string filePath)
        {
            FileStream fileStream = File.Create(filePath);

            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(filePath))
            {

                File.Delete(filePath);
            }

            bf.Serialize(fileStream, obj);

            fileStream.Close();
        }

        static public void BinarySerialize2(T obj, Stream stream)
        {

            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(stream, obj);
        }

        /// <summary>
        /// This method is the opposite, deserializing a binary format from a file
        /// and converting it to an object.  
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        static public T BinaryDeserialize(string filePath)
        {
            T t = default(T);

            FileStream fileStream;

            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);

                t = (T)bf.Deserialize(fileStream);

                fileStream.Close();
            }

            return t;
        }
        /// <summary>
        /// Serializing the T value to filename file as an Xml
        /// </summary>
        /// <param name="value"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        static public string estateToXmlSerialie(T value, string filename)
        {


            if (value == null)
            {
                return string.Empty; 
            }
            try
            {
                var xmlSer = new XmlSerializer(typeof(T));
                var stringWriter = new StringWriter(); 
                using(var writer = XmlWriter.Create(stringWriter))
                {
                    xmlSer.Serialize(writer, value);
                    writer.Flush(); 
                    return stringWriter.ToString(); 
                }
            }catch (Exception e)
            {
                throw new Exception("Error occured when saving object as an xml file", e);
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
