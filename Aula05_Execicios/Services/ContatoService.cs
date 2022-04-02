using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula05_Execicios.Data;
using Aula05_Execicios.Domain;

namespace Aula05_Execicios.Services
{
    public class ContatoService
    {
        ContatoRepository minhaAgenda = new ContatoRepository();

        public int RetornaProximaId()
        {
            return minhaAgenda.GetAll().Count + 1;
        }
        public string CriarContato(string nome, string telefone)
        {
            minhaAgenda.Save(new Contato(RetornaProximaId(), nome, telefone));

            return "Contato add com sucesso";
        }

        public string ListarContatos()
        {
            var builder = new StringBuilder();
            var listacontatos = minhaAgenda.GetAll();
            var qtdContatos = listacontatos.Count;

            if(qtdContatos == 0)
            {
                builder.AppendLine("Lista vazia");
            }
            else
            {
                    foreach (Contato contato in listacontatos)
                {
                    builder.AppendLine("Id: " + contato.Id + "Nome: " + contato.Nome);
                }
            }

            return builder.ToString();
        }
    }
}