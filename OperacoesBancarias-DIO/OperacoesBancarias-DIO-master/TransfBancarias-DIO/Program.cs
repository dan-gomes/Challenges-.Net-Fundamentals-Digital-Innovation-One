using System;
using System.Collections.Generic;
using TransfBancarias_DIO.Entidades;
using TransfBancarias_DIO.Enumeradores;

namespace TransfBancarias_DIO
{
    public class Program
    {
        static List<Conta> listaContas = new List<Conta>();
        static void Main(string[] args)
        {
            string opcaoUsuario = ListarOpcoesUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Transferir();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;

                    default: throw new ArgumentNullException();

                }
                opcaoUsuario = ListarOpcoesUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }

        private static void Depositar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser depositado: ");
            double valorDepositado = double.Parse(Console.ReadLine());

            listaContas[indiceConta].Depositar(valorDepositado);
        }

        private static void Sacar()
        {
            Console.WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser sacado: ");
            double valorSacado = double.Parse(Console.ReadLine());

            listaContas[indiceConta].Sacar(valorSacado);
        }

        private static void Transferir()
        {
            Console.WriteLine("Digite o número da conta de origem: ");
            int indiceContaOrigem = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da de destino: ");
            int indiceContaDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor a ser transferido: ");
            double valorTransferencia = double.Parse(Console.ReadLine());
            listaContas[indiceContaOrigem].Transferir(valorTransferencia, listaContas[indiceContaDestino]);
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova conta");
            Console.WriteLine("Digite 1 para Conta Física ou 2 para Jurídica: ");
            int tipoConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Nome do Cliente: ");
            string nomeCliente = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial: ");
            double saldoInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o crédito: ");
            double creditoInicial = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(nome: nomeCliente,
                                        tipoConta: (TipoConta)tipoConta,
                                        saldo: saldoInicial,
                                        credito: creditoInicial);
            listaContas.Add(novaConta);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Listar contas");
            if (listaContas.Count == 0)
            {
                Console.WriteLine("Nenhuma conta encontrada.");
                return;
            }
            for (int i = 0; i < listaContas.Count; i++)
            {
                Conta conta = listaContas[1];
                Console.Write("#{0} - ",i);
                Console.WriteLine(conta);
            }
        }

        private static string ListarOpcoesUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("TransfBancarias-Dio a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Listar contas");
            Console.WriteLine("2 - Inserir nova conta");
            Console.WriteLine("3 - Transferir");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();
            var opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return opcaoUsuario;
        }
    }
}
