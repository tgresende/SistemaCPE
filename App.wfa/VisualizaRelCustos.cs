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
    public partial class VisualizaRelCustos : Form
    {
        public string titulo;
        public VisualizaRelCustos()
        {
            InitializeComponent();
           
        }

        private void VisualizaRelCustos_Load(object sender, EventArgs e)
        {
         /*   foreach (var gasto in Servicos.gastosServico.SelecionarGastos("0==0"))
            
            {
                dsGastosProjetos.Add(gasto);
            }




            ReportParameter p = new ReportParameter("pNomeProjeto", titulo);
            this.rvCustos.LocalReport.SetParameters(p);

            this.rvCustos.RefreshReport();
          * */
        }
    }
}
