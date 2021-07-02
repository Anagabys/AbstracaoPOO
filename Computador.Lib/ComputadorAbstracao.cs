using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computador.Lib
{
    public class ComputadorAbstracao
    {
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string SistemaOperacional { get; set; }
        public int CapacidadeHD { get; set; }

        
        public string RetornaTipo(string Tipo)
        {
            Console.Write("\nDigite o tipo de computador: Notebook ou de Mesa ?\n");
            Tipo = Console.ReadLine();
            Console.WriteLine("Tipo inserido: " + Tipo);
            return Tipo;
        }

        public string RetornaMarca(string Marca)
        {
            Console.Write("\nDigite a marca do computador: ");
            Marca = Console.ReadLine();
            Console.WriteLine("Marca inserida: " + Marca);
            return Marca;

        }
        public string RetornaSistemaOperacional(string SistemaOperacional)
        {
            Console.Write("\nDigite o Sistema Operacional do computador: ");
            SistemaOperacional = Console.ReadLine();
            Console.WriteLine("Sistema Operacional: " + SistemaOperacional);
            return SistemaOperacional;

        }
        public int RetornaCapacidadeHD(int CapacidadeHD)
        {
            Console.Write("\nDigite a capacidade do HD do computador: ");
            CapacidadeHD = int.Parse( Console.ReadLine());
            Console.WriteLine("Capacidade do HD: " + CapacidadeHD);
            return CapacidadeHD;

        }

        public void Ligar()
        {
            Console.WriteLine("Computador Ligado !");
        }

        public void AcessarInternet()
        {
            Console.WriteLine("\nAcessou internet !");

        }
        public void Desligar()
        {
            Console.WriteLine("\nComputador desligado !");

        }


    }
}
