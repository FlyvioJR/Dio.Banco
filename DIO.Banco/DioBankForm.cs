using DIO.Banco.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DIO.Banco
{
    public partial class DioBankForm : Form
    {
        #region variaveis globais
        
        Conta entidade = new Conta();
        List<Conta> lstContas = new List<Conta>() {
            new Conta("Flavio de Souza Santos Junior", 170, 500, Enums.TipoConta.PessoaFisica, 1),
            new Conta("Curso Digital Innovation One", 550, 500, Enums.TipoConta.PessoaJuridica, 2)
        };

        #endregion

        public DioBankForm()
        {
            InitializeComponent();
        }

        #region Metodos

        public void CarregarGrid()
        {
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = lstContas;
        }

        public void AjustarGrid()
        {
            dgvClientes.Columns[0].Width = 160;
            dgvClientes.Columns[1].Width = 55;
            dgvClientes.Columns[2].Width = 55;
            dgvClientes.Columns[3].Width = 97;
            dgvClientes.Columns[4].Width = 30;

            dgvClientes.Columns[3].HeaderText = "Tipo de Conta";
        }

        public bool ValidarNovaConta()
        {
            if (txtNome.Text.Trim().Equals("") || txtNome.Text.Trim().Length < 10)
            {
                MessageBox.Show("Insira um nome válido!");
                return false;
            }
            if (mkdDepositoInicial.Text.Trim().Equals(","))
            {
                MessageBox.Show("Insira um valor válido");
                return false;
            }
            foreach (var conta in lstContas)
            {
                if (conta.Nome.ToUpper().Equals(txtNome.Text.ToUpper()))
                {
                    MessageBox.Show("Usuario já existe!");
                    return false;
                }
            }
            return true;
        }

        public bool ValidaOperacoes()
        {
            if (mkdValor.Text.Equals(""))
            {
                MessageBox.Show("Insira um valor válido");
                return false;
            }

            if (rdbTransferencia.Checked)
            {
                if (txtIdBeneficiado.Text.Equals(""))
                {
                    MessageBox.Show("Insira o Id do beneficiado!");
                    return false;
                }
                
                int.TryParse(txtIdBeneficiado.Text, out int idBeneficiado);
                
                if (idBeneficiado > lstContas.ToArray().Length || idBeneficiado < 1)
                {
                    MessageBox.Show("Insira um Id válido!");
                    txtIdBeneficiado.Focus();
                    return false;
                }
            }
            return true;
        }

        public void LimparTela()
        {
            txtNome.Clear();
            txtIdBeneficiado.Clear();
            mkdDepositoInicial.Clear();
            mkdSaldo.Clear();
            mkdValor.Clear();
            rdbSaque.Checked = false;
            rdbSaque.Enabled = false;
            rdbDeposito.Checked = false;
            rdbDeposito.Enabled = false; 
            rdbTransferencia.Checked = false;
            rdbTransferencia.Enabled = false;
            txtIdBeneficiado.Enabled = false;
            btnAdicionarUsuario.Enabled = true;
            ckbDepositoInicial.Checked = false;
            rdbPessoaFisica.Checked = true;
        }

        #endregion

        #region eventos

        private void DioBankForm_Load(object sender, EventArgs e)
        {
            LimparTela();
            CarregarGrid();
            AjustarGrid();
            rdbPessoaFisica.Checked = true;
        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            if(ValidarNovaConta())
            {
                string nome = txtNome.Text;
                double saldo = 0.00;
                double credito = 500.00;
                int idAtual = lstContas.ToArray().Length + 1;

                if (ckbDepositoInicial.Checked)
                    double.TryParse(mkdDepositoInicial.Text.Trim(), out saldo);

                Conta conta = new Conta(
                    nome,
                    saldo,
                    credito,
                    rdbPessoaFisica.Checked ? Enums.TipoConta.PessoaFisica : Enums.TipoConta.PessoaJuridica,
                    idAtual);

                lstContas.Add(conta);
                DioBankForm_Load(sender, e);
            }
        }

        private void ckbDepositoInicial_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDepositoInicial.Checked)
            {
                mkdDepositoInicial.Enabled = true;
                mkdDepositoInicial.Focus();
            }
            else
            {
                mkdDepositoInicial.Clear();
                mkdDepositoInicial.Enabled = false;
            }
        }

        private void btnRealizarOperacao_Click(object sender, EventArgs e)
        {
            if (entidade == null)
                return;
            entidade = entidade.BuscarContaPorId(lstContas, entidade.Id);

            if (!ValidaOperacoes())
                return;

            if (rdbSaque.Checked && entidade.Id > 0)
            {
                double valor = double.Parse(mkdValor.Text);
                MessageBox.Show(entidade.Sacar(valor) ? $"Saque realizado com sucesso! O seu saldo é {entidade.Saldo}" : "Saldo Insuficiente!");
            }
            else if (rdbDeposito.Checked && entidade.Id > 0)
            {
                if (txtIdBeneficiado.Text.Equals(""))
                {
                    double valor = double.Parse(mkdValor.Text);
                    MessageBox.Show(entidade.Depositar(valor) ? $"Valor depositado com sucesso! O seu saldo é {entidade.Saldo}" : "Valor incorreto! Por favor tente novamente.");
                }
                else
                {
                    double valor = double.Parse(mkdValor.Text);
                    int idBeneficiado = int.Parse(txtIdBeneficiado.Text);
                    Conta contaBeneficiado = new Conta();
                    contaBeneficiado = new Conta().BuscarContaPorId(lstContas, idBeneficiado);
                    MessageBox.Show(entidade.DepositarParaBeneficiario(valor, contaBeneficiado) ? "Valor depositado com sucesso!" : "Valor incorreto! Por favor tente novamente.");
                }
            }
            else if (rdbTransferencia.Checked && entidade.Id > 0)
            {
                double valor = double.Parse(mkdValor.Text);
                int idBeneficiado = int.Parse(txtIdBeneficiado.Text);

                Conta contaBeneficiado = new Conta().BuscarContaPorId(lstContas, idBeneficiado);
                MessageBox.Show(entidade.Tranferir(valor, contaBeneficiado) ? $"Tranferencia realizada com sucesso! O seu saldo é {entidade.Saldo}" : "Saldo Insuficiente!");
            }
            DioBankForm_Load(sender, e);
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LimparTela();

            if (e.RowIndex < 0)
                return;

            txtNome.Text = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            mkdSaldo.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            if (dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString() == "PessoaFisica")
                rdbPessoaFisica.Checked = true;
            if (dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString() == "PessoaJuridica")
                rdbpessoaJuridica.Checked = true;

            entidade = new Conta().BuscarContaPorId(lstContas, (int)dgvClientes.Rows[e.RowIndex].Cells[4].Value);

            btnAdicionarUsuario.Enabled = entidade.Id > 0 ? false : true;
            rdbSaque.Enabled = entidade.Id > 0 ? true : false;
            rdbDeposito.Enabled = entidade.Id > 0 ? true : false;
            rdbTransferencia.Enabled = entidade.Id > 0 ? true : false;
        }

        private void rdbSaque_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSaque.Checked)
            {
                mkdValor.Enabled = true;
                txtIdBeneficiado.Enabled = false;
                mkdValor.Focus();
            }
            else
                mkdValor.Enabled = false;
        }

        private void rdbDeposito_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDeposito.Checked || rdbTransferencia.Checked)
            {
                mkdValor.Enabled = true;
                txtIdBeneficiado.Enabled = true;
                mkdValor.Focus();
            }
            else
                mkdValor.Enabled = false;
        }

        private void btnLimparTela_Click(object sender, EventArgs e)
        {
            LimparTela();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        #endregion
    }
}
