using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Calculadora
{
    /// <summary>
    /// Classe Responsável por executar as operações referentes aos componentes do form F_Calculadora.
    /// </summary>
    public static class Operacoes
    {
        /// <summary>
        /// Concatena um Digito ao Texto do Label (Display)
        /// </summary>
        /// <param name="digito"></param>
        public static void AdicionaAoDisplay(F_Calculadora form, char digito)
        {
           form.DisplayText += digito;
        }
    }
}
