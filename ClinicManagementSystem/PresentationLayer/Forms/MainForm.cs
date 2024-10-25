using Microsoft.Extensions.DependencyInjection;
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
    public partial class MainForm : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public MainForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }



        private void doctorButton_Click(object sender, EventArgs e)
        {
            var doctorForm = _serviceProvider.GetRequiredService<DoctorForm>();
            doctorForm.ShowDialog();
        }

        private void patientsButton_Click(object sender, EventArgs e)
        {
            var patientForm = _serviceProvider.GetRequiredService<PatientForm>();
            patientForm.ShowDialog();
        }
    }

}
