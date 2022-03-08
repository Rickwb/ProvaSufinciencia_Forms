
namespace ProvaSufinciencia_Forms
{
    partial class CadastrarViagem
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
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.lblNomeMotorista = new System.Windows.Forms.Label();
            this.txtNomeMot = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rdViagemNa = new System.Windows.Forms.RadioButton();
            this.rdViagemInter = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(211, 83);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 23);
            this.txtDestino.TabIndex = 0;
            this.txtDestino.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(89, 86);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(47, 15);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(89, 132);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(93, 15);
            this.lblPlaca.TabIndex = 3;
            this.lblPlaca.Text = "Placa do Onibus";
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(211, 129);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(100, 23);
            this.txtPlaca.TabIndex = 2;
            // 
            // lblNomeMotorista
            // 
            this.lblNomeMotorista.AutoSize = true;
            this.lblNomeMotorista.Location = new System.Drawing.Point(89, 179);
            this.lblNomeMotorista.Name = "lblNomeMotorista";
            this.lblNomeMotorista.Size = new System.Drawing.Size(111, 15);
            this.lblNomeMotorista.TabIndex = 5;
            this.lblNomeMotorista.Text = "Nome do Motorista";
            this.lblNomeMotorista.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeMot
            // 
            this.txtNomeMot.Location = new System.Drawing.Point(211, 176);
            this.txtNomeMot.Name = "txtNomeMot";
            this.txtNomeMot.Size = new System.Drawing.Size(100, 23);
            this.txtNomeMot.TabIndex = 4;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(89, 228);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(31, 15);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Data";
            this.lblData.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(211, 228);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2022, 3, 5, 10, 24, 14, 0);
            // 
            // rdViagemNa
            // 
            this.rdViagemNa.AutoSize = true;
            this.rdViagemNa.Location = new System.Drawing.Point(125, 279);
            this.rdViagemNa.Name = "rdViagemNa";
            this.rdViagemNa.Size = new System.Drawing.Size(115, 19);
            this.rdViagemNa.TabIndex = 10;
            this.rdViagemNa.TabStop = true;
            this.rdViagemNa.Text = "Viagem Nacional";
            this.rdViagemNa.UseVisualStyleBackColor = true;
            this.rdViagemNa.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdViagemInter
            // 
            this.rdViagemInter.AutoSize = true;
            this.rdViagemInter.Location = new System.Drawing.Point(276, 279);
            this.rdViagemInter.Name = "rdViagemInter";
            this.rdViagemInter.Size = new System.Drawing.Size(145, 19);
            this.rdViagemInter.TabIndex = 11;
            this.rdViagemInter.TabStop = true;
            this.rdViagemInter.Text = "Viagem Intermunicipal";
            this.rdViagemInter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CadastrarViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.rdViagemInter);
            this.Controls.Add(this.rdViagemNa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblNomeMotorista);
            this.Controls.Add(this.txtNomeMot);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.txtDestino);
            this.Name = "CadastrarViagem";
            this.Text = "CadastrarViagem";
            this.Load += new System.EventHandler(this.CadastrarViagem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label lblNomeMotorista;
        private System.Windows.Forms.TextBox txtNomeMot;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rdViagemNa;
        private System.Windows.Forms.RadioButton rdViagemInter;
        private System.Windows.Forms.Button button1;
    }
}