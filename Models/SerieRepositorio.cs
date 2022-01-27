
using CatalogoDeSeries.Interface;

namespace CatalogoDeSeries.Models
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List <Serie> listaSerie = new List<Serie>();
        public void Atualiza(int Id, Serie classeBase)
        {
            listaSerie[Id] = classeBase;
        }

        public void Exclui(int Id)
        {
            listaSerie[Id].Excluir();
        }

        public void Insere(Serie classeBase)
        {
            listaSerie.Add(classeBase);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int Id)
        {
            return listaSerie[Id];
        }
    }
}