using System.DirectoryServices;

namespace Remkot
{
    public partial class AEClientForm : Form
    {
        private int _id;
        private string[] _attr;
        public AEClientForm(int id, string[] attr)
        {
            _id = id;
            _attr = attr;
            InitializeComponent();
            if (attr == null)
            {
                this.Text = "Добавление клиента";
                button_action.Text = "Добавить";
            }
            if (attr != null)
            {
                this.Text = "Изменение клиента";
                button_action.Text = "Изменнить";
                textBox_fio.Text = attr[0];
                textBox_phone.Text = attr[1];
            }
            this.Show();
        }

        private void button_action_Click(object sender, EventArgs e)
        {
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            string fio = textBox_fio.Text;
            string phone = textBox_phone.Text;

            if (_attr == null)
            {
                dataBaseConnection.addClient(fio, phone);
            }
            if (_attr != null)
            {
                // TODO: Вызов метода изменения
            }
        }
    }
}
