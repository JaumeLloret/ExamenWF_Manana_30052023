namespace ExamenWF_Mañana_30052023
{
    partial class StaffForm
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
            staffListView = new ListView();
            addButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // staffListView
            // 
            staffListView.BackColor = SystemColors.Window;
            staffListView.BorderStyle = BorderStyle.FixedSingle;
            staffListView.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            staffListView.FullRowSelect = true;
            staffListView.Location = new Point(5, 4);
            staffListView.MultiSelect = false;
            staffListView.Name = "staffListView";
            staffListView.Size = new Size(706, 750);
            staffListView.TabIndex = 0;
            staffListView.UseCompatibleStateImageBehavior = false;
            staffListView.ItemSelectionChanged += StaffListView_ItemSelectionChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(5, 760);
            addButton.Name = "addButton";
            addButton.Size = new Size(350, 120);
            addButton.TabIndex = 1;
            addButton.Text = "Añadir Empleado";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(361, 760);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(350, 120);
            exitButton.TabIndex = 2;
            exitButton.Text = "Salir";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(716, 883);
            ControlBox = false;
            Controls.Add(exitButton);
            Controls.Add(addButton);
            Controls.Add(staffListView);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StaffForm";
            Text = "Lista de empleados";
            ResumeLayout(false);
        }

        #endregion

        private ListView staffListView;
        private Button addButton;
        private Button exitButton;
    }
}