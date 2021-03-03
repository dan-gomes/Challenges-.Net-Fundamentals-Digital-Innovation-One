using System;
using System.Collections.Generic;
using System.Text;

namespace RegistreSuaSerie.Interfaces
{
    public interface ISeriesRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualizar(int id, T entidade);
        int ProximoId();
    }
}
