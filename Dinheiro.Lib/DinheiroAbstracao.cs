using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinheiro.Lib
{
    public class DinheiroAbstracao
    {
        public double Valor { get; set; }
        public string TipoDeMoedaFiduciaria { get; set; }
        public string TipoFisico { get; set; }
        public string Cor { get; set; }

        public double RetornaValor(double Valor)
        {
            Console.Write("Digite o valor da moeda: ");
            Valor = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor inserido: " + Valor);
            return Valor;
        }
        public string RetornaTipoDeMoedaFifuciaria(string TipoDeMoedaFiduciaria)
        {
            Console.Write("\nDigite o tipo da moeda: Dolar, Real, Euro, Peso, Libra, outras: ");
            TipoDeMoedaFiduciaria = Console.ReadLine();
            Console.WriteLine("Tipo de moeda inserido: " + TipoDeMoedaFiduciaria);
            return TipoDeMoedaFiduciaria;
        }

        public string RetornaTipoFisico(string TipoFisico)
        {
            Console.Write("\nDigite o tipo fisico da Moeda, papel ou moeda: ");
            TipoFisico = Console.ReadLine();
            Console.WriteLine("Tipo de moeda inserido: " + TipoFisico);
            return TipoFisico;
        }
        public string RetornaCor(string Cor)
        {
            Console.Write("\nDigite a cor da Moeda: ");
            Cor = Console.ReadLine();
            Console.WriteLine("Tipo de moeda inserido: " + Cor);
            return Cor;
        }
    }
}
