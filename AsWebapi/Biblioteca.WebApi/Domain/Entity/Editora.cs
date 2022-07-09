namespace Biblioteca.WebApi.Domain.Entity
{
    public class Editora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cidade { get; set; }
        public IList<Livro> Livros { get; set; }
    }
}