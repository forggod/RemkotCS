using Npgsql;
using System.Data;
using System.Xml.Linq;

namespace Remkot
{
    class DataBaseConnection
    {
        private string connectionDB = "Server=localhost; Port=5432; User Id=postgres; Password=postpass; Database=Remkot";
        NpgsqlConnection _connection;
        private DataSet _dataSet = new DataSet();
        private DataTable _dataTable = new DataTable();
        public DataBaseConnection()
        {
            _connection = new NpgsqlConnection(connectionDB);
            createDBIFEX();
        }
        public void createDBIFEX()
        {
            string sql = @"CREATE TABLE IF NOT EXISTS cashier (
                            id_cashier SERIAL,
                            fio CHARACTER VARYING(100) NOT NULL,
                            PRIMARY KEY(id_cashier),
	                        UNIQUE(fio)
                        );

                        CREATE TABLE IF NOT EXISTS client(
                            id_client SERIAL,
                            fio CHARACTER VARYING(100) NOT NULL,
                            phone CHARACTER VARYING(15) NOT NULL,
                            PRIMARY KEY(id_client),
	                        UNIQUE(fio)
                        );

                        CREATE TABLE IF NOT EXISTS normal_document(
                            id_document SERIAL,
                            document CHARACTER VARYING(200) NOT NULL,
                            PRIMARY KEY(id_document)
                        );

                        CREATE TABLE IF NOT EXISTS parts_info(
                            id_part SERIAL,
                            name CHARACTER VARYING(200) NOT NULL,
                            supplier_aligment INTEGER NOT NULL,
	                        count INTEGER NOT NULL,
                            PRIMARY KEY(id_part),
	                        FOREIGN KEY (supplier_aligment) REFERENCES normal_document (id_document) ON DELETE CASCADE ON UPDATE CASCADE
                        );

                        CREATE TABLE IF NOT EXISTS service_application(
                            id_application SERIAL,
                            id_cashier INTEGER NOT NULL,
                            id_client INTEGER NOT NULL,
                            id_part INTEGER NOT NULL,
                            id_document INTEGER NOT NULL,
                            service varchar(255) NOT NULL,
                            FOREIGN KEY(id_cashier) REFERENCES cashier(id_cashier) ON DELETE CASCADE ON UPDATE CASCADE,
                            FOREIGN KEY(id_client) REFERENCES client(id_client) ON DELETE CASCADE ON UPDATE CASCADE,
                            FOREIGN KEY(id_part) REFERENCES parts_info(id_part) ON DELETE CASCADE ON UPDATE CASCADE,
                            FOREIGN KEY(id_document) REFERENCES normal_document(id_document) ON DELETE CASCADE ON UPDATE CASCADE
                        ); ";
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }
        public DataTable getClients()
        {
            string sql = $"SELECT id_client, fio, phone FROM client";
            _connection.Open();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                _dataSet.Reset();
                dataAdapter.Fill(_dataSet);
            }
            _connection.Close();
            return _dataSet.Tables[0];
        }
        public DataTable getApplicationsUI()
        {
            string sql = $"SELECT sa.id_application, cl.fio, ca.fio, pi.name, id_document, service FROM service_application sa " +
                            $"JOIN client cl ON sa.id_application = cl.id_client " +
                            $"JOIN cashier ca ON sa.id_cashier = ca.id_cashier " +
                            $"JOIN parts_info pi ON sa.id_part = pi.id_part;";
            _connection.Open();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                _dataSet.Reset();
                dataAdapter.Fill(_dataSet);
            }
            _connection.Close();
            return _dataSet.Tables[0];
        }
        public DataTable getApplications()
        {
            string sql = $"SELECT id_application, id_cashier, id_client, id_part, id_document, service " +
                $"FROM service_application;";
            _connection.Open();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                _dataSet.Reset();
                dataAdapter.Fill(_dataSet);
            }
            _connection.Close();
            return _dataSet.Tables[0];
        }
        public bool getTabExistElement(string param, string field, string table)
        {
            string sql = $"SELECT * FROM {table} WHERE {field} = '{param}'";
            _connection.Open();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                _dataSet.Reset();
                dataAdapter.Fill(_dataSet);
            }
            _connection.Close();
            if (_dataSet.Tables[0].Rows.Count > 1)
                return true;
            return false;
        }
        public DataTable getCashiers()
        {
            string sql = $"SELECT id_cashier, fio FROM cashier;";
            _connection.Open();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                _dataSet.Reset();
                dataAdapter.Fill(_dataSet);
            }
            _connection.Close();
            return _dataSet.Tables[0];
        }
        public DataTable getPartsInfo()
        {
            string sql = $"SELECT id_part, name, supplier_aligment, count FROM parts_info;";
            _connection.Open();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                _dataSet.Reset();
                dataAdapter.Fill(_dataSet);
            }
            _connection.Close();
            return _dataSet.Tables[0];
        }
        public DataTable getDocuments()
        {
            string sql = $"SELECT id_document, document FROM normal_document;";
            _connection.Open();
            using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sql, _connection))
            {
                _dataSet.Reset();
                dataAdapter.Fill(_dataSet);
            }
            _connection.Close();
            return _dataSet.Tables[0];
        }
        public void addClient(string fio, string phone)
        {
            string sql = $"INSERT INTO client (fio, phone) VALUES ('{fio}', '{phone}');";
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }
        public void addServiceApplication(int cashier, int client, int part, int document, string service)
        {
            string sql = $"INSERT INTO service_application (id_cashier, id_client, id_part, " +
                $"id_document, service) VALUES ('{cashier}', '{client}', '{part}', '{document}', " +
                $"'{service}');";
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }
        public void addCashier(string fio)
        {
            string sql = $"INSERT INTO cashier (fio) VALUES ('{fio}');";
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }
        public void addPartInfo(string name, int supAlignId, int count)
        {
            string sql = $"INSERT INTO parts_info (name, supplier_aligment, count) VALUES " +
                $"('{name}', '{supAlignId}', '{count}');";
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }
        public void addDocument(string document)
        {
            string sql = $"INSERT INTO normal_document (document) VALUES ('{document}');";
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }
        public void delete(string table, int id, string idField)
        {
            string sql = $"DELETE FROM {table} WHERE {idField} = '{id}';";
            _connection.Open();
            using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
            {
                npgsqlCommand.ExecuteNonQuery();
            }
            _connection.Close();
        }
        public bool editClient(int id, string fio, string phone)
        {
            try
            {
                string sql = $"UPDATE client SET fio = '{fio}', phone = '{phone}' WHERE id_client = '{id}';";
                _connection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
                _connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникло исключение" + $"\n{ex.Message}");
                return false;
            }
        }
        public bool editServiceApplication(int id, int cashier, int client, int part, int document, string service)
        {
            try
            {
                string sql = $"UPDATE service_application SET id_cashier = '{cashier}', id_client = '{client}', id_part = '{part}', " +
                    $"id_document = '{document}', service = '{service}' WHERE id_application= '{id}';";
                _connection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
                _connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникло исключение" + $"\n{ex.Message}");
                return false;
            }
        }
        public bool editCashier(int id, string fio)
        {
            try
            {
                string sql = $"UPDATE cashier SET fio = '{fio}' WHERE id_cashier = '{id}';";
                _connection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
                _connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникло исключение" + $"\n{ex.Message}");
                return false;
            }
        }
        public bool editPartsInfo(int id, string name, int supAlignId, int count)
        {
            try
            {
                string sql = $"UPDATE parts_info SET name = '{name}', supplier_aligment = '{supAlignId}', " +
                    $"count = '{count}' WHERE id_part = '{id}';";
                _connection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
                _connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникло исключение" + $"\n{ex.Message}");
                return false;
            }
        }
        public bool editDocument(int id, string document)
        {
            try
            {
                string sql = $"UPDATE normal_document SET document = '{document}' WHERE id_document = '{id}';";
                _connection.Open();
                using (NpgsqlCommand npgsqlCommand = new NpgsqlCommand(sql, _connection))
                {
                    npgsqlCommand.ExecuteNonQuery();
                }
                _connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникло исключение" + $"\n{ex.Message}");
                return false;
            }
        }
    }
}
