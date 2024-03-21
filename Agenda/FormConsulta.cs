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
    public partial class FormConsulta : Form
    {
        // Instâncias da classes contato e controle contato
        Contato cont = new Contato();
        ControleContato ctrl = new ControleContato();

        public FormConsulta()
        {
            InitializeComponent();
        }

        // Método de limpar o texto sem parâmetros e retornos
        private void limpar()
        {
            txtCod.Clear();
        }

        // Método do clique do botão consulta
        private void btnConsulta_Click(object sender, EventArgs e)
        {

            // Tenta executar a consulta
            try
            {
                // Será armazenada a informação dos campos do contato pela operação de consultar com o texto do código digitado no controle contato
                cont = ctrl.consultar(int.Parse(txtCod.Text));

                // Se o armazenamento estiver nulo, emitir alerta de sem informações encontradas
                if ( cont is null )
                {
                    MessageBox.Show("Registro não cadastrado");
                }

                // Se houver alguma informação, emitir o nome na label nome e limpar a caixa de texto
                else
                {
                    lblNm.Text = cont.Nm.ToString();
                    limpar();
                }
            }
            // Emissão do erro na execução do bloco try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Método do clique do botão buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Se a opção da combobox das opções de busca for igual a 0 (Código)
            if (cmbOpcoes.SelectedIndex == 0)
            {
                try
                {
                    // Armazena a informação do texto da pesquisa na variável
                    int codigo = Convert.ToInt32(txtPesquisa.Text);

                    // Preenche a fonte da informação na tabela pelo método de buscar pelo código digitado de acordo com a informação armazenada
                    dgvTabela.DataSource = ctrl.buscarPCodigo(codigo);
                }
                catch
                {
                    MessageBox.Show("Digite um valor inteiro para o código!");
                    txtPesquisa.Clear();
                }
            }

            // Mesmo procedimento porém com opções de buscas diferentes e sem a necessidade dos blocos try e catch
            else if (cmbOpcoes.SelectedIndex == 1)
            {
                string nm = txtPesquisa.Text;
                dgvTabela.DataSource = ctrl.buscarPNome(nm);
            }
            else if (cmbOpcoes.SelectedIndex == 2)
            {
                string tel = txtPesquisa.Text;
                dgvTabela.DataSource = ctrl.buscarPTel(tel);
            }
            else if (cmbOpcoes.SelectedIndex == 3)
            {
                string cel = txtPesquisa.Text;
                dgvTabela.DataSource = ctrl.buscarPCel(cel);
            }
            else if (cmbOpcoes.SelectedIndex == 4)
            {
                string email = txtPesquisa.Text;
                dgvTabela.DataSource = ctrl.buscarPEmail(email);
            }
        }

        // Método do clique botão de listar, onde emite a listagem de todos os dados da BD do método de listar no controle contato preenchidos na tabela
        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvTabela.DataSource = ctrl.Listar();
        }

        // Método de selecionamento da combobox de opções
        private void cmbOpcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Se nenhum item for selecionado (0 é o 1°item da lista, então '< 0' representa nada selecionado)
            if (cmbOpcoes.SelectedIndex < 0)
            {
                // Desativa a caixa de texto pesquisa e botão de busca e esvazia a label de resultado
                txtPesquisa.Enabled = false;
                btnBuscar.Enabled = false;
                lblRes.Text = "";
            }
            // Se houver algum item selecionado
            else
            {
                // Ativa o texto de pesquisa, emite a mensagem de digitar a respectiva opção no label resultado, apaga e foca o texto da pesquisa
                txtPesquisa.Enabled = true;
                lblRes.Text = "Digite o " + cmbOpcoes.Text;
                txtPesquisa.Clear();
                txtPesquisa.Focus();
            }

        }

        // Método da mudança de texto da caixa de pesquisa, se houver algum caracter, botão de buscar é ativado, se não é desativado
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisa.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }
    }
}
