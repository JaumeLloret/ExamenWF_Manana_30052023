using ExamenWF_Mañana_30052023.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenWF_Mañana_30052023
{
    public partial class ShowEmployeeForm : Form
    {
        public static List<string> languagesProgramming = new List<string>();

        public ShowEmployeeForm(ITEmployee employee)
        {
            InitializeComponent();

            nameLabel.Text = employee.Name;
            departmentLabel.Text = employee.Department;
            ageLabel.Text = employee.Age.ToString();
            maritalStatusLabel.Text = employee.MaritalStatus;
            foreach (string language in languagesProgramming)
            {
                if (languagesProgrammingListBox.Items.Contains(language))
                {
                    languagesProgrammingListBox.SelectedItems.Add(language);
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            languagesProgramming.Clear();

            foreach (string language in languagesProgrammingListBox.SelectedItems)
                languagesProgramming.Add(language);

            DialogResult = DialogResult.OK;
            Close();
        }
        
        private void ReturnButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
