namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(textBox1.Text, out double anguloGrados))
            {
                MessageBox.Show("Ingrese un ángulo válido.");
                return;
            }


            double anguloRadianes = anguloGrados * Math.PI / 180;


            double tangente = Math.Tan(anguloRadianes);


            label1.Text = "Tangente en grados: " + tangente;
            label2.Text = "Tangente en radianes: " + tangente + " (para ángulo en radianes)";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
