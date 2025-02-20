using CampeonatosFIFA.Dominio.Entidades;

namespace CampeonatosFIFA.Core.Repositorios
{
    public interface ISeleccionRepositorio
    {
        Task<IEnumerable<Pais>> ObtenerTodos();
        Task<Pais> ObtenerPais(int Id);
        Task<Pais> AgregarPais(Pais pais);
        Task<Pais> EditarPais(Pais pais);
        Task<bool> EliminarPais(int Id);
        Task<IEnumerable<Pais>> BuscarPais(int Tipo, string Dato);
    }
}