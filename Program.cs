class Program
{
    public static void Main(string[] args)
    {
        Queue<int> filaClientes = new Queue<int>();



        void opcoesMenu()
        {
            Console.WriteLine("*****MENU*****");
            Console.WriteLine("1. Inserir cliente na fila");
            Console.WriteLine("2. Atender próximo cliente");
            Console.WriteLine("3. Exibir próximo cliente");
            Console.WriteLine("4. Verificar tamanho da fila");
            Console.WriteLine("5. Sair");
            Console.WriteLine("Selecione uma opção: ");
            string opcaoSelecionada = Console.ReadLine()!;

            int opcaoSelecionadaNumerica = int.Parse(opcaoSelecionada);

            switch (opcaoSelecionadaNumerica)
            {
                case 1:
                    InserirCliente();
                    break;
                case 2:
                    //AtenderProximoCliente;
                    break;
                case 3:
                    //ExibirProximoCliente;
                    break;
                case 4:
                    //VerificarTamanhoFila();
                    break;
                case 5:
                    Console.WriteLine("Tchau! =)");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        }

        void InserirCliente()
        {
            //criando id aleatorio para o cliente
            Random random = new Random();
            int idCliente = random.Next();
            Console.WriteLine(idCliente);

            //inserindo cliente na fila

            filaClientes.Enqueue(idCliente);

            //imprimindo clientes
            foreach (int idClientes in filaClientes)
            {
                Console.WriteLine(idCliente);
            }

            //limpa console e reexibe menu
            Thread.Sleep(4000);
            Console.Clear();
            opcoesMenu();
        }

        opcoesMenu();

    }
}