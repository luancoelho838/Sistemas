Console.WriteLine("========== LANCHONETE ==========");

MostrarMenu();
NovoPedido();

void MostrarMenu(){

    Console.WriteLine("========== MENU ==========");
    Console.WriteLine("1 - Novo pedido");
    Console.WriteLine("2 - Ver relatório");
    Console.WriteLine("3 - Encerrar sistema");

    Console.WriteLine("Escolha uma opção: ");
    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            NovoPedido();
            break;
        case 2:
            MostrarRelatorio();
            break;
        case 3:
            EncerrarSistema();
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            MostrarMenu();
            break;
    }
}


void NovoPedido()
{
    Console.WriteLine("Nome do cliente: ");
    string nomeCliente = Console.ReadLine();

    Console.WriteLine("Quantidade de X-Burguer: ");
    int quantidadeXburguer = int.Parse(Console.ReadLine());

    Console.WriteLine("Quantidade de refrigerante: ");
    int quantidadeRefrigerante = int.Parse(Console.ReadLine());

    Console.WriteLine("Quantidade de batata frita: ");
    int quantidadeBatataFrita = int.Parse(Console.ReadLine());

    CalcularTotal(quantidadeXburguer, quantidadeRefrigerante, quantidadeBatataFrita);

}

double CalcularTotal(int quantidadeXburguer, int quantidadeRefrigerante, int quantidadeBatataFrita)
{
    double precoXburguer = 18.0;
    double precoRefrigerante = 7.0;
    double precoBatataFrita = 12.0;

    double total = (quantidadeXburguer * precoXburguer) + (quantidadeRefrigerante * precoRefrigerante) + (quantidadeBatataFrita * precoBatataFrita);
    Console.WriteLine($"Total do pedido: R$ {total}");

    return total;
}


void ConfirmaçãoPedido()
{
    Console.WriteLine("Pedido confirmado?\n1 - Sim\n2 - Cancelar");
    int opcaoConfirmacao = int.Parse(Console.ReadLine());

    if (opcaoConfirmacao == 1)
    {
        Console.WriteLine("Pedido confirmado!");
    }
    else
    {
        Console.WriteLine("Pedido cancelado.");
    }
}

void MostrarRelatorio()
{
    Console.WriteLine("========== RELATÓRIO ==========");
    Console.WriteLine("Pedidos realizados: ");
    Console.WriteLine("Hambúgueres vendidos: ");
    Console.WriteLine("Batatas vendidas: ");
    Console.WriteLine("Refrigerantes vendidos: ");
    Console.WriteLine("Faturamento: ");
    Console.WriteLine("Ticket médio: ");
}


void EncerrarSistema()
{
    Console.WriteLine("Deseja realemente encerrar o sistema?\n1 - Sim\n2 - Não");
    int opcaoEncerrar = int.Parse(Console.ReadLine());
    Console.WriteLine("Sistema encerrado.");
}