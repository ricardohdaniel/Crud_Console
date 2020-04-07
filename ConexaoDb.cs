using System;
using MySql.Data.MySqlClient;
namespace CRUD_CONSOLE
{
    public class ConexaoDb
    {
        public MySqlConnection Conexao { get; set; }
        public string StrSql { get; set; }
        public MySqlCommand Comando { get; set; }

        public ConexaoDb(string strSql)
        {
            StrSql = strSql;
            Conexao = new MySqlConnection("Server=localhost;Port=3306;Database=CadCliente;Uid=root;uid=root;");
            Comando = new MySqlCommand(StrSql, Conexao);
        }
    }
}

