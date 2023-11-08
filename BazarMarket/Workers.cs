using BazarMarket.Domein.Entity.Workers;

namespace BazarMarket
{
    public partial class Workers : Form
    {
        Manager manager = new Manager();
        public Workers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Salesman1OK_Click(object sender, EventArgs e)
        {

        }

        private void ProductSorterOK_Click(object sender, EventArgs e)
        {

        }

        private void ManagerOK_Click(object sender, EventArgs e)
        {
            ManagerId.Text = manager.Id.ToString();
            MangerName.Text = manager.Name;
            ManagerSalary.Text = manager.Salary;
            
        }
    }
}