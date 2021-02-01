using System;

namespace MestreDosCodigos.Escudeiro.POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Pessoa
            {
                Nome = "Fulano de Tal",
                DataNascimento = new DateTime(1992, 11, 18),
                Altura = 1.71
            };

            pessoa.ImprimirDados();
            Console.WriteLine("");
            pessoa.ImprimirIdade();
            Console.WriteLine("");

            var contaCorrente = new ContaCorrente("012345678-99", 500, 1.15);
            var contaCorrente2 = new ContaCorrente("423456413-99", 200, 1.5);
            contaCorrente.Depositar(1000);
            Console.WriteLine("");
            contaCorrente.MostrarDados();
            Console.WriteLine("");
            contaCorrente.Sacar(1500);
            Console.WriteLine("");
            contaCorrente.MostrarDados();
            Console.WriteLine("");
            contaCorrente.Sacar(contaCorrente.Saldo - contaCorrente.TaxaOperacao);
            Console.WriteLine("");
            contaCorrente.MostrarDados();
            Console.WriteLine("");
            contaCorrente2.Depositar(-100);
            Console.WriteLine("");
            contaCorrente2.MostrarDados();
            Console.WriteLine("");
            contaCorrente2.Sacar(300);
            Console.WriteLine("");
            contaCorrente2.MostrarDados();
            Console.WriteLine("");
            contaCorrente2.Sacar(contaCorrente2.Saldo - contaCorrente2.TaxaOperacao);
            Console.WriteLine("");
            contaCorrente2.MostrarDados();
            Console.WriteLine("");

            var contaEspecial = new ContaEspecial("987654321-00", 500, 1000);
            var contaEspecial2 = new ContaEspecial("227532465-00", 1000, 1500);
            contaEspecial.MostrarDados();
            Console.WriteLine("");
            contaEspecial.Sacar(1500);
            Console.WriteLine("");
            contaEspecial.MostrarDados();
            Console.WriteLine("");
            contaEspecial2.Depositar(5000);
            Console.WriteLine("");
            contaEspecial2.MostrarDados();
            Console.WriteLine("");
            contaEspecial2.Sacar(contaEspecial2.Saldo);
            Console.WriteLine("");
            contaEspecial2.MostrarDados();
            Console.WriteLine("");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            var controleRemoto = new ControleRemoto();
            var televisao = new Televisao(controleRemoto);
            ConsoleKey key;
            Console.WriteLine("Aperte + (NumPad) ou \"Seta para cima\" para aumentar o volume.");
            Console.WriteLine("Aperte - (NumPad ou \"Seta para baixo\" para diminuir o volume.");
            Console.WriteLine("Aperte ESC para finalizar o programa.");
            do
            {
                var read = Console.ReadKey(true);
                key = read.Key;
                switch(key)
                {
                    case ConsoleKey.Add:
                        controleRemoto.AumentarVolume();
                        break;
                    case ConsoleKey.UpArrow:
                        controleRemoto.AumentarVolume();
                        break;
                    case ConsoleKey.Subtract:
                        controleRemoto.DiminuirVolume();
                        break;
                    case ConsoleKey.DownArrow:
                        controleRemoto.DiminuirVolume();
                        break;
                }
            } while (key != ConsoleKey.Escape);
            Console.WriteLine("Volume da televisão ao fim do Prorama: {0}", televisao.Volume);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
