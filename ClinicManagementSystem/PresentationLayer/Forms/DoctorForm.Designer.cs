namespace PresentationLayer.Forms
{
    partial class DoctorForm
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
            components = new System.ComponentModel.Container();
            doctorDataGridView = new DataGridView();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            addDoctorButton = new Button();
            deleteDoctorButton = new Button();
            editDoctorButton = new Button();
            validationErrorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)doctorDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // doctorDataGridView
            // 
            doctorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorDataGridView.Location = new Point(87, 334);
            doctorDataGridView.Name = "doctorDataGridView";
            doctorDataGridView.RowHeadersWidth = 51;
            doctorDataGridView.Size = new Size(643, 188);
            doctorDataGridView.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            firstNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameTextBox.Location = new Point(87, 96);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(353, 27);
            firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameLabel.Location = new Point(87, 38);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(125, 38);
            firstNameLabel.TabIndex = 2;
            firstNameLabel.Text = "Nombre";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(87, 145);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(127, 38);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Apellido";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            lastNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameTextBox.Location = new Point(87, 203);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(353, 27);
            lastNameTextBox.TabIndex = 3;
            // 
            // addDoctorButton
            // 
            addDoctorButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addDoctorButton.Location = new Point(86, 270);
            addDoctorButton.Name = "addDoctorButton";
            addDoctorButton.Size = new Size(196, 39);
            addDoctorButton.TabIndex = 5;
            addDoctorButton.Text = "Guardar";
            addDoctorButton.UseVisualStyleBackColor = true;
            addDoctorButton.Click += addDoctorButton_Click;
            // 
            // deleteDoctorButton
            // 
            deleteDoctorButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteDoctorButton.Location = new Point(302, 275);
            deleteDoctorButton.Name = "deleteDoctorButton";
            deleteDoctorButton.Size = new Size(196, 39);
            deleteDoctorButton.TabIndex = 6;
            deleteDoctorButton.Text = "Eliminar";
            deleteDoctorButton.UseVisualStyleBackColor = true;
            deleteDoctorButton.Click += deleteDoctorButton_Click;
            // 
            // editDoctorButton
            // 
            editDoctorButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editDoctorButton.Location = new Point(519, 275);
            editDoctorButton.Name = "editDoctorButton";
            editDoctorButton.Size = new Size(196, 39);
            editDoctorButton.TabIndex = 7;
            editDoctorButton.Text = "Editar";
            editDoctorButton.UseVisualStyleBackColor = true;
            editDoctorButton.Click += editDoctorButton_Click;
            // 
            // validationErrorProvider
            // 
            validationErrorProvider.ContainerControl = this;
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 588);
            Controls.Add(editDoctorButton);
            Controls.Add(deleteDoctorButton);
            Controls.Add(addDoctorButton);
            Controls.Add(lastNameLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(doctorDataGridView);
            Name = "DoctorForm";
            Text = "DoctorForm";
            ((System.ComponentModel.ISupportInitialize)doctorDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)validationErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView doctorDataGridView;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private Button addDoctorButton;
        private Button deleteDoctorButton;
        private Button editDoctorButton;
        private ErrorProvider validationErrorProvider;
    }
}