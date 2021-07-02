using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro.Lib
{
    public class LivroAbstracao
    {
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public int QuantidadePaginas { get; set; }
        public string Idioma { get; set; }
        public string TipodeCapa { get; set; }

        public string RetornaTitulo(string Titulo)
        {
            Console.Write("Qual o titulo do livro: ");
            Titulo = Console.ReadLine();
            Console.WriteLine("Titulo inserido: " + Titulo);
            return Titulo;

        }
        public string RetornaEditora(string Editora)
        {
            Console.Write("\nDigite o nome da editora: ");
            Editora = Console.ReadLine();
            Console.WriteLine("Editora inserida: " + Editora);
            return Editora;
        }
        public int RetornaQtdPaginas(int QuantidadePaginas)
        {
            Console.Write("\nDigite a quantidade de paginas: ");
            QuantidadePaginas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade de paginas inseridas" + QuantidadePaginas);
            return QuantidadePaginas;
        }
        public string RetornaIdioma(string Idioma)
        {
            Console.Write("\nQual o idoma do livro: ");
            Idioma = Console.ReadLine();
            Console.WriteLine("Idioma inserido: " + Idioma);
            return Idioma;
        }
        public string RetornaTipodeCapa(string TipodeCapa)
        {
            Console.Write("\nDigite o tipo de capa: Capa comum ou capa dura ?\n");
            TipodeCapa = Console.ReadLine();
            Console.WriteLine("Tipo de capa inserido: " + TipodeCapa);
            return TipodeCapa;
        }

        public void Ler()
        {
            Console.WriteLine("\nLeitura efetuada !");
        }
        public void Traduzir()
        {
            Console.WriteLine("\nLivro traduzido !");
        }
        public void Guardar()
        {
            Console.WriteLine("\nLivro guardado !");
        }



    }
}

