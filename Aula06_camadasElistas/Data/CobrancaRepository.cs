using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula06_camadasElistas.Domain;

namespace Aula06_camadasElistas.Data
{
    public class CobrancaRepository
    {
        private List<Cobranca> listacobrancas = new List<Cobranca>();

        public void save(Cobranca cobranca)
        {
            listacobrancas.Add(cobranca);
        }

        public List<Cobranca> getAll()
        {
            return listacobrancas;           
        }

        public void efetuarPgto(int id_cobranca)
        {
            Cobranca atual = listacobrancas.Find(x => x.Id == id_cobranca);
            atual.Payday=DateTime.Now;
            atual.Status=true;
        }


    }
}