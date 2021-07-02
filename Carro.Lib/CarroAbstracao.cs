using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro.Lib
{
    public class CarroAbstracao
    {
        public int NumeroRenavan { get; set; }
        public int NumeroChassi { get; set; }
        public string Cor { get; set; }
        public int AnoFabricao { get; set; }
        public int AnoModelo { get; set; }
        public string Marca { get; set; }
        public string Nome { get; set; }
        public string NomeModelo { get; set; }


        public void Acelerar()
        {
            Console.WriteLine("Acelerou ...");
        }

        public void Abastecimento()
        {
            Console.WriteLine("Abasteceu...");
        }

        public void TrocarMarcha()
        {
            Console.WriteLine("Trocou de Marcha...");
        }
    }
}
