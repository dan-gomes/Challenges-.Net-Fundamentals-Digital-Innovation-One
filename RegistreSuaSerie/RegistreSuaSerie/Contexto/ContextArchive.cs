using System.IO;

namespace RegistreSuaSerie.Contexto
{
    /// <summary>
    /// Classe responsável pela manipulação de arquivos.
    /// </summary>
    public class ContextArchive
    {
        /// <summary>
        /// Método responsável por criar um novo arquivo.
        /// </summary>
        public void CriarArquivo()
        {
            if (File.Exists(ConfiguracaoArquivo.ArchiveAddres))
                return;

            using FileStream file = new FileStream(ConfiguracaoArquivo.ArchiveName, FileMode.CreateNew);
        }


        /// <summary>
        /// Método responsável por adcionar elemento em um arquivo.
        /// </summary>
        /// <param name="conteudo">Conteudo a ser adicionado no arquivo</param>
        /// docs = https://docs.microsoft.com/pt-br/dotnet/standard/io/how-to-write-text-to-a-file
        public async void Adicionar(string conteudo)
            => await File.AppendAllTextAsync(ConfiguracaoArquivo.ArchiveAddres, conteudo);

    }
}
