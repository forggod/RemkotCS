using System.Data;

namespace Remkot
{
    public partial class AEServiceApplicationForm : Form
    {
        private int _id;
        private string[]? _attr;
        public AEServiceApplicationForm(int id, string[]? attr)
        {
            _id = id;
            _attr = attr;
            InitializeComponent();
            fillComboBoxes();
            if (attr == null)
            {
                this.Text = "Добавление клиента";
                button_action.Text = "Добавить";
            }
            if (attr != null)
            {
                this.Text = "Изменение клиента";
                button_action.Text = "Изменнить";
                comboBox_cashier.SelectedItem = attr[0];
                comboBox_client.SelectedItem = attr[1];
                comboBox_part.SelectedItem = attr[2];
                comboBox_document.SelectedItem = attr[3];
                textBox_service.Text = attr[4];
            }
            this.Show();
        }
        private void fillComboBoxes()
        {
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            DataTable table = dataBaseConnection.getCashiers();
            for (int i = 0; i < table.Rows.Count - 1; i++)
                comboBox_cashier.Items.Add(table.Rows[i].ItemArray[1].ToString());
            table = dataBaseConnection.getClients();
            for (int i = 0; i < table.Rows.Count - 1; i++)
                comboBox_client.Items.Add(table.Rows[i].ItemArray[1].ToString());
            table = dataBaseConnection.getPartsInfo();
            for (int i = 0; i < table.Rows.Count - 1; i++)
                comboBox_part.Items.Add(table.Rows[i].ItemArray[1].ToString());
            table = dataBaseConnection.getDocuments();
            for (int i = 0; i < table.Rows.Count - 1; i++)
                comboBox_doc.Items.Add(table.Rows[i].ItemArray[1].ToString());
        }

        private void button_action_Click(object sender, EventArgs e)
        {
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            int cashier = -1;
            int client = -1;
            int part = -1;
            int document = -1;
            string service = textBox_service.Text;

            DataTable table = dataBaseConnection.getCashiers();
            foreach (DataRow row in table.Rows)
                if (row.ItemArray[1].Equals(comboBox_cashier.SelectedItem.ToString()))
                {
                    cashier = Convert.ToInt32(row.ItemArray[0]);
                    break;
                }
            if (cashier == -1)
            {
                MessageBox.Show("Кассир не найден");
                return;
            }

            table = dataBaseConnection.getClients();
            foreach (DataRow row in table.Rows)
                if (row.ItemArray[1].Equals(comboBox_client.SelectedItem.ToString()))
                {
                    client = Convert.ToInt32(row.ItemArray[0]);
                    break;
                }
            if (client == -1)
            {
                MessageBox.Show("Клиент не найден");
                return;
            }

            table = dataBaseConnection.getPartsInfo();
            foreach (DataRow row in table.Rows)
                if (row.ItemArray[1].Equals(comboBox_part.SelectedItem.ToString()))
                {
                    part = Convert.ToInt32(row.ItemArray[0]);
                    break;
                }
            if (part == -1)
            {
                MessageBox.Show("Запчасть не найдена");
                return;
            }

            table = dataBaseConnection.getDocuments();
            foreach (DataRow row in table.Rows)
                if (row.ItemArray[1].Equals(comboBox_doc.SelectedItem.ToString()))
                {
                    document = Convert.ToInt32(row.ItemArray[0]);
                    break;
                }
            if (document == -1)
            {
                MessageBox.Show("Документ не найден");
                return;
            }

            if (service == "")
            {
                MessageBox.Show("Заполните поле работы");
                return;
            }

            if (_attr == null)
            {
                dataBaseConnection.addServiceApplication(cashier, client, part, document, service);
            }
            if (_attr != null)
            {
                dataBaseConnection.editServiceApplication(_id, cashier, client, part, document, service);
            }
            this.Close();
        }
    }
}
