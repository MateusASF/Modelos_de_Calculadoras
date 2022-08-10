using calculadoras;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace calculadoraIMC
{
    public partial class CalculadoraBasica : Form
    {
        double value1, value2;
        string calc;

        public CalculadoraBasica()
        {
            InitializeComponent();
        }


        private void bt_limpar_Click(object sender, EventArgs e)
        {
            insert_calc.Text = "";
        }

        private void bt_resultado_Click(object sender, EventArgs e)
        {
            DataTable Calc = new DataTable();
            insert_calc.Text = insert_calc.Text.Replace(',', '.');
            var result = Calc.Compute(insert_calc.Text, "");
            insert_calc.Text = result.ToString();
        }

        private void bt_backspace_Click(object sender, EventArgs e)
        {
            insert_calc.Text = insert_calc.Text.Substring(0, insert_calc.Text.Length - 1);
        }


        #region Clicks Operações Básicas
        private void bt_subtrair_Click(object sender, EventArgs e)
        {
            insert_calc.Text += "-";
        }

        private void bt_somar_Click(object sender, EventArgs e)
        {
            insert_calc.Text += "+";
        }

        private void bt_multiplicar_Click(object sender, EventArgs e)
        {
            insert_calc.Text += "*";
        }

        private void bt_dividir_Click(object sender, EventArgs e)
        {
            insert_calc.Text += "/";
        }

        

        #endregion

        #region Clicks numerais
        private void bt_num1_Click(object sender, EventArgs e)
        {
            insert_calc.Text += '1';
        }

        private void bt_num2_Click(object sender, EventArgs e)
        {
            insert_calc.Text += '2';
        }

        private void bt_num3_Click(object sender, EventArgs e)
        {
            insert_calc.Text += '3';
        }

        private void bt_num4_Click(object sender, EventArgs e)
        {
            insert_calc.Text += '4';
        }

        private void bt_num5_Click(object sender, EventArgs e)
        {
            insert_calc.Text += '5';
        }

        private void bt_num6_Click(object sender, EventArgs e)
        {
            insert_calc.Text += '6';
        }

        private void bt_num7_Click(object sender, EventArgs e)
        {
            insert_calc.Text += '7';
        }

        private void bt_num8_Click(object sender, EventArgs e)
        {
            insert_calc.Text += '8';
        }

        private void bt_num9_Click(object sender, EventArgs e)
        {
            insert_calc.Text += '9';
        }


        private void bt_num0_Click(object sender, EventArgs e)
        {
            insert_calc.Text += '0';
        }
        #endregion

        private void bt_Back_Basic_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
