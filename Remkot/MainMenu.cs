namespace Remkot
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button_clients_Click(object sender, EventArgs e)
        {
            string table = "client";
            DataForm dataForm = new DataForm(table);
        }

        private void button_application_Click(object sender, EventArgs e)
        {
            string table = "service_application";
            DataForm dataForm = new DataForm(table);
        }
    }
}
