namespace PresentationLayer.Forms
{
    partial class CategoryForm
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
            titleLabel = new Label();
            categoryFormGroupBox = new GroupBox();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            SaveButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            categoriesDataGridView = new DataGridView();
            categoryFormGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)categoriesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(217, 22);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(297, 38);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Listado de Categorias";
            // 
            // categoryFormGroupBox
            // 
            categoryFormGroupBox.Controls.Add(deleteButton);
            categoryFormGroupBox.Controls.Add(editButton);
            categoryFormGroupBox.Controls.Add(SaveButton);
            categoryFormGroupBox.Controls.Add(nameTextBox);
            categoryFormGroupBox.Controls.Add(nameLabel);
            categoryFormGroupBox.Location = new Point(67, 95);
            categoryFormGroupBox.Name = "categoryFormGroupBox";
            categoryFormGroupBox.Size = new Size(564, 212);
            categoryFormGroupBox.TabIndex = 1;
            categoryFormGroupBox.TabStop = false;
            categoryFormGroupBox.Text = "Formulario";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLabel.Location = new Point(16, 50);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(103, 28);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Categoría";
            // 
            // nameTextBox
            // 
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Location = new Point(20, 104);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(494, 27);
            nameTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(22, 156);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(140, 38);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Guardar";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editButton.Location = new Point(198, 156);
            editButton.Name = "editButton";
            editButton.Size = new Size(140, 38);
            editButton.TabIndex = 3;
            editButton.Text = "Editar";
            editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteButton.Location = new Point(374, 156);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(140, 38);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Eliminar";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // categoriesDataGridView
            // 
            categoriesDataGridView.AllowUserToAddRows = false;
            categoriesDataGridView.AllowUserToDeleteRows = false;
            categoriesDataGridView.AllowUserToResizeColumns = false;
            categoriesDataGridView.AllowUserToResizeRows = false;
            categoriesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoriesDataGridView.Location = new Point(73, 332);
            categoriesDataGridView.Name = "categoriesDataGridView";
            categoriesDataGridView.RowHeadersWidth = 51;
            categoriesDataGridView.Size = new Size(558, 238);
            categoriesDataGridView.TabIndex = 2;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 591);
            Controls.Add(categoriesDataGridView);
            Controls.Add(categoryFormGroupBox);
            Controls.Add(titleLabel);
            Name = "CategoryForm";
            Text = "CategoryForm";
            categoryFormGroupBox.ResumeLayout(false);
            categoryFormGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)categoriesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private GroupBox categoryFormGroupBox;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Button deleteButton;
        private Button editButton;
        private Button SaveButton;
        private DataGridView categoriesDataGridView;
    }
}