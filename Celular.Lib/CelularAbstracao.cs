using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celular.Lib
{
    public class CelularAbstracao
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string CorAparelho { get; set; }
        public string SistemaOperacional { get; set; }
        public int MemoriaRam { get; set; }

        public string RetornaMarca(string Marca)
        {
            Console.Write("Digite a marca do celular: ");
            Marca = Console.ReadLine();
            Console.WriteLine("Marca inserida: " + Marca);
            return Marca;
        }
        public string RetornaModelo(string Modelo)
        {
            Console.Write("\nDigite o modelo do celular: ");
            Modelo = Console.ReadLine();
            Console.WriteLine("Modelo inserido: " + Modelo);
            return Modelo;
        }
        public string RetornaCor(string Cor)
        {
            Console.Write("\nDigite a cor do celular: ");
            Cor = Console.ReadLine();
            Console.WriteLine("Cor inserida: " + Cor);
            return Cor;
        }
        public string RetornaSistemaOperacional(string SistemaOperacional)
        {
            Console.Write("\nDigite o Sistema Operacional do celular: ");
            SistemaOperacional = Console.ReadLine();
            Console.WriteLine("Sistema Operacional inserido: " + SistemaOperacional);
            return SistemaOperacional;

        }
        public int RetornaMemoriaRam (int MemoriaRam)
        {
            Console.Write("\nDigite a capacidade de memória RAM do celular: ");
            MemoriaRam = int.Parse(Console.ReadLine());
            Console.WriteLine("Capacidade de memória RAM inserida: " + MemoriaRam);
            return MemoriaRam;
        }

        public void Ligar()
        {
            Console.WriteLine("\nCelular ligado !");
        }
        public void EnviarMensagem()
        {
            Console.WriteLine("\nMensagem enviada !");
        }
        public void EfetuarLigacao()
        {
            Console.WriteLine("\nLigação efetuada !");
        }
        public void TirarFoto()
        {
            Console.WriteLine("\nFoto efetuada !");
        }
        public void UsarCalendario()
        {
            Console.WriteLine("\nCalendário aberto !");
        }
        
    }
}
