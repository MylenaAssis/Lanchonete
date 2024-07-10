using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaPedidos.Modelo
{
    internal class Senha
    {
        Random numeroAleatorio = new Random();
        private int senha;

        public Senha()
        {
            this.senha = numeroAleatorio.Next();
            Console.WriteLine(senha);
        }

        public void GerarSenhaRetirada()
        {
            Console.WriteLine($"A senha para retirada do pedido é: {senha}");
        }

    }
}
