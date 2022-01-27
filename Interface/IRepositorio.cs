using System.Collections.Generic;

namespace CatalogoDeSeries.Interface
{
    public interface IRepositorio<Catalogo>
    {
        List <Catalogo> Lista();

        Catalogo RetornaPorId(int Id);
        void Insere(Catalogo classeBase);
        void Exclui(int Id);
        void Atualiza(int Id, Catalogo classeBase);
        int ProximoId();
    
    }
}