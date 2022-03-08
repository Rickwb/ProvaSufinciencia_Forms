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
    public partial class CadastrarPassageiro : Form
    {
        public CadastrarPassageiro()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (NmIdade.Value>=60)
            {
                lblRg.Visible = true;
                txtRg.Visible = true;
            }
            else
            {
                lblRg.Visible = false;
                txtRg.Visible = false;
            }

        }

        private void rdIdoso_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarPassageiro_Load(object sender, EventArgs e)
        {

        }

        private void rdEstudante_CheckedChanged(object sender, EventArgs e)
        {
            if (rdEstudante.Checked)
            {
                lblNomeEscola.Visible = true;
                txtNomeEscola.Visible = true;
            }else
            {
                lblNomeEscola.Visible = false;
                txtNomeEscola.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNomeEscola_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
