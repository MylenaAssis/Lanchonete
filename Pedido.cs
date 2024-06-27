using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaPedidos
{
    internal class Pedido
    {
        List<Item> itens = new List<Item>();

        public void adicionarItem(Item item)
        {
            itens.Add(item);
        }
    }
}
