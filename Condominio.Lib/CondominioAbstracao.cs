using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condominio.Lib
{
    public class CondominioAbstracao
    {
        public string Endereco { get; set; }
        public int QtdDePredios { get; set; }
        public int QtdDeMoradores { get; set; }
        public string SindicoAdm { get; set; }


        public void RealizarReuniaoCondominio()
        {
            Console.WriteLine("\nReunião realizada !");
        }
        public void RealizarReforma()
        {
            Console.WriteLine("\nReforma realizada!");
        }
        public void TrocarSindicoAdm()
        {
            Console.WriteLine("\nNovo sindico escolhido !");
        }



    }
}
