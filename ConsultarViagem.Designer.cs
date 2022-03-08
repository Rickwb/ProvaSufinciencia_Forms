
namespace ProvaSufinciencia_Forms
{
    partial class ConsultarViagem
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
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.rdViagemInter = new System.Windows.Forms.RadioButton();
            this.rdViagemNa = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNomeMotorista = new System.Windows.Forms.Label();
            this.txtNomeMot = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnGetValorTotal = new System.Windows.Forms.Button();
            this.btnGerarArquivoCsv = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(83, 119);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(93, 15);
            this.lblPlaca.TabIndex = 7;
            this.lblPlaca.Text = "Placa do Onibus";
            this.lblPlaca.Click += new System.EventHandler(this.lblPlaca_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(220, 116);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 23);
            this.txtPlaca.TabIndex = 6;
            this.txtPlaca.TextChanged += new System.EventHandler(this.txtPlaca_TextChanged);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(83, 51);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(47, 15);
            this.lblDestino.TabIndex = 5;
            this.lblDestino.Text = "Destino";
            this.lblDestino.Click += new System.EventHandler(this.lblDestino_Click);
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(220, 55);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 23);
            this.txtDestino.TabIndex = 4;
            // 
            // rdViagemInter
            // 
            this.rdViagemInter.AutoSize = true;
            this.rdViagemInter.Location = new System.Drawing.Point(286, 298);
            this.rdViagemInter.Name = "rdViagemInter";
            this.rdViagemInter.Size = new System.Drawing.Size(145, 19);
            this.rdViagemInter.TabIndex = 17;
            this.rdViagemInter.TabStop = true;
            this.rdViagemInter.Text = "Viagem Intermunicipal";
            this.rdViagemInter.UseVisualStyleBackColor = true;
            this.rdViagemInter.CheckedChanged += new System.EventHandler(this.rdViagemInter_CheckedChanged);
            // 
            // rdViagemNa
            // 
            this.rdViagemNa.AutoSize = true;
            this.rdViagemNa.Location = new System.Drawing.Point(135, 298);
            this.rdViagemNa.Name = "rdViagemNa";
            this.rdViagemNa.Size = new System.Drawing.Size(115, 19);
            this.rdViagemNa.TabIndex = 16;
            this.rdViagemNa.TabStop = true;
            this.rdViagemNa.Text = "Viagem Nacional";
            this.rdViagemNa.UseVisualStyleBackColor = true;
            this.rdViagemNa.CheckedChanged += new System.EventHandler(this.rdViagemNa_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(220, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 5, 10, 24, 14, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(83, 160);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(31, 15);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "Data";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // lblNomeMotorista
            // 
            this.lblNomeMotorista.AutoSize = true;
            this.lblNomeMotorista.Location = new System.Drawing.Point(83, 240);
            this.lblNomeMotorista.Name = "lblNomeMotorista";
            this.lblNomeMotorista.Size = new System.Drawing.Size(111, 15);
            this.lblNomeMotorista.TabIndex = 13;
            this.lblNomeMotorista.Text = "Nome do Motorista";
            this.lblNomeMotorista.Click += new System.EventHandler(this.lblNomeMotorista_Click);
            // 
            // txtNomeMot
            // 
            this.txtNomeMot.Location = new System.Drawing.Point(220, 240);
            this.txtNomeMot.Name = "txtNomeMot";
            this.txtNomeMot.Size = new System.Drawing.Size(100, 23);
            this.txtNomeMot.TabIndex = 12;
            this.txtNomeMot.TextChanged += new System.EventHandler(this.txtNomeMot_TextChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(469, 94);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(74, 26);
            this.btnConsultar.TabIndex = 18;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnGetValorTotal
            // 
            this.btnGetValorTotal.Location = new System.Drawing.Point(534, 275);
            this.btnGetValorTotal.Name = "btnGetValorTotal";
            this.btnGetValorTotal.Size = new System.Drawing.Size(142, 23);
            this.btnGetValorTotal.TabIndex = 19;
            this.btnGetValorTotal.Text = "ValorTotal da Viagem";
            this.btnGetValorTotal.UseVisualStyleBackColor = true;
            this.btnGetValorTotal.Click += new System.EventHandler(this.btnGetValorTotal_Click);
            // 
            // btnGerarArquivoCsv
            // 
            this.btnGerarArquivoCsv.Location = new System.Drawing.Point(534, 332);
            this.btnGerarArquivoCsv.Name = "btnGerarArquivoCsv";
            this.btnGerarArquivoCsv.Size = new System.Drawing.Size(142, 23);
            this.btnGerarArquivoCsv.TabIndex = 20;
            this.btnGerarArquivoCsv.Text = "Gerar Arquivo Csv";
            this.btnGerarArquivoCsv.UseVisualStyleBackColor = true;
            this.btnGerarArquivoCsv.Click += new System.EventHandler(this.btnGerarArquivoCsv_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 276);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 21;
            // 
            // ConsultarViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGerarArquivoCsv);
            this.Controls.Add(this.btnGetValorTotal);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.rdViagemInter);
            this.Controls.Add(this.rdViagemNa);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNomeMotorista);
            this.Controls.Add(this.txtNomeMot);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.txtDestino);
            this.Name = "ConsultarViagem";
            this.Text = "ConsultarViagem";
            this.Load += new System.EventHandler(this.ConsultarViagem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.RadioButton rdViagemInter;
        private System.Windows.Forms.RadioButton rdViagemNa;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNomeMotorista;
        private System.Windows.Forms.TextBox txtNomeMot;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnGetValorTotal;
        private System.Windows.Forms.Button btnGerarArquivoCsv;
        private System.Windows.Forms.TextBox textBox1;
    }
}