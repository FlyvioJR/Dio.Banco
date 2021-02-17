using DIO.Banco.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Banco.Entidades
{
    class Conta
    {
        [Display(Name = "Nome")]
        public string Nome { get; private set; }
        [Display(Name = "Saldo")]
        
        public double Saldo { get; private set; }
        [Display(Name = "Credito")]

        public double Credito { get; private set; }

        [Display(Name = "Tipo de Conta")]
        public TipoConta TipoConta { get; private set; }

        public int Id { get; private set; }

        public Conta() 
        {
        }

        public Conta(string nome, double saldo, double credito, TipoConta tipoConta, int id)
        {
            Saldo = saldo;
            Credito = credito;
            Nome = nome;
            TipoConta = tipoConta;
            Id = id;
        }

        public bool Sacar(double valorSaque)
        {
            if (Saldo - valorSaque < (Credito * -1))
            {
                return false;
            }
            Saldo -= valorSaque;
            return true;
        }

        public bool Depositar(double valorDeposito)
        {
            if (valorDeposito > 0)
            {
                Saldo += valorDeposito;
                return true;
            }
            else
                return false;
        }

        public bool DepositarParaBeneficiario(double valorDeposito, Conta contaBeneficiado)
        {
            if (valorDeposito > 0)
            {
                contaBeneficiado.Saldo += valorDeposito;
                return true;
            }
            else
                return false;
        }

        public bool Tranferir(double valorTransferencia, Conta contaDestino)
        {
            if (Sacar(valorTransferencia))
                return contaDestino.Depositar(valorTransferencia);
            return false;
        }

        public Conta BuscarContaPorId(List<Conta> lstContas, int id)
        {
            return lstContas.Find(x => x.Id == id);
        }
    }
}
