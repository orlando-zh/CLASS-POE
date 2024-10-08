using BusinessLayer.Services;
using BusinessLayer.Services.Doctors;
using CommonLayer.Entities;
using FluentValidation.Results;
using PresentationLayer.Validations;
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
    public partial class DoctorForm : Form
    {
        private DoctorService _doctorService;
        bool isEditing = false;
        public DoctorForm()
        {
            InitializeComponent();
            _doctorService = new DoctorService();
            LoadDoctorsData();
        }

        private void LoadDoctorsData()
        {
            doctorDataGridView.DataSource = _doctorService.GetAllDoctors();
        }

        private void addDoctorButton_Click(object sender, EventArgs e)
        {
            if (isEditing) 
            {
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                int id = int.Parse(doctorDataGridView.CurrentRow.Cells[0].Value.ToString());

                Doctor doctor = new Doctor();
                doctor.FirstName = firstName;
                doctor.LastName = lastName;
                doctor.Id = id;

                _doctorService.UpdateDoctor(doctor);
                LoadDoctorsData();

                isEditing = false;
            }
            else
            {
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;

                Doctor doctor = new Doctor();
                doctor.FirstName = firstName;
                doctor.LastName = lastName;

                DoctorValidator doctorValidator = new DoctorValidator();
                ValidationResult result = doctorValidator.Validate(doctor);

                if (!result.IsValid)
                {
                    DisplayValidationErrors(result);
                }
                else
                {

                    _doctorService.AddDoctor(doctor);
                    LoadDoctorsData();
                }
            }
        }

        private void deleteDoctorButton_Click(object sender, EventArgs e)
        {
            if (doctorDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var deleteConfirm = new DialogResult();

                deleteConfirm = MessageBox.Show("Está seguro que desea eliminar el dato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteConfirm == DialogResult.Yes)
                {
                    int id = int.Parse(doctorDataGridView.CurrentRow.Cells[0].Value.ToString());
                    _doctorService.DeleteDoctor(id);
                    LoadDoctorsData();
                }
            }
        }

        private void editDoctorButton_Click(object sender, EventArgs e)
        {
            if(doctorDataGridView.SelectedRows.Count > 0)
            {
                firstNameTextBox.Text = doctorDataGridView.CurrentRow.Cells[1].Value.ToString();
                lastNameTextBox.Text = doctorDataGridView.CurrentRow.Cells[2].Value.ToString();
                isEditing = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }
        }

        private void DisplayValidationErrors(ValidationResult result)
        {
            validationErrorProvider.Clear();

            foreach(var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Doctor.FirstName):
                        validationErrorProvider.SetError(firstNameTextBox, error.ErrorMessage);
                    break;
                    case nameof(Doctor.LastName):
                        validationErrorProvider.SetError(lastNameTextBox, error.ErrorMessage);
                    break;
                }
            }
        }
    }
}
