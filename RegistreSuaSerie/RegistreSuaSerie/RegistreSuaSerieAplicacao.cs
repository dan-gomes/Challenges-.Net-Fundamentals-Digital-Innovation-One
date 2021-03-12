using RegistreSuaSerie.Classes;
using RegistreSuaSerie.Classes.Enum;
using RegistreSuaSerie.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RegistreSuaSerie
{
    public class RegistreSuaSerieAplicacao : IRegistreSuaSerie
    {
        private readonly ISeriesRepositorio _seriesRepositorio;

        public RegistreSuaSerieAplicacao(ISeriesRepositorio seriesRepositorio)
        {
            _seriesRepositorio = seriesRepositorio;
        }

        public void Execute()
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

                    default: throw new ArgumentNullException("Campo informado é inválido, reinciei a aplicação");

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

        private void CadastrarSerie()
        {            
            Console.WriteLine("Informe o titulo da série: ");
            string titulo = Console.ReadLine();            
                
            foreach (var item in Enum.GetValues(typeof(Generos)))
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("Informe o gênero da série conforme listado acima: ");
            int genero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma descrição: ");
            var descricao = Console.ReadLine();

            Console.WriteLine("Informe o ano da série: ");
            var ano = Console.ReadLine();

            _seriesRepositorio
                .Incluir(new Series(new Random()
                .Next(),(Generos)genero,titulo,descricao,int.Parse(ano)));
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

        private void InicializarCampos(string campo)
        {

            Console.Clear();
            Console.WriteLine($"Informe o valor para {campo} abaixo: ");
        }

        private bool PerguntaUsuario()
        {
            Console.WriteLine("Deseja sair do programa?");
            Console.WriteLine("Digite 'Sim' para sair e 'Nao' para não sair");
            var opcao = Console.ReadLine();

            if (true)
            {

            }
            return true;
        }
    }
}
