namespace ExamenWF_Mañana_30052023
{
    partial class ShowEmployeeForm
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
            nameLabel = new Label();
            label2 = new Label();
            departmentLabel = new Label();
            label3 = new Label();
            ageLabel = new Label();
            label5 = new Label();
            maritalStatusLabel = new Label();
            label4 = new Label();
            updateButton = new Button();
            returnButton = new Button();
            languagesProgrammingListBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del empleado";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(27, 29);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(38, 15);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 2;
            label2.Text = "Departamento del empleado";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new Point(27, 81);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(38, 15);
            departmentLabel.TabIndex = 3;
            departmentLabel.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 4;
            label3.Text = "Edad del empleado";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(27, 128);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(38, 15);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 154);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 6;
            label5.Text = "Estado Civil";
            // 
            // maritalStatusLabel
            // 
            maritalStatusLabel.AutoSize = true;
            maritalStatusLabel.Location = new Point(27, 173);
            maritalStatusLabel.Name = "maritalStatusLabel";
            maritalStatusLabel.Size = new Size(38, 15);
            maritalStatusLabel.TabIndex = 7;
            maritalStatusLabel.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 198);
            label4.Name = "label4";
            label4.Size = new Size(154, 15);
            label4.TabIndex = 8;
            label4.Text = "Lenguajes de programación";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(5, 454);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(111, 36);
            updateButton.TabIndex = 10;
            updateButton.Text = "Actualizar";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += UpdateButton_Click;
            // 
            // returnButton
            // 
            returnButton.Location = new Point(122, 454);
            returnButton.Name = "returnButton";
            returnButton.Size = new Size(119, 36);
            returnButton.TabIndex = 11;
            returnButton.Text = "Volver";
            returnButton.UseVisualStyleBackColor = true;
            returnButton.Click += ReturnButton_Click;
            // 
            // languagesProgrammingListBox
            // 
            languagesProgrammingListBox.FormattingEnabled = true;
            languagesProgrammingListBox.ItemHeight = 15;
            languagesProgrammingListBox.Items.AddRange(new object[] { "C#", "C++", "Java", "Kotlin", "Go", "Dart", "JavaScript", "Python" });
            languagesProgrammingListBox.Location = new Point(27, 234);
            languagesProgrammingListBox.Name = "languagesProgrammingListBox";
            languagesProgrammingListBox.SelectionMode = SelectionMode.MultiSimple;
            languagesProgrammingListBox.Size = new Size(192, 199);
            languagesProgrammingListBox.TabIndex = 12;
            // 
            // ShowEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 496);
            ControlBox = false;
            Controls.Add(languagesProgrammingListBox);
            Controls.Add(returnButton);
            Controls.Add(updateButton);
            Controls.Add(label4);
            Controls.Add(maritalStatusLabel);
            Controls.Add(label5);
            Controls.Add(ageLabel);
            Controls.Add(label3);
            Controls.Add(departmentLabel);
            Controls.Add(label2);
            Controls.Add(nameLabel);
            Controls.Add(label1);
            Name = "ShowEmployeeForm";
            Text = "Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label nameLabel;
        private Label label2;
        private Label departmentLabel;
        private Label label3;
        private Label ageLabel;
        private Label label5;
        private Label maritalStatusLabel;
        private Label label4;
        private Button updateButton;
        private Button returnButton;
        private ListBox languagesProgrammingListBox;
    }
}