using CadastroClientes.Models;
using System.Linq;

//CADASTRO DE CLIENTES - VERSÃO INICIAL
bool executando = true;

List<Cliente> clientes = new List<Cliente>();
int proximoId = 1;

while (executando)
{
    string tituloDoSistema = "=== SISTEMA DE CADASTRO DE CLIENTES ===";
    Console.Clear();
    Console.WriteLine(tituloDoSistema);
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Listar clientes");
    Console.WriteLine("3 - Buscar cliente por CPF");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");
    
    string? opcao = Console.ReadLine();
    
    switch (opcao)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("=== CADASTRO DE CLIENTE ===");

            Cliente cliente = new Cliente();

            cliente.Id = proximoId++;

            Console.Write("Nome: ");
            cliente.Nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(cliente.Nome))
            {
                Console.WriteLine("Nome inválido. O nome não pode estar vazio.");
                Console.ReadKey();
                break;
            }

            Console.Write("CPF: ");
            cliente.Cpf = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(cliente.Cpf) || cliente.Cpf.Length != 11 || !cliente.Cpf.All(char.IsDigit))
            {
                Console.WriteLine("CPF inválido. O CPF deve conter exatamente 11 dígitos numéricos.");
                Console.ReadKey();
                break;
            }

            Console.Write("Email: ");
            cliente.Email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(cliente.Email) || !cliente.Email.Contains("@"))
            {
                Console.WriteLine("Email inválido. O email deve conter o caractere '@'.");
                Console.ReadKey();
                break;
            }

            cliente.DataCadastro = DateTime.Now;

            clientes.Add(cliente);

            Console.WriteLine("Cliente cadastrado com sucesso!");
            Console.ReadKey();
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("=== LISTA DE CLIENTES ===\n");

            if (clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                Console.ReadKey();
                break;
            }

            else
            {
                foreach (var c in clientes)
                {
                    Console.WriteLine($"ID: {c.Id}");
                    Console.WriteLine($"Nome: {c.Nome}");
                    Console.WriteLine($"CPF: {c.Cpf}");
                    Console.WriteLine($"Email: {c.Email}");
                    Console.WriteLine($"Data de Cadastro: {c.DataCadastro}");
                    Console.WriteLine(new string('-', 30));
                }
            }
            Console.ReadKey();
            break;

        case "3":
            Console.Clear();
            Console.WriteLine("=== BUSCAR CLIENTE POR CPF ===");

            Console.Write("Digite o CPF do cliente: ");
            string? cpfBusca = Console.ReadLine();

            var clienteEncontrado = clientes.FirstOrDefault(c => c.Cpf == cpfBusca);

            if (clienteEncontrado == null)
            {
                Console.WriteLine("Cliente não encontrado.");
            }

            else
            {
                Console.WriteLine("Cliente encontrado:");
                Console.WriteLine($"ID: {clienteEncontrado.Id}");
                Console.WriteLine($"Nome: {clienteEncontrado.Nome}");
                Console.WriteLine($"CPF: {clienteEncontrado.Cpf}");
                Console.WriteLine($"Email: {clienteEncontrado.Email}");
                Console.WriteLine($"Data de Cadastro: {clienteEncontrado.DataCadastro}");
            }

            Console.ReadKey();
            break;

        case "0":
            executando = false;
            Console.WriteLine("Saindo do programa...");
            Console.ReadKey();
            Console.Clear();
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.ReadKey();
            break;
    }
}