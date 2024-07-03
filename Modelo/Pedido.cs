using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaPedidos.Modelo
{
    internal class Pedido
    {
        public int Id { get; set; }

        //criando o construtor
        public Pedido(int id)
        {
            Id = id;
        }

        //criando lista de itens do pedido
        public List<Item> itens = new List<Item>();

        public void AdicionarItem(Item item)
        {
            itens.Add(item);
        }

        /*
        //implementação de pedido do trabalho - exibir elemento da fila
        public void ExibirPedido()
        {
            Console.WriteLine(Id);
            //imprimir lista de itens
        }
        */
    }
}
