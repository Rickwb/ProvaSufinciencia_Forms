using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaSufinciencia_Forms.Entities
{
    [Serializable()]
    public class ViagemIntermunicipal : Viagem
    {
        public ViagemIntermunicipal(string destino,string placaOnibus, string nomeMotorista, DateTime dataViagem, DateTime horaViagem) : base(destino,placaOnibus, nomeMotorista, dataViagem, horaViagem)
        {
        }

        public override void AddPassageiro(Passageiro passageiro)
        {
            if (Passageiros.Count()<15)
            {
                Passageiros.Add(passageiro);
            }
        }

        public override float GetValorTotal()
        {
            return 4.05f;
        }
    }
    
}
