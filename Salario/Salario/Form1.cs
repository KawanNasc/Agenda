using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReajustar_Click(object sender, EventArgs e)
        {
            // Instâncias das classes derivadas
            Programador programador = new Programador();
            Designer designer = new Designer();
            DevWeb devweb = new DevWeb();

            // Variáveis de interpretação das caixas de texto nome e salário
            decimal salario = Convert.ToDecimal(txtSalario.Text);
            string nm = txtNm.Text;

            // Caso a radio button de Designer estiver assinalada
            if ( rdbDesigner.Checked )
            {
                // Objeto da classe designer com a variável de salário do Funcionário será igual ao texto do Salário 
                designer.salario = salario;
                // Executa com método Reajustar junto com o objeto 
                designer.Reajustar();
                // Texto do resultado será igual ao objeto designer do salário convertida para String
                lblResultado.Text = designer.salario.ToString();
            }
            // Caso a radio button de Programador estiver assinalada
            else if ( rdbProgramador.Checked )
            {
                // Objeto da classe programador com a variável de salário do Funcionário será igual ao texto do Salário 
                programador.salario = salario;
                // Executa com método Reajustar junto com o objeto
                programador.Reajustar();
                // Texto do resultado será igual ao objeto programador do salário convertida para String
                lblResultado.Text = programador.salario.ToString();
            }
            // Caso a radio button de DevWeb estiver assinalada
            else if (rdbDevWeb.Checked)
            {
                // Objeto da classe devweb com a variável de salário do Funcionário será igual ao texto do Salário 
                devweb.salario = salario;
                // Executa com método Reajustar junto com o objeto
                devweb.Reajustar();
                // Texto do resultado será igual ao objeto devweb do salário convertida para String
                lblResultado.Text = devweb.salario.ToString();
            }
        }
    }
}
