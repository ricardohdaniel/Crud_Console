using System;
using MySql.Data.MySqlClient;

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

            string arg = "INSERT INTO Clientes (nome,datanasc,email,telefone) VALUES (@nome,@datanasc,@email,@telefone)";
            ConexaoDb con = new ConexaoDb(arg);
            con.Comando.Parameters.AddWithValue("@nome", nome);
            con.Comando.Parameters.AddWithValue("@datanasc", dataNascimento);
            con.Comando.Parameters.AddWithValue("@email", email);
            con.Comando.Parameters.AddWithValue("@telefone", telefone);

            con.Comando.ExecuteNonQuery();
            con.FecharConexao();

        }

        public void Consultar(int id)
        {
            string arg = "SELECT * FROM Clientes WHERE id=@id";
            ConexaoDb con = new ConexaoDb(arg);
            con.Comando.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            MySqlDataReader dr = con.Comando.ExecuteReader();

            while (dr.Read())
            {
                Nome = dr["nome"].ToString(); 
                DataNascimento = Convert.ToDateTime(dr["datanasc"]);
                Email = dr["email"].ToString();
                Telefone = dr["telefone"].ToString();

                Console.WriteLine(Nome + " " + DataNascimento + " " + Email + " " + Telefone);
            }


            con.FecharConexao();
        }
    }
}
