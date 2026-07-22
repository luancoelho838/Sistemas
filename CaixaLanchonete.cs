Console.WriteLine("========== LANCHONETE ==========");


int pedidosConfirmados = 0;
int quantidadeXburguer = 0;
int quantidadeRefrigerante = 0;
int quantidadeBatataFrita = 0;
double faturamentoPedido = 0;



int quantidadeXburguerTotal = 0;
int quantidadeRefrigeranteTotal = 0;
int quantidadeBatataFritaTotal = 0;
double faturamentoTotal = 0;



while(true)
{
   MostrarMenu();
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

    PedidoNulo();

    CalcularTotal(quantidadeXburguer, quantidadeRefrigerante, quantidadeBatataFrita);

}

void PedidoNulo()
{
    if(quantidadeXburguer == 0 && quantidadeRefrigerante == 0 && quantidadeBatataFrita == 0)
    {
        Console.WriteLine("Pedido nulo. Por favor, insira pelo menos um item.");
        RealizarNovoPedido();
    }
}


double CalcularTotal(int quantidadeXburguer, int quantidadeRefrigerante, int quantidadeBatataFrita)
{
    const double precoXburguer = 18.0;
    const double precoRefrigerante = 7.0;
    const double precoBatataFrita = 12.0;

    double total = (quantidadeXburguer * precoXburguer) + (quantidadeRefrigerante * precoRefrigerante) + (quantidadeBatataFrita * precoBatataFrita);
    faturamentoPedido = total;

    MostrarTotalPedido(total);
    
    return total;
}

void MostrarTotalPedido(double total)
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
        AtualizarRelatorio(quantidadeXburguer, quantidadeRefrigerante, quantidadeBatataFrita, faturamentoPedido);
        RealizarNovoPedido();
    }
    else
    {
        Console.WriteLine("Pedido cancelado.");
        RealizarNovoPedido();
    }
}

void RealizarNovoPedido()
{
    Console.WriteLine("Deseja realizar outro pedido?\n1 - Sim\n2 - Não");
    int opcaoNovoPedido = int.Parse(Console.ReadLine());
    if(opcaoNovoPedido == 1)
    {
        NovoPedido();
        ConfirmarPedido();
    }
    else
    {   
        VoltarMenu();
    }
}

void AtualizarRelatorio(int quantidadeXburguer, int quantidadeRefrigerante, int quantidadeBatataFrita, double faturamentoPedido)
{
    pedidosConfirmados += 1;
    quantidadeXburguerTotal += quantidadeXburguer;
    quantidadeRefrigeranteTotal += quantidadeRefrigerante;
    quantidadeBatataFritaTotal += quantidadeBatataFrita;
    faturamentoTotal += faturamentoPedido;
}


void MostrarRelatorio()
{
    Console.WriteLine("========== RELATÓRIO ==========");
    Console.WriteLine($"Pedidos realizados: {pedidosConfirmados}");
    Console.WriteLine($"Hambúgueres vendidos: {quantidadeXburguerTotal}");
    Console.WriteLine($"Batatas vendidas: {quantidadeBatataFritaTotal}");
    Console.WriteLine($"Refrigerantes vendidos: {quantidadeRefrigeranteTotal}");
    Console.WriteLine($"Faturamento: R$ {faturamentoTotal}");
    if (pedidosConfirmados > 0)
    {
        Console.WriteLine($"Ticket médio: R$ {faturamentoTotal / pedidosConfirmados:F2}");
    }
    else
    {
        Console.WriteLine("Ticket médio: R$ 0.00");
    }

    VoltarMenu();
}

void VoltarMenu()
{
    Console.WriteLine("Deseja voltar ao menu principal?\n1 - Sim\n2 - Não");
    int opcaoVoltarMenu = int.Parse(Console.ReadLine());
    if(opcaoVoltarMenu == 1)
    {
        MostrarMenu();
    }
    else
    {  
        EncerrarSistema();
    }
}

void EncerrarSistema()
{
    Console.WriteLine("Deseja realmente encerrar o sistema?\n1 - Sim\n2 - Não");
    int opcaoEncerrar = int.Parse(Console.ReadLine());
    if (opcaoEncerrar == 1)
    {
        Console.WriteLine("Sistema encerrado.");
        Environment.Exit(0);
    }
    else if (opcaoEncerrar == 2)
    {
        VoltarMenu();
    }
    else{
        Console.WriteLine("Opção inválida. Tente novamente.");
        EncerrarSistema();
    }
}