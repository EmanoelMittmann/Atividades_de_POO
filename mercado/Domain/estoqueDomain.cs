using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mercado.Domain
{
    /*Identifique as classes e implemente um
    programa para a seguinte especificação: “O	supermercado vende diferentes tipos de produtos.
    Cada produto tem um preço e uma	 quantidade em estoque. Um	pedido	de um	cliente	é composto de itens,
    onde cada item  específica o produto que o cliente deseja e a respectiva quantidade.
     Esse pedido pode ser pago em dinheiro, cheque ou cartão.” 
*/
    public class estoqueDomain
    {
        public estoqueDomain(int id, float valor, int quantidade, string nome, string categoria) 
        {
            Id = id;
            Valor = valor;
            Quantidade = quantidade;
            Nome = nome;
            Categoria = categoria;
        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Valor { get; set; }
        public string Categoria { get; set; }
        public int Quantidade { get; set; }



    }
}