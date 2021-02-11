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
            new Conta("Flavio de Souza Santos Junior", 100.00, 500.00, Enums.TipoConta.PessoaFisica, 1),
            new Conta("Curso Digital Innovation One", 100.00, 500.00, Enums.TipoConta.PessoaJuridica, 2)
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
            dgvClientes.Columns[0].Width = 180;
            dgvClientes.Columns[1].Width = 60;
            dgvClientes.Columns[2].Width = 60;
            dgvClientes.Columns[3].Width = 97;

            dgvClientes.Columns[3].HeaderText = "Tipo de Conta";

            dgvClientes.Columns[4].Visible = false;
        }

        public void LimparTela()
        {
            txtNome.Clear();
            txtNomeBeneficiado.Clear();
            mkdDepositoInicial.Clear();
            mkdSaldo.Clear();
            mkdValor.Clear();
            rdbSaque.Checked = false;
            rdbDeposito.Checked = false;
            rdbTransferencia.Checked = false;
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
            string nome = txtNome.Text;
            double saldo = 0;
            double credito = 500;
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
                if (txtNomeBeneficiado.Equals(""))
                {
                    double valor = double.Parse(mkdValor.Text);
                    entidade.Depositar(valor);
                }
                else
                {
                    double valor = double.Parse(mkdValor.Text);
                    Conta contaBeneficiado = new Conta().BuscarConta(lstContas ,txtNomeBeneficiado.Text);

                    entidade.DepositarParaBeneficiario(valor, contaBeneficiado);
                }
            }
            DioBankForm_Load(sender, e);
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNome.Text = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            mkdSaldo.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            entidade.Id = int.Parse(dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void rdbSaque_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSaque.Checked || rdbDeposito.Checked || rdbTransferencia.Checked)
            {
                mkdValor.Enabled = true;
                mkdValor.Focus();
            }
            else
                mkdValor.Enabled = false;
        }
    }
}
