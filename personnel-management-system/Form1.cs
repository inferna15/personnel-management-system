namespace personnel_management_system
{
    public partial class Form1 : Form
    {
        private readonly UserHelper _userHelper;
        private readonly DataContext _dataContext;

        public Form1()
        {
            InitializeComponent();
            _dataContext = new DataContext();
            _userHelper = new UserHelper(_dataContext);

            _dataContext.Database.EnsureCreated();
        }

        private async void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username_box.Text))
            {
                MessageBox.Show("Kullanýcý adý boþ olamaz.");
            } 
            else if (string.IsNullOrEmpty(password_box.Text))
            {
                MessageBox.Show("Þifre boþ olamaz.");
            }
            else
            {
                User user = await _userHelper.GetByUsername(username_box.Text);
                if (user != null)
                {
                    if (user.Password == _userHelper.CreateHash(password_box.Text))
                    {
                        var mainApp = new MainApp(_dataContext);
                        mainApp.Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Þifre hatalý.");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanýcý adý hatalý.");
                }
            }
        }
    }
}
