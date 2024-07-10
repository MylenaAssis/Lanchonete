using FilaPedidos.Modelo;
using System.Xml.Serialization;

class Program
{

    public static void Main(string[] args)
    {
        
        Queue<object> filaPedidos = new Queue<object>();
        Queue<object> filaReservaPedidos = new Queue<object>();
        int tamanhoMaximo = 3;

        void opcoesMenu()
        {
            Console.WriteLine("\n*****MENU*****");
            Console.WriteLine("1. Inserir pedido na fila pelo id");
            Console.WriteLine("2. Atender próximo pedido");
            Console.WriteLine("3. Exibir próximo pedido");
            Console.WriteLine("4. Verificar tamanho da fila");
            Console.WriteLine("4. Sair");
            Console.WriteLine("\nSelecione uma opção: ");
            string opcaoSelecionada = Console.ReadLine()!;

            int opcaoSelecionadaNumerica = int.Parse(opcaoSelecionada);

            switch (opcaoSelecionadaNumerica)
            {
                case 1:
                    InserirPedido();
                    break;
                case 2:
                    AtenderProximoPedido();
                    break;
                case 3:
                    ExibirProximoPedido();
                    break;
                case 4:
                    VerificarTamanhoFila();
                    break;
                case 5:
                    Console.WriteLine("\nTchau! =)");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        }

        void InserirPedido()
        {
            Random random = new Random();
            object idCliente = random.Next();
            
            if (filaPedidos.Count < tamanhoMaximo)
            {
                //inserindo cliente na fila
                filaPedidos.Enqueue(idCliente);
                Console.WriteLine("\nPedido recebido, aguarde atendimento.");
                Console.WriteLine("\nFILA:");
                foreach (object id in filaPedidos)
                {
                    Console.WriteLine(id);
                }

            } else
            {
                Console.WriteLine("\nProduto esgotado, pedido inserido na fila de espera.");
                filaReservaPedidos.Enqueue(idCliente);

                Console.WriteLine("\nFILA DE ESPERA:");
                foreach (object id in filaReservaPedidos)
                {
                    Console.WriteLine(id);
                }
            }

            ReexibeMenu(3000);

        }

        void AtenderProximoPedido()
        {
            if (filaPedidos.Count > 0)
            {
                object dequeue = filaPedidos.Dequeue();
                Console.WriteLine("O proximo pedido é o " + dequeue);

                Console.WriteLine("\nA fila atualizada é:");
                foreach (object id in filaPedidos)
                {
                    Console.WriteLine(id);
                }
            } else
            {
                Console.WriteLine("A fila está vazia.");
            }

            ReexibeMenu(3000);
        }

        void ExibirProximoPedido()
        {
            if (filaPedidos.Count > 0)
            {
                object proximoPedido = filaPedidos.Peek();
                Console.WriteLine($"O proximo pedido é o {proximoPedido}.");

                Console.WriteLine("\nA fila atualizada é:");
                foreach (object id in filaPedidos)
                {
                    Console.WriteLine(id);
                }
            } else
            {
                Console.WriteLine("Sem mais pedidos - fila vazia.");
            }

            ReexibeMenu(3000);
        }

        void VerificarTamanhoFila()
        {
            if (filaPedidos.Count >= tamanhoMaximo)
            {
                Console.WriteLine("A fila alcançou seu limite.");
                Console.WriteLine("\nA fila atualizada é:");
                foreach (object id in filaPedidos)
                {
                    Console.WriteLine(id);
                }

            }
            else if (filaPedidos.Count == 0)
            {
                Console.WriteLine("A fila está vazia.");

            } 
            else
            {
                Console.WriteLine($"Temos {filaPedidos.Count} pedidos na fila para atendimento e {filaReservaPedidos.Count} na fila de espera.");

                Console.WriteLine("\nA fila atualizada é:");
                foreach (object id in filaPedidos)
                {
                    Console.WriteLine(id);
                }
            }

            ReexibeMenu(4000);

        }

        void ReexibeMenu(int tempoMilissegundos)
        {
            Thread.Sleep(tempoMilissegundos);
            Console.Clear();
            opcoesMenu();
        }

        opcoesMenu();

    }
}
