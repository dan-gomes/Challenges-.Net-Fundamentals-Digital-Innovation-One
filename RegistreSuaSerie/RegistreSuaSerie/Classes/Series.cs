using RegistreSuaSerie.Classes.Enum;
using RegistreSuaSerie.Entidades;
using System;

namespace RegistreSuaSerie.Classes
{
    /// <summary>
    /// Classe de negócio que representa a série informado pelo usuário.
    /// </summary>
    public class Series : EntidadeBase
    {
        private string Titulo { get; set; }
        private Generos Genero { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Series(int id, Generos genero, string titulo, string descricao, int ano)
        {
           Id = id;
           Genero = genero;
           Titulo = titulo;
           Descricao = descricao;
           Ano = ano;
           Excluido = false;
        }
        public Series()
        {

        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + Genero + Environment.NewLine;
            retorno += "Título: " + Titulo + Environment.NewLine;
            retorno += "Descrição: " + Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + Ano;
            return retorno;

        }

        public string RetornarTitulo() => Titulo;
        public int RetornarId() => Id;       
        public void Excluir() => Excluido = true;
        
    }
}
