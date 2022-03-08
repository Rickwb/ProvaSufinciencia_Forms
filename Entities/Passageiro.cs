using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaSufinciencia_Forms.Entities
{
    [Serializable()]
    public class Passageiro
    {
        public Passageiro(string nome,string telefone,int idade)
        {
            Nome = nome;
            Telefone = telefone;
            Idade = idade;
        }

        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public int Idade { get; private set; }
        private float TarifaInteira = 6;
        
        public float getTarifa()
        {
            return TarifaInteira;
        }

    }
}
