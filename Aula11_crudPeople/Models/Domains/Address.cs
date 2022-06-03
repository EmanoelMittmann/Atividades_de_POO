using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula11_crudPeople.Models.Domains;

namespace Aula11_crudPeople.Models.Domains
{
    public class Address
    {
        public Address(){}
        public Address(int id, string street, string number, string zipCode)
        {
            Id = id;
            this.street = street;
            Number = number;
            ZipCode = zipCode;
        }

        public int Id { get; set; }
        public string street { get; set; }
        public string Number { get; set; }
        public string ZipCode { get; set; }
        public Person person { get; set; }

        internal void Create(Address address)
        {
            throw new NotImplementedException();
        }
    }
}