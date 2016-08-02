using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.CA
{
    class Program
    {
        static void Main(string[] args)
        {
            string cpf = "089 .509.  376-61  ";
            string cnpj = "53 ad .235.  456/0rt001-25";

            string cpf2 = Library.Rotinas.SomenteNumeros(cpf);
            string cnpj2 = Library.Rotinas.SomenteNumeros(cnpj);
            bool bcpf = Library.Rotinas.ValidaCpfCnpj(cpf);
            bool bcnpj = Library.Rotinas.ValidaCpfCnpj(cnpj);

        }
    }
}
