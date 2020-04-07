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
            Console.WriteLine(Opcoes.Alterar + " (Digite 2)");
            Console.WriteLine(Opcoes.Excluir + " (Digite 3)");

            int opc = int.Parse(Console.ReadLine());

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





        }
    }
}
