using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace coursova
{
    public partial class Form1 : Form
    {
        Database SkiBase = new Database();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Курсова робота з баз даних\nТема: Лижний курорт\nВиконав ст. гр. ІС-11 Бацан Ілля");
        }

        private void comboBoxSkiPassID_DropDown(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("GetSkiPassId", SkiBase.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SkiBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            comboBoxSkiPassID.Items.Clear();
            while (reader.Read())
            {
                comboBoxSkiPassID.Items.Add(reader["SkiPassId"].ToString());
            }

            reader.Close();
            SkiBase.closeConnection();
        }

        private void comboBoxTourniquetID_DropDown(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("GetTourniquetId", SkiBase.GetConnection());
            command.CommandType = CommandType.StoredProcedure;
            SkiBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            comboBoxTourniquetID.Items.Clear();
            while (reader.Read())
            {
                comboBoxTourniquetID.Items.Add(reader["TourniquetID"].ToString());
            }

            reader.Close();
            SkiBase.closeConnection();
        }

        private void buttonPass_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = SkiBase.GetConnection())
            {
                using (SqlCommand command = new SqlCommand("Valid", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@SkiPassId", SqlDbType.Int).Value = Convert.ToInt32(comboBoxSkiPassID.SelectedItem);
                    command.Parameters.Add("@TourniquetId", SqlDbType.Int).Value = Convert.ToInt32(comboBoxTourniquetID.SelectedItem);

                    SqlParameter returnValue = command.Parameters.Add("RetVal", SqlDbType.Int);
                    returnValue.Direction = ParameterDirection.ReturnValue;

                    connection.Open();
                    command.ExecuteNonQuery();

                    int result = (int)returnValue.Value;

                    if (result == 1)
                    {
                        MessageBox.Show(">> Прохід дозволено! >>");
                    }
                    else if (result == 0)
                    {
                        MessageBox.Show("Х Прохід заборонено! Х");
                    }
                }
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("GetSkiPassId", SkiBase.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();

            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["SkiPassId"].ToString());
            }

            reader.Close();
            SkiBase.closeConnection();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("TariffBalance", SkiBase.GetConnection());

            command.CommandType = CommandType.StoredProcedure;

            // Add input parameters
            command.Parameters.AddWithValue("@SkiPassId", 5);

            // Add output parameter
            SqlParameter outputParam = command.Parameters.Add("@Res", SqlDbType.NVarChar, 70);
            outputParam.Direction = ParameterDirection.Output;


            SkiBase.openConnection();
            command.ExecuteNonQuery();
            

            string result = outputParam.Value.ToString();

            MessageBox.Show(result);
        }

        private void comboBoxTariffName_DropDown(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("GetTarifNames", SkiBase.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            SkiBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            comboBoxTariffName.Items.Clear();
            while (reader.Read())
            {
                comboBoxTariffName.Items.Add(reader["TariffName"].ToString());
            }

            reader.Close();
            SkiBase.closeConnection();
        }

        private void buttonPickTariff_Click(object sender, EventArgs e)
        {
            
            string queryString = $"SELECT Price FROM Tariff WHERE TariffName  = '{comboBoxTariffName.SelectedItem.ToString()}'";
            SqlCommand command = new SqlCommand(queryString, SkiBase.GetConnection());
            SkiBase.openConnection();

            object result = command.ExecuteScalar();

            if (result != null)
            {
                decimal price = Convert.ToDecimal(result);
                labelPrice.Text = price.ToString();
            }
            else
            {
                labelPrice.Text = "Немає данних";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string queryString1 = $"SELECT TariffId FROM Tariff WHERE TariffName  = '{comboBoxTariffName.SelectedItem.ToString()}'";
            SqlCommand command = new SqlCommand(queryString1, SkiBase.GetConnection());
            SkiBase.openConnection();
            object id = command.ExecuteScalar();
            string queryString2 = $"INSERT INTO SkiPass VALUES ({Convert.ToInt32(id)})";
            SqlCommand command2 = new SqlCommand(queryString2, SkiBase.GetConnection());
            command2.ExecuteNonQuery();
            labelPrice.Text = String.Empty;
            comboBoxTariffName.SelectedIndex = -1;
            MessageBox.Show("Скі-пас додано до бази даних");
            SkiBase.closeConnection();
        }

        private void buttonRevenues_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("TariffName", "TariffName");
            dataGridView1.Columns.Add("Revenue", "Revenue");
            dataGridView1.Columns.Add("Ski-pass count", "Ski-pass count");

            string querystring = $"SELECT Tariff.TariffName, SUM(Tariff.Price) AS Revenue, COUNT(*) AS [Ski-pass count] FROM Tariff INNER JOIN SkiPass ON Tariff.TariffID = SkiPass.TariffID GROUP BY Tariff.TariffName";
            
            SqlCommand sqlCommand = new SqlCommand(querystring, SkiBase.GetConnection());
            SkiBase.openConnection();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetString(0), reader.GetDouble(1), reader.GetInt32(2));
            }
            reader.Close();
            SkiBase.closeConnection();
        }

        private void buttonLifts_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("TourniquetID", "TourniquetID");
            dataGridView1.Columns.Add("PassageDate", "PassageDate");
            dataGridView1.Columns.Add("RecordCount", "RecordCount");

            string querystring = $"SELECT TourniquetID, CONVERT(date, PassageTime) AS PassageDate, COUNT(*) AS RecordCount FROM Usage GROUP BY TourniquetID, CONVERT(date, PassageTime) ORDER BY TourniquetID, CONVERT(date, PassageTime); ";

            SqlCommand sqlCommand = new SqlCommand(querystring, SkiBase.GetConnection());
            SkiBase.openConnection();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader.GetInt32(0), reader.GetDateTime(1), reader.GetInt32(2));
            }
            reader.Close();
            SkiBase.closeConnection();
        }

        private void comboBoxTariffName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}