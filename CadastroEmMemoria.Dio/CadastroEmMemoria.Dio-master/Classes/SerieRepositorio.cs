using System.Collections.Generic;
using CadastroEmMemoria.Dio.Interfaces;

namespace CadastroEmMemoria.Dio
{
    public class SerieRepositorio : IRepositorio<Serie>
    {

        private List<Serie> listaSerie = new List<Serie>();
        public void Atualizar(int id, Serie entidade)
            => listaSerie[id] = entidade;
        public void Exclui(int id)
            => listaSerie[id].Excluir();
        public void Insere(Serie entidade)
            => listaSerie.Add(entidade);
        public List<Serie> Lista()
            => listaSerie;
        public int ProximoId()
            => listaSerie.Count;
        public Serie RetornaPorId(int id)
            => listaSerie[id];

    }
}