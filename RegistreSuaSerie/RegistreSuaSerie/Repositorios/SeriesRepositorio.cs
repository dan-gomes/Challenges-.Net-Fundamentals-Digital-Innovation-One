﻿using RegistreSuaSerie.Classes;
using RegistreSuaSerie.Contexto;
using RegistreSuaSerie.Interfaces;
using System.Collections.Generic;

namespace RegistreSuaSerie.Repositorios
{
    public class SeriesRepositorio : ISeriesRepositorio<Series>
    {
        public void Atualizar(int id, Series entidade)
        {
            throw new System.NotImplementedException();
        }

        public void Exclui(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Insere(Series entidade)
        {
            
        }

        public List<Series> Lista()
        {
            throw new System.NotImplementedException();
        }

        public int ProximoId()
        {
            throw new System.NotImplementedException();
        }

        public Series RetornaPorId(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
