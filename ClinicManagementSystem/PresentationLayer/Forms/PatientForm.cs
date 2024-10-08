using BusinessLayer.Services;
using BusinessLayer.Services.Patients;
using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class PatientForm : Form
    {
        private PatientService _patientService;
        private bool _isEditing = false;

        public PatientForm()
        {
            InitializeComponent();
            _patientService = new PatientService();

            LoadPatientsData();

            doctorComboBox.DataSource = _patientService.GetDoctors();
            doctorComboBox.DisplayMember = "Doctor";
            doctorComboBox.ValueMember = "Id";
        }

        private void LoadPatientsData()
        {
            patientsDataGridView.DataSource = _patientService.GetAllPatients();
        }

        private void savePatientButton_Click(object sender, EventArgs e)
        {
            if (_isEditing)
            {
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTexBox.Text;
                int age = Convert.ToInt32(ageTextBox.Text);
                int doctorId = Convert.ToInt32(doctorComboBox.SelectedValue);
                int id = int.Parse(patientsDataGridView.CurrentRow.Cells[0].Value.ToString());

                Patient patient = new Patient()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    DoctorId = doctorId,
                    PatientId = id
                };

                _patientService.EditPatient(patient);
                LoadPatientsData();

                _isEditing = false;
            }
            else
            {
                Patient patient = new Patient()
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTexBox.Text,
                    Age = Convert.ToInt32(ageTextBox.Text),
                    DoctorId = Convert.ToInt32(doctorComboBox.SelectedValue)
                };

                _patientService.AddPatient(patient);

                LoadPatientsData();
            }

        }

        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            if (patientsDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var deleteConfirm = new DialogResult();

                deleteConfirm = MessageBox.Show("Está seguro que desea eliminar el dato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteConfirm == DialogResult.Yes)
                {
                    int id = int.Parse(patientsDataGridView.CurrentRow.Cells[0].Value.ToString());
                    _patientService.DeletePatient(id);
                    LoadPatientsData();
                }
            }
        }

        private void editPatientButton_Click(object sender, EventArgs e)
        {
            if (patientsDataGridView.SelectedRows.Count > 0)
            {
                firstNameTextBox.Text = patientsDataGridView.CurrentRow.Cells[1].Value.ToString();
                lastNameTexBox.Text = patientsDataGridView.CurrentRow.Cells[2].Value.ToString();
                ageTextBox.Text = patientsDataGridView.CurrentRow.Cells[3].Value.ToString();
                doctorComboBox.Text = patientsDataGridView.CurrentRow.Cells[4].Value.ToString();
                _isEditing = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }
        }
    }
}
