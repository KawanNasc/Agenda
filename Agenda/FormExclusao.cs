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
    public partial class FormExclusao : Form
    {

        // Instâncias da classes contato e controle contato
        Contato cont  = new Contato();
        ControleContato ctrl = new ControleContato();

        public FormExclusao()
        {
            InitializeComponent();
        }

        // Método de limpar o texto sem parâmetros e retornos
        private void limpar()
        {
            txtCod.Clear();
        }

        // Método do clique do botão excluir
        private void btnExc_Click(object sender, EventArgs e)
        {

            // Se nada for digitado na caixa número, emitirá mensagem de não permissão da exclusão
            if ( txtCod.Text == "" )
            {
                MessageBox.Show("Não é permitido exclusão sem digitar o código!");
            }

            // Se for digitado
            else
            {
                // Armazenamento das informações para os campos acessores de acordo com que foi digitado nas caixas de texto
                cont.Cod = Convert.ToInt32(txtCod.Text);

                // Execução e retorno da exclusão na classe controle contato de acordo com todos os armazenamentos de informações
                MessageBox.Show(ctrl.excluir(cont));

                // Ação do método limpar
                limpar();
            }
        }
    }
}
