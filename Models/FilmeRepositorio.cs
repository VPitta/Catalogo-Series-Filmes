using CatalogoDeSeries.Interface;

namespace CatalogoDeSeries.Models
{
    public class FilmeRepositorio : IRepositorio <Filme>
    {
        private List <Filme> listaFilme = new List<Filme>();
        public void Atualiza(int Id, Filme ClassBase)
        {
            listaFilme[Id] = ClassBase;
        }

        public void Exclui(int Id)
        {
            listaFilme[Id].Excluir();
        }

        public void Insere(Filme ClassBase)
        {
            listaFilme.Add(ClassBase);
        }

        public List<Filme> Lista()
        {
            return listaFilme;
        }

        public int ProximoId()
        {
            return listaFilme.Count;
        }

        public Filme RetornaPorId(int Id)
        {
            return listaFilme[Id];
        }
    }
}