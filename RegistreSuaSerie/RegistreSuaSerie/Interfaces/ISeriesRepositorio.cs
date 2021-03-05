using RegistreSuaSerie.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistreSuaSerie.Interfaces
{
    public interface ISeriesRepositorio
    {
        List<Series> Lista();
        Series RetornaPorId(int id);
        void Insere(Series entidade);
        void Exclui(int id);
        void Atualizar(int id, Series entidade);
        int ProximoId();
    }
}
