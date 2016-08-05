using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using App.Comunicacao;

namespace App.MetroApp.UsersControl
{
    public partial class ucCadCliente : DevExpress.XtraEditors.XtraUserControl
    {
        private void PreencheGrid(string filtro)
        {
            bsClients.Clear();
            foreach (var Client in Servicos.ClientesServico.SelecionarClientes())
                bsClients.Add(Client);
        }

        public ucCadCliente()
        {
            InitializeComponent();
        }
    }
}
