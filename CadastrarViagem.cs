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
    public partial class CadastrarViagem : Form
    {
        public CadastrarViagem()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarViagem_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdViagemNa.Checked)
            {
                var viagem = new ViagemMunicipal(txtDestino.Text, txtPlaca.Text, txtNomeMot.Text, dateTimePicker1.Value.Date, dateTimePicker1.Value.Date);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
