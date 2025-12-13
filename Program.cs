bool executando = true;

while (executando)
{
    Console.Clear();
    Console.WriteLine("=== SISTEMA DE CADASTRO DE CLIENTES ===");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Listar clientes");
    Console.WriteLine("3 - Buscar cliente por CPF");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");
    
    string? opcao = Console.ReadLine();
    
    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente (em desenvolvimento)");
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine("Listagem de clientes (em desenvolvimento)");
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("Busca de cliente por CPF (em desenvolvimento)");
            Console.ReadKey();
            break;
        case "0":
            executando = false;
            Console.WriteLine("Saindo do programa...");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.ReadKey();
            break;
    }
}