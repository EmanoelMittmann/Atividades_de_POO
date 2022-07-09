namespace Biblioteca.WebApi.Domain.Entity
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Num_edit{ get; set; }
        public int Volume { get; set; }
        public Editora Editora { get; set; }
        public int EditoraId { get; set; }
        public Genero Genero { get; set; }
        public int GeneroId { get; set; }

        public IList<Autor> Autores { get; set; }
        public Emprestimo Emprestimo { get; set; }
        
    }
}