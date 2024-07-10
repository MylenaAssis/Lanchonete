using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FilaPedidos.Modelo
{
    internal class Item
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public bool Disponivel { get; private set; }

        //criando o construtor
        public Item(string nome, double valor, bool disponivel)
        {
            Nome = nome;
            Valor = valor;
            Disponivel = disponivel;
        }

        //propriedades que tem apenas getter podem ser trocadas por funcoes lambda, como a seguir:
        public string Resumo => $"{Nome} ----- R${Valor}.";

        public void CadastrarNovoItem();

    }
}
