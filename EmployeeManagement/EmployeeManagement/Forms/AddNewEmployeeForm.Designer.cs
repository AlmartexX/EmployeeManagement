namespace EmployeeManagement.Forms
{
    partial class AddNewEmployeeForm
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            NameTextBox = new System.Windows.Forms.TextBox();
            SurnameTextBox = new System.Windows.Forms.TextBox();
            SalaryTextBox = new System.Windows.Forms.TextBox();
            PositionComboBox = new System.Windows.Forms.ComboBox();
            DateOfBirtthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            AddEmplyeeButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(176, 77);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 25);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(138, 141);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 25);
            label2.TabIndex = 1;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(137, 211);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 25);
            label3.TabIndex = 2;
            label3.Text = "Зарплата";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(121, 280);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(102, 25);
            label4.TabIndex = 3;
            label4.Text = "Должность";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(87, 352);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(136, 25);
            label5.TabIndex = 4;
            label5.Text = "Дата Рождения";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new System.Drawing.Point(276, 77);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new System.Drawing.Size(300, 31);
            NameTextBox.TabIndex = 5;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new System.Drawing.Point(276, 141);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new System.Drawing.Size(300, 31);
            SurnameTextBox.TabIndex = 6;
            // 
            // SalaryTextBox
            // 
            SalaryTextBox.Location = new System.Drawing.Point(276, 211);
            SalaryTextBox.Name = "SalaryTextBox";
            SalaryTextBox.Size = new System.Drawing.Size(300, 31);
            SalaryTextBox.TabIndex = 7;
            // 
            // PositionComboBox
            // 
            PositionComboBox.FormattingEnabled = true;
            PositionComboBox.Location = new System.Drawing.Point(276, 277);
            PositionComboBox.Name = "PositionComboBox";
            PositionComboBox.Size = new System.Drawing.Size(300, 33);
            PositionComboBox.TabIndex = 8;
            // 
            // DateOfBirtthDateTimePicker
            // 
            DateOfBirtthDateTimePicker.Location = new System.Drawing.Point(276, 346);
            DateOfBirtthDateTimePicker.Name = "DateOfBirtthDateTimePicker";
            DateOfBirtthDateTimePicker.Size = new System.Drawing.Size(300, 31);
            DateOfBirtthDateTimePicker.TabIndex = 9;
            // 
            // AddEmplyeeButton
            // 
            AddEmplyeeButton.Location = new System.Drawing.Point(331, 431);
            AddEmplyeeButton.Name = "AddEmplyeeButton";
            AddEmplyeeButton.Size = new System.Drawing.Size(137, 54);
            AddEmplyeeButton.TabIndex = 10;
            AddEmplyeeButton.Text = "Добавить";
            AddEmplyeeButton.UseVisualStyleBackColor = true;
            AddEmplyeeButton.Click += AddEmplyeeButton_Click;
            // 
            // AddNewEmployeeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 532);
            Controls.Add(AddEmplyeeButton);
            Controls.Add(DateOfBirtthDateTimePicker);
            Controls.Add(PositionComboBox);
            Controls.Add(SalaryTextBox);
            Controls.Add(SurnameTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddNewEmployeeForm";
            Text = "Добавить сотрудника";
            Load += AddNewEmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.ComboBox PositionComboBox;
        private System.Windows.Forms.DateTimePicker DateOfBirtthDateTimePicker;
        private System.Windows.Forms.Button AddEmplyeeButton;
    }
}