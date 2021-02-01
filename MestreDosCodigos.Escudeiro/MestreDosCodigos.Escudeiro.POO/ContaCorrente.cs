using System;

namespace MestreDosCodigos.Escudeiro.POO
{
    public class ContaCorrente : ContaBancaria, IImprimivel
    {
        public double TaxaOperacao { get; private set; }

        public ContaCorrente(
            string numeroConta,
            double saldoInicial,
            double taxaOperacao
            ) : base(numeroConta, saldoInicial)
        {
            TaxaOperacao = taxaOperacao;
        }

        public new bool Depositar(double deposito)
        {
            if (base.Depositar(deposito))
            {
                Saldo -= TaxaOperacao;
                return true;
            }
            return false;
        }

        public new bool Sacar(double saque)
        {
            if (saque < 0)
            {
                Console.WriteLine("Não é possível fazer um saque negativo!");
                return false;
            }
            else if (Saldo < (saque + TaxaOperacao))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            else
            {
                Saldo -= saque + TaxaOperacao;
                return true;
            }
        }

        public void MostrarDados()
        {
            Console.WriteLine($"Número da conta: {NumeroConta}\r\nSaldo: {Saldo:C2}\r\nTaxa de Õperação: {TaxaOperacao:C2}");
        }
    }
}
