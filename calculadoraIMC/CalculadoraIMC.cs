namespace calculadoraIMC
{
    public partial class CalculadoraIMC : Form
    {
        public CalculadoraIMC()
        {
            InitializeComponent();
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            double peso, altura;


            peso = Convert.ToDouble(insert_peso.Text.Replace(".",","));
            altura =  Convert.ToDouble(insert_altura.Text.Replace(".", ","));

            var (descricaoImc, resultadoImc) = Calcular_IMC(peso, altura);

            lb_resultado.Text = $"Resultado\n{descricaoImc}\nSeu IMC: {resultadoImc:f2}";
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            insert_altura.Clear();
            insert_peso.Clear();
            lb_resultado.Text = "";
        }


        private (string, double) Calcular_IMC (double peso, double altura)
        {
            var imc = peso / (Math.Pow(altura, 2));
            var resultado = imc switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso normal",
                >= 25 and < 30 => "Sobre peso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido",
            };

            return (resultado, imc);
        }

        private void CalculadoraIMC_Load(object sender, EventArgs e)
        {
            insert_peso.Focus();
        }

        private void bt_Back_IMC_Menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}