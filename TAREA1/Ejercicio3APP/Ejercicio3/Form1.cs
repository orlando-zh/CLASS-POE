namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener valores del formulario para el Romboide
            double baseRomboide = double.Parse(txtBaseRomboide.Text);
            double alturaRomboide = double.Parse(txtAlturaRomboide.Text);
            double ladoRomboide = double.Parse(txtLadoRomboide.Text);

            // Crear objeto Romboide
            Romboide romboide = new Romboide(baseRomboide, alturaRomboide, ladoRomboide);

            // Calcular y mostrar resultados del Romboide
            lblAreaRomboide.Text = $"Área del Romboide: {romboide.CalcularArea()}";
            lblPerimetroRomboide.Text = $"Perímetro del Romboide: {romboide.CalcularPerimetro()}";

            // Obtener valores del formulario para el Trapezoide
            double baseMayorTrapezoide = double.Parse(txtBaseMayorTrapezoide.Text);
            double baseMenorTrapezoide = double.Parse(txtBaseMenorTrapezoide.Text);
            double alturaTrapezoide = double.Parse(txtAlturaTrapezoide.Text);
            double lado1Trapezoide = double.Parse(txtLado1Trapezoide.Text);
            double lado2Trapezoide = double.Parse(txtLado2Trapezoide.Text);

            // Crear objeto Trapezoide
            Trapezoide trapezoide = new Trapezoide(baseMayorTrapezoide, baseMenorTrapezoide, alturaTrapezoide, lado1Trapezoide, lado2Trapezoide);

            // Calcular y mostrar resultados del Trapezoide
            lblAreaTrapezoide.Text = $"Área del Trapezoide: {trapezoide.CalcularArea()}";
            lblPerimetroTrapezoide.Text = $"Perímetro del Trapezoide: {trapezoide.CalcularPerimetro()}";
        }
    }

    public class Romboide
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado { get; set; }

        public Romboide(double base, double altura, double lado)
        {
            Base = base;
            Altura = altura;
            Lado = lado;
        }

        public double CalcularArea()
        {
            return Base * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Base + Lado);
        }
    }

    public class Trapezoide
    {
        public double BaseMayor { get; set; }
        public double BaseMenor { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public Trapezoide(double baseMayor, double baseMenor, double altura, double lado1, double lado2)
        {
            BaseMayor = baseMayor;
            BaseMenor = baseMenor;
            Altura = altura;
            Lado1 = lado1;
            Lado2 = lado2;
        }

        public double CalcularArea()
        {
            return ((BaseMayor + BaseMenor) / 2) * Altura;
        }

        public double CalcularPerimetro()
        {
            return BaseMayor + BaseMenor + Lado1 + Lado2;
        }
    }
}
