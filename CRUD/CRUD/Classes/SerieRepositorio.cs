using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Interfaces;

namespace CRUD.Classes
{
    public class SerieRepositorio : iRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public void Excluir(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }
    }
}
