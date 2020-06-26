namespace Aula26Interfaces
{
    public interface iCarrinho
    {
         void Ler();
         void Incluir(Produto _produto);
         void Excluir(Produto _produto);
         void Alterar(int _codigo, Produto _produtoAlterado);
    }
}