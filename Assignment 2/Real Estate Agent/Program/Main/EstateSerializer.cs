using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
            
            if(File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                
                t = (T) bf.Deserialize(fileStream);
                
                fileStream.Close();
            }

            return t; 
        }
    }
}
