namespace Projeto03.ConceitosWebApi.Model
{
    public class Utils // Utilitários
    {
        public static IEnumerable<Curso> ListarCursos()
        {
            return new List<Curso>()
            {
                new Curso() { Id = 10, Ch = 30, Descricao = "JavaScript", Preco = 30.00},
                new Curso() { Id = 11, Ch = 40, Descricao = "Python", Preco = 0.00},
                new Curso() { Id = 12, Ch = 380, Descricao = "Bootcamp Angular Developer", Preco = 0.00},
                new Curso() { Id = 13,Ch = 40, Descricao = "Lógica de Programação" , Preco = 30.00}
            };
        }
    }
}
