using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProvaSufinciencia_Forms.Entities
{
    [Serializable()]
    public class Empresa
    {
        private readonly Repositorio _repositorio;
        public Empresa(Repositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Passageiro> GetPassageirosMaisVelhos_OrdemAlfabetica()
        {
            var passageirosIdosos = new List<Passageiro>();
            foreach (var viagem in _repositorio.AllViagens)
            {
                foreach (var ps in viagem.Passageiros)
                {
                    if (ps is Idoso)
                    {
                        passageirosIdosos.Add(ps);
                    }
                }
            }
            return passageirosIdosos;
        }
    }
}
