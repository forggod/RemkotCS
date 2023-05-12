using System.Data;

namespace Remkot
{
    public partial class AEServiceApplicationForm : Form
    {
        private int _id;
        private string[] _attr;
        public AEServiceApplicationForm(int id, string[] attr)
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

        }
    }
}
