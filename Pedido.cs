using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaPedidos
{
    internal class Pedido
    {
        private int Id { get; set; }

        public List<Item> Itens = new List<Item>();

        public void ExibirPedido()
        {
            Console.WriteLine(Id);
            //imprimir lista de itens
        }
    }
}
