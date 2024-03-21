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
    public partial class Login : Form
    {

        // Instância da classe de logar
        Logar lgn = new Logar();
        public Login()
        {
            InitializeComponent();
        }

        // Método de clique do botão entrar
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Se o texto do e-mail ou senha estiverem vazias
            if ( txtEMail.Text == "" || txtSenha.Text == "" )
            {
                // Exibição da exigência de inserir os valores da caixa de mensagem
                MessageBox.Show("Digite login e senha para acessar o sistema!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Se ambas estiverem preenchidas
            else
            {
                // Tentará o login
                try
                {
                    // Variável que obterá o retorno de verdadeiro ou falso das mensagens no método de logar da sua classe
                    bool logar = lgn.Log(txtEMail.Text, txtSenha.Text);


                    // Se logar for verdadeiro (Há um dado existente digitado na BD?) 
                    if ( logar == true )
                    {
                        // Esconderá a tela atual
                        this.Hide();

                        // Instância e exibição da tela principal
                        Form1 home = new Form1();
                        home.Show();
                    }

                    // Se não for verdadeiro (Ñão há um dado existente digitado na BD?) 
                    else
                    {
                        // Emissão da mensagem de erro de login
                        MessageBox.Show("E-Mail e/ou senha inválidos!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // Apagar o texto digitado anterior e passar o foco (Dígito determinado)
                        txtEMail.Clear();
                        txtSenha.Clear();
                        txtEMail.Focus();
                    }
                }

                // Emissão do erro na execução do bloco try
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Método de clique do botão sair da aplicação
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
