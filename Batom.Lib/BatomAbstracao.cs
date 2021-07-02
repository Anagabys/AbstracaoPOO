using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batom.Lib
{
    public class BatomAbstracao
    {
        public string Marca { get; set; }

        public string Cor { get; set; }

        public string TipoCobertura { get; set; }

        public void PassarBatom()
        {
            Console.WriteLine("Passou batom !");
        }

        public void GuardarBatom()
        {
            Console.WriteLine("Guardou batom !");
        }
    }
}
