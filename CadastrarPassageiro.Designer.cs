
namespace ProvaSufinciencia_Forms
{
    partial class CadastrarPassageiro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.RadioButton rdEstudante;
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NmIdade = new System.Windows.Forms.NumericUpDown();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNomeEscola = new System.Windows.Forms.TextBox();
            this.lblNomeEscola = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblTituloSelecionarViagem = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            rdEstudante = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.NmIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdEstudante
            // 
            rdEstudante.AutoSize = true;
            rdEstudante.Location = new System.Drawing.Point(50, 237);
            rdEstudante.Name = "rdEstudante";
            rdEstudante.Size = new System.Drawing.Size(77, 19);
            rdEstudante.TabIndex = 8;
            rdEstudante.TabStop = true;
            rdEstudante.Text = "Estudante";
            rdEstudante.UseVisualStyleBackColor = true;
            rdEstudante.CheckedChanged += new System.EventHandler(this.rdEstudante_CheckedChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(141, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 23);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(50, 47);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(50, 95);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(36, 15);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Idade";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(50, 162);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(51, 15);
            this.lblTelefone.TabIndex = 3;
            this.lblTelefone.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 5;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // NmIdade
            // 
            this.NmIdade.Location = new System.Drawing.Point(141, 93);
            this.NmIdade.Name = "NmIdade";
            this.NmIdade.Size = new System.Drawing.Size(120, 23);
            this.NmIdade.TabIndex = 6;
            this.NmIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NmIdade.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(141, 162);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 23);
            this.txtTelefone.TabIndex = 9;
            // 
            // txtNomeEscola
            // 
            this.txtNomeEscola.Location = new System.Drawing.Point(141, 277);
            this.txtNomeEscola.Name = "txtNomeEscola";
            this.txtNomeEscola.Size = new System.Drawing.Size(100, 23);
            this.txtNomeEscola.TabIndex = 11;
            this.txtNomeEscola.Visible = false;
            // 
            // lblNomeEscola
            // 
            this.lblNomeEscola.AutoSize = true;
            this.lblNomeEscola.Location = new System.Drawing.Point(35, 280);
            this.lblNomeEscola.Name = "lblNomeEscola";
            this.lblNomeEscola.Size = new System.Drawing.Size(92, 15);
            this.lblNomeEscola.TabIndex = 12;
            this.lblNomeEscola.Text = "Nome da Escola";
            this.lblNomeEscola.Visible = false;
            this.lblNomeEscola.Click += new System.EventHandler(this.lblNomeEscola_Click);
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(141, 344);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 23);
            this.txtRg.TabIndex = 13;
            this.txtRg.Visible = false;
            this.txtRg.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(50, 345);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(21, 15);
            this.lblRg.TabIndex = 14;
            this.lblRg.Text = "Rg";
            this.lblRg.Visible = false;
            // 
            // lblTituloSelecionarViagem
            // 
            this.lblTituloSelecionarViagem.AutoSize = true;
            this.lblTituloSelecionarViagem.Location = new System.Drawing.Point(610, 13);
            this.lblTituloSelecionarViagem.Name = "lblTituloSelecionarViagem";
            this.lblTituloSelecionarViagem.Size = new System.Drawing.Size(101, 15);
            this.lblTituloSelecionarViagem.TabIndex = 15;
            this.lblTituloSelecionarViagem.Text = "SelecionarViagem";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(498, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CadastrarPassageiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTituloSelecionarViagem);
            this.Controls.Add(this.lblRg);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.lblNomeEscola);
            this.Controls.Add(this.txtNomeEscola);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(rdEstudante);
            this.Controls.Add(this.NmIdade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "CadastrarPassageiro";
            this.Text = "CadastrarPassageiro";
            this.Load += new System.EventHandler(this.CadastrarPassageiro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NmIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NmIdade;
        private System.Windows.Forms.RadioButton rdEstudante;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNomeEscola;
        private System.Windows.Forms.Label lblNomeEscola;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblTituloSelecionarViagem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}