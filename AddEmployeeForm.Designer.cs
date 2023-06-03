namespace ExamenWF_Mañana_30052023
{
    partial class AddEmployeeForm
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
            nameTextBox = new TextBox();
            label2 = new Label();
            departmentComboBox = new ComboBox();
            label3 = new Label();
            ageMaskedTextBox = new MaskedTextBox();
            addButton = new Button();
            cancelButton = new Button();
            marriedStatusGroupBox = new GroupBox();
            widowerRadioButton = new RadioButton();
            divorcedRadioButton = new RadioButton();
            marriedRadioButton = new RadioButton();
            singleRadioButton = new RadioButton();
            groupBox1 = new GroupBox();
            reliableCheckBox = new CheckBox();
            punctualCheckBox = new CheckBox();
            gentleCheckBox = new CheckBox();
            workerCheckBox = new CheckBox();
            marriedStatusGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo del Empleado";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(25, 27);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(305, 23);
            nameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 2;
            label2.Text = "Departamento del Empleado";
            // 
            // departmentComboBox
            // 
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Items.AddRange(new object[] { "Programación", "Testeo", "Sistemas", "Mantenimento" });
            departmentComboBox.Location = new Point(25, 84);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(305, 23);
            departmentComboBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 123);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 4;
            label3.Text = "Edad del Empleado";
            // 
            // ageMaskedTextBox
            // 
            ageMaskedTextBox.Location = new Point(25, 141);
            ageMaskedTextBox.Mask = "00";
            ageMaskedTextBox.Name = "ageMaskedTextBox";
            ageMaskedTextBox.Size = new Size(305, 23);
            ageMaskedTextBox.TabIndex = 5;
            ageMaskedTextBox.Validated += AgeMaskedTextBox_Validated;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 388);
            addButton.Name = "addButton";
            addButton.Size = new Size(163, 74);
            addButton.TabIndex = 8;
            addButton.Text = "Añadir";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(181, 388);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(157, 74);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancelar";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += CancelButton_Click;
            // 
            // marriedStatusGroupBox
            // 
            marriedStatusGroupBox.Controls.Add(widowerRadioButton);
            marriedStatusGroupBox.Controls.Add(divorcedRadioButton);
            marriedStatusGroupBox.Controls.Add(marriedRadioButton);
            marriedStatusGroupBox.Controls.Add(singleRadioButton);
            marriedStatusGroupBox.Location = new Point(12, 179);
            marriedStatusGroupBox.Name = "marriedStatusGroupBox";
            marriedStatusGroupBox.Size = new Size(318, 89);
            marriedStatusGroupBox.TabIndex = 10;
            marriedStatusGroupBox.TabStop = false;
            marriedStatusGroupBox.Text = "Estado Civil";
            // 
            // widowerRadioButton
            // 
            widowerRadioButton.AutoSize = true;
            widowerRadioButton.Location = new Point(158, 51);
            widowerRadioButton.Name = "widowerRadioButton";
            widowerRadioButton.Size = new Size(56, 19);
            widowerRadioButton.TabIndex = 3;
            widowerRadioButton.TabStop = true;
            widowerRadioButton.Text = "Viudo";
            widowerRadioButton.UseVisualStyleBackColor = true;
            // 
            // divorcedRadioButton
            // 
            divorcedRadioButton.AutoSize = true;
            divorcedRadioButton.Location = new Point(158, 26);
            divorcedRadioButton.Name = "divorcedRadioButton";
            divorcedRadioButton.Size = new Size(82, 19);
            divorcedRadioButton.TabIndex = 2;
            divorcedRadioButton.TabStop = true;
            divorcedRadioButton.Text = "Divorciado";
            divorcedRadioButton.UseVisualStyleBackColor = true;
            // 
            // marriedRadioButton
            // 
            marriedRadioButton.AutoSize = true;
            marriedRadioButton.Location = new Point(75, 51);
            marriedRadioButton.Name = "marriedRadioButton";
            marriedRadioButton.Size = new Size(64, 19);
            marriedRadioButton.TabIndex = 1;
            marriedRadioButton.TabStop = true;
            marriedRadioButton.Text = "Casado";
            marriedRadioButton.UseVisualStyleBackColor = true;
            // 
            // singleRadioButton
            // 
            singleRadioButton.AutoSize = true;
            singleRadioButton.Location = new Point(75, 26);
            singleRadioButton.Name = "singleRadioButton";
            singleRadioButton.Size = new Size(62, 19);
            singleRadioButton.TabIndex = 0;
            singleRadioButton.TabStop = true;
            singleRadioButton.Text = "Soltero";
            singleRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(reliableCheckBox);
            groupBox1.Controls.Add(punctualCheckBox);
            groupBox1.Controls.Add(gentleCheckBox);
            groupBox1.Controls.Add(workerCheckBox);
            groupBox1.Location = new Point(12, 274);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(318, 100);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Habilidades del Empleado";
            // 
            // reliableCheckBox
            // 
            reliableCheckBox.AutoSize = true;
            reliableCheckBox.Location = new Point(174, 53);
            reliableCheckBox.Name = "reliableCheckBox";
            reliableCheckBox.Size = new Size(77, 19);
            reliableCheckBox.TabIndex = 3;
            reliableCheckBox.Text = "Confiable";
            reliableCheckBox.UseVisualStyleBackColor = true;
            // 
            // punctualCheckBox
            // 
            punctualCheckBox.AutoSize = true;
            punctualCheckBox.Location = new Point(175, 28);
            punctualCheckBox.Name = "punctualCheckBox";
            punctualCheckBox.Size = new Size(67, 19);
            punctualCheckBox.TabIndex = 2;
            punctualCheckBox.Text = "Puntual";
            punctualCheckBox.UseVisualStyleBackColor = true;
            // 
            // gentleCheckBox
            // 
            gentleCheckBox.AutoSize = true;
            gentleCheckBox.Location = new Point(40, 53);
            gentleCheckBox.Name = "gentleCheckBox";
            gentleCheckBox.Size = new Size(67, 19);
            gentleCheckBox.TabIndex = 1;
            gentleCheckBox.Text = "Amable";
            gentleCheckBox.UseVisualStyleBackColor = true;
            // 
            // workerCheckBox
            // 
            workerCheckBox.AutoSize = true;
            workerCheckBox.Location = new Point(40, 28);
            workerCheckBox.Name = "workerCheckBox";
            workerCheckBox.Size = new Size(81, 19);
            workerCheckBox.TabIndex = 0;
            workerCheckBox.Text = "Trabajador";
            workerCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 474);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(marriedStatusGroupBox);
            Controls.Add(cancelButton);
            Controls.Add(addButton);
            Controls.Add(ageMaskedTextBox);
            Controls.Add(label3);
            Controls.Add(departmentComboBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "AddEmployeeForm";
            Text = "Añade un Empleado";
            marriedStatusGroupBox.ResumeLayout(false);
            marriedStatusGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private Label label2;
        private ComboBox departmentComboBox;
        private Label label3;
        private MaskedTextBox ageMaskedTextBox;
        private Button addButton;
        private Button cancelButton;
        private GroupBox marriedStatusGroupBox;
        private RadioButton widowerRadioButton;
        private RadioButton divorcedRadioButton;
        private RadioButton marriedRadioButton;
        private RadioButton singleRadioButton;
        private GroupBox groupBox1;
        private CheckBox reliableCheckBox;
        private CheckBox punctualCheckBox;
        private CheckBox gentleCheckBox;
        private CheckBox workerCheckBox;
    }
}