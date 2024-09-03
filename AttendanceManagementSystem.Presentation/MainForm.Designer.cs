namespace AttendanceManagementSystem.Presentation
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
            label1 = new Label();
            timeRecordButon = new Button();
            manageEmployeeButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(209, 64);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(804, 92);
            label1.TabIndex = 0;
            label1.Text = "Employee Management";
            // 
            // timeRecordButon
            // 
            timeRecordButon.BackColor = Color.DeepSkyBlue;
            timeRecordButon.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timeRecordButon.ForeColor = Color.White;
            timeRecordButon.Location = new Point(443, 252);
            timeRecordButon.Margin = new Padding(5);
            timeRecordButon.Name = "timeRecordButon";
            timeRecordButon.Size = new Size(322, 73);
            timeRecordButon.TabIndex = 1;
            timeRecordButon.Text = "Time Record";
            timeRecordButon.UseVisualStyleBackColor = false;
            timeRecordButon.Click += button1_Click;
            // 
            // manageEmployeeButton
            // 
            manageEmployeeButton.BackColor = Color.Red;
            manageEmployeeButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            manageEmployeeButton.ForeColor = Color.White;
            manageEmployeeButton.Location = new Point(354, 384);
            manageEmployeeButton.Margin = new Padding(5);
            manageEmployeeButton.Name = "manageEmployeeButton";
            manageEmployeeButton.Size = new Size(489, 81);
            manageEmployeeButton.TabIndex = 2;
            manageEmployeeButton.Text = "Manage Employee";
            manageEmployeeButton.UseVisualStyleBackColor = false;
            manageEmployeeButton.Click += manageEmployeeButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1256, 621);
            Controls.Add(manageEmployeeButton);
            Controls.Add(timeRecordButon);
            Controls.Add(label1);
            Margin = new Padding(5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button timeRecordButon;
        private Button manageEmployeeButton;
    }
}