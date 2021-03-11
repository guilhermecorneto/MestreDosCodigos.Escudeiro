using System;
using System.Collections.Generic;
using System.Text;

namespace MestreDosCodigos.Escudeiro.POO
{
    public abstract class ContaBancaria
    {
        public string NumeroConta { get; private set; }
        public double Saldo { get; protected set; }

        public ContaBancaria(string numeroConta, double saldoInicial)
        {
            Saldo = saldoInicial;
            NumeroConta = numeroConta;
        }

        public virtual bool Depositar(double deposito)
        {
            if (deposito < 0)
            {
                Console.WriteLine("Não é possível fazer um deposito negativo!");
                return false;
            }
            else
            {
                Saldo += deposito;
                return true;
            }
        }

        public virtual bool Sacar(double saque)
        {
            if (saque < 0)
            {
                Console.WriteLine("Não é possível fazer um saque negativo!");
                return false;
            }
            else if (Saldo < saque)
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            else
            {
                Saldo -= saque;
                return true;
            }
        }
    }
}
