using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula05_Execicios.Domain;

namespace Aula05_Execicios.Data
{
    public class ContatoRepository
    {
        private List<Contato> listaDeContato = new List<Contato>();

        public List<Contato> GetAll()
        {
            return listaDeContato;
        }

        public void Save(Contato contato)
        {
            listaDeContato.Add(contato);
        }

        public Contato GetById(int idContato)
        {
            return listaDeContato.Find(p => p.Id == idContato);
        }

        public void Update(Contato contato)
        {
            var contatoEditado = listaDeContato.Find( p => p.Id == contato.Id);

            contatoEditado.Nome = contato.Nome;
            contatoEditado.Telefone = contato.Telefone;
        }

        public void Delete(Contato contato)
        {
            listaDeContato.Remove(contato);
        }
    }
}