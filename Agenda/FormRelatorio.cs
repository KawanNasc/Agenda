using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;

namespace Agenda
{
    public partial class FormRelatorio : Form
    {
        Conexao c = new Conexao();
        Contato cont = new Contato();
        ControleContato ctrl = new ControleContato();

        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            string sql = "select * from tbcontato;";
            MySqlDataAdapter dtAdpt = new MySqlDataAdapter(sql, c.con);
            DataSetCont dtCont = new DataSetCont();
            dtAdpt.Fill(dtCont, "tbcontato");

            ReportDocument rptDoc = new CRContato();
            rptDoc.SetDataSource(dtCont);

            crystalReportViewer1.ReportSource = rptDoc;
        }

        private void FormRelatorio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conexao c = new Conexao();
            c.desconectar();
        }
    }
}
