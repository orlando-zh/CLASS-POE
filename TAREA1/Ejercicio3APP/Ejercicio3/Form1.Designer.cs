namespace Ejercicio3
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            txtBaseRomboide = new TextBox();
            label2 = new Label();
            txtAlturaRomboide = new TextBox();
            txtLadoRomboide = new TextBox();
            Lado = new Label();
            label3 = new Label();
            lblAreaRomboide = new Label();
            label4 = new Label();
            lblPerimetroRomboide = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtAlturaTrapezoide = new TextBox();
            label9 = new Label();
            txtBaseMenorTrapezoide = new TextBox();
            label10 = new Label();
            txtBaseMayorTrapezoide = new TextBox();
            label11 = new Label();
            txtLado1Trapezoide = new TextBox();
            label12 = new Label();
            txtLado2Trapezoide = new TextBox();
            lblAreaTrapezoide = new Label();
            label13 = new Label();
            lblPerimetroTrapezoide = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPerimetroRomboide);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblAreaRomboide);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtLadoRomboide);
            groupBox1.Controls.Add(Lado);
            groupBox1.Controls.Add(txtAlturaRomboide);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtBaseRomboide);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 335);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Romboide";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblPerimetroTrapezoide);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(lblAreaTrapezoide);
            groupBox2.Controls.Add(txtLado2Trapezoide);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(txtLado1Trapezoide);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtAlturaTrapezoide);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtBaseMenorTrapezoide);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtBaseMayorTrapezoide);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(374, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(384, 407);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Trapezoide";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 0;
            label1.Text = "Base";
            label1.Click += label1_Click;
            // 
            // txtBaseRomboide
            // 
            txtBaseRomboide.Location = new Point(94, 32);
            txtBaseRomboide.Name = "txtBaseRomboide";
            txtBaseRomboide.Size = new Size(125, 27);
            txtBaseRomboide.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 85);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Altura";
            // 
            // txtAlturaRomboide
            // 
            txtAlturaRomboide.Location = new Point(94, 82);
            txtAlturaRomboide.Name = "txtAlturaRomboide";
            txtAlturaRomboide.Size = new Size(125, 27);
            txtAlturaRomboide.TabIndex = 3;
            // 
            // txtLadoRomboide
            // 
            txtLadoRomboide.Location = new Point(94, 121);
            txtLadoRomboide.Name = "txtLadoRomboide";
            txtLadoRomboide.Size = new Size(125, 27);
            txtLadoRomboide.TabIndex = 5;
            txtLadoRomboide.TextChanged += txtLadoRomboide_TextChanged;
            // 
            // Lado
            // 
            Lado.AutoSize = true;
            Lado.Location = new Point(12, 124);
            Lado.Name = "Lado";
            Lado.Size = new Size(42, 20);
            Lado.TabIndex = 4;
            Lado.Text = "Lado";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 169);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 6;
            label3.Text = "Área del Romboide";
            label3.Click += this.label3_Click;
            // 
            // lblAreaRomboide
            // 
            lblAreaRomboide.AutoSize = true;
            lblAreaRomboide.Location = new Point(157, 169);
            lblAreaRomboide.Name = "lblAreaRomboide";
            lblAreaRomboide.Size = new Size(0, 20);
            lblAreaRomboide.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 223);
            label4.Name = "label4";
            label4.Size = new Size(172, 20);
            label4.TabIndex = 8;
            label4.Text = "Perímetro del Romboide";
            // 
            // lblPerimetroRomboide
            // 
            lblPerimetroRomboide.AutoSize = true;
            lblPerimetroRomboide.Location = new Point(200, 227);
            lblPerimetroRomboide.Name = "lblPerimetroRomboide";
            lblPerimetroRomboide.Size = new Size(0, 20);
            lblPerimetroRomboide.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 222);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 287);
            label6.Name = "label6";
            label6.Size = new Size(143, 20);
            label6.TabIndex = 18;
            label6.Text = "Área del Trapezoide";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(168, 164);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 164);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 16;
            label8.Text = "Lado 1";
            label8.Click += label8_Click;
            // 
            // txtAlturaTrapezoide
            // 
            txtAlturaTrapezoide.Location = new Point(130, 116);
            txtAlturaTrapezoide.Name = "txtAlturaTrapezoide";
            txtAlturaTrapezoide.Size = new Size(125, 27);
            txtAlturaTrapezoide.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 119);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 14;
            label9.Text = "Altura";
            // 
            // txtBaseMenorTrapezoide
            // 
            txtBaseMenorTrapezoide.Location = new Point(130, 77);
            txtBaseMenorTrapezoide.Name = "txtBaseMenorTrapezoide";
            txtBaseMenorTrapezoide.Size = new Size(125, 27);
            txtBaseMenorTrapezoide.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 80);
            label10.Name = "label10";
            label10.Size = new Size(87, 20);
            label10.TabIndex = 12;
            label10.Text = "Base Menor";
            // 
            // txtBaseMayorTrapezoide
            // 
            txtBaseMayorTrapezoide.Location = new Point(130, 27);
            txtBaseMayorTrapezoide.Name = "txtBaseMayorTrapezoide";
            txtBaseMayorTrapezoide.Size = new Size(125, 27);
            txtBaseMayorTrapezoide.TabIndex = 11;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(23, 30);
            label11.Name = "label11";
            label11.Size = new Size(86, 20);
            label11.TabIndex = 10;
            label11.Text = "Base Mayor";
            // 
            // txtLado1Trapezoide
            // 
            txtLado1Trapezoide.Location = new Point(130, 161);
            txtLado1Trapezoide.Name = "txtLado1Trapezoide";
            txtLado1Trapezoide.Size = new Size(125, 27);
            txtLado1Trapezoide.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 222);
            label12.Name = "label12";
            label12.Size = new Size(54, 20);
            label12.TabIndex = 21;
            label12.Text = "Lado 2";
            label12.Click += label12_Click;
            // 
            // txtLado2Trapezoide
            // 
            txtLado2Trapezoide.Location = new Point(130, 222);
            txtLado2Trapezoide.Name = "txtLado2Trapezoide";
            txtLado2Trapezoide.Size = new Size(125, 27);
            txtLado2Trapezoide.TabIndex = 22;
            // 
            // lblAreaTrapezoide
            // 
            lblAreaTrapezoide.AutoSize = true;
            lblAreaTrapezoide.Location = new Point(186, 290);
            lblAreaTrapezoide.Name = "lblAreaTrapezoide";
            lblAreaTrapezoide.Size = new Size(0, 20);
            lblAreaTrapezoide.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 344);
            label13.Name = "label13";
            label13.Size = new Size(176, 20);
            label13.TabIndex = 24;
            label13.Text = "Perímetro del Trapezoide";
            // 
            // lblPerimetroTrapezoide
            // 
            lblPerimetroTrapezoide.AutoSize = true;
            lblPerimetroTrapezoide.Location = new Point(192, 347);
            lblPerimetroTrapezoide.Name = "lblPerimetroTrapezoide";
            lblPerimetroTrapezoide.Size = new Size(0, 20);
            lblPerimetroTrapezoide.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtLadoRomboide;
        private Label Lado;
        private TextBox txtAlturaRomboide;
        private Label label2;
        private TextBox txtBaseRomboide;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Label lblPerimetroRomboide;
        private Label label4;
        private Label lblAreaRomboide;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtAlturaTrapezoide;
        private Label label9;
        private TextBox txtBaseMenorTrapezoide;
        private Label label10;
        private TextBox txtBaseMayorTrapezoide;
        private Label label11;
        private Label label12;
        private TextBox txtLado1Trapezoide;
        private TextBox txtLado2Trapezoide;
        private Label lblPerimetroTrapezoide;
        private Label label13;
        private Label lblAreaTrapezoide;
    }
}
