using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WFABD
{
    public partial class Form1 : Form
    {
        private readonly string _connectionStr = "Data Source=Lufer;Initial Catalog=database_city;Integrated Security=True";
        private readonly SqlConnection _sql;
        private SqlCommand _cmd;
        private SqlDataAdapter _adapter;
        private string _cityid = "";

        public Form1()
        {
            InitializeComponent();
            _sql = new SqlConnection(_connectionStr);
            _sql.Open();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.countryTableAdapter.Fill(this.database_cityDataSet.country);
            this.logsTableAdapter.Fill(this.database_cityDataSet.logs);
            dgvCity.AutoGenerateColumns = false;
            dgvCity.DataSource = FetchCityDetails();
        }
        private DataTable FetchCityDetails()
        {
            if(_sql.State == ConnectionState.Closed)
            {
                _sql.Open();
            }

            DataTable dt = new DataTable();
            _cmd = new SqlCommand("spCity", _sql);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@ActionType", "FetchData");
            _adapter = new SqlDataAdapter(_cmd);
            _adapter.Fill(dt);
            return dt;
        }
        private DataTable FetchCountryDetails()
        {
            if(_sql.State == ConnectionState.Closed)
            {
                _sql.Open();
            }

            DataTable dt = new DataTable();
            _cmd = new SqlCommand("spCountry", _sql);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@ActionType", "FetchData");
            _adapter = new SqlDataAdapter(_cmd);
            _adapter.Fill(dt);
            return dt;
        }
        private DataTable FetchLogsDetails()
        {
            if(_sql.State == ConnectionState.Closed)
            {
                _sql.Open();
            }

            DataTable dt = new DataTable();
            _cmd = new SqlCommand("spLogs", _sql);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@ActionType", "FetchData");
            _adapter = new SqlDataAdapter(_cmd);
            _adapter.Fill(dt);
            return dt;
        }
        private DataTable FetchCityRecords(string _ctid)
        {
            if (_sql.State == ConnectionState.Closed)
            {
                _sql.Open();
            }

            DataTable dt = new DataTable();
            _cmd = new SqlCommand("spCity", _sql);
            _cmd.CommandType = CommandType.StoredProcedure;
            _cmd.Parameters.AddWithValue("@ActionType", "FetchRecord");
            _cmd.Parameters.AddWithValue("@Id", _ctid);
            _adapter = new SqlDataAdapter(_cmd);
            _adapter.Fill(dt);
            return dt;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCName.Text))
            {
                MessageBox.Show("City name is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCName.Select();
            } 
            else if (string.IsNullOrWhiteSpace(txtLat.Text))
            {
                MessageBox.Show("Lat is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLat.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtLong.Text))
            {
                MessageBox.Show("Long is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLong.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtCID.Text))
            {
                MessageBox.Show("Country code is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCID.Select();
            }
            else
            {
                try
                {
                    if(_sql.State == ConnectionState.Closed)
                    {
                        _sql.Open();
                    }

                    DataTable dt = new DataTable();
                    _cmd = new SqlCommand("spCity", _sql);
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@ActionType", "SaveData");
                    _cmd.Parameters.AddWithValue("@Id", _cityid);
                    _cmd.Parameters.AddWithValue("@CityName", txtCName.Text);
                    _cmd.Parameters.AddWithValue("@lat", txtLat.Text);
                    _cmd.Parameters.AddWithValue("@long", txtLong.Text);
                    _cmd.Parameters.AddWithValue("@country_id", txtCID.Text);

                    int numRow = _cmd.ExecuteNonQuery();

                    if (numRow > 0)
                    {
                        MessageBox.Show("Record is successfully saved", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }

                    else
                    {
                        MessageBox.Show("Something goes wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void DgvCity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnSave.Text = "Update";
                _cityid = dgvCity.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataTable dt = FetchCityRecords(_cityid);

                if (dt.Rows.Count > 0)
                {
                    _cityid = dt.Rows[0][0].ToString();
                    txtCName.Text = dt.Rows[0][1].ToString();
                    txtLat.Text = dt.Rows[0][2].ToString();
                    txtLong.Text = dt.Rows[0][3].ToString();
                    txtCID.Text = dt.Rows[0][4].ToString();
                }

                else
                {
                    Clear();
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_cityid))
            {
                try
                {
                    if(_sql.State == ConnectionState.Closed)
                    {
                        _sql.Open();
                    }

                    DataTable dt = new DataTable();
                    _cmd = new SqlCommand("spCity", _sql);
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@ActionType", "DeleteData");
                    _cmd.Parameters.AddWithValue("@Id", _cityid);
                    int numRes = _cmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record is successfully deleted", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                    else
                    {
                        MessageBox.Show("Something goes wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please, select a record", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Clear()
        {
            btnSave.Text = "Save";
            _cityid = "";

            txtCName.Clear();
            txtLat.Clear();
            txtLong.Clear();
            txtCID.Clear();
            txtContName.Clear();
            txtContEng.Clear();
            txtContCod.Clear();

            dgvCity.AutoGenerateColumns = false;
            dgvLogs.AutoGenerateColumns = false;

            dgvCity.DataSource = FetchCityDetails();
            dgvLogs.DataSource = FetchLogsDetails();
            dgvCountry.DataSource = FetchCountryDetails();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }     

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtContName.Text))
            {
                MessageBox.Show("Country name is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCName.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtContEng.Text))
            {
                MessageBox.Show("Country Eng Name is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLat.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtContCod.Text))
            {
                MessageBox.Show("Country code is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLong.Select();
            }
            else
            {
                try
                {
                    if (_sql.State == ConnectionState.Closed)
                    {
                        _sql.Open();
                    }

                    _cmd = new SqlCommand("INSERT INTO country (country_name, country_name_eng, country_code)" +
                    " VALUES(@country_name, @country_name_eng, @country_code)", _sql);
                    _cmd.Parameters.AddWithValue("@country_name", txtContName.Text);
                    _cmd.Parameters.AddWithValue("@country_name_eng", txtContEng.Text);
                    _cmd.Parameters.AddWithValue("@country_code", txtContCod.Text);
                    _cmd.ExecuteNonQuery();
                    Clear();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                               
            }
        }

        private void btnDELC_Click(object sender, EventArgs e)
        {
            try
            {
                if(_sql.State == ConnectionState.Closed)
                {
                    _sql.Open();
                }

                _cmd = new SqlCommand("DELETE FROM country WHERE id = @countryid", _sql);
                _cmd.Parameters.AddWithValue("@countryid", txtcoID.Text);
                _cmd.ExecuteNonQuery();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUPC_Click(object sender, EventArgs e)
        {
            try
            {
                if(_sql.State == ConnectionState.Closed)
                {
                    _sql.Open();
                }

                _cmd = new SqlCommand("UPDATE country SET country_name = @countryname, country_name_eng = @countryeng, country_code = @countrycode " +
                    "WHERE id = @Id", _sql);
                _cmd.Parameters.AddWithValue("@countryname", txtContName.Text);
                _cmd.Parameters.AddWithValue("@countryeng", txtContEng.Text);
                _cmd.Parameters.AddWithValue("@countrycode", txtContCod.Text);
                _cmd.Parameters.AddWithValue("@Id", txtcoID.Text);
                _cmd.ExecuteNonQuery();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
