using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Agenda
{
    public class ControleContato
    {

        // Instâncias das classes conexão e contato
        Conexao c = new Conexao();
        Contato cont = new Contato();

        // Método pública de retorno string cadastrar com a instância da contato
        public string cadastrar(Contato cont)
        {

            // Tenta executar o cadastro
            try
            {
                // Comando para inserir valores no banco de dados
                string sql = " INSERT INTO tbcontato (nome, telefone, celular, email) " + " VALUES (' " + cont.Nm + " ', ' " + 
                                                                                                          cont.Tel + " ', ' " + 
                                                                                                          cont.Cel + " ', ' " + 
                                                                                                          cont.Email + " '); ";

                // Objeto de execução do comando selecionando a execução sugerida pela sql + conexão necessária da BD
                MySqlCommand comando = new MySqlCommand(sql, c.con);

                // Opera da classe Contato a função de conectar
                c.conectar();

                // Método de execução de acordo com o objeto comando
                comando.ExecuteNonQuery();

                // Desconectar o BD
                c.desconectar();

                // Retornar mensagem de sucesso
                return ("Cadastro realizado com sucesso!");
            }

            // Emissão do erro na execução do bloco try
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }

        // Mesmo procedimento do método cadastrar porém com outras ações na BD de acordo com o nome do método
        public string alterar(Contato cont)
        {
            try
            {
                string sql = "UPDATE tbcontato SET nome = ' " + cont.Nm +  " ', " + 
                                                  "telefone = ' " + cont.Tel + "', " +
                                                  "celular = ' " + cont.Cel + "', " +
                                                  "email = ' " + cont.Email + "' " +
                                                  "where codcontato = " + cont.Cod + "; ";

                MySqlCommand comando = new MySqlCommand(sql, c.con);

                c.conectar();
                comando.ExecuteNonQuery();
                c.desconectar();
                return ("Alteração realizado com sucesso!");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }

        public string excluir(Contato cont)
        {
            try
            {
                string sql = "DELETE from tbcontato where codcontato = " + cont.Cod + "; ";

                MySqlCommand comando = new MySqlCommand(sql, c.con);

                c.conectar();
                comando.ExecuteNonQuery();
                c.desconectar();
                return ("Exclusão realizado com sucesso!");
            }
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }

        public Contato consultar(int cod)
        {
            try
            {
                string sql = "SELECT * from tbcontato where codcontato = " + cod + "; ";

                MySqlCommand comando = new MySqlCommand(sql, c.con);

                c.conectar();

                MySqlDataReader objDados = comando.ExecuteReader();

                if (!objDados.HasRows)
                {
                    return null;
                }
                else
                {
                    objDados.Read();
                    cont.Cod = Convert.ToInt32(objDados["codcontato"]);
                    cont.Nm = objDados["nome"].ToString();
                    cont.Tel = objDados["telefone"].ToString();
                    cont.Email = objDados["celular"].ToString();

                    objDados.Close();
                    return cont;
                }
            }
            catch (MySqlException e)
            {
                throw (e);
            }
            finally 
            { 
                c.desconectar();
            }
        }

        // (PesquisaCodigo) Método pública de retorno à Tabela de dados buscar por código com seu parâmetro inteiro cod atribuído de um novo valor em Contato.cs
        public DataTable buscarPCodigo(int cod)
        {
            // Variável de string comando de banco de dados, selecionando todos os dados que estão como código do valor armazenado
            string sql = "SELECT codcontato AS 'Código', nome AS 'Nome', telefone AS 'Telefone', celular AS 'Tel. Celular', email AS 'E-Mail' FROM tbcontato WHERE codcontato = " + cod + ";";

            // Objeto da classe do sistema de comando sql de parâmetros da variável 'sql' do comando ditado em banco de dados com a conexão do banco de dados dos objetos de conexão
            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            
            // Operação de conectar ao BD
            c.conectar();

            // Objeto de adptação para selecionar a tabela do BD
            MySqlDataAdapter dtAdpt = new MySqlDataAdapter(cmd);

            // Objeto da tabela de dados do DataGridView
            DataTable tabela = new DataTable();

            // Com os dados da tabela na BD, preencha-os na DataGridView
            dtAdpt.Fill(tabela);

            // Operação de desconectar ao BD
            c.desconectar();

            // Retornar as informações finais da tabela
            return tabela;
        }

        // (PesquisaNome) Método pública de retorno à Tabela de dados buscar por código com seu parâmetro inteiro nome atribuído de um novo valor em Contato.cs
        public DataTable buscarPNome(string nm)
        {
            // Variável de string comando de banco de dados, selecionando todos os dados que estão como código do valor armazenado
            string sql = "SELECT codcontato AS 'Código', nome AS 'Nome', telefone AS 'Telefone', celular AS 'Tel. Celular', email AS 'E-Mail' FROM tbcontato WHERE nome LIKE '%" + nm +  "%';";

            // Mesmo procedimento do buscarPCodigo
            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            c.conectar();

            MySqlDataAdapter dtAdpt = new MySqlDataAdapter(cmd);
            DataTable tabela = new DataTable();

            dtAdpt.Fill(tabela);
            c.desconectar();

            return tabela;
        }
        
        // Mesmo procedimento do buscarPNome porém com outros campos em telefone, celular e e-mail
        public DataTable buscarPTel(string tel)
        {
            string sql = "SELECT codcontato AS 'Código', nome AS 'Nome', telefone AS 'Telefone', celular AS 'Tel. Celular', email AS 'E-Mail' FROM tbcontato WHERE telefone LIKE '%" + tel + "%';";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            c.conectar();

            MySqlDataAdapter dtAdpt = new MySqlDataAdapter(cmd);
            DataTable tabela = new DataTable();

            dtAdpt.Fill(tabela);
            c.desconectar();

            return tabela;
        }

        public DataTable buscarPCel(string cel)
        {
            string sql = "SELECT codcontato AS 'Código', nome AS 'Nome', telefone AS 'Telefone', celular AS 'Tel. Celular', email AS 'E-Mail' FROM tbcontato WHERE celular LIKE '%" + cel +  "%';";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            c.conectar();

            MySqlDataAdapter dtAdpt = new MySqlDataAdapter(cmd);
            DataTable tabela = new DataTable();

            dtAdpt.Fill(tabela);
            c.desconectar();

            return tabela;
        }

        public DataTable buscarPEmail(string email)
        {
            string sql = "SELECT codcontato AS 'Código', nome AS 'Nome', telefone AS 'Telefone', celular AS 'Tel. Celular', email AS 'E-Mail' FROM tbcontato WHERE email LIKE '%" + email + "%';";

            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            c.conectar();

            MySqlDataAdapter dtAdpt = new MySqlDataAdapter(cmd);
            DataTable tabela = new DataTable();

            dtAdpt.Fill(tabela);
            c.desconectar();

            return tabela;
        }
        // (ListarTodos) - Método de retorno de tabela de dados listar, sem parâmetros
        public DataTable Listar()
        {
            // Buscam todos os dados
            string sql = "SELECT codcontato AS 'Código', nome AS 'Nome', telefone AS 'Telefone', celular AS 'Tel. Celular', email AS 'E-Mail' from tbcontato;";

            // Mesmos procedimentos
            MySqlCommand cmd = new MySqlCommand(sql, c.con);
            c.conectar();

            MySqlDataAdapter dtAdpt = new MySqlDataAdapter(cmd);
            DataTable tabela = new DataTable();

            dtAdpt.Fill(tabela);
            c.desconectar();

            return tabela;
        }

        // Método pública de retorno em string de Backup com seu parâmetro string caminho
        public string Backup(string Caminho)
        {
            // Objeto da data atual
            string dtAtual = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");

            // Estabelece um nome e caminho enviado "C:\\backupContatos_2023-11-29-20-22-33" por exemplo
            string caminhoBackup = Caminho + "\\backupContatos_" + dtAtual + ".sql";

            // Tenta enviar para backup
            try
            {
                // Objeto de comando para execução de acordo com o envio estabelecido + conexão da BD
                MySqlCommand cmd = new MySqlCommand(caminhoBackup, c.con);

                // Objeto de Backup de acordo com o comando
                MySqlBackup backup = new MySqlBackup(cmd);

                // Opera da classe Contato a função de conectar
                c.conectar();

                // Execução da escrita do comando de exportação do backup sobre o arquivo
                backup.ExportToFile(caminhoBackup);

                // Desconectar o BD
                c.desconectar();

                // Retorno de mensagem de sucesso
                return ("Backup do BD realizado com sucesso!");
            }

            // Emissão do erro na execução do bloco try
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }
        
        // Método pública de retorno em string de restauração com seu parâmetro de caminho
        public string Restore(string Caminho)
        {
            // Tenta executar a restauração
            try
            {
                // Objeto de comando para execução de acordo com o envio estabelecido + conexão da BD
                MySqlCommand cmd = new MySqlCommand(Caminho, c.con);

                // Objeto de Backup de acordo com o comando
                MySqlBackup backup = new MySqlBackup(cmd);

                // Opera da classe Contato a função de conectar
                c.conectar();

                // Execução da escrita do comando de importação do backup sobre o arquivo
                backup.ImportFromFile(Caminho);

                // Desconectar o BD
                c.desconectar();

                // Retorno de mensagem de sucesso
                return ("BD restaurado com sucesso");
            }

            // Emissão do erro na execução do bloco try
            catch (MySqlException e)
            {
                return (e.ToString());
            }
        }
    }
}
