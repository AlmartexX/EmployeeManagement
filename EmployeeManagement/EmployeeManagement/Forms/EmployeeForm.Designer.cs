namespace EmployeeManagement
{
    partial class EmployeeForm
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
            AddEmplyeeButton = new System.Windows.Forms.Button();
            DeleteEmpolyeeButton = new System.Windows.Forms.Button();
            GetReportOfEmpolyeeButton = new System.Windows.Forms.Button();
            PositionFiltercomboBox = new System.Windows.Forms.ComboBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AddEmplyeeButton
            // 
            AddEmplyeeButton.Location = new System.Drawing.Point(896, 187);
            AddEmplyeeButton.Name = "AddEmplyeeButton";
            AddEmplyeeButton.Size = new System.Drawing.Size(184, 87);
            AddEmplyeeButton.TabIndex = 0;
            AddEmplyeeButton.Text = "Добавить";
            AddEmplyeeButton.UseVisualStyleBackColor = true;
            AddEmplyeeButton.Click += AddEmplyeeButton_Click;
            // 
            // DeleteEmpolyeeButton
            // 
            DeleteEmpolyeeButton.Location = new System.Drawing.Point(896, 296);
            DeleteEmpolyeeButton.Name = "DeleteEmpolyeeButton";
            DeleteEmpolyeeButton.Size = new System.Drawing.Size(184, 87);
            DeleteEmpolyeeButton.TabIndex = 1;
            DeleteEmpolyeeButton.Text = "Удалить";
            DeleteEmpolyeeButton.UseVisualStyleBackColor = true;
            DeleteEmpolyeeButton.Click += DeleteEmpolyeeButton_Click;
            // 
            // GetReportOfEmpolyeeButton
            // 
            GetReportOfEmpolyeeButton.Location = new System.Drawing.Point(896, 404);
            GetReportOfEmpolyeeButton.Name = "GetReportOfEmpolyeeButton";
            GetReportOfEmpolyeeButton.Size = new System.Drawing.Size(184, 87);
            GetReportOfEmpolyeeButton.TabIndex = 2;
            GetReportOfEmpolyeeButton.Text = "Справка";
            GetReportOfEmpolyeeButton.UseVisualStyleBackColor = true;
            GetReportOfEmpolyeeButton.Click += GetReportOfEmpolyeeButton_Click;
            // 
            // PositionFiltercomboBox
            // 
            PositionFiltercomboBox.FormattingEnabled = true;
            PositionFiltercomboBox.Location = new System.Drawing.Point(53, 50);
            PositionFiltercomboBox.Name = "PositionFiltercomboBox";
            PositionFiltercomboBox.Size = new System.Drawing.Size(182, 33);
            PositionFiltercomboBox.TabIndex = 3;
            PositionFiltercomboBox.SelectedIndexChanged += PositionFiltercomboBox_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(53, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new System.Drawing.Size(810, 437);
            dataGridView1.TabIndex = 4;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1118, 632);
            Controls.Add(dataGridView1);
            Controls.Add(PositionFiltercomboBox);
            Controls.Add(GetReportOfEmpolyeeButton);
            Controls.Add(DeleteEmpolyeeButton);
            Controls.Add(AddEmplyeeButton);
            Name = "EmployeeForm";
            Text = "Сотрудники";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button AddEmplyeeButton;
        private System.Windows.Forms.Button DeleteEmpolyeeButton;
        private System.Windows.Forms.Button GetReportOfEmpolyeeButton;
        private System.Windows.Forms.ComboBox PositionFiltercomboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
