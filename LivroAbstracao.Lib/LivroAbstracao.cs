using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivroAbstracao.Lib
{
    public class LivroAbstracao
    {
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public int QuantidadePaginas { get; set; }
        public string Idioma { get; set; }
        public string TipodeCapa { get; set; }

        public void Ler()
        {
            Console.WriteLine("Leitura efetuada !");
        }
        public void Traduzir()
        {
            Console.WriteLine("Livro traduzido !");
        }
        public void Guardar()
        {
            Console.WriteLine("Livro guardado !");
        }



    }
}
