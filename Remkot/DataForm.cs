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
            timer_update.Enabled = true;
        }
        private void updateDataGridView()
        {
            int sId = 0;
            if (dataGridView_table.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridView_table.SelectedRows[0];
                sId = Convert.ToInt32(row.Cells[0].Value);
            }

            DataBaseConnection dataBaseConnection = new DataBaseConnection();
            if (_tableName == "client")
            {
                _dataTable = dataBaseConnection.getClients();
                dataGridView_table.DataSource = _dataTable;
                dataGridView_table.Columns[0].HeaderCell.Value = "ID";
                dataGridView_table.Columns[1].HeaderCell.Value = "ФИО";
                dataGridView_table.Columns[2].HeaderCell.Value = "Телефон";
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
            }

            dataGridView_table.ClearSelection();
            foreach (DataGridViewRow row in dataGridView_table.Rows)
            {
                if (row.Cells[0].Value.Equals(sId))
                {
                    row.Selected = true;
                }
            }
        }
        private void toolStripMenuItem_add_Click(object sender, EventArgs e)
        {
            string[]? attr = null;
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
            if (dataGridView_table.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите строку");
                return;
            }
            DataGridViewRow row = dataGridView_table.SelectedRows[0];
            int sId = Convert.ToInt32(row.Cells[0].Value);

            if (_tableName == "client")
            {
                string[] attr =
                {
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                };
                AEClientForm aeClientForm = new AEClientForm(sId, attr);
            }
            if (_tableName == "service_application")
            {
                string[] attr =
                { 
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    row.Cells[3].Value.ToString(),
                    row.Cells[4].Value.ToString(),
                    row.Cells[5].Value.ToString(),
                };
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

        private void timer_update_Tick(object sender, EventArgs e)
        {
            updateDataGridView();
        }
    }
}
