using System;
using System.Collections.Generic;
namespace Aula26Interfaces
{
    public class Carrinho : iCarrinho
    {
        public float ValorTotal {get;set;}
        List<Produto> carrinho = new List<Produto>();

        public void SomarTotal(){
            foreach(Produto item in carrinho){
                ValorTotal += item.Preco;
            }
            Console.WriteLine($"\n Valor total dos itens selecionados: R$ {ValorTotal}");
        }
        public void Alterar(int _codigo, Produto _produtoAlterado)
        {
            carrinho.Find(j => j.Codigo == _codigo).Nome = _produtoAlterado.Nome;
            carrinho.Find(k => k.Codigo == _codigo).Preco = _produtoAlterado.Preco;
        }

        public void Excluir(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void Incluir(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Ler()
        {
            foreach(Produto item in carrinho){
                System.Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }
        }
    }
}