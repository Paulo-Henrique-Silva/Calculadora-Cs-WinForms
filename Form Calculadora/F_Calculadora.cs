using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Calculadora
{
    public partial class F_Calculadora : Form
    {
        private decimal val1;
        private string OpSymb;

        public F_Calculadora()
        {
            InitializeComponent();
        }

        /// <summary>
        /// A partir de um botão, adiciona o texto do botão ao Display.
        /// </summary>
        /// <param name="sender">Botão como objeto</param>
        /// <param name="e"></param>
        private void AdicionaNumAoDisplay(object sender, EventArgs e)
        {
            Lbl_Display.Text += (sender as Button).Text;
        }

        /// <summary>
        /// A partir de um botão, adiciona o texto do botão(operação) ao display, caso o label vazio.
        /// </summary>
        /// <param name="sender">Botão como objeto</param>
        /// <param name="e"></param>
        private void ObtemOpDigitada(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Lbl_Display.Text))
            {
                OpSymb = (sender as Button).Text;
                val1 = decimal.Parse(Lbl_Display.Text);
                Lbl_Display.ResetText();
            }
        }

        private void Btn_Igual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Lbl_Display.Text))
            {
                decimal val2 = decimal.Parse(Lbl_Display.Text); 

                switch (OpSymb) 
                {
                    case "+":
                        Lbl_Display.Text = (val1 + val2).ToString();
                        break;

                    case "-":
                        Lbl_Display.Text = (val1 - val2).ToString();
                        break;

                    case "*":
                        Lbl_Display.Text = (val1 * val2).ToString();
                        break;

                    case "/":
                        Lbl_Display.Text = (val2 == 0) ? "Impossível Dividir!" : (val1 / val2).ToString();
                        break;
                };

            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            //Remove o último dígito com base no tamanho da string
            if (!string.IsNullOrEmpty(Lbl_Display.Text))
                Lbl_Display.Text = Lbl_Display.Text.Remove(Lbl_Display.Text.Length - 1);
        }

        private void Btn_AllClear_Click(object sender, EventArgs e)
        {
            Lbl_Display.ResetText();
            val1 = 0m;
            OpSymb = string.Empty;
        }
    }
}
