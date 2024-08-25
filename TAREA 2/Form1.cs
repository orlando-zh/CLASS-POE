namespace ProyectoFinal
{
    using System.Collections.Generic;
    using System.Collections;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;
    using System.ComponentModel;

    public partial class Form1 : Form
    {
        private BindingList<Persona> personas = new BindingList<Persona>();
        private int edit_index = -1;//-1 para NO edicion.
        public Form1()
        {
            InitializeComponent();
            txtTelefono.KeyPress += new KeyPressEventHandler(txtTelefono_KeyPress);

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Persona per = new Persona();
            per.Nombre = txtNombre.Text;
            per.Apellido = txtApellido.Text;
            per.Telefono = txtTelefono.Text;
            per.Correo = txtCorreo.Text;

            if (edit_index != -1 && personas.Count > 0)
            {
                //Si edit index tiene una posiccion  a editar
                personas[edit_index] = per;
                edit_index = -1;
            }
            else
            {
                //Elemento nuevo
                personas.Add(per);
            }



            actualizarGrid();
            limpiar();

        }

        private void actualizarGrid()
        {
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = personas;
            dgvDatos.ClearSelection();

        }

        private void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvDatos.SelectedRows[0].Index;
                personas.RemoveAt(selectedIndex);
                actualizarGrid();
            }
        }

        private void dgvDatos_DoubleClick(object sender, EventArgs e)
        {

            DataGridViewRow seleccionada = dgvDatos.SelectedRows[0];
            int pos = dgvDatos.Rows.IndexOf(seleccionada);
            edit_index = pos;
            System.Diagnostics.Debug.WriteLine(pos);

            Persona per = personas[edit_index];
            txtNombre.Text = per.Nombre;
            txtApellido.Text = per.Apellido;
            txtTelefono.Text = per.Telefono;
            txtCorreo.Text = per.Correo;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvDatos.DataSource = personas;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}