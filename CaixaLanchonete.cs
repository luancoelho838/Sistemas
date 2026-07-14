Console.WriteLine("========== LANCHONETE ==========");

// Definir o loop
// Arrumar acumuladores 
// Arrumar os cálculos (faturamento dobrado, etc)
// Considerar chance de quebra caso pedidos = 0




int registro = 0;

int pedidosConfirmados = 0;
int quantidadeXburguer = 0;
int quantidadeRefrigerante = 0;
int quantidadeBatataFrita = 0;
double faturamentoTotal = 0;




while(registro == 0)
{
   MostrarMenu();
   MostrarTotal(CalcularTotal(quantidadeXburguer, quantidadeRefrigerante, quantidadeBatataFrita));
}


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
    quantidadeXburguer = int.Parse(Console.ReadLine());

    Console.WriteLine("Quantidade de refrigerante: ");
    quantidadeRefrigerante = int.Parse(Console.ReadLine());

    Console.WriteLine("Quantidade de batata frita: ");
    quantidadeBatataFrita = int.Parse(Console.ReadLine());

    faturamentoTotal += CalcularTotal(quantidadeXburguer, quantidadeRefrigerante, quantidadeBatataFrita);

}


double CalcularTotal(int quantidadeXburguer, int quantidadeRefrigerante, int quantidadeBatataFrita)
{
    double precoXburguer = 18.0;
    double precoRefrigerante = 7.0;
    double precoBatataFrita = 12.0;

    double total = (quantidadeXburguer * precoXburguer) + (quantidadeRefrigerante * precoRefrigerante) + (quantidadeBatataFrita * precoBatataFrita);

    return total;
}

void MostrarTotal(double total)
{
    Console.WriteLine($"Total do pedido: R$ {total}");
    ConfirmarPedido();
}


void ConfirmarPedido()
{
    Console.WriteLine("Pedido confirmado?\n1 - Sim\n2 - Cancelar");
    int opcaoConfirmacao = int.Parse(Console.ReadLine());

    if (opcaoConfirmacao == 1)
    {
        Console.WriteLine("Pedido confirmado!");
        AtualizarRelatorio();
    }
    else
    {
        Console.WriteLine("Pedido cancelado.");
    }

    Console.WriteLine("Deseja realizar outro pedido?\n1 - Sim\n2 - Não");
    int opcaoNovoPedido = int.Parse(Console.ReadLine());
    if(opcaoNovoPedido == 1)
    {
        NovoPedido();
    }
    else
    {
        MostrarMenu();
    }
}

void AtualizarRelatorio()
{
    pedidosConfirmados += 1;
    quantidadeXburguer += quantidadeXburguer;
    quantidadeRefrigerante += quantidadeRefrigerante;
    quantidadeBatataFrita += quantidadeBatataFrita;
    faturamentoTotal += faturamentoTotal;
}


void MostrarRelatorio()
{
    Console.WriteLine("========== RELATÓRIO ==========");
    Console.WriteLine($"Pedidos realizados: {pedidosConfirmados}");
    Console.WriteLine($"Hambúgueres vendidos: {quantidadeXburguer}");
    Console.WriteLine($"Batatas vendidas: {quantidadeBatataFrita}");
    Console.WriteLine($"Refrigerantes vendidos: {quantidadeRefrigerante}");
    Console.WriteLine($"Faturamento: R$ {faturamentoTotal}");
    Console.WriteLine($"Ticket médio: R$ {faturamentoTotal / pedidosConfirmados:F2}");
}


void EncerrarSistema()
{
    Console.WriteLine("Deseja realmente encerrar o sistema?\n1 - Sim\n2 - Não");
    int opcaoEncerrar = int.Parse(Console.ReadLine());
    Console.WriteLine("Sistema encerrado.");
}