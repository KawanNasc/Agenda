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
    public partial class FormAlterar : Form
    {
        // Instâncias da classes contato e controle contato
        Contato cont = new Contato();
        ControleContato ctrl = new ControleContato();

        public FormAlterar()
        {
            InitializeComponent();
        }

        // Método de limpar os textos sem parâmetros e retornos
        private void limpar()
        {
            txtCod.Clear();
            txtNm.Clear();
            mtbTel.Clear();
            mtbCel.Clear();
            txtEMail.Clear();
        }

        // Método do clique do botão alterar
        private void btnAlt_Click(object sender, EventArgs e)
        {
            // Se nada for digitado na caixa número, emitirá mensagem de não permissão da alteração
            if (txtNm.Text == "")
            {
                MessageBox.Show("Não é permitido alteração sem um nome!!!");
            }
            // Se for digitado
            else
            {
               // Armazenamento das informações para os campos acessores de acordo com que foi digitado nas caixas de texto
                cont.Cod = Convert.ToInt32(txtCod.Text);
                cont.Nm = txtNm.Text;
                cont.Tel = mtbTel.Text;
                cont.Cel = mtbCel.Text;
                cont.Email = txtEMail.Text;

                // Execução e retorno da alteração na classe controle contato de acordo com todos os armazenamentos de informações
                MessageBox.Show(ctrl.alterar(cont));

                // Ação do método limpar
                limpar();
            }

        }
    }
}
