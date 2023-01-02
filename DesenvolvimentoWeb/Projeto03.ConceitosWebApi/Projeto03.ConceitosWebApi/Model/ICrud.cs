namespace Projeto02.GestaoEventos.DataAccess.Interfaces
{
    // Create, Read (Retrieve), Update and Delete  - CRUD
    public interface ICrud<T>
    {
        T? Incluir(T entidade);
        IEnumerable<T> ListarTodos();
        T Buscar(int id);
        T Alterar(T entidade, int id = 0);
        bool Remover(int id);
    }
}
