using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armario.Lib
{
    public class ArmarioAbstracao
    {
        public string MarcaFabricante { get; set; }
        public string Cor { get; set; }
        public int QuantidadePortas { get; set; }
        public int QuantidadeGavetas { get; set; }
        public double Altura { get; set; }
        public double Largura { get; set; }

        public void AbrirPorta()
        {
            Console.WriteLine("\nPortas abertas !");
        }
        public void AbrirGaveta()
        {
            Console.WriteLine("\nGavetas Abertas !");
        }
        public void GuardarPertences()
        {
            Console.WriteLine("\nPertences guardados !");
        }
    }
}
