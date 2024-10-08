namespace PresentationLayer.Forms
{
    partial class PatientForm
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
            patientsDataGridView = new DataGridView();
            titleLabel = new Label();
            patientsFormGroupBox = new GroupBox();
            doctorComboBox = new ComboBox();
            doctorLabel = new Label();
            ageTextBox = new TextBox();
            ageLabel = new Label();
            lastNameTexBox = new TextBox();
            lastNameLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            savePatientButton = new Button();
            editPatientButton = new Button();
            deletePatientButton = new Button();
            ((System.ComponentModel.ISupportInitialize)patientsDataGridView).BeginInit();
            patientsFormGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // patientsDataGridView
            // 
            patientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientsDataGridView.Location = new Point(73, 411);
            patientsDataGridView.Name = "patientsDataGridView";
            patientsDataGridView.RowHeadersWidth = 51;
            patientsDataGridView.Size = new Size(643, 188);
            patientsDataGridView.TabIndex = 1;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(226, 44);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(281, 38);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Listado de Pacientes";
            // 
            // patientsFormGroupBox
            // 
            patientsFormGroupBox.Controls.Add(doctorComboBox);
            patientsFormGroupBox.Controls.Add(doctorLabel);
            patientsFormGroupBox.Controls.Add(ageTextBox);
            patientsFormGroupBox.Controls.Add(ageLabel);
            patientsFormGroupBox.Controls.Add(lastNameTexBox);
            patientsFormGroupBox.Controls.Add(lastNameLabel);
            patientsFormGroupBox.Controls.Add(firstNameTextBox);
            patientsFormGroupBox.Controls.Add(firstNameLabel);
            patientsFormGroupBox.Location = new Point(73, 109);
            patientsFormGroupBox.Name = "patientsFormGroupBox";
            patientsFormGroupBox.Size = new Size(643, 223);
            patientsFormGroupBox.TabIndex = 3;
            patientsFormGroupBox.TabStop = false;
            patientsFormGroupBox.Text = "Formulario";
            // 
            // doctorComboBox
            // 
            doctorComboBox.FormattingEnabled = true;
            doctorComboBox.Location = new Point(358, 168);
            doctorComboBox.Name = "doctorComboBox";
            doctorComboBox.Size = new Size(238, 28);
            doctorComboBox.TabIndex = 7;
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorLabel.Location = new Point(358, 130);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new Size(77, 28);
            doctorLabel.TabIndex = 6;
            doctorLabel.Text = "Doctor";
            // 
            // ageTextBox
            // 
            ageTextBox.BorderStyle = BorderStyle.FixedSingle;
            ageTextBox.Location = new Point(34, 168);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(238, 27);
            ageTextBox.TabIndex = 5;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ageLabel.Location = new Point(28, 130);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(58, 28);
            ageLabel.TabIndex = 4;
            ageLabel.Text = "Edad";
            // 
            // lastNameTexBox
            // 
            lastNameTexBox.BorderStyle = BorderStyle.FixedSingle;
            lastNameTexBox.Location = new Point(358, 73);
            lastNameTexBox.Name = "lastNameTexBox";
            lastNameTexBox.Size = new Size(238, 27);
            lastNameTexBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(352, 35);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(100, 28);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Apellidos";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            firstNameTextBox.Location = new Point(23, 73);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(238, 27);
            firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameLabel.Location = new Point(17, 35);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(89, 28);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "Nombre";
            // 
            // savePatientButton
            // 
            savePatientButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            savePatientButton.Location = new Point(73, 351);
            savePatientButton.Name = "savePatientButton";
            savePatientButton.Size = new Size(155, 41);
            savePatientButton.TabIndex = 4;
            savePatientButton.Text = "Guardar";
            savePatientButton.UseVisualStyleBackColor = true;
            savePatientButton.Click += savePatientButton_Click;
            // 
            // editPatientButton
            // 
            editPatientButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editPatientButton.Location = new Point(315, 351);
            editPatientButton.Name = "editPatientButton";
            editPatientButton.Size = new Size(155, 41);
            editPatientButton.TabIndex = 5;
            editPatientButton.Text = "Editar";
            editPatientButton.UseVisualStyleBackColor = true;
            editPatientButton.Click += editPatientButton_Click;
            // 
            // deletePatientButton
            // 
            deletePatientButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletePatientButton.Location = new Point(561, 351);
            deletePatientButton.Name = "deletePatientButton";
            deletePatientButton.Size = new Size(155, 41);
            deletePatientButton.TabIndex = 6;
            deletePatientButton.Text = "Eliminar";
            deletePatientButton.UseVisualStyleBackColor = true;
            deletePatientButton.Click += deletePatientButton_Click;
            // 
            // PatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 611);
            Controls.Add(deletePatientButton);
            Controls.Add(editPatientButton);
            Controls.Add(savePatientButton);
            Controls.Add(patientsFormGroupBox);
            Controls.Add(titleLabel);
            Controls.Add(patientsDataGridView);
            Name = "PatientForm";
            Text = "PatientForm";
            ((System.ComponentModel.ISupportInitialize)patientsDataGridView).EndInit();
            patientsFormGroupBox.ResumeLayout(false);
            patientsFormGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView patientsDataGridView;
        private Label titleLabel;
        private GroupBox patientsFormGroupBox;
        private Label firstNameLabel;
        private TextBox lastNameTexBox;
        private Label lastNameLabel;
        private TextBox firstNameTextBox;
        private TextBox ageTextBox;
        private Label ageLabel;
        private Label doctorLabel;
        private ComboBox doctorComboBox;
        private Button savePatientButton;
        private Button editPatientButton;
        private Button deletePatientButton;
    }
}