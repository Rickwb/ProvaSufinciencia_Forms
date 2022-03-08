using ProvaSufinciencia_Forms.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaSufinciencia_Forms
{
    public class Repositorio
    {
        public Repositorio()
        {
            AllPassageiros=
        }
        private readonly string pathFileAllPassageiros = Environment.CurrentDirectory+"/fileAllPassageiros.txt";
        private readonly string pathFileAllViagens = Environment.CurrentDirectory+"/fileAllViagens.txt";
        public List<Passageiro> AllPassageiros { get; set; }
        public List<Viagem> AllViagens { get; set; }

        public void SerializarAllPassageiros()
        { 
            
        }

        public void SerializarAllViagens()
        {
        }
        public List<Viagem> DeserializarViagens()
        {
        }






    }
}
