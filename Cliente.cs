using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaPedidos
{
    internal class Cliente
    {
        private int Cpf { get; set; }
        private string Nome { get; set; }
        private bool ParticipanteClube { get; set; }

        public void ExibirCadastroCliente()
        {
            Console.WriteLine($"Nome: {Nome}.");
            Console.WriteLine($"CPF: {Cpf}");
            if ( ParticipanteClube )
            {
                Console.WriteLine("Faz parte do clube fidelidade.");
            } else
            {
                Console.WriteLine("Ainda não participa do clube fidelidade.");
            }
        }
    }
}
