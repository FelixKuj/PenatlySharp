//-------------------------------------------------------------------------------------
// File name...................: BinarySerialization.cs
// Purpose.....................: Serialize (save object from the program into files) and 
//                               deserialize (read data from files and save into objects 
//                               in the program) all objects containing data, using 
//                               binary serialization.
// Programmer..................: André Rubira
// Date........................: 2013-03-07
// Version.....................:
// Changed.....................: 
//--------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PenaltySharp.DAL
{
    public class BinarySerialization<T>
    {
        // objects from the program will be saved into this file
        private static string _fileName;

        // property related to _fileName
        public static string FileName { get { return _fileName; } set { _fileName = value; } }

        // Default constructor
        public BinarySerialization()
        {
            _fileName = "Data1.DAT";
        }

        /// <summary>
        /// BinarySerialize is a method in the BinarySerialization class that
        /// Serialize (save object from the program into files) using 
        /// binary serialization.
        /// </summary>
        /// <param name="animals">Object or object list</param>
        /// <returns>true or cast an exception</returns>
        public static bool BinarySerialize(T lista)
        {
            // Binärafiler (binärt data) - serialisering
            Stream stream = null;

            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(_fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, lista);
            }
            catch
            {
                throw;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            return true;
        }

        /// <summary>
        /// BinaryDeSerialize is a method in the BinarySerialization class that
        /// DeSerialize (read data from files and save into objects 
        /// in the program)  using binary deserialization.
        /// </summary>
        /// <param name="path">filename</param>
        /// <returns>Object or object list</returns>
        public static T BinaryDeSerialize(string path)
        {
            T lista;

            // Binärafiler (binärt data) - serialisering
            Stream stream = null;

            _fileName = path;

            try
            {
                IFormatter formatter = new BinaryFormatter();
                stream = new FileStream(_fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                lista = (T)formatter.Deserialize(stream);
            }
            catch
            {
                throw;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

            return lista;
        }
    }
}
