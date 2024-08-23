namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Combarar_button(object sender, EventArgs e)
        {
         
            string cadena1 = textBox1.Text;
            string cadena2 = textBox2.Text;

           
            if (cadena1 == cadena2)
            {
                MessageBox.Show("Las cadenas son iguales.");
            }
            else
            {
                MessageBox.Show("Las cadenas son diferentes.");
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}