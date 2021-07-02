using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pessoa.Lib;

namespace Pessoa.Lib
{
    public class PessoaAbstracao
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public float Altura { get; set; }
        public string Profissao { get; set; }
        public string Signo { get; set; }

        public string RetornaNome(string Nome)
        {
            Console.Write("Digite seu nome:");
            Nome = Console.ReadLine();
            Console.WriteLine("Nome inserido: " + Nome);
            return Nome;
        }
        public int RetornaIdade(int Idade)
        {
            Console.Write("\nDigite sua idade: ");
            Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Idade inserida: " + Idade);
            return Idade;
        }
        public string RetornaSexo(string Sexo)
        {
            Console.Write("\nDigite F para sexo feminino, e M para sexo masculino: ");
            Sexo = Console.ReadLine();
            Console.WriteLine("Sexo inserido: " + Sexo);
            return Sexo;
        }
        public float RetornaAltura(float Altura)
        {
            Console.Write("\nDigite sua altura: ");
            Altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Altura inserida: " + Altura);
            return Altura;
        }
        public string RetornaProfissao(string Profissao)
        {
            Console.Write("\nDigite sua profissão: ");
            Profissao = Console.ReadLine();
            Console.WriteLine("Profissão inserida: " + Profissao);
            return Profissao;
        }
        public string RetornaSigno(string Signo)
        {
            Console.Write("\nDigite seu signo solar: ");
            Signo = Console.ReadLine();
            Console.WriteLine("Signo inserido: " + Signo);
            return Signo;
        }

        public void Andar()
        {
            Console.WriteLine("\nAndou !");

        }
        public void Falar()
        {
            Console.WriteLine("\nFalou !");
        }

        public void Comer()
        {
            Console.WriteLine("\nComeu !");

        }
        public void Estudar()
        {
            Console.WriteLine("\nEstudou !");
        }
    }
}
