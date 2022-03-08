using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaSufinciencia_Forms
{
    public interface ISerializador<T> where T :class
    {
        public void SerializarObjeto<T>(object obj, string path);
        public List<T> DeserializarObjeto(string path);
    }
}
