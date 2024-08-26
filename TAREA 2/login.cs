using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void buttonInit_Click(object sender, EventArgs e)
        {
            // Create an instance of Form1
            Form1 form1 = new Form1();

            // Show the Form1 window
            form1.Show();

            this.Hide();
        }
    }
}
