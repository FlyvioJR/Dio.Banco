
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.ckbDepositoInicial = new System.Windows.Forms.CheckBox();
            this.mkdDepositoInicial = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbSaque = new System.Windows.Forms.RadioButton();
            this.rdbDeposito = new System.Windows.Forms.RadioButton();
            this.rdbTransferencia = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.mkdValor = new System.Windows.Forms.MaskedTextBox();
            this.txtIdBeneficiado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRealizarOperacao = new System.Windows.Forms.Button();
            this.btnLimparTela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarUsuario
            // 
            this.btnAdicionarUsuario.Location = new System.Drawing.Point(347, 73);
            this.btnAdicionarUsuario.Name = "btnAdicionarUsuario";
            this.btnAdicionarUsuario.Size = new System.Drawing.Size(108, 23);
            this.btnAdicionarUsuario.TabIndex = 0;
            this.btnAdicionarUsuario.Text = "Adicionar Usuario";
            this.btnAdicionarUsuario.UseVisualStyleBackColor = true;
            this.btnAdicionarUsuario.Click += new System.EventHandler(this.btnAdicionarUsuario_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(380, 347);
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
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saldo Atual";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(89, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(366, 20);
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
            this.mkdSaldo.Location = new System.Drawing.Point(89, 74);
            this.mkdSaldo.Name = "mkdSaldo";
            this.mkdSaldo.Size = new System.Drawing.Size(85, 20);
            this.mkdSaldo.TabIndex = 6;
            this.mkdSaldo.ValidatingType = typeof(int);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(15, 162);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(440, 179);
            this.dgvClientes.TabIndex = 7;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // ckbDepositoInicial
            // 
            this.ckbDepositoInicial.AutoSize = true;
            this.ckbDepositoInicial.Location = new System.Drawing.Point(290, 44);
            this.ckbDepositoInicial.Name = "ckbDepositoInicial";
            this.ckbDepositoInicial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbDepositoInicial.Size = new System.Drawing.Size(98, 17);
            this.ckbDepositoInicial.TabIndex = 8;
            this.ckbDepositoInicial.Text = "Deposito Inicial";
            this.ckbDepositoInicial.UseVisualStyleBackColor = true;
            this.ckbDepositoInicial.CheckedChanged += new System.EventHandler(this.ckbDepositoInicial_CheckedChanged);
            // 
            // mkdDepositoInicial
            // 
            this.mkdDepositoInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mkdDepositoInicial.Enabled = false;
            this.mkdDepositoInicial.Location = new System.Drawing.Point(410, 42);
            this.mkdDepositoInicial.Mask = "0000";
            this.mkdDepositoInicial.Name = "mkdDepositoInicial";
            this.mkdDepositoInicial.RejectInputOnFirstFailure = true;
            this.mkdDepositoInicial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mkdDepositoInicial.Size = new System.Drawing.Size(45, 20);
            this.mkdDepositoInicial.TabIndex = 9;
            this.mkdDepositoInicial.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecione a operação desejada";
            // 
            // rdbSaque
            // 
            this.rdbSaque.AutoSize = true;
            this.rdbSaque.Location = new System.Drawing.Point(185, 103);
            this.rdbSaque.Name = "rdbSaque";
            this.rdbSaque.Size = new System.Drawing.Size(56, 17);
            this.rdbSaque.TabIndex = 11;
            this.rdbSaque.TabStop = true;
            this.rdbSaque.Text = "Saque";
            this.rdbSaque.UseVisualStyleBackColor = true;
            this.rdbSaque.CheckedChanged += new System.EventHandler(this.rdbSaque_CheckedChanged);
            // 
            // rdbDeposito
            // 
            this.rdbDeposito.AutoSize = true;
            this.rdbDeposito.Location = new System.Drawing.Point(255, 103);
            this.rdbDeposito.Name = "rdbDeposito";
            this.rdbDeposito.Size = new System.Drawing.Size(67, 17);
            this.rdbDeposito.TabIndex = 12;
            this.rdbDeposito.TabStop = true;
            this.rdbDeposito.Text = "Deposito";
            this.rdbDeposito.UseVisualStyleBackColor = true;
            this.rdbDeposito.CheckedChanged += new System.EventHandler(this.rdbDeposito_CheckedChanged);
            // 
            // rdbTransferencia
            // 
            this.rdbTransferencia.AutoSize = true;
            this.rdbTransferencia.Location = new System.Drawing.Point(347, 103);
            this.rdbTransferencia.Name = "rdbTransferencia";
            this.rdbTransferencia.Size = new System.Drawing.Size(85, 17);
            this.rdbTransferencia.TabIndex = 13;
            this.rdbTransferencia.TabStop = true;
            this.rdbTransferencia.Text = "Tranferência";
            this.rdbTransferencia.UseVisualStyleBackColor = true;
            this.rdbTransferencia.CheckedChanged += new System.EventHandler(this.rdbDeposito_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Valor";
            // 
            // mkdValor
            // 
            this.mkdValor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mkdValor.Enabled = false;
            this.mkdValor.Location = new System.Drawing.Point(277, 130);
            this.mkdValor.Mask = "0000";
            this.mkdValor.Name = "mkdValor";
            this.mkdValor.RejectInputOnFirstFailure = true;
            this.mkdValor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mkdValor.Size = new System.Drawing.Size(45, 20);
            this.mkdValor.TabIndex = 15;
            this.mkdValor.ValidatingType = typeof(int);
            // 
            // txtIdBeneficiado
            // 
            this.txtIdBeneficiado.Enabled = false;
            this.txtIdBeneficiado.Location = new System.Drawing.Point(126, 130);
            this.txtIdBeneficiado.Name = "txtIdBeneficiado";
            this.txtIdBeneficiado.Size = new System.Drawing.Size(48, 20);
            this.txtIdBeneficiado.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Id do beneficiado";
            // 
            // btnRealizarOperacao
            // 
            this.btnRealizarOperacao.Location = new System.Drawing.Point(347, 128);
            this.btnRealizarOperacao.Name = "btnRealizarOperacao";
            this.btnRealizarOperacao.Size = new System.Drawing.Size(108, 23);
            this.btnRealizarOperacao.TabIndex = 18;
            this.btnRealizarOperacao.Text = "Realizar Operação";
            this.btnRealizarOperacao.UseVisualStyleBackColor = true;
            this.btnRealizarOperacao.Click += new System.EventHandler(this.btnRealizarOperacao_Click);
            // 
            // btnLimparTela
            // 
            this.btnLimparTela.Location = new System.Drawing.Point(300, 347);
            this.btnLimparTela.Name = "btnLimparTela";
            this.btnLimparTela.Size = new System.Drawing.Size(75, 23);
            this.btnLimparTela.TabIndex = 19;
            this.btnLimparTela.Text = "Limpar";
            this.btnLimparTela.UseVisualStyleBackColor = true;
            this.btnLimparTela.Click += new System.EventHandler(this.btnLimparTela_Click);
            // 
            // DioBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 378);
            this.Controls.Add(this.btnLimparTela);
            this.Controls.Add(this.btnRealizarOperacao);
            this.Controls.Add(this.txtIdBeneficiado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mkdValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbTransferencia);
            this.Controls.Add(this.rdbDeposito);
            this.Controls.Add(this.rdbSaque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mkdDepositoInicial);
            this.Controls.Add(this.ckbDepositoInicial);
            this.Controls.Add(this.dgvClientes);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.CheckBox ckbDepositoInicial;
        private System.Windows.Forms.MaskedTextBox mkdDepositoInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbSaque;
        private System.Windows.Forms.RadioButton rdbDeposito;
        private System.Windows.Forms.RadioButton rdbTransferencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mkdValor;
        private System.Windows.Forms.TextBox txtIdBeneficiado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRealizarOperacao;
        private System.Windows.Forms.Button btnLimparTela;
    }
}

