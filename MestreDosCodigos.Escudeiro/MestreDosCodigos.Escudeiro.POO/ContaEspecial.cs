using System;

namespace MestreDosCodigos.Escudeiro.POO
{
    public class ContaEspecial : ContaBancaria, IImprimivel
    {
        public double Limite { get; private set; }

        public ContaEspecial(string numeroConta, double saldoInicial, double limite) : base(numeroConta, saldoInicial)
        {
            Limite = limite;
        }

        public override bool Sacar(double saque)
        {
            if (saque < 0)
            {
                Console.WriteLine("Não é possível fazer um saque negativo!");
                return false;
            }
            else if (Saldo + Limite < saque)
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

        public void MostrarDados()
        {
            Console.WriteLine($"Número da conta: {NumeroConta}\r\nSaldo: {Saldo:C2}\r\nLimite: {Limite:C2}");
        }
    }
}
