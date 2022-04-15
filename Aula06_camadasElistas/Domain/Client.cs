using System;
using System.Collections.Generic;
using Aula06_camadasElistas.Domain;



namespace Aula06_camadasElistas.Domain
{
    public class Client
    {
        public Client(int id, string name, string phoneNumber)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
            Cobranca = new List<Cobranca>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public List<Cobranca> Cobranca { get; set ; }
    }
}