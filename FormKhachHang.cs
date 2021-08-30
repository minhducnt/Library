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
    public partial class FormKhachHang : Form
    {
        bool Add = false;
        //string connectionSTR = "Data Source = (local)\\SQLEXPRESS;Initial Catalog =LibraryManagement; Integrated Security = True";
        string connectionSTR = "Data Source = (local);Initial Catalog =LibraryManagement; Integrated Security = True";
        SqlConnection connection = null;
        public FormKhachHang()
        {
            InitializeComponent();
            LoadData();
        }
        void SetCbTenKhachHang()
        {
            connection = new SqlConnection(connectionSTR);
            cbTenKhach.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select TenKhach From KhachHang", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbTenKhach.Items.Add(dr["TenKhach"].ToString());
            connection.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelKhachHang.Visible = true;
            ReSet();
            Add = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            panelKhachHang.Visible = false;
            Add = false;
            txtMaKhach.Enabled = true;
        }

        private void LoadData()
        {
            string query = "select * from KhachHang";
            dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
            SetCbTenKhachHang();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelKhachHang.Visible = true;
            int r = dtGridView.CurrentCell.RowIndex;
            txtMaKhach.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtTenKhach.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtEmail.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtDiaChi.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtSoDienThoai.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            if (!Add)
                txtMaKhach.Enabled = false;
        }

        private void ReSet()
        {
            txtMaKhach.ResetText();
            txtTenKhach.ResetText();
            txtEmail.ResetText();
            txtDiaChi.ResetText();
            txtSoDienThoai.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    string query = "EXEC dbo.NhapKhachHang @MaKhach=N'" + txtMaKhach.Text + "'," +
                        "@TenKhach=N'" + txtTenKhach.Text + "'," +
                        "@Email=N'" + txtEmail.Text + "'," +
                        "@DiaChiKhach=N'" + txtDiaChi.Text + "'," +
                        "@DienThoaiKhach=N'" + txtSoDienThoai.Text + "'";
                    DataProvider.Instance.ExecuteQuery(query);
                    MessageBox.Show("Thêm thành công!!");
                    LoadData();
                    panelKhachHang.Visible = false;
                    Add = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã tồn tại khách trên");
                }
            }
            else
            {
                string query = "EXEC dbo.SuaKhachHang @MaKhach = N'" + txtMaKhach.Text + "'," +
                        "@TenKhach=N'" + txtTenKhach.Text + "'," +
                        "@Email=N'" + txtEmail.Text + "'," +
                        "@DiaChiKhach=N'" + txtDiaChi.Text + "'," +
                        "@DienThoaiKhach=N'" + txtSoDienThoai.Text + "'";
                DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Sửa thành công!!");
                LoadData();
                panelKhachHang.Visible = false;
                txtMaKhach.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "EXEC dbo.XoaKhachHang @MaKhach = N'" + txtMaKhach.Text + "'";
            DataProvider.Instance.ExecuteQuery(query);
            MessageBox.Show("Xóa thành công!!");
            LoadData();
            panelKhachHang.Visible = false;
            txtMaKhach.Enabled = true;
        }

        private void cbTenKhach_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionSTR);

            string query = "Select *From KhachHang Where TenKhach ='" + cbTenKhach.Text + "'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtGridView.DataSource = dt;
            connection.Close();
            if (cbTenKhach.Text == "")
            {
                string querycus = "select * from KhachHang";
                dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(querycus);

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

        private void FormKhachHang_Load(object sender, EventArgs e)
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
