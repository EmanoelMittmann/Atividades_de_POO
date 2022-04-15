using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula06_camadasElistas.Domain;
using Aula06_camadasElistas.Data;
using System.Text;


namespace Aula06_camadasElistas.Services
{
    public class CobrancaService
    {
        ClienteRepository repositoriocliente = new ClienteRepository();
        CobrancaRepository repositorio = new CobrancaRepository();
     
        public string criarConta( DateTime datevenc, double valor, int idcliente)
        {
            var idCobranca = repositorio.getAll().Count + 1;
            var cliente = repositoriocliente.getbyid(idcliente);
            
            repositorio.save(new Cobranca(idCobranca,DateTime.Now,datevenc,valor,cliente));

            return "cobranca adicionada com sucesso!";

        }
        public string retornarlista(){

            var retorno = new StringBuilder();
            var lista = repositorio.getAll();
            var qtdCobranca = lista.Count;

            if(qtdCobranca == 0)
            {
                return retorno.AppendLine("lista vazia").ToString();
            }
            else
            {
                foreach(Cobranca cobranca in lista){
                    retorno.AppendLine("id : "+cobranca.Id + " dia pgto: " + cobranca.Payday + " cobranca data: " + cobranca.Status);
                }
                return retorno.ToString();
            }
        }

        public string efetuarpgto( int id){
            
            repositorio.efetuarPgto(id);
            return "cobranca paga com sucesso";

        }
    }
}