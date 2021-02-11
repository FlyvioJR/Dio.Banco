using DIO.Banco.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIO.Banco
{
    public partial class DioBankForm : Form
    {
        Conta entidade = new Conta();

        List<Conta> lstContas = new List<Conta>() {
            new Conta("Flavio de Souza Santos Junior", 170, 500, Enums.TipoConta.PessoaFisica, 1),
            new Conta("Curso Digital Innovation One", 550, 500, Enums.TipoConta.PessoaJuridica, 2)
        };

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

        public void LimparTela()
        {
            txtNome.Clear();
            txtIdBeneficiado.Clear();
            mkdDepositoInicial.Clear();
            mkdSaldo.Clear();
            mkdValor.Clear();
            rdbSaque.Checked = false;
            rdbDeposito.Checked = false;
            rdbTransferencia.Checked = false;
            txtIdBeneficiado.Enabled = false;
            btnAdicionarUsuario.Enabled = true;
        }

        #endregion


        private void DioBankForm_Load(object sender, EventArgs e)
        {
            LimparTela();
            CarregarGrid();
            AjustarGrid();
            rdbPessoaFisica.Checked = true;
        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            if(entidade.Id == 0)
            {
                string nome = txtNome.Text;
                double saldo = 0.001F;
                double credito = 500.002F;
                int IdAtual = lstContas.ToArray().Length + 1;

                if (ckbDepositoInicial.Checked)
                {
                    double.Parse(mkdDepositoInicial.ToString());
                }

                Conta conta = new Conta(
                    nome,
                    saldo,
                    credito,
                    rdbPessoaFisica.Checked ? Enums.TipoConta.PessoaFisica : Enums.TipoConta.PessoaJuridica,
                    IdAtual);

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
            entidade = entidade.BuscarContaPorId(lstContas, entidade.Id);

            if (rdbSaque.Checked && entidade.Id > 0)
            {

                double valor = double.Parse(mkdValor.Text);
                entidade.Sacar(valor);
            }
            else if (rdbDeposito.Checked && entidade.Id > 0)
            {
                if (txtIdBeneficiado.Text.Equals(""))
                {
                    double valor = double.Parse(mkdValor.Text);
                    entidade.Depositar(valor);
                }
                else
                {
                    double valor = double.Parse(mkdValor.Text);
                    Conta contaBeneficiado = new Conta().BuscarConta(lstContas ,txtIdBeneficiado.Text);

                    entidade.DepositarParaBeneficiario(valor, contaBeneficiado);
                }
            }
            else if (rdbTransferencia.Checked && entidade.Id > 0)
            {
                double valor = double.Parse(mkdValor.Text);

                Conta contaBeneficiado = new Conta().BuscarConta(lstContas, txtIdBeneficiado.Text);
                entidade.Tranferir(valor, contaBeneficiado);

            }
            DioBankForm_Load(sender, e);
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LimparTela();
            txtNome.Text = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            mkdSaldo.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            if (dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString() == "PessoaFisica")
                rdbPessoaFisica.Checked = true;
            if (dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString() == "PessoaJuridica")
                rdbpessoaJuridica.Checked = true;

            entidade.Id = int.Parse(dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString());

            btnAdicionarUsuario.Enabled = entidade.Id > 0 ? false : true; 
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
    }
}
