using System;

namespace Aula26Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();
            Produto p1 = new Produto(1, "Borderlands", 29.99f);
            Produto p2 = new Produto(2, "Call of Duty: Modern Warfare", 219.99f);
            Produto p3 = new Produto(3, "Batman: Arkham City", 39.99f);
            Produto p4 = new Produto(4, "Resident Evil 7", 69.99f);

            cart.Incluir(p1);
            cart.Incluir(p2);
            cart.Incluir(p3);
            cart.Incluir(p4);
            cart.Ler();
            cart.SomarTotal();
        }
    }
}
