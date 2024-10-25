namespace PresentationLayer.Forms
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Principalpanel = new Panel();
            SalegroupBox = new GroupBox();
            SalesdataGridView = new DataGridView();
            button3 = new Button();
            btn = new Button();
            btnAddCar = new Button();
            Amountlabel = new Label();
            AmounttextBox = new TextBox();
            QuantitytextBox = new TextBox();
            Quantitylabel = new Label();
            DateSaleLabel = new Label();
            SaledateTimePicker = new DateTimePicker();
            priceLabel = new Label();
            modelLabel = new Label();
            PriceTextBox = new TextBox();
            ModelTextBox = new TextBox();
            flowLayoutPanel1 = new Panel();
            ModelCarbutton = new Button();
            Principalpanel.SuspendLayout();
            SalegroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalesdataGridView).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Principalpanel
            // 
            Principalpanel.Controls.Add(SalegroupBox);
            Principalpanel.Location = new Point(234, 0);
            Principalpanel.Name = "Principalpanel";
            Principalpanel.Size = new Size(1213, 700);
            Principalpanel.TabIndex = 0;
            // 
            // SalegroupBox
            // 
            SalegroupBox.Controls.Add(SalesdataGridView);
            SalegroupBox.Controls.Add(button3);
            SalegroupBox.Controls.Add(btn);
            SalegroupBox.Controls.Add(btnAddCar);
            SalegroupBox.Controls.Add(Amountlabel);
            SalegroupBox.Controls.Add(AmounttextBox);
            SalegroupBox.Controls.Add(QuantitytextBox);
            SalegroupBox.Controls.Add(Quantitylabel);
            SalegroupBox.Controls.Add(DateSaleLabel);
            SalegroupBox.Controls.Add(SaledateTimePicker);
            SalegroupBox.Controls.Add(priceLabel);
            SalegroupBox.Controls.Add(modelLabel);
            SalegroupBox.Controls.Add(PriceTextBox);
            SalegroupBox.Controls.Add(ModelTextBox);
            SalegroupBox.Location = new Point(28, 45);
            SalegroupBox.Name = "SalegroupBox";
            SalegroupBox.Size = new Size(1171, 626);
            SalegroupBox.TabIndex = 0;
            SalegroupBox.TabStop = false;
            SalegroupBox.Text = "Ventas y Carros";
            // 
            // SalesdataGridView
            // 
            SalesdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalesdataGridView.Location = new Point(529, 26);
            SalesdataGridView.Name = "SalesdataGridView";
            SalesdataGridView.RowHeadersWidth = 51;
            SalesdataGridView.Size = new Size(636, 594);
            SalesdataGridView.TabIndex = 13;
            // 
            // button3
            // 
            button3.Location = new Point(329, 544);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 12;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            btn.Location = new Point(175, 544);
            btn.Name = "btn";
            btn.Size = new Size(125, 29);
            btn.TabIndex = 11;
            btn.Text = "Realizar venta";
            btn.UseVisualStyleBackColor = true;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(33, 544);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(120, 29);
            btnAddCar.TabIndex = 10;
            btnAddCar.Text = "Agregar carro";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // Amountlabel
            // 
            Amountlabel.AutoSize = true;
            Amountlabel.Location = new Point(26, 426);
            Amountlabel.Name = "Amountlabel";
            Amountlabel.Size = new Size(42, 20);
            Amountlabel.TabIndex = 9;
            Amountlabel.Text = "Total";
            // 
            // AmounttextBox
            // 
            AmounttextBox.Location = new Point(28, 449);
            AmounttextBox.Name = "AmounttextBox";
            AmounttextBox.Size = new Size(125, 27);
            AmounttextBox.TabIndex = 8;
            // 
            // QuantitytextBox
            // 
            QuantitytextBox.Location = new Point(26, 359);
            QuantitytextBox.Name = "QuantitytextBox";
            QuantitytextBox.Size = new Size(125, 27);
            QuantitytextBox.TabIndex = 7;
            // 
            // Quantitylabel
            // 
            Quantitylabel.AutoSize = true;
            Quantitylabel.Location = new Point(28, 336);
            Quantitylabel.Name = "Quantitylabel";
            Quantitylabel.Size = new Size(74, 20);
            Quantitylabel.TabIndex = 6;
            Quantitylabel.Text = "Cantitdad";
            // 
            // DateSaleLabel
            // 
            DateSaleLabel.AutoSize = true;
            DateSaleLabel.Location = new Point(28, 236);
            DateSaleLabel.Name = "DateSaleLabel";
            DateSaleLabel.Size = new Size(108, 20);
            DateSaleLabel.TabIndex = 5;
            DateSaleLabel.Text = "Fecha de venta";
            // 
            // SaledateTimePicker
            // 
            SaledateTimePicker.Location = new Point(26, 260);
            SaledateTimePicker.Name = "SaledateTimePicker";
            SaledateTimePicker.Size = new Size(250, 27);
            SaledateTimePicker.TabIndex = 4;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(26, 142);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(50, 20);
            priceLabel.TabIndex = 3;
            priceLabel.Text = "Precio";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(26, 34);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(61, 20);
            modelLabel.TabIndex = 2;
            modelLabel.Text = "Modelo";
            // 
            // PriceTextBox
            // 
            PriceTextBox.Location = new Point(26, 165);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(125, 27);
            PriceTextBox.TabIndex = 1;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(26, 57);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(167, 27);
            ModelTextBox.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(ModelCarbutton);
            flowLayoutPanel1.Location = new Point(4, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(232, 698);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // ModelCarbutton
            // 
            ModelCarbutton.Location = new Point(0, 229);
            ModelCarbutton.Name = "ModelCarbutton";
            ModelCarbutton.Size = new Size(232, 71);
            ModelCarbutton.TabIndex = 1;
            ModelCarbutton.Text = "Carros";
            ModelCarbutton.UseVisualStyleBackColor = true;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 701);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(Principalpanel);
            Name = "DashboardForm";
            Text = "DashboardForm";
            Principalpanel.ResumeLayout(false);
            SalegroupBox.ResumeLayout(false);
            SalegroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SalesdataGridView).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Principalpanel;
        private Panel flowLayoutPanel1;
        private Button ModelCarbutton;
        private GroupBox SalegroupBox;
        private Label priceLabel;
        private Label modelLabel;
        private TextBox PriceTextBox;
        private TextBox ModelTextBox;
        private Label DateSaleLabel;
        private DateTimePicker SaledateTimePicker;
        private TextBox QuantitytextBox;
        private Label Quantitylabel;
        private TextBox AmounttextBox;
        private DataGridView SalesdataGridView;
        private Button button3;
        private Button btn;
        private Button btnAddCar;
        private Label Amountlabel;
    }
}