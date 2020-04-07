using System;
using MySql.Data.MySqlClient;
using CRUD_CONSOLE;

namespace CRUD_CONSOLE.Entities
{
    public class Cliente
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }

        public Cliente()
        {

        }


        public void Cadastrar(string nome, DateTime dataNascimento, string email, string telefone)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Email = email;
            Telefone = telefone;

            string strSql = "INSERT INTO Clientes (nome, datanasc, email, telefone) VALUES (@nome , @datanasc, @email , @telefone)";
            ConexaoDb con = new ConexaoDb(strSql);
            MySqlConnection conexao = new MySqlConnection("Persist Security Info=False;Server=localhost;Port=3306;Database=CadCliente;Uid=root;");
            con.Conexao.Open();
            MySqlCommand comando = new MySqlCommand(strSql, conexao);
            con.Comando.Parameters.AddWithValue("@nome", nome);
            con.Comando.Parameters.AddWithValue("@datanasc", dataNascimento);
            con.Comando.Parameters.AddWithValue("@email", email);
            con.Comando.Parameters.AddWithValue("@telefone", telefone);

            con.Comando.ExecuteNonQuery();
            con.Conexao.Close();

        }
    }
}
