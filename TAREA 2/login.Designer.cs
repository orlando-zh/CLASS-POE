namespace ProyectoFinal
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            Init_button = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Init_button
            // 
            Init_button.BackColor = Color.DarkGray;
            Init_button.BackgroundImageLayout = ImageLayout.Center;
            Init_button.Font = new Font("Sitka Banner", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Init_button.ForeColor = SystemColors.Desktop;
            Init_button.Location = new Point(343, 215);
            Init_button.Name = "Init_button";
            Init_button.Size = new Size(148, 41);
            Init_button.TabIndex = 0;
            Init_button.Text = "Iniciar";
            Init_button.UseVisualStyleBackColor = false;
            Init_button.Click += buttonInit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(311, 97);
            label1.Name = "label1";
            label1.Size = new Size(219, 28);
            label1.TabIndex = 1;
            label1.Text = "Registro de Datos";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Init_button);
            Name = "login";
            Text = "login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Init_button;
        private Label label1;
    }
}