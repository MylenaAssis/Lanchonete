using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FilaPedidos
{
    internal class Item
    {
        private int Id { get; }
        private string Nome { get; }
        private decimal Valor { get; }
        private bool Disponivel { get; }
    }
}
