using System.Data;

namespace Remkot
{
    public partial class DataForm : Form
    {
        private DataTable _dataTable = new DataTable();
        private string _tableName;
        public DataForm(string tableName)
        {
            _tableName = tableName;
            InitializeComponent();
            this.Show();
            updateDataGridView();
        }
        private void updateDataGridView()
        {
            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            if (_tableName == "client")
            {
                _dataTable = dataBaseConnection.getClients();
                dataGridView_table.DataSource = _dataTable;
                dataGridView_table.Columns[0].HeaderCell.Value = "ID";
                dataGridView_table.Columns[1].HeaderCell.Value = "ФИО";
                dataGridView_table.Columns[2].HeaderCell.Value = "Телефон";
                return;
            }
            if (_tableName == "service_application")
            {
                _dataTable = dataBaseConnection.getApplicationsUI();
                dataGridView_table.DataSource = _dataTable;
                dataGridView_table.Columns[0].HeaderCell.Value = "ID";
                dataGridView_table.Columns[1].HeaderCell.Value = "Кассир";
                dataGridView_table.Columns[2].HeaderCell.Value = "Клиент";
                dataGridView_table.Columns[3].HeaderCell.Value = "Запчасть";
                dataGridView_table.Columns[4].HeaderCell.Value = "Документ";
                dataGridView_table.Columns[5].HeaderCell.Value = "Работы";
                return;
            }
        }
        private void toolStripMenuItem_add_Click(object sender, EventArgs e)
        {
            string[] attr = null;
            if (_tableName == "client")
            {
                AEClientForm aeClientForm = new AEClientForm(0, attr);
            }
            if (_tableName == "service_application")
            {
                AEServiceApplicationForm aeServiceApplicationForm = new AEServiceApplicationForm(0, attr);
            }
        }

        private void toolStripMenuItem_edit_Click(object sender, EventArgs e)
        {
            string[] attr = null;
            if (dataGridView_table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            DataGridViewRow row = dataGridView_table.SelectedRows[0];
            int sId = Convert.ToInt32(row.Cells[0].Value);
            // TODO: Передача значений полей
            if (_tableName == "client")
            {
                AEClientForm aeClientForm = new AEClientForm(sId, attr);
            }
            if (_tableName == "service_application")
            {
                AEServiceApplicationForm aeServiceApplicationForm = new AEServiceApplicationForm(sId, attr);
            }
        }

        private void toolStripMenuItem_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            DataGridViewRow row = dataGridView_table.SelectedRows[0];
            int sId = Convert.ToInt32(row.Cells[0].Value);

            if (_tableName == "client")
            {
                DataBaseConnection dataBaseConnection = new DataBaseConnection();
                dataBaseConnection.delete(_tableName, sId, "id_client");
            }
            if (_tableName == "service_application")
            {
                DataBaseConnection dataBaseConnection = new DataBaseConnection();
                dataBaseConnection.delete(_tableName, sId, "id_application");
            }
        }
    }
}
