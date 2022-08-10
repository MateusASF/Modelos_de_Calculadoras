using calculadoraIMC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace calculadoras
{
    public partial class MenuCalculadoras : Form
    {
    
        public MenuCalculadoras()
        {
            InitializeComponent();
        }

        private void bt_menu_calcIMC_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculadoraIMC formDesejasado = new CalculadoraIMC();
            formDesejasado.ShowDialog();
            this.Show();
        }

        private void bt_menu_calcBasic_Click(object sender, EventArgs e)
        {
            this.Hide();
            CalculadoraBasica formDesejasado = new CalculadoraBasica();
            formDesejasado.ShowDialog();
            this.Show();
        }


    }
}
