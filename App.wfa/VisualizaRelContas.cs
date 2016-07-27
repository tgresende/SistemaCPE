using App.Comunicacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace App.wfa
{
    public partial class VisualizaRelContas : Form
    {
        public string titulo;
        public VisualizaRelContas()
        {
            InitializeComponent();
           
        }

        private void VisualizaRelCustos_Load(object sender, EventArgs e)
        {
            foreach (var conta in Servicos.ContasServico.SelecionarContasRel("0==0"))            
            {
                bsContas.Add(conta);
            }




            ReportParameter p = new ReportParameter("pNomeProjeto", titulo);
            this.rvContas.LocalReport.SetParameters(p);

            this.rvContas.RefreshReport();

            this.rvContas.RefreshReport();
        }
    }
}
