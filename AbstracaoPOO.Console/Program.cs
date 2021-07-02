using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carro.Lib;
using Batom.Lib;
using Pessoa.Lib;
using Livro.Lib;
using Computador.Lib;
using Celular.Lib;
using Armario.Lib;
using Dinheiro.Lib;
using ContaBancaria.Lib;
using Condominio.Lib;

namespace AbstracaoPOO.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            int opcao = 0;
            System.Console.Clear();
            System.Console.WriteLine("Escolha o projeto de abstração para executar.\n");
            System.Console.WriteLine("1 - Carro. \n");
            System.Console.WriteLine("2 - Batom. \n");
            System.Console.WriteLine("3 - Pessoa. \n");
            System.Console.WriteLine("4 - Livro. \n");
            System.Console.WriteLine("5 - Computador. \n");
            System.Console.WriteLine("6 - Celular. \n");
            System.Console.WriteLine("7 - Armario. \n");
            System.Console.WriteLine("8 - Dinheiro. \n");
            System.Console.WriteLine("9 - Conta Bancaria. \n");
            System.Console.WriteLine("10 - Condominio. \n");
            System.Console.Write("Digite a opção desejada: ");

            opcao = int.Parse(System.Console.ReadLine());

            if (opcao == 1)
                ExecutarCarroAbstracao();

            if (opcao == 2)
                ExecutarBatomAbstracao();

            if (opcao == 3)
                ExecutarPessoaAbstracao();
            if (opcao == 4)
                ExecutarLivroAbstracao();
            if (opcao == 5)
                ExecutarComputadorAbstracao();
            if (opcao == 6)
                ExecutarCelularAbstracao();
            if (opcao == 7)
                ExecutarAbstracaoArmario();
            if (opcao == 8)
                ExecutarDinheiroAbstracao();
            if (opcao == 9)
                ExecutarContaBancariaAbstracao();
            if (opcao == 10)
                ExecutarCondominioAbstracao();

        }
        public static void ExecutarCarroAbstracao()
        {
            System.Console.Clear();
            CarroAbstracao oCarro = new CarroAbstracao();

            oCarro.AnoFabricao = 2013;
            oCarro.AnoModelo = 2013;
            oCarro.Cor = "Preto";
            oCarro.Marca = "Mitsubishi";
            oCarro.Nome = "Lancer";
            oCarro.NumeroChassi = 3445;
            oCarro.NumeroRenavan = 772663;
            oCarro.NomeModelo = "GT AWD 2.0 CVT Automatica";

            oCarro.Acelerar();
            oCarro.Abastecimento();
            oCarro.TrocarMarcha();

            System.Console.ReadKey();
            Menu();
        }
        public static void ExecutarBatomAbstracao()
        {
            System.Console.Clear();
            BatomAbstracao oBatom = new BatomAbstracao();

            oBatom.Cor = "Rosa";
            oBatom.Marca = "Vult";
            oBatom.TipoCobertura = "Mate";
            oBatom.PassarBatom();
            oBatom.GuardarBatom();

            System.Console.ReadKey();
            Menu();
        }
        public static void ExecutarPessoaAbstracao()
        {
            System.Console.Clear();
            PessoaAbstracao aPessoa = new PessoaAbstracao();

            aPessoa.RetornaNome("");
            aPessoa.RetornaIdade(aPessoa.Idade);
            aPessoa.RetornaSexo("");
            aPessoa.RetornaAltura(aPessoa.Altura);
            aPessoa.RetornaProfissao("");
            aPessoa.RetornaSigno("");
            aPessoa.Andar();
            aPessoa.Falar();
            aPessoa.Comer();
            aPessoa.Estudar();

            System.Console.ReadKey();
            Menu();

        }
        public static void ExecutarLivroAbstracao()
        {
            System.Console.Clear();
            LivroAbstracao oLivro = new LivroAbstracao();

            oLivro.RetornaTitulo("");
            oLivro.RetornaEditora("");
            oLivro.RetornaIdioma("");
            oLivro.RetornaTipodeCapa("");
            oLivro.RetornaQtdPaginas(oLivro.QuantidadePaginas);
            oLivro.Traduzir();
            oLivro.Ler();
            oLivro.Guardar();

            System.Console.ReadKey();
            Menu();

        }
        public static void ExecutarComputadorAbstracao()
        {
            System.Console.Clear();
            ComputadorAbstracao oComputador = new ComputadorAbstracao();

            oComputador.Ligar();
            oComputador.RetornaTipo("");
            oComputador.RetornaMarca("");
            oComputador.RetornaSistemaOperacional("");
            oComputador.RetornaCapacidadeHD(oComputador.CapacidadeHD);
            oComputador.AcessarInternet();
            oComputador.Desligar();

            System.Console.ReadKey();
            Menu();
        }
        public static void ExecutarCelularAbstracao()
        {
            System.Console.Clear();
            CelularAbstracao oCelular = new CelularAbstracao();

            oCelular.RetornaMarca("");
            oCelular.RetornaModelo("");
            oCelular.RetornaSistemaOperacional("");
            oCelular.RetornaMemoriaRam(oCelular.MemoriaRam);
            oCelular.RetornaCor("");
            oCelular.Ligar();
            oCelular.EnviarMensagem();
            oCelular.EfetuarLigacao();
            oCelular.TirarFoto();

            System.Console.ReadKey();
            Menu();

        }
        public static void ExecutarAbstracaoArmario()
        {
            System.Console.Clear();
            ArmarioAbstracao oArmario = new ArmarioAbstracao();

            oArmario.MarcaFabricante= "Veneza";
            oArmario.QuantidadeGavetas = 4;
            oArmario.QuantidadePortas = 6;
            oArmario.Largura = 1.90;
            oArmario.Altura = 1.55;
            oArmario.Cor = "Branco";
            oArmario.AbrirGaveta();
            oArmario.AbrirPorta();
            oArmario.GuardarPertences();

            System.Console.ReadKey();
            Menu();

        }
        public static void ExecutarDinheiroAbstracao()
        {
            System.Console.Clear();
            DinheiroAbstracao oDinheiro = new DinheiroAbstracao();

            oDinheiro.RetornaValor(oDinheiro.Valor);
            oDinheiro.RetornaTipoDeMoedaFifuciaria(oDinheiro.TipoDeMoedaFiduciaria);
            oDinheiro.RetornaTipoFisico("");
            oDinheiro.RetornaCor("");

            System.Console.ReadKey();
            Menu();
        }
        public static void ExecutarContaBancariaAbstracao()
        {
            System.Console.Clear();
            ContaBancariaAbstracao ContaBancaria = new ContaBancariaAbstracao();

            ContaBancaria.RetornaTitularDaConta("");
            ContaBancaria.RetornaNumConta(ContaBancaria.NumDaConta);
            ContaBancaria.RetornaNumDaAgencia(ContaBancaria.NumDaAgencia);
            ContaBancaria.RetornaNomeAgencia(ContaBancaria.NomeAgencia);

            System.Console.Clear();
            int op;
            System.Console.WriteLine("Selecione a opção desejada:\n1- Saques \n2- Depósitos.");
            op = int.Parse(System.Console.ReadLine());
            System.Console.Clear();
            if (op == 1)
            {
                ContaBancaria.Sacar(ContaBancaria.SaldoDaConta);
            }
            else
            {
                if(op==2)
                {
                    ContaBancaria.Depositar(ContaBancaria.ValorDeposito);
                }
            }

                
            System.Console.ReadKey();
            Menu();
        }
        public static void ExecutarCondominioAbstracao()
        {
            System.Console.Clear();

            CondominioAbstracao oCondominio = new CondominioAbstracao();

            oCondominio.Endereco = "Rua Javari, 91";
            oCondominio.QtdDeMoradores = 500;
            oCondominio.SindicoAdm = "Marcelo";
            oCondominio.QtdDePredios = 10;
            oCondominio.RealizarReuniaoCondominio();
            oCondominio.RealizarReforma();
            oCondominio.TrocarSindicoAdm();

            System.Console.ReadKey();
            Menu();
        }
            


    }
}
