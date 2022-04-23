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
        /// <summary>
        /// Propriedade para acessar com segurança o Texto presente no Label Lbl_Display
        /// </summary>
        public string DisplayText 
        {
            get
            {
                return Lbl_Display.Text;
            }

            set
            {
                if (Lbl_Display.Text.Length < 20) //Evita que texto ultrapasse o Tamanho do Lbl
                    Lbl_Display.Text = value;
            }
        }

        public F_Calculadora()
        {
            InitializeComponent();
        }

        private void Btn_Num0_Click(object sender, EventArgs e)
        {
            Operacoes.AdicionaAoDisplay(this, '0');
        }

        private void Btn_Num1_Click(object sender, EventArgs e)
        {
            Operacoes.AdicionaAoDisplay(this, '1');
        }

        private void Btn_Num2_Click(object sender, EventArgs e)
        {
            Operacoes.AdicionaAoDisplay(this, '2');
        }

        private void Btn_Num3_Click(object sender, EventArgs e)
        {
            Operacoes.AdicionaAoDisplay(this, '3');
        }

        private void Btn_Num4_Click(object sender, EventArgs e)
        {
            Operacoes.AdicionaAoDisplay(this, '4');
        }

        private void Btn_Num5_Click(object sender, EventArgs e)
        {
            Operacoes.AdicionaAoDisplay(this, '5');
        }

        private void Btn_Num6_Click(object sender, EventArgs e)
        {
            Operacoes.AdicionaAoDisplay(this, '6');
        }

        private void Btn_Num7_Click(object sender, EventArgs e)
        {
            Operacoes.AdicionaAoDisplay(this, '7');
        }

        private void Btn_Num8_Click(object sender, EventArgs e)
        {
            Operacoes.AdicionaAoDisplay(this, '8');
        }

        private void Btn_Num9_Click(object sender, EventArgs e)
        {
            Operacoes.AdicionaAoDisplay(this, '9');
        }

        private void Btn_CasaDec_Click(object sender, EventArgs e)
        {

        }

        private void Btn_OpAdi_Click(object sender, EventArgs e)
        {
            Operacoes.AdicionaAoDisplay(this, '+');
        }

        private void Btn_OpSub_Click(object sender, EventArgs e)
        {
            Operacoes.AdicionaAoDisplay(this, '-');
        }

        private void Btn_OpMut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Lbl_Display.Text))
                Operacoes.AdicionaAoDisplay(this, '*');
        }

        private void Btn_OpDiv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Lbl_Display.Text))
                Operacoes.AdicionaAoDisplay(this, '/');
        }

        private void Btn_Igual_Click(object sender, EventArgs e)
        {

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
        }
    }
}
