using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Agenda
{
    public class Logar
    {
        // Instância da conexão
        Conexao c = new Conexao();

        // Método de login pública booleana com seus parâmetros de string: email e senha
        public bool Log(string email, string senha)
        {
            // Tenta realizar o login
            try
            {
                // Comando para verificar se existe o email e senha digitada dos parâmetros na BD
                string sql = "select email, senha from tblogin where email like '" + email + "' and senha like '" + senha + "';";

                // Objeto do comando sql + conexão da BD
                MySqlCommand cmd = new MySqlCommand(sql, c.con);

                // Opera da classe Contato a função de conectar
                c.conectar();

                // Objeto um leitor de dados do resultado da cmd com a função de executar o leitor
                MySqlDataReader objDados = cmd.ExecuteReader();

                // Se este objeto não tiver linhas (Dados)
                if ( !objDados.HasRows ) 
                {
                    // Retorna falso
                    return false;
                }

                // Se houver
                else
                {
                    // Retorno verdadeiro
                    return true;
                }
            }
            // Emissão do erro na execução do bloco try
            catch (MySqlException e)
            {
                throw (e);
            }
            // Por fim, desconectar o BD
            finally
            {
                c.desconectar();
            }
        }
    }
}
