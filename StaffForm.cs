using ExamenWF_Mañana_30052023.models;

namespace ExamenWF_Mañana_30052023
{
    public partial class StaffForm : Form
    {
        private List<ITEmployee> _staff;

        public StaffForm()
        {
            InitializeComponent();
            staffListView.View = View.Details;

            staffListView.Columns.Add("Nombre", 230);
            staffListView.Columns.Add("Departamento", 150);
            staffListView.Columns.Add("Edad", 70);

            _staff = new List<ITEmployee>();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                _staff.Add(AddEmployeeForm.employee);

                ListViewItem item = new ListViewItem(_staff.Last().Name);
                item.SubItems.AddRange(
                    new string[]
                    {
                        _staff.Last().Department,
                        _staff.Last().Age.ToString()
                    }
                );

                staffListView.Items.Add(item);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StaffListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (staffListView.SelectedIndices.Count <= 0)
                return;

            ShowEmployeeForm form =
                new ShowEmployeeForm(_staff[staffListView.SelectedIndices[0]]);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                _staff[staffListView
                    .SelectedIndices[0]]
                    .LanguagesProgramming = ShowEmployeeForm.languagesProgramming;
            }
        }

    }
}