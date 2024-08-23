namespace Class15
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calcularButton = new Button();
            downloadFileButton = new Button();
            SuspendLayout();
            // 
            // calcularButton
            // 
            calcularButton.Location = new Point(335, 122);
            calcularButton.Name = "calcularButton";
            calcularButton.Size = new Size(94, 29);
            calcularButton.TabIndex = 0;
            calcularButton.Text = "button1";
            calcularButton.UseVisualStyleBackColor = true;
            calcularButton.Click += calcularButton_Click;
            // 
            // downloadFileButton
            // 
            downloadFileButton.Location = new Point(335, 187);
            downloadFileButton.Name = "downloadFileButton";
            downloadFileButton.Size = new Size(156, 29);
            downloadFileButton.TabIndex = 1;
            downloadFileButton.Text = "Descargar Archivo";
            downloadFileButton.UseVisualStyleBackColor = true;
            downloadFileButton.Click += this.downloadFileButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(downloadFileButton);
            Controls.Add(calcularButton);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button calcularButton;
        private Button downloadFileButton;
    }
}
