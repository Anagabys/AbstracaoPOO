using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Lib
{
    public class ContaBancariaAbstracao
    {
        public string TitularDaConta { get; set; }
        public int NumDaConta { get; set; }
        public int NumDaAgencia { get; set; }
        public string NomeAgencia { get; set; }
        public double SaldoDaConta { get; set; }
        public double ValorDeposito { get; set; }

        int NumDaconta;

        public string RetornaTitularDaConta(string TitularDaConta)
        {
            Console.WriteLine("Digite o nome do titular da conta: ");
            TitularDaConta = Console.ReadLine();
            return TitularDaConta;
        }

        public int RetornaNumConta(int NumeroDaConta)
        {
            
            Console.WriteLine("Digite o número da conta: ");
            NumDaconta = int.Parse(Console.ReadLine());
            return NumDaconta;
        }
        public int RetornaNumDaAgencia(int NumDaAgencia)
        {
            Console.WriteLine("Digite o número da agencia: ");
            NumDaAgencia = int.Parse(Console.ReadLine());
            return NumDaAgencia;
        }
        public string RetornaNomeAgencia(string NomeAgencia)
        {
            Console.WriteLine("Digite o nome da agencia: ");
            NomeAgencia = Console.ReadLine();
            return NomeAgencia;
        }


        public double Sacar(double SaldoDaConta)
        {
            int op;
            double SaldoDisponivel = 500;
            double ValorDoSaque;
            Console.WriteLine("Digite o valor que deseja sacar: ");
            ValorDoSaque = double.Parse(Console.ReadLine());

            if ((ValorDoSaque == SaldoDisponivel) || (ValorDoSaque < SaldoDisponivel))
            {
                SaldoDaConta = SaldoDisponivel -= ValorDoSaque;

                Console.WriteLine("Saque realizado com sucesso !");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Deseja consultar Valor disponivel na sua conta bancária após saque ?\n1- SIM    2- NÃO ");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("\nSaldo disponivel na conta: " + SaldoDaConta);

                }

            }
            else
            {
                Console.WriteLine("\nNão foi possivel efetuar a operação, valor desejado não está disponivel !\n");
                Console.WriteLine("\nDeseja consultar Valor disponivel na sua conta bancária para saque?\n1- SIM    2- NÃO ");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("\nSaldo disponivel na conta: " + SaldoDisponivel);

                }
            }
            return SaldoDaConta;
        }
        public double Depositar(double ValorDep)
        {
            
            double ValorDepositado, SaldoComDeposito;
            string NomeTitularDeposito, NomeAgenciaDeposito;
            int NumContaDeposito, NumAgenciaDeposito;
            double SaldoDisponivel = 500;
            
            Console.WriteLine("Digite o nome do titular da conta para deposito:");
            NomeTitularDeposito = Console.ReadLine();
            Console.WriteLine("Digite o número da conta para deposito:");
            NumContaDeposito = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero da agencia para deposito: ");
            NumAgenciaDeposito = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da agencia para deposito:");
            NomeAgenciaDeposito = Console.ReadLine();

            Console.WriteLine("Qual o valor do deposito ?");
            ValorDepositado = double.Parse(Console.ReadLine());

            if (NumContaDeposito==NumDaconta)
            {
                SaldoComDeposito = SaldoDisponivel + ValorDepositado;
                Console.WriteLine("Saldo total disponivel em conta: " + SaldoComDeposito);
                return SaldoComDeposito;
            }
            else
            {
                Console.WriteLine("Recebedor: " + NomeTitularDeposito);
                Console.WriteLine("Saldo disponivel em conta: " + ValorDepositado);
                return ValorDepositado;
            }

        }
    }
}
