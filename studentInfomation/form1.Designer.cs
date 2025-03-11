namespace studentInfomation
{
    partial class form1
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
            sdntextBox = new TextBox();
            sdIDtextBox = new TextBox();
            sdmTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addstudentButton = new Button();
            comboBox = new ComboBox();
            dataGridView = new DataGridView();
            label4 = new Label();
            labelDepartment = new Label();
            showstudentButton = new Button();
            label5 = new Label();
            gradetextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // sdntextBox
            // 
            sdntextBox.Location = new Point(53, 207);
            sdntextBox.Name = "sdntextBox";
            sdntextBox.Size = new Size(300, 31);
            sdntextBox.TabIndex = 0;
            // 
            // sdIDtextBox
            // 
            sdIDtextBox.Location = new Point(53, 278);
            sdIDtextBox.Name = "sdIDtextBox";
            sdIDtextBox.Size = new Size(300, 31);
            sdIDtextBox.TabIndex = 1;
            // 
            // sdmTextBox
            // 
            sdmTextBox.Location = new Point(53, 352);
            sdmTextBox.Name = "sdmTextBox";
            sdmTextBox.Size = new Size(300, 31);
            sdmTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 179);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 3;
            label1.Text = "Student Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 250);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 4;
            label2.Text = "Student ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 324);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 5;
            label3.Text = "Major";
            // 
            // addstudentButton
            // 
            addstudentButton.Location = new Point(53, 516);
            addstudentButton.Name = "addstudentButton";
            addstudentButton.Size = new Size(140, 40);
            addstudentButton.TabIndex = 6;
            addstudentButton.Text = "เพิ่มนักศึกษา";
            addstudentButton.UseVisualStyleBackColor = true;
            addstudentButton.Click += addstudentButton_Click;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(53, 92);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(300, 33);
            comboBox.TabIndex = 7;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = SystemColors.ButtonFace;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(373, 83);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(1009, 521);
            dataGridView.TabIndex = 8;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 64);
            label4.Name = "label4";
            label4.Size = new Size(123, 25);
            label4.TabIndex = 9;
            label4.Text = "อาจารย์ที่ปรึกษา";
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Location = new Point(53, 128);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(107, 25);
            labelDepartment.TabIndex = 10;
            labelDepartment.Text = "Department";
            labelDepartment.Click += labelDepartment_Click;
            // 
            // showstudentButton
            // 
            showstudentButton.Location = new Point(199, 516);
            showstudentButton.Name = "showstudentButton";
            showstudentButton.Size = new Size(140, 40);
            showstudentButton.TabIndex = 11;
            showstudentButton.Text = "แสดงนักศึกษา";
            showstudentButton.UseVisualStyleBackColor = true;
            showstudentButton.Click += showstudentButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 393);
            label5.Name = "label5";
            label5.Size = new Size(43, 25);
            label5.TabIndex = 12;
            label5.Text = "gpa";
            // 
            // gradetextBox
            // 
            gradetextBox.Location = new Point(53, 421);
            gradetextBox.Name = "gradetextBox";
            gradetextBox.Size = new Size(300, 31);
            gradetextBox.TabIndex = 13;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 635);
            Controls.Add(gradetextBox);
            Controls.Add(label5);
            Controls.Add(showstudentButton);
            Controls.Add(labelDepartment);
            Controls.Add(label4);
            Controls.Add(dataGridView);
            Controls.Add(comboBox);
            Controls.Add(addstudentButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sdmTextBox);
            Controls.Add(sdIDtextBox);
            Controls.Add(sdntextBox);
            Name = "form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox sdntextBox;
        private TextBox sdIDtextBox;
        private TextBox sdmTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addstudentButton;
        private ComboBox comboBox;
        private DataGridView dataGridView;
        private Label label4;
        private Label labelDepartment;
        private Button showstudentButton;
        private Label label5;
        private TextBox gradetextBox;
    }
}
