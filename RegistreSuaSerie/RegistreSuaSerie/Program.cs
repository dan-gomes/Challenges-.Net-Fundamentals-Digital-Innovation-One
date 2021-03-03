using System;

namespace RegistreSuaSerie
{
    public class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        VisualizarSerie();
                        break;
                    case "3":
                        CadastrarSerie();
                        break;
                    case "4":
                        ExcluirSerie();
                        break;
                    case "5":
                        EditarSerie();
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

        private static void EditarSerie()
        {
            throw new NotImplementedException();
        }

        private static void ExcluirSerie()
        {
            throw new NotImplementedException();
        }

        private static void CadastrarSerie()
        {
            throw new NotImplementedException();
        }

        private static void VisualizarSerie()
        {
            throw new NotImplementedException();
        }

        private static void ListarSeries()
        {
            throw new NotImplementedException();
        }

        private static string ObterOpcaoUsuario()
        {           
            Console.WriteLine();
            Console.WriteLine("#RegistreSuaSerie\r\n");            
            Console.WriteLine(
                 "Informe a opção desejada: \r\n" 
                + "1 - Listar séries \r\n" 
                + "2 - Inserir nova série \r\n" 
                + "3 - Atualizar série \r\n" 
                + "4 - Excluir série \r\n" 
                + "5 - Visualizar série \r\n" 
                + "C - Limpar Tela \r\n" 
                + "X - Sair");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
