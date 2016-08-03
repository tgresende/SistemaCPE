using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Dominio
{
    public enum TipoDocumentoPessoa
    {
        Nulo, Cpf, Cnpj
    }

    public enum CompraVendaPedido
    {
        Nulo, Compra, Venda
    }

    public enum PagarReceber
    {
        Nulo, Pagar, Receber
    }

    public enum CreditoDebito
    {
        Nulo, Credito, Debito
    }
}
