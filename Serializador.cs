using ProvaSufinciencia_Forms.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProvaSufinciencia_Forms
{
    public class Serializador<T> : ISerializador<T> where T : class
    {
        public List<T> DeserializarObjeto(string path)
        {
            var lista = new List<T>();
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);
                if (!reader.EndOfStream)
                {
                    lista.Add(JsonSerializer.Deserialize<T>(reader.ReadLine()));
                }

                return lista;

            }
            return null;
        }

        public void SerializarObjeto<T>(object obj, string path)
        {
            if (File.Exists(path))
            {
                StreamWriter streamWriter = new StreamWriter(path);
                streamWriter.WriteLine(JsonSerializer.Serialize(obj));
                streamWriter.Close();
            }
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(JsonSerializer.Serialize(obj));
            writer.Close();
        }
    }
}
