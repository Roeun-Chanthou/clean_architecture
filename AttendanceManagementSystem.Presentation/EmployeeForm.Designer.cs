namespace AttendanceManagementSystem.Presentation
{
    partial class EmployeeForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            employeeIDTextBox = new TextBox();
            fullnameTextBox = new TextBox();
            positionTextBox = new TextBox();
            cardnoTextBox = new TextBox();
            addNewButton = new Button();
            saveButton = new Button();
            updateButton = new Button();
            dataGridView1 = new DataGridView();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(541, 35);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(418, 71);
            label1.TabIndex = 0;
            label1.Text = "Employee Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(26, 240);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(215, 45);
            label2.TabIndex = 1;
            label2.Text = "Employee ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(61, 312);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(180, 45);
            label3.TabIndex = 2;
            label3.Text = "Full Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(91, 389);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(150, 45);
            label4.TabIndex = 3;
            label4.Text = "Position :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(87, 464);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(154, 45);
            label5.TabIndex = 4;
            label5.Text = "Card No :";
            label5.Click += label5_Click;
            // 
            // employeeIDTextBox
            // 
            employeeIDTextBox.BackColor = Color.White;
            employeeIDTextBox.Location = new Point(261, 237);
            employeeIDTextBox.Margin = new Padding(2);
            employeeIDTextBox.Multiline = true;
            employeeIDTextBox.Name = "employeeIDTextBox";
            employeeIDTextBox.ReadOnly = true;
            employeeIDTextBox.Size = new Size(331, 57);
            employeeIDTextBox.TabIndex = 5;
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Location = new Point(261, 309);
            fullnameTextBox.Margin = new Padding(2);
            fullnameTextBox.Multiline = true;
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(331, 59);
            fullnameTextBox.TabIndex = 6;
            // 
            // positionTextBox
            // 
            positionTextBox.Location = new Point(261, 386);
            positionTextBox.Margin = new Padding(2);
            positionTextBox.Multiline = true;
            positionTextBox.Name = "positionTextBox";
            positionTextBox.Size = new Size(331, 58);
            positionTextBox.TabIndex = 7;
            // 
            // cardnoTextBox
            // 
            cardnoTextBox.Location = new Point(261, 461);
            cardnoTextBox.Margin = new Padding(2);
            cardnoTextBox.Multiline = true;
            cardnoTextBox.Name = "cardnoTextBox";
            cardnoTextBox.Size = new Size(331, 56);
            cardnoTextBox.TabIndex = 8;
            // 
            // addNewButton
            // 
            addNewButton.BackColor = Color.DeepSkyBlue;
            addNewButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addNewButton.Location = new Point(291, 635);
            addNewButton.Margin = new Padding(2);
            addNewButton.Name = "addNewButton";
            addNewButton.Size = new Size(162, 67);
            addNewButton.TabIndex = 9;
            addNewButton.Text = "Add New";
            addNewButton.UseVisualStyleBackColor = false;
            addNewButton.Click += addNewButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.MediumSpringGreen;
            saveButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveButton.Location = new Point(491, 635);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(166, 67);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.DarkCyan;
            updateButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateButton.Location = new Point(686, 635);
            updateButton.Margin = new Padding(2);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(168, 67);
            updateButton.TabIndex = 11;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(652, 195);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(948, 398);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DeleteButton
            // 
            DeleteButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            DeleteButton.BackColor = Color.Crimson;
            DeleteButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteButton.Location = new Point(895, 635);
            DeleteButton.Margin = new Padding(2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(209, 67);
            DeleteButton.TabIndex = 13;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1611, 780);
            Controls.Add(DeleteButton);
            Controls.Add(dataGridView1);
            Controls.Add(updateButton);
            Controls.Add(saveButton);
            Controls.Add(addNewButton);
            Controls.Add(cardnoTextBox);
            Controls.Add(positionTextBox);
            Controls.Add(fullnameTextBox);
            Controls.Add(employeeIDTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox employeeIDTextBox;
        private TextBox fullnameTextBox;
        private TextBox positionTextBox;
        private TextBox cardnoTextBox;
        private Button addNewButton;
        private Button saveButton;
        private Button updateButton;
        private DataGridView dataGridView1;
        private Button DeleteButton;
    }
}