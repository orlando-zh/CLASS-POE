namespace PresentationLayer.Forms
{
    partial class MainForm
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
            patientsButton = new Button();
            doctorButton = new Button();
            SuspendLayout();
            // 
            // patientsButton
            // 
            patientsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            patientsButton.Location = new Point(63, 86);
            patientsButton.Name = "patientsButton";
            patientsButton.Size = new Size(143, 51);
            patientsButton.TabIndex = 0;
            patientsButton.Text = "Ver Pacientes";
            patientsButton.UseVisualStyleBackColor = true;
            patientsButton.Click += patientsButton_Click;
            // 
            // doctorButton
            // 
            doctorButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            doctorButton.Location = new Point(304, 86);
            doctorButton.Name = "doctorButton";
            doctorButton.Size = new Size(143, 51);
            doctorButton.TabIndex = 1;
            doctorButton.Text = "Ver Doctores";
            doctorButton.UseVisualStyleBackColor = true;
            doctorButton.Click += doctorButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 203);
            Controls.Add(doctorButton);
            Controls.Add(patientsButton);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button patientsButton;
        private Button doctorButton;
    }
}