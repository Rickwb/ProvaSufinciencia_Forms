using ProvaSufinciencia_Forms.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaSufinciencia_Forms
{
    public partial class ConsultarViagem : Form
    {
        private readonly Repositorio _repository;
        private Viagem ViagemConsultada;
        public ConsultarViagem(Repositorio repositorio)
        {
            _repository = repositorio;
            InitializeComponent();
        }

        private void ConsultarViagem_Load(object sender, EventArgs e)
        {



        }

        private void lblDestino_Click(object sender, EventArgs e)
        {

        }

        private void lblPlaca_Click(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdViagemInter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdViagemNa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void lblNomeMotorista_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeMot_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            var getByName = _repository.Viagens.FindAll(x => x.Destino.Contains(txtDestino.Text) || x.DataViagem.Date == dateTimePicker1.Value.Date || x.PlacaOnibus == txtPlaca.Text);

            if (getByName.Count>1)
            {
                var viagem = getByName.Where(x => x.Destino.Contains(txtDestino.Text) && x.DataViagem.Date == dateTimePicker1.Value.Date).SingleOrDefault();
                if (viagem is not null)
                    ViagemConsultada = viagem;

            }
            else if(getByName.Count==1)
            {
                ViagemConsultada = getByName.ElementAt(0);
            }
            else
            {
                
            }
        }

        private void btnGetValorTotal_Click(object sender, EventArgs e)
        {
            if (ViagemConsultada is not null)
            {
                var valorTotal = ViagemConsultada.GetValorTotal();

                textBox1.Text = valorTotal.ToString();
            }
        }

        private void btnGerarArquivoCsv_Click(object sender, EventArgs e)
        {
            ViagemConsultada.GerarArquivoCsv();
        }
    }
}
