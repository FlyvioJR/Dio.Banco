﻿using DIO.Banco.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.Banco.Entidades
{
    class Conta
    {
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }

        private TipoConta TipoConta { get; set; }

        public Conta(double saldo, double credito, string nome, TipoConta tipoConta)
        {
            Saldo = saldo;
            Credito = credito;
            Nome = nome;
            TipoConta = tipoConta;
        }

        public bool Sacar(double valorSaque)
        {
            if (Saldo - valorSaque < (Credito * -1))
            {
                Console.WriteLine("Saldo Insuficiente!");
                return false;
            }
            Saldo -= valorSaque;
            Console.WriteLine($"Saque realizado com sucesso! O seu saldo é {Saldo}");
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            if (valorDeposito > 0)
            {
                Saldo += valorDeposito;
                Console.WriteLine($"Valor depositado com sucesso! O seu saldo é {Saldo}");
            }
            else
                Console.WriteLine($"Valor incorreto! Por favor tente novamente.");
        }

        public void Tranferir(double valorTransferencia, Conta contaDestino)
        {
            if (Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }
    }
}
