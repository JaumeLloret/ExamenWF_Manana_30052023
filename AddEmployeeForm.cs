using ExamenWF_Mañana_30052023.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenWF_Mañana_30052023
{
    public partial class AddEmployeeForm : Form
    {
        public static ITEmployee employee = new ITEmployee();

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string mariedStatus = GetTextForRadioButtonCheked(); 

            if (IsTextBlank(nameTextBox.Text)
                || IsTextBlank(departmentComboBox.Text)
                || IsTextBlank(mariedStatus)
                || !ageMaskedTextBox.MaskCompleted)
            {
                MessageBox.Show("Ningun campo puede estar en blanco");
                return;
            }

            employee.Name = nameTextBox.Text;
            employee.Department = departmentComboBox.Text;
            employee.MaritalStatus = mariedStatus;
            employee.Age = int.Parse(ageMaskedTextBox.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void AgeMaskedTextBox_Validated(object sender, EventArgs e)
        {
            if (!ageMaskedTextBox.MaskCompleted)
                return;

            int age = int.Parse(ageMaskedTextBox.Text);

            if (age < 18 || age > 68)
            {
                ageMaskedTextBox.BackColor = Color.Red;
                addButton.Enabled = false;
                MessageBox.Show("La edad del empleado deberia estar entre 18 años y 68 años");
                return;
            }

            ageMaskedTextBox.BackColor = Color.White;
            addButton.Enabled = true;
        }

        private bool IsTextBlank(string text) => text.Length == 0;

        private string GetTextForRadioButtonCheked()
        {
            foreach (Control control in marriedStatusGroupBox.Controls)
            {
                if (control is RadioButton radioButton)
                {
                    if (radioButton.Checked)
                    {
                        return radioButton.Text;
                    }
                }
            }

            return "";
        }
    }
}
