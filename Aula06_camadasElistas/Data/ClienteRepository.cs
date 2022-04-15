using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula06_camadasElistas.Domain;

namespace Aula06_camadasElistas.Data
{
    public class ClienteRepository
    {
        private List<Client> listaclientes = new List<Client>();

        public void save(Client cliente){

            listaclientes.Add(cliente);
        }

        public List<Client> getAll()
        {
            return listaclientes;
        }

        public bool update(Client client){

            var clienteED = listaclientes.Find(x => x.Id == client.Id);
            if(clienteED == null)
            {
                return false ;
            }
            else
            {
                clienteED.Name=client.Name;
                clienteED.PhoneNumber=client.PhoneNumber;
                return true;
            }
            

            
        }
        public bool delete(int id_dell)
        {
            var clienteDEL = listaclientes.Find(i => i.Id == id_dell);
            if(clienteDEL == null)
            {
                return false;
            }
            else
            {
                listaclientes.Remove(clienteDEL);
                return true;
            }

        }
        
        public int tamanhoList(){
            return listaclientes.Count;
        }

        public Client getbyid(int id)
        {
            var cliente = listaclientes.Find(i => i.Id == id);
            return cliente;
            
        }
    }
}