
namespace DIO.Banco
{
    partial class DioBankForm
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
            this.btnAdicionarUsuario = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rdbPessoaFisica = new System.Windows.Forms.RadioButton();
            this.rdbpessoaJuridica = new System.Windows.Forms.RadioButton();
            this.mkdSaldo = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarUsuario
            // 
            this.btnAdicionarUsuario.Location = new System.Drawing.Point(378, 74);
            this.btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            this.btnAdicionarUsuario.Size = new System.Drawing.Size(121, 23);
            this.btnAdicionarUsuario.TabIndex = 0;
            this.btnAdicionarUsuario.Text = "Adicionar Usuario";
            this.btnAdicionarUsuario.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(424, 285);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 16);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(12, 45);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(73, 13);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "Tipo de conta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(410, 20);
            this.txtNome.TabIndex = 4;
            // 
            // rdbPessoaFisica
            // 
            this.rdbPessoaFisica.AutoSize = true;
            this.rdbPessoaFisica.Location = new System.Drawing.Point(89, 43);
            this.rdbPessoaFisica.Name = "rdbPessoaFisica";
            this.rdbPessoaFisica.Size = new System.Drawing.Size(90, 17);
            this.rdbPessoaFisica.TabIndex = 5;
            this.rdbPessoaFisica.TabStop = true;
            this.rdbPessoaFisica.Text = "Pessoa Fisica";
            this.rdbPessoaFisica.UseVisualStyleBackColor = true;
            // 
            // rdbpessoaJuridica
            // 
            this.rdbpessoaJuridica.AutoSize = true;
            this.rdbpessoaJuridica.Location = new System.Drawing.Point(185, 43);
            this.rdbpessoaJuridica.Name = "rdbpessoaJuridica";
            this.rdbpessoaJuridica.Size = new System.Drawing.Size(99, 17);
            this.rdbpessoaJuridica.TabIndex = 5;
            this.rdbpessoaJuridica.TabStop = true;
            this.rdbpessoaJuridica.Text = "Pessoa Juridica";
            this.rdbpessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // mkdSaldo
            // 
            this.mkdSaldo.Enabled = false;
            this.mkdSaldo.Location = new System.Drawing.Point(89, 75);
            this.mkdSaldo.Name = "mkdSaldo";
            this.mkdSaldo.Size = new System.Drawing.Size(85, 20);
            this.mkdSaldo.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(484, 179);
            this.dataGridView1.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(290, 44);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Deposito Inicial";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Location = new System.Drawing.Point(394, 42);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(105, 20);
            this.maskedTextBox1.TabIndex = 9;
            // 
            // DioBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 320);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mkdSaldo);
            this.Controls.Add(this.rdbpessoaJuridica);
            this.Controls.Add(this.rdbPessoaFisica);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAdicionarUsuario);
            this.Name = "DioBankForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.DioBankForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarUsuario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rdbPessoaFisica;
        private System.Windows.Forms.RadioButton rdbpessoaJuridica;
        private System.Windows.Forms.MaskedTextBox mkdSaldo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

