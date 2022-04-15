using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula06_camadasElistas.Data;
using Aula06_camadasElistas.Domain;

namespace Aula06_camadasElistas.Services
{
    public class ClientService
    {
        ClienteRepository repositorio = new ClienteRepository();

        public string newClient(string name, string fone){
            int id_client = repositorio.tamanhoList()+1;
            repositorio.save(new Client(id_client,name,fone));
            return "cliente foi adicionado";

        }

        public string retornarlista(){
            var retorno = new StringBuilder();
            var lista_de_cliente = repositorio.getAll();
            var qtdClientes = lista_de_cliente.Count;

            if(qtdClientes == 0)
            {
                return retorno.AppendLine("lista vazia").ToString();
            }
            else
            {
                foreach(Client cliente in lista_de_cliente){
                    retorno.AppendLine("id : "+cliente.Id + " name: " + cliente.Name + " fone: " + cliente.PhoneNumber);
                }
                return retorno.ToString();
            }

        }

        public string delete(int id_dell){
            var retorno = string.Empty;
            if(repositorio.tamanhoList() == 0)
            {
                retorno = "lista vazia";
                return retorno;
            }
            else
            {
                var deletou = repositorio.delete(id_dell);
                if(deletou == true)
                {
                    retorno = "cliente deletado";
                }
                else
                {
                    retorno = "deu pau";
                }
                return retorno;
            }
            
        }

        public string editCliente(int id, string nome, string telefone){
            string retorno = string.Empty;
            if(repositorio.tamanhoList() == 0)
            {
                retorno = "lista vazia";
                return retorno;
            }
            else
            {
                var editado = repositorio.update(new Client(id,nome,telefone));
                if(editado == true)
                {
                    retorno = "cliente editado com sucesso";
                }
                else
                {
                    retorno = "deu pau";
                }
                return retorno;
            }
        }
    }
}