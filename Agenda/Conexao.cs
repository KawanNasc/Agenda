using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Agenda
{
    public class Conexao
    {
        // Instância de comando da BD (Servidor, porta, base de ados, usuário e senha)
        public MySqlConnection con = new MySqlConnection(@"Server=localhost; Port=3306; Database=agenda; User=root; Pwd=");

        // Método de conexão pública string sem parâmetros
        public string conectar()
        {
            // Tenta abrir a conexão e emitir a mensagem de sucesso
            try
            {
                con.Open();
                return ("Conexão realizada com sucesso");
            }

            // Caso não conseguir abrir, emite a falha
            catch (MySqlException e) 
            {
                return (e.ToString());
            }
        }

        // Método de desconexão pública string sem parâmetros
        public string desconectar()
        {
            // Tenta fechar a conexão e emitir a mensagem de sucesso
            try
            {
                con.Close();
                return ("Conexão realizada com sucesso");
            }

            // Caso não conseguir fechar, emite a falha
            catch (MySqlException e) 
            {
                return (e.ToString());
            }
        }
    }
}
