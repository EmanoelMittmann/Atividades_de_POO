using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Aula06_camadasElistas.Domain
{
    public class Cobranca
    {
        public Cobranca(int id, DateTime creationdate, DateTime duedate, double value, Client cliente)
        {
            Id = id;
            Creationdate = creationdate;
            Duedate = duedate;
            Value = value;
            Payday = null;
            Cliente = cliente;
            Status = false;
        }

/*
Desenvolva um console application que interaja para um controle de um sistema de cobranças onde cada cobrança deve estar vinculada a um cliente, e cada cliente pode ter várias cobranças.
Segue o doc exemplo das cobranças de um cliente. Utilize esse doc para saber quais dados armazenar e utilize os conhecimentos das listas genéricas e lambdas que trabalhamos na aula passada.
*/

        public int Id { get; set; }
        public DateTime Creationdate { get; set; }
        public DateTime Duedate { get; set; }
        public double Value { get; set;}
        public DateTime? Payday {get; set;}
        public bool Status {get; set; }
        public Client Cliente { get; set; }
      
    }

}