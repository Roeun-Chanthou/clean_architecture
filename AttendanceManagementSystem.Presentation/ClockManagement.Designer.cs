namespace AttendanceManagementSystem.Presentation
{
    partial class ClockManagement
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
            label1 = new Label();
            label2 = new Label();
            cardNoTextBox = new TextBox();
            clockinButton = new Button();
            clockoutButton = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MediumSlateBlue;
            label1.Location = new Point(309, 66);
            label1.Name = "label1";
            label1.Size = new Size(414, 92);
            label1.TabIndex = 0;
            label1.Text = "Clock  Time";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(256, 263);
            label2.Name = "label2";
            label2.Size = new Size(213, 60);
            label2.TabIndex = 1;
            label2.Text = "Card No :";
            // 
            // cardNoTextBox
            // 
            cardNoTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cardNoTextBox.Location = new Point(485, 263);
            cardNoTextBox.Multiline = true;
            cardNoTextBox.Name = "cardNoTextBox";
            cardNoTextBox.Size = new Size(370, 61);
            cardNoTextBox.TabIndex = 2;
            cardNoTextBox.TextChanged += cardNoTextBox_TextChanged;
            // 
            // clockinButton
            // 
            clockinButton.BackColor = Color.OliveDrab;
            clockinButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clockinButton.ForeColor = Color.White;
            clockinButton.Location = new Point(256, 386);
            clockinButton.Name = "clockinButton";
            clockinButton.Size = new Size(224, 69);
            clockinButton.TabIndex = 3;
            clockinButton.Text = "Time-In";
            clockinButton.UseVisualStyleBackColor = false;
            clockinButton.Click += clockinButton_Click;
            // 
            // clockoutButton
            // 
            clockoutButton.BackColor = Color.Crimson;
            clockoutButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clockoutButton.ForeColor = Color.White;
            clockoutButton.Location = new Point(596, 386);
            clockoutButton.Name = "clockoutButton";
            clockoutButton.Size = new Size(259, 69);
            clockoutButton.TabIndex = 4;
            clockoutButton.Text = "Time-Out";
            clockoutButton.UseVisualStyleBackColor = false;
            clockoutButton.Click += clockoutButton_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 10;
            // 
            // ClockManagement
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 588);
            Controls.Add(clockoutButton);
            Controls.Add(clockinButton);
            Controls.Add(cardNoTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClockManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clock";
            Load += ClockManagement_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox cardNoTextBox;
        private Button clockinButton;
        private Button clockoutButton;
        private System.Windows.Forms.Timer timer;
    }
}