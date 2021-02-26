using System;

namespace CadastroEmMemoria.Dio
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            //Apresentará erro pois não pode inicializar um objeto abstrato.
            // EntidadeBase minhaClasse = new EntidadeBase();

            //Solução é utilizar uma entidade que herda da EntidadeBase.
            // Serie serie = new Serie();
            string opcaoUsuario = ObterOpcaoUsuario();

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
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();

        }

        private static void Depositar()
        {
            throw new NotImplementedException();
        }

        private static void Sacar()
        {
            throw new NotImplementedException();
        }

        private static void Transferir()
        {
            throw new NotImplementedException();
        }

        private static void InserirConta()
        {
            throw new NotImplementedException();
        }

        private static void ListarContas()
        {
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                System.Console.WriteLine("Nenhuma série cadastrada.");
                return;
            }
            foreach (var Serie in lista)
            {
                System.Console.WriteLine("#ID {0}: - {1}", Serie.retornaId(), Serie.retornaTitulo());
            }
        }

        private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("DIO Séries a seu dispor!!!");
            System.Console.WriteLine("Informe a opção desejada:");
            System.Console.WriteLine("1 - Listar séries");
            System.Console.WriteLine("2 - Inserir nova série");
            System.Console.WriteLine("3 - Atualizar série");
            System.Console.WriteLine("4 - Excluir série");
            System.Console.WriteLine("5 - Visualizar série");
            System.Console.WriteLine("C - Limpar Tela");
            System.Console.WriteLine("X - Sair");
            System.Console.WriteLine();
            string opcaoUsuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return opcaoUsuario;
        }


    }
}
