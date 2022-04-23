using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operações_Calculadora
{
    public static class CalculadoraOp
    {
        public static void AdicionaAoDisplay(Label display, char digito)
        {
            display.Text += digito;
        }
    }
}
