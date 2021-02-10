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
        
        List<Conta> lstContas = new List<Conta>() {
            new Conta("Flavio de Souza Santos Junior", 100.00, 500.00, Enums.TipoConta.PessoaFisica),
            new Conta("Curso Digital Innovation One", 100.00, 500.00, Enums.TipoConta.PessoaJuridica)
        };

        public DioBankForm()
        {
            InitializeComponent();
        }
        
        
        private void DioBankForm_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnAdicionarUsuario_Click(object sender, EventArgs e)
        {
            string nome = txtNome.ToString();
            double saldo = 0;
            double credito = 500;

            if (ckbDepositoInicial.Checked)
            {
                double.Parse(mkdDepositoInicial.ToString());
            }

            Conta conta = new Conta(
                nome,
                saldo,
                credito,
                rdbPessoaFisica.Checked ? Enums.TipoConta.PessoaFisica : Enums.TipoConta.PessoaJuridica);
            
            lstContas.Add(conta);
            DioBankForm_Load(sender,  e);
        }

        private void ckbDepositoInicial_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDepositoInicial.Checked)
            {
                mkdDepositoInicial.Enabled = true;
            }
            else
            { 
                mkdDepositoInicial.Clear();
                mkdDepositoInicial.Enabled = false;
            }
        }

        public void CarregaGrid()
        {
            


            dgvClientes.DataSource = lstContas;

            dgvClientes.Columns[0].Width = 180;
            dgvClientes.Columns[1].Width = 60;
            dgvClientes.Columns[2].Width = 60;
            dgvClientes.Columns[3].Width = 100;

            dgvClientes.Columns[3].HeaderText = "Tipo de Conta";
        }
    }
}
