using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCuoiKyDBMS.DAO;
using System.Data.SqlClient;

namespace BTChuong_5
{
    public partial class FormNhaXuatBan : Form
    {
        bool Add = false;
        //string connectionSTR = "Data Source = (local)\\SQLEXPRESS;Initial Catalog =LibraryManagement; Integrated Security = True";
        string connectionSTR = "Data Source = (local);Initial Catalog =LibraryManagement; Integrated Security = True";
        SqlConnection connection = null;
        public FormNhaXuatBan()
        {
            InitializeComponent();
            LoadData();
        }

        void SetCbTenNXB()
        {
            connection = new SqlConnection(connectionSTR);
            cbTenNhaXuatBan.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select TenNXB From NXB", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbTenNhaXuatBan.Items.Add(dr["TenNXB"].ToString());
            connection.Close();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelNhaXuatBan.Visible = true;
            ReSet();
            Add = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            panelNhaXuatBan.Visible = false;
            Add = false;
            txtMaNhaXuatBan.Enabled = true;
        }

        private void dtGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelNhaXuatBan.Visible = true;
            int r = dtGridView.CurrentCell.RowIndex;
            txtMaNhaXuatBan.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtTenNhaXuatBan.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            if (!Add)
                txtMaNhaXuatBan.Enabled = false;
        }

        private void LoadData()
        {
            SetCbTenNXB();
            string query = "select * from NXB";
            dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void ReSet()
        {
            txtMaNhaXuatBan.ResetText();
            txtTenNhaXuatBan.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    string query = "EXEC dbo.NhapNhaXuatBan @MaNXB=N'" + txtMaNhaXuatBan.Text + "'," +
                        "@TenNXB=N'" + txtTenNhaXuatBan.Text + "'";
                    DataProvider.Instance.ExecuteQuery(query);
                    MessageBox.Show("Thêm thành công!!");
                    LoadData();
                    panelNhaXuatBan.Visible = false;
                    Add = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã tồn tại nhà xuất bản trên!");
                }
            }
            else
            {
                string query = "EXEC dbo.SuaNXB @MaNXB=N'" + txtMaNhaXuatBan.Text + "'," +
                        "@TenNXB=N'" + txtTenNhaXuatBan.Text + "'";
                DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Sửa thành công!!");
                LoadData();
                panelNhaXuatBan.Visible = false;
                txtMaNhaXuatBan.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "EXEC dbo.XoaNXB @MaNXB = N'" + txtMaNhaXuatBan.Text + "'";
            DataProvider.Instance.ExecuteQuery(query);
            MessageBox.Show("Xóa thành công!!");
            LoadData();
            panelNhaXuatBan.Visible = false;
            txtMaNhaXuatBan.Enabled = true;
        }

        private void cbTenNXB_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionSTR);

            string query = "Select *From NXB Where TenNXB='" + cbTenNhaXuatBan.Text + "'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtGridView.DataSource = dt;
            connection.Close();
            if (cbTenNhaXuatBan.Text == "")
            {
                string querystaff = "select * from NXB";
                dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(querystaff);

            }
        }

        void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void FormNhaXuatBan_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel.Instance.ToExcel(dtGridView, saveFileDialog1.FileName);
            }
        }
    }
}
