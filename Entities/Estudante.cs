﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaSufinciencia_Forms.Entities
{
    [Serializable()]
    public class Estudante:Passageiro
    {
        public Estudante(string nome,string telefone,int idade,string escola):base(nome,telefone,idade)
        {
            Escola = escola;
        }
        public string Escola { get; private set; }

        public float GetTarifa()
        {
            return getTarifa() / 2;
        }
    }
}
