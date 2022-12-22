namespace Projeto02.GestaoEventos.DataAccess.Interfaces
{
    // Create, Read (Retrieve), Update and Delete  - CRUD
    public interface ICrud<T>
    {
        long Incluir(T entidade);
        IEnumerable<T> ListarTodos();
        T Buscar(int id);
        bool Alterar(T entidade);
        bool Remover(T entidade);
    }
}
