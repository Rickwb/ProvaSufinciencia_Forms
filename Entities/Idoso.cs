using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaSufinciencia_Forms.Entities
{
    [Serializable()]
    public class Idoso : Passageiro
    {
        public Idoso(string nome, string telefone, int idade,string rg) : base(nome, telefone, idade)
        {
            Rg = rg;
        }
        public string Rg { get; private set; }

        public float GetTarifa()
        {
            return 0;
        }
    }
}
