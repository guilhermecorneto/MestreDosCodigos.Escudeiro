using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MestreDosCodigos.Escudeiro
{
    interface Pessoa
    {

    }

    interface Membro
    {

    }
    class Aluno : Pessoa, Membro
    {
        public string Nome { get; set; }
        public List<double> Notas { get; set; } = new List<double>();

        public void AdicionarNota(double nota)
        {
            Notas.Add(nota);
        }

        public double ObterMedia()
        {
            if (Notas.Count == 0)
                return -1;
            return ((double)Notas.Sum()) / Notas.Count;
        }
    }
    class Program
    {
        static int index = 1;
        static string[] menu0 = new string[] {
            "(1) Teste 1 - Manipular A e B",
            "(2) Teste 2 - Verificar maior e menor entre N salários",
            "(3) Teste 3 - Imprimir todos os múltiplos de 3 entre 1 e 100",
            "(4) Teste 4 - Armazenar N alunos e suas notas",
            "(5) Teste 5 - Calcular Bhaskara",
            "(6) Teste 6 - Demonstração de uso de REF e OUT",
            "(7) Teste 7 - Somar os números pares",
            "(8) Teste 8 - Imprimir N número de forma crescente e decrescente",
            "(9) Teste 9 - Demonstração de uso do LINQ",
            "(10)Sair",
        };
        static string[] menu1 = new string[] {
            "(1) Somar valores (A + B)",
            "(2) Subtrair Valores (A - B)",
            "(3) Dividir B por A",
            "(4) Multiplicar A por B",
            "(5) Par ou Ímpar",
            "(6) Novos valores de A e B",
            "(7) Sair"
        };
        static string[] menu2 = new string[]
        {
            "(1) Nova lista de inteiros",
            "(2) Imprimir todos os números da lista",
            "(3) Imprimir todos os números da lista na ordem crescente",
            "(4) Imprimir todos os números da lista na ordem decrescente",
            "(5) Imprimir o primeiro número da lista",
            "(6) Imprimir o último número da lista",
            "(7) Inserir um número no início da lista",
            "(8) Insirir um número no final da lista",
            "(9) Remover o primeiro número",
            "(10) Remover o último número",
            "(11) Retornar apenas os números pares",
            "(12) Retornar apenas o número informado",
            "(13) Transformar todos os números da lista em um Array",
            "(14) Sair"
        };

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                opcao = Menu(menu0);
                ProcessarOpcao0(opcao);
            } while (opcao != 10);

        }

        private static void ProcessarOpcao0(int opcao)
        {
            Console.Clear();

            switch (opcao)
            {
                case 1:
                    double a, b;
                    Entrada(out a, out b);
                    int op1;
                    do
                    {
                        op1 = Menu(menu1);
                        ProcessarOpcao1(op1, ref a, ref b);

                    } while (op1 != 7);
                    break;
                case 2:
                    var i = 1;
                    List<Tuple<string, double>> funcionarios = new List<Tuple<string, double>>();
                    string nome = "";
                    while (nome != "0")
                    {
                        Console.Write($"Nome do {i}º funcionário: (digite 0 para finalizar a entrada):");
                        nome = Console.ReadLine();
                        nome = nome.Trim();
                        while (string.IsNullOrEmpty(nome))
                        {
                            Console.WriteLine("Entrada inválida!");
                            Console.WriteLine("");
                            Console.Write($"Nome do {i}º funcionário: (digite 0 para finalizar a entrada):");
                            nome = Console.ReadLine();
                            nome = nome.Trim();
                        }
                        if (nome != "0")
                        {
                            Console.Write("Salário:");
                            var e = Console.ReadLine();
                            double salario;
                            while (!double.TryParse(e, out salario))
                            {
                                Console.WriteLine("Entrada inválida!");
                                Console.WriteLine("");
                                Console.Write("Salário:");
                                e = Console.ReadLine();
                            }
                            funcionarios.Add(new Tuple<string, double>(nome, salario));
                            i++;
                            Console.Clear();
                        }
                    }
                    Console.Clear();
                    double maiorSalario = double.MinValue;
                    Tuple<string, double> maiorSalFunc = new Tuple<string, double>("", 0);
                    Tuple<string, double> menorSalFunc = new Tuple<string, double>("", 0);
                    double menorSalario = double.MaxValue;
                    for (var index = 0; index < funcionarios.Count; index++)
                    {
                        if (funcionarios[index].Item2 > maiorSalario)
                        {
                            maiorSalario = funcionarios[index].Item2;
                            maiorSalFunc = funcionarios[index];
                        }
                        if (funcionarios[index].Item2 < menorSalario)
                        {
                            menorSalario = funcionarios[index].Item2;
                            menorSalFunc = funcionarios[index];
                        }
                    }
                    Console.WriteLine("Funcionário com o maior salário: {0} | Salário: {1:C2}", maiorSalFunc.Item1, maiorSalFunc.Item2);
                    Console.WriteLine("Funcionário com o menor salário: {0} | Salário: {1:C2}", menorSalFunc.Item1, menorSalFunc.Item2);
                    Console.WriteLine("Aperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 3:
                    List<int> multiplosDeTres = new List<int>();
                    for (int index = 1; index <= 100; index++)
                        if (index % 3 == 0)
                            multiplosDeTres.Add(index);
                    Console.WriteLine(string.Join(" ,", multiplosDeTres));
                    Console.WriteLine("Aperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 4:
                    i = 1;
                    List<Aluno> alunos = new List<Aluno>();
                    do
                    {
                        Console.Write($"Nome do {i}º aluno: (digite 0 para finalizar a entrada):");
                        nome = Console.ReadLine();
                        nome = nome.Trim();
                        while (string.IsNullOrEmpty(nome))
                        {
                            Console.WriteLine("Entrada inválida!");
                            Console.WriteLine("");
                            Console.Write($"Nome do {i}º aluno: (digite 0 para finalizar a entrada):");
                            nome = Console.ReadLine();
                            nome = nome.Trim();
                        }
                        if (nome != "0")
                        {
                            var aluno = new Aluno();
                            aluno.Nome = nome;
                            string e;
                            double nota;
                            var notaI = 1;
                            do
                            {
                                Console.Write($"Nota {notaI} (digite x para finalizar a entrada):");
                                e = Console.ReadLine();
                                while (!double.TryParse(e, out nota) && e != "x" || double.TryParse(e, out nota) && nota < 0)
                                {
                                    Console.WriteLine("Entrada inválida!");
                                    Console.WriteLine("");
                                    Console.Write($"Nota {notaI} (digite x para finalizar a entrada):");
                                    e = Console.ReadLine();
                                }
                                if (e != "x")
                                {
                                    aluno.AdicionarNota(nota);
                                    Console.Clear();
                                    notaI++;
                                }
                            } while (e != "x");
                            Console.Clear();
                            alunos.Add(aluno);
                            i++;
                        }
                    } while (nome != "0");
                    Console.Clear();
                    foreach (var aluno in alunos)
                        if (aluno.ObterMedia() > 7)
                            Console.WriteLine("Aluno: {0} | Média: {1}", aluno.Nome, aluno.ObterMedia().ToString("N2"));
                    Console.WriteLine("Aperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 5:
                    double bA, bB, bC;
                    Console.WriteLine("Digite o valor de A: ");
                    var entrada = Console.ReadLine();
                    while (!double.TryParse(entrada, out bA))
                    {
                        Console.WriteLine("Entrada inválida!");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o valor de A:");
                        entrada = Console.ReadLine();
                    }
                    Console.WriteLine("Digite o valor de B: ");
                    entrada = Console.ReadLine();
                    while (!double.TryParse(entrada, out bB))
                    {
                        Console.WriteLine("Entrada inválida!");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o valor de B:");
                        entrada = Console.ReadLine();
                    }
                    Console.WriteLine("Digite o valor de C: ");
                    entrada = Console.ReadLine();
                    while (!double.TryParse(entrada, out bC))
                    {
                        Console.WriteLine("Entrada inválida!");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o valor de C:");
                        entrada = Console.ReadLine();
                    }
                    var delta = Math.Pow(bB, 2) - 4 * bA * bC;
                    var r1 = (-bB + Math.Sqrt(delta)) / (2 * bA);
                    var r2 = (-bB - Math.Sqrt(delta)) / (2 * bA);
                    Console.Clear();
                    Console.WriteLine("R1: {0}", r1);
                    Console.WriteLine("R2: {0}", r2);
                    Console.WriteLine("Aperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Ambos os comandos REF e OUT são usados ao passar variáveis simples como parâmetro, para garantir que o que é passado é a " +
                        "referência em memória da variável, e não somento o valor, dessa forma as ações do método que recebem o parâmetro que alterem o valor " +
                        "da variável, são refletidas fora do escopo do método. Os comentários no código dos métodos \"ProcessarOpcao1\"(ref) e \"Entrada\"(out) " +
                        "explicam as diferenças específicas");
                    Console.WriteLine("Aperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 7:
                    double pA, pB, pC, pD;
                    Console.WriteLine("Digite o valor de A: ");
                    entrada = Console.ReadLine();
                    while (!double.TryParse(entrada, out pA))
                    {
                        Console.WriteLine("Entrada inválida!");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o valor de A:");
                        entrada = Console.ReadLine();
                    }
                    Console.WriteLine("Digite o valor de B: ");
                    entrada = Console.ReadLine();
                    while (!double.TryParse(entrada, out pB))
                    {
                        Console.WriteLine("Entrada inválida!");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o valor de B:");
                        entrada = Console.ReadLine();
                    }
                    Console.WriteLine("Digite o valor de C: ");
                    entrada = Console.ReadLine();
                    while (!double.TryParse(entrada, out pC))
                    {
                        Console.WriteLine("Entrada inválida!");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o valor de C:");
                        entrada = Console.ReadLine();
                    }
                    Console.WriteLine("Digite o valor de D: ");
                    entrada = Console.ReadLine();
                    while (!double.TryParse(entrada, out pD))
                    {
                        Console.WriteLine("Entrada inválida!");
                        Console.WriteLine("");
                        Console.WriteLine("Digite o valor de D:");
                        entrada = Console.ReadLine();
                    }
                    double soma = 0;
                    if (pA % 2 == 0)
                        soma += pA;
                    if (pB % 2 == 0)
                        soma += pB;
                    if (pC % 2 == 0)
                        soma += pC;
                    if (pD % 2 == 0)
                        soma += pD;
                    Console.Clear();
                    Console.WriteLine("Soma dos pares: {0}", soma);
                    Console.WriteLine("Aperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 8:
                    List<double> valores = new List<double>();
                    do
                    {
                        Console.WriteLine("Digite um número qualquer (x para encenrrar a entrada):");
                        entrada = Console.ReadLine();
                        double numero;
                        while (!double.TryParse(entrada, out numero) && entrada != "x")
                        {
                            Console.WriteLine("Entrada inválida!");
                            Console.WriteLine("");
                            Console.WriteLine("Digite um número qualquer (x para encenrrar a entrada):");
                            entrada = Console.ReadLine();
                        }
                        if (entrada != "x")
                        {
                            valores.Add(numero);
                            Console.Clear();
                        }
                    } while (entrada != "x");
                    Console.WriteLine("Ordem crescente: {0}", string.Join(", ", valores.OrderBy(x => x)));
                    Console.WriteLine("Ordem crescente: {0}", string.Join(", ", valores.OrderByDescending(x => x)));
                    Console.WriteLine("Aperte qualquer tecla para continuar...");
                    Console.ReadKey();
                    break;
                case 9:
                    int op2;
                    List<int> lista;
                    EntradaList(out lista);
                    do
                    {
                        op2 = Menu(menu2);
                        ProcessarOpcao2(op2, lista);

                    } while (op2 != 14);
                    break;
            }
        }

        private static void ProcessarOpcao2(int op2, List<int> lista)
        {
            switch (op2)
            {
                case 1:
                    EntradaList(out lista);
                    break;
                case 2:
                    ImprimirLista(lista);
                    break;
                case 3:
                    ImprimirLista(lista.OrderBy(l => l).ToList());
                    break;
                case 4:
                    ImprimirLista(lista.OrderByDescending(l => l).ToList());
                    break;
                case 5:
                    Console.WriteLine(lista.First());
                    break;
                case 6:
                    Console.WriteLine(lista.Last());
                    break;
                case 7:
                    Console.WriteLine("Digite um número inteiro:");
                    var entrada = Console.ReadLine();
                    int numero;
                    while (!int.TryParse(entrada, out numero))
                    {
                        Console.WriteLine("Entrada inválida!");
                        Console.WriteLine("");
                        Console.WriteLine("Digite um número qualquer:");
                        entrada = Console.ReadLine();
                    }
                    lista.Insert(0, numero);
                    break;
                case 8:
                    Console.WriteLine("Digite um número inteiro:");
                    entrada = Console.ReadLine();
                    while (!int.TryParse(entrada, out numero))
                    {
                        Console.WriteLine("Entrada inválida!");
                        Console.WriteLine("");
                        Console.WriteLine("Digite um número qualquer:");
                        entrada = Console.ReadLine();
                    }
                    lista.Add(numero);
                    break;
                case 9:
                    if (lista.Count > 0)
                        lista.RemoveAt(0);
                    else
                        Console.WriteLine("Lista vazia!");
                    break;
                case 10:
                    if (lista.Count > 0)
                        lista.RemoveAt(lista.Count - 1);
                    else
                        Console.WriteLine("Lista vazia!");
                    break;
                case 11:
                    ImprimirLista(lista.Where(l => l % 2 == 0).ToList());
                    break;
                case 12:
                    Console.WriteLine("Digite um número inteiro:");
                    entrada = Console.ReadLine();
                    while (!int.TryParse(entrada, out numero))
                    {
                        Console.WriteLine("Entrada inválida!");
                        Console.WriteLine("");
                        Console.WriteLine("Digite um número qualquer:");
                        entrada = Console.ReadLine();
                    }
                    var i = lista.IndexOf(numero);
                    if (i < 0)
                        Console.WriteLine("Número não encontrado");
                    else
                        Console.WriteLine("Número {0} encontrado na posição {1}", numero, i);
                    break;
                case 13:
                    Console.WriteLine("Tipo da lista convertida: {0}", lista.ToArray().GetType());
                    break;
            }
            if (op2 != 14)
            {
                Console.WriteLine("Aperte qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private static void ImprimirLista(List<int> lista)
        {
            Console.WriteLine(string.Join(", ", lista));
        }

        private static void EntradaList(out List<int> lista)
        {
            string entrada;
            Console.Clear();
            lista = new List<int>();
            do
            {
                Console.WriteLine("Digite um número inteiro (x para encenrrar a entrada):");
                entrada = Console.ReadLine();
                int numero;
                while (!int.TryParse(entrada, out numero) && entrada != "x")
                {
                    Console.WriteLine("Entrada inválida!");
                    Console.WriteLine("");
                    Console.WriteLine("Digite um número qualquer (x para encenrrar a entrada):");
                    entrada = Console.ReadLine();
                }
                if (entrada != "x")
                {
                    lista.Add(numero);
                    Console.Clear();
                }
            } while (entrada != "x");
        }

        /*
         * Exemplo de utilização de REF
         * As variáveis a e b são recebidas por parâmetro com o modificador ref e são utilizadas imediatamente, sem serem atribuídas antes.
         * Isso é possível por que o ref presume que a variável já foi atribuída antes, então possui valor para ser manipulado
         */
        private static void ProcessarOpcao1(int opcao, ref double a, ref double b)
        {
            Console.WriteLine("");
            Console.WriteLine("");

            switch (opcao)
            {
                case 1: Console.WriteLine("A + B = " + (a + b)); break;
                case 2: Console.WriteLine("A - B = " + (a - b)); break;
                case 3: Console.WriteLine("B / A = " + (b / a)); break;
                case 4: Console.WriteLine("A x B = " + (a * b)); break;
                case 5:
                    Console.WriteLine("A é " + ParOuImpar(a));
                    Console.WriteLine("B é " + ParOuImpar(b));
                    break;
                case 6:
                    Console.Clear();
                    Entrada(out a, out b);
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("");
            if (opcao != 7)
            {
                Console.WriteLine("Aperte qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        private static string ParOuImpar(double valor)
        {
            return valor % 2 == 0 ? "PAR" : "ÍMPAR";
        }

        /*
         * Exemplo de utilização de OUT
         * As variáveis a e b são recebidas por parâmetro com o modificador out não podem ser utilizadas até receberem uma atribuição.
         * Isso acontece por que o out NÃO presume que a variável já foi atribuída antes, então não permite a manipulação dos seus valores
         */
        private static void Entrada(out double a, out double b)
        {
            string entrada;

            Console.WriteLine("Digite o valor de A (aperte enter para confirmar o valor).");
            entrada = Console.ReadLine();

            //var x = a + b; //Essa linha causaria erro de compilação por estar usando os valores de a e b sem uma atribuição antes

            while (!double.TryParse(entrada, out a)) //primeira atribuição de a
            {
                Console.WriteLine("Entrada inválida!");
                Console.WriteLine("");
                Console.WriteLine("Digite o valor de A (aperte enter para confirmar o valor).");
                entrada = Console.ReadLine();
            }

            Console.WriteLine("Digite o valor de B (aperte enter para confirmar o valor).");
            entrada = Console.ReadLine();

            while (!double.TryParse(entrada, out b)) //primeira atribuição de b
            {
                Console.WriteLine("Entrada inválida!");
                Console.WriteLine("");
                Console.WriteLine("Digite o valor de B (aperte enter para confirmar o valor).");
                entrada = Console.ReadLine();
            }

            var y = a + b; //Essa linha não causa erro de compilação, pois a e b já tiveram sua primeira atribuição
        }

        private static int Menu(string[] ops)
        {
            int numOp = ops.Length;
            index = 0;
            ConsoleKeyInfo tecla;
            do
            {
                Console.Clear();

                for (int i = 1; i <= numOp; i++)
                    EscreverLinhaDeMenu(i, index, ops);

                tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    case ConsoleKey.UpArrow: index--; break;
                    case ConsoleKey.DownArrow: index++; break;
                    case ConsoleKey.Escape: index = 0; break;
                }
                if (index > numOp)
                    index = 1;
                else if (index < 1)
                    index = numOp;
            } while (tecla.Key != ConsoleKey.Enter);

            return index;
        }

        private static void EscreverLinhaDeMenu(int i, int index, string[] ops)
        {
            if (i == index)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine(ops[i - 1]);


            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
