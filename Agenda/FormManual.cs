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
    public partial class FormManual : Form
    {
        public FormManual()
        {
            InitializeComponent();
        }

        // Método de carregar o arquivo pdf ao carregar a página
        private void FormManual_Load(object sender, EventArgs e)
        {
           axAcroPDF2.LoadFile("Excel.pdf");
        }
    }
}
