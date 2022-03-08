using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProvaSufinciencia_Forms.Entities
{
    [Serializable()]
    public abstract class Viagem
    {
        public Viagem(string destino,string placaOnibus,string nomeMotorista, DateTime dataViagem,DateTime horaViagem)
        {
            Destino = destino;
            PlacaOnibus = placaOnibus;
            NomeMotorista = nomeMotorista;
            DataViagem = dataViagem.Date;
            HoraViagem = Convert.ToDateTime(horaViagem.Hour);
            Passageiros = new List<Passageiro>();
        }
        public string Destino { get; init; }
        public string PlacaOnibus { get; private set; }
        public string NomeMotorista { get; private set; }
        public DateTime DataViagem { get; private set; }
        public DateTime HoraViagem { get; private set; }
        public List<Passageiro> Passageiros { get; private set; }

        public abstract float GetValorTotal();
        public abstract void AddPassageiro(Passageiro passageiro);
        
        public void GerarArquivoCsv()
        {
            StreamWriter writer = new StreamWriter(new FileStream(Directory.GetCurrentDirectory()+@"\", FileMode.Create, FileAccess.Write, FileShare.Read));

            writer.WriteLine($"{DataViagem.ToString()},{HoraViagem.Hour.ToString()},{PlacaOnibus},{NomeMotorista}");

            writer.Flush();
            Passageiros.ForEach(p=>
                writer.WriteLine(".csv",p));
            writer.Close();

        }

    

    }
}
