using BussisnesLayer.Services;
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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            string modelo = ModelTextBox.Text; 
            decimal precio;

            if (!decimal.TryParse(PriceTextBox.Text, out precio))
            {
                MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime saleDate = SaledateTimePicker.Value;

            int cantidad;
            if (!int.TryParse(QuantitytextBox.Text, out cantidad))
            {
                MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalAmount;
            if (!decimal.TryParse(AmounttextBox.Text, out totalAmount))
            {
                MessageBox.Show("Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Car nuevoCarro = new Car
            {
                Model = modelo,
                Price = precio
            };


            Sale nuevaVenta = new Sale
            {
                SaleDate = saleDate,
                Quantity = cantidad,
                TotalAmount = totalAmount,
                CarID = nuevoCarro.CarID 
            };

    
            CarService carService = new CarService();
            carService.AddCar(nuevoCarro); 
            SaleService saleService = new SaleService();
            saleService.AddSale(nuevaVenta); 

            ModelTextBox.Clear();
            PriceTextBox.Clear(); 
            QuantitytextBox.Clear(); 
            AmounttextBox.Clear();




        }
    }
}
    
