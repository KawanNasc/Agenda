using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {

        // Instância da classe controle de controle
        ControleContato ctrl = new ControleContato();

        public Form1()
        {
            InitializeComponent();
        }

        // Execução e retorno da conexão do Banco de Dados
        private void Form1_Load(object sender, EventArgs e)
        {

            // Instância da classe de conexão
            Conexao conexao = new Conexao();

            // Resultado da operação do método conectar emitido na caixa de mensagem
            MessageBox.Show(conexao.conectar());
        }

        // Método do botão de item do menustrip de cadastro
        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instancia e mostra a tela de cadastro
            FormCadastro cad = new FormCadastro();
            cad.ShowDialog();
        }

        // Mesmo procedimento porém com diferentes botões de itens
        private void atualizacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlterar alt = new FormAlterar();
            alt.ShowDialog();
        }

        private void exclusãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExclusao exc = new FormExclusao();
            exc.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsulta cons = new FormConsulta();
            cons.ShowDialog();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Execução e retorno da caixa de mensagem, determinando o endereço C:\\Backup como local de envio no método Backup da instância de controle contato
            MessageBox.Show(ctrl.Backup("C:\\Backup"), "Backup do Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void restauraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Objeto de tela de adicionar arquivos do explorador de arq. 
            OpenFileDialog ofd = new OpenFileDialog();

            // Apenas mostrar como opções para restaurar arquivos do formato .sql
            ofd.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*";

            // Se a tela de add. estiver clicada (Botão do Ok)
            if ( ofd.ShowDialog() == DialogResult.OK )
            {
                // Objeto do caminho do backup selecionado
                string CaminhoBackup = ofd.FileName;

                // Execução e retorno da caixa de mensagem, determinando o caminho do arquivo a ser restaurado pelo método Restore da instância de controle contato
                MessageBox.Show(ctrl.Restore(CaminhoBackup), "Restauração do BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRelatorio relatorio = new FormRelatorio();
            relatorio.ShowDialog();
        }

        private void manualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormManual manual = new FormManual();
            manual.ShowDialog();
        }

        // Método de clique do botão sair da aplicação
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
