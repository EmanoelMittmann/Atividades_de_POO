namespace Biblioteca.WebApi.Domain.Entity
{
    public class Emprestimo
    {
        public int Id { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }

        public Livro Livro { get; set; }
        public int LivroId { get; set; }
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
    }
}