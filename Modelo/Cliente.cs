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

        public void BuscaCadastroCliente(string cpf);
        public void ExibirCadastroCliente();
        public void CadastrarNovoCliente();
    }
}
