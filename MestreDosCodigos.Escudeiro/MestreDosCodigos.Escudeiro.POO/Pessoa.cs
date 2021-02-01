using System;
using System.Collections.Generic;
using System.Text;

namespace MestreDosCodigos.Escudeiro.POO
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Altura { get; set; }

        public void ImprimirDados()
        {
            Console.WriteLine($"Nome: {Nome}\r\nData de Nascimento: {DataNascimento:dd/MM/yyyy}\r\nAltura: {Altura:N2}m");
        }

        public void ImprimirIdade()
        {
            var idade = DateTime.Now.Year - DataNascimento.Year;
            if (DateTime.Now.Month < DataNascimento.Month || DateTime.Now.Day < DataNascimento.Day)
                idade--;
            Console.WriteLine(idade);
        }
    }
}
