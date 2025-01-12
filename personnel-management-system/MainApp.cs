using System.Windows.Forms;

namespace personnel_management_system
{
    public partial class MainApp : Form
    {
        private readonly PersonnelHelper _personnelHelper;
        private int lastId = 0;

        public MainApp(DataContext dataContext)
        {
            _personnelHelper = new PersonnelHelper(dataContext);
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            list.DataSource = await _personnelHelper.GetAll();
            list.Columns[0].HeaderText = "Id";
            list.Columns[1].HeaderText = "T.C. no";
            list.Columns[2].HeaderText = "Adı";
            list.Columns[3].HeaderText = "Soyadı";
            list.Columns[4].HeaderText = "Ünvanı";
            list.Columns[5].HeaderText = "Bölümü";
            list.Columns[6].HeaderText = "Doğum Tarihi";
            list.Columns[6].DefaultCellStyle.Format = "dd.MM.yyyy";
            list.Columns[7].HeaderText = "Yaşı";
            list.Columns[8].HeaderText = "Başlama Tarihi";
            list.Columns[8].DefaultCellStyle.Format = "dd.MM.yyyy";
            list.Columns[9].HeaderText = "Görevde mi?";
        }

        private async void create_btn_Click(object sender, EventArgs e)
        {
            Personnel personnel = new Personnel();
            personnel.Ssn = ssn_box.Text;
            personnel.FirstName = firstname_box.Text;
            personnel.LastName = lastname_box.Text;
            personnel.Title = title_box.Text;
            personnel.Department = department_box.Text;
            personnel.DateOfBirth = dateofbirth_box.Value;
            personnel.StartDate = dateofstart_box.Value;
            personnel.IsOnDuty = isonduty_box.Checked;

            await _personnelHelper.Add(personnel);
            LoadData();
            lastId = 0;
        }

        private void MainApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void list_SelectionChangedAsync(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count == 1)
            {
                var selectedRow = list.SelectedRows[0];
                Personnel personnel = await _personnelHelper.GetById(Convert.ToInt32(selectedRow.Cells[0].Value.ToString()));
                lastId = personnel.Id;
                ssn_box.Text = personnel.Ssn;
                firstname_box.Text = personnel.FirstName;
                lastname_box.Text = personnel.LastName;
                title_box.Text = personnel.Title;
                department_box.Text = personnel.Department;
                dateofbirth_box.Value = personnel.DateOfBirth;
                age_box.Text = personnel.Age.ToString();
                dateofstart_box.Value = personnel.StartDate;
                isonduty_box.Checked = personnel.IsOnDuty;
            }
        }

        private async void delete_btn_ClickAsync(object sender, EventArgs e)
        {
            if (list.SelectedRows.Count == 1)
            {
                var selectedRow = list.SelectedRows[0];
                await _personnelHelper.DeleteById(Convert.ToInt32(selectedRow.Cells[0].Value.ToString()));
                LoadData();
                lastId = 0;
            }
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            if (lastId != 0)
            {
                Personnel personnel = await _personnelHelper.GetById(lastId);
                personnel.Ssn = ssn_box.Text;
                personnel.FirstName = firstname_box.Text;
                personnel.LastName = lastname_box.Text;
                personnel.Title = title_box.Text;
                personnel.Department = department_box.Text;
                personnel.DateOfBirth = dateofbirth_box.Value;
                personnel.StartDate = dateofstart_box.Value;
                personnel.IsOnDuty = isonduty_box.Checked;
                _personnelHelper.Update(personnel);
                LoadData();
            }
        }
    }
}
