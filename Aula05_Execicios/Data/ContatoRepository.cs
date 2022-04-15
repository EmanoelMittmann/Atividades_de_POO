using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula05_Execicios.Domain;
using Microsoft.EntityFrameworkCore;

namespace Aula05_Execicios.Data
{
    public class ContatoRepository
    {
        private Datacontext Context;

        public AgendaDeContatos(Datacontext context)
        {
            this.Context = context;
        }
        public List<Contato> GetAll()
        {
            return Context.contatos.ToList();
        }

        public void Save(Contato contato)
        {
            Context.Add(contato);
            Context.SaveChanges();
        }

        public Contato GetById(int idContato)
        {
            return Context.contatos.SingleOrDefault(i=> i.Id == idContato);
        }

        public void Update(Contato contato)
        {
          Context.Entry(contato).State = EntityState.Modified;
        }

        public void Delete(Contato contato)
        {
            Context.contatos.Remove(contato);
        }

        public void Disable(Contato contato)
        {
            
        }
    }
}