using System;
using CRUD_CONSOLE.Entities;
using CRUD_CONSOLE.Entities.Enums;

namespace CRUD_CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema CRUD");
            Console.WriteLine();
            Console.WriteLine("Escolha alguma das opções abaixo: ");

            Console.WriteLine(Opcoes.Cadastrar + " (Digite 0)");
            Console.WriteLine(Opcoes.Consultar + " (Digite 1)");
            Console.WriteLine(Opcoes.Excluir + " (Digite 2)");
            Console.WriteLine(Opcoes.Listar + " (Digite 3)");
            Console.Write("Opção: ");
            int opc = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------------------------");
            try
            {
                if (opc == 0)
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Data de Nascimento: ");
                    DateTime dataNasc = DateTime.Parse(Console.ReadLine());
                    Console.Write("E-mail: ");
                    string email = Console.ReadLine();
                    Console.Write("Telefone: ");
                    string telefone = Console.ReadLine();
                    Cliente cliente = new Cliente();
                    cliente.Cadastrar(nome, dataNasc, email, telefone);
                }
                if (opc == 1)
                {
                    Console.Write("Digite o ID do Cliente a ser exibido: ");
                    int id = int.Parse(Console.ReadLine());
                    Cliente cliente = new Cliente();
                    cliente.Consultar(id);
                }
                if (opc == 2)
                {
                    Console.Write("Digite o ID do Cliente a ser excluído: ");
                    int id = int.Parse(Console.ReadLine());
                    Cliente cliente = new Cliente();
                    cliente.Excluir(id);
                }
                if (opc == 3)
                {
                    Cliente cliente = new Cliente();
                    cliente.ListarClientes();
                }
            }
            catch (Exception erro)
            {
                Console.WriteLine("Erro: " + erro.Message);
            }

        }
    }
}
