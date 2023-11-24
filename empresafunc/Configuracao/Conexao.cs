using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace empresafunc.Configuracao
{
    class Conexao
    {

        private string _servidor = "localhost";
        private string _port = "3306";
        private string _usuario = "root";
        private string _senha = "root";
        private string _bancoDadosNome = "empresa_x2a_bd";

        private MySqlConnection connection;
        private MySqlCommand command;

        public Conexao() { 

            try
            {
                connection = new MySqlConnection($"server={_servidor}; database={_bancoDadosNome}; port={_port}; user={_usuario}; password={_senha}");
                connection.Open();
            }
            catch ( Exception ex )
            {
                throw ex;
            }
        
        
        }

        public MySqlCommand Comando (string comando)
        {

            try
            {
                command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = comando;

                return command;

            }
             catch ( Exception ex )
            {
                throw ex;
            }
        }

    }
}
