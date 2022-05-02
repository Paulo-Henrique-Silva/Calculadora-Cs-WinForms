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

        private void F_Calculadora_Load(object sender, EventArgs e) => Icon = Properties.Resources.Icon_Calculadora;

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
        /// A partir de um botão, atualiza o val1 conforme a operação digitada.
        /// </summary>
        /// <param name="sender">Botão como objeto</param>
        /// <param name="e"></param>
        private void ObtemOpDigitada(object sender, EventArgs e)
        {
            //Caso a op indique se o número é positivo ou negativo
            if (string.IsNullOrEmpty(Lbl_Display.Text) && ((sender as Button).Text == "+" || (sender as Button).Text == "-"))
                Lbl_Display.Text += (sender as Button).Text;

            if (decimal.TryParse(Lbl_Display.Text, out decimal val1Update))
            {
                //salva a ultima op digitada e obtem a atual 
                string ultimaOp = OpSymb;
                OpSymb = (sender as Button).Text;

                //Atualiza o val1 conforme a op anterior, caso haja uma
                switch (ultimaOp) 
                {
                    case "+":
                        val1 += val1Update;
                        break;

                    case "-":
                        val1 -= val1Update;
                        break;

                    case "*":
                        val1 *= val1Update;
                        break;

                    case "/":

                        if (val1Update == 0)
                        {
                            DivZeroErro();
                            return;
                        }
                        else 
                            val1 /= val1Update;

                        break;

                    default:
                        val1 = val1Update;
                        break;
                }

                Lbl_Display.ResetText();
                Lbl_Conta.Text = $"{val1} {OpSymb}"; //mostra a conta atual ao user
            }
        }

        /// <summary>
        /// Realiza a Operação val1 + val2 (atual número no display).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Igual_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(Lbl_Display.Text, out decimal val2))
            {
                switch (OpSymb) //termina a conta conforme a op digitada pelo usuário
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

                        if (val2 == 0)
                        {
                            DivZeroErro();
                            return;
                        }
                        else
                            Lbl_Display.Text = (val1 / val2).ToString();

                        break;

                    default:
                        Lbl_Display.Text = val2.ToString();
                        val1 = '\0';
                        break;
                }

                //mostra a conta completa ao user
                Lbl_Conta.Text = (val1 == '\0') ? $"{val2} = " : $"{val1} {OpSymb} {val2} = ";

                //reseta o val1 e a op para recomeçar a conta
                val1 = 0m; 
                OpSymb = string.Empty;
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
            //reseta todos os elementos da calculadora
            Lbl_Display.ResetText();
            Lbl_Conta.ResetText();
            val1 = 0m;
            OpSymb = string.Empty;
        }

        private void DivZeroErro()
        {
            MessageBox.Show("É impossível dividir por Zero.", "Math Error");

            Lbl_Display.ResetText();
            Lbl_Conta.ResetText();
            val1 = 0m;
            OpSymb = string.Empty;
        }
    }
}