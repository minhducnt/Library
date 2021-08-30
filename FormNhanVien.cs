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
    public partial class FormNhanVien : Form
    {
        bool Add = false;
        //string connectionSTR = "Data Source = (local)\\SQLEXPRESS;Initial Catalog =LibraryManagement; Integrated Security = True";
        string connectionSTR = "Data Source = (local);Initial Catalog =LibraryManagement; Integrated Security = True";
        SqlConnection connection = null;
        public FormNhanVien()
        {
            InitializeComponent();
            LoadData();
        }

        void SetCbTenNhanVien()
        {
            connection = new SqlConnection(connectionSTR);
            cbTenNhanVien.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select TenNhanVien From NhanVien", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbTenNhanVien.Items.Add(dr["TenNhanVien"].ToString());
            connection.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelNhanVien.Visible = true;
            ReSet();
            Add = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            panelNhanVien.Visible = false;
            Add = false;
            txtMaNhanVien.Enabled = true;
        }

        private void dtGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelNhanVien.Visible = true;
            int r = dtGridView.CurrentCell.RowIndex;
            txtMaNhanVien.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtTenNhanVien.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            txtNgaySinh.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtCMND.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            cbGioiTinh.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtEmail.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            txtDiaChi.Text = dtGridView.Rows[r].Cells[6].Value.ToString();
            txtSoDienThoai.Text = dtGridView.Rows[r].Cells[7].Value.ToString();
            cbChucVu.Text = dtGridView.Rows[r].Cells[8].Value.ToString();
            if (!Add)
                txtMaNhanVien.Enabled = false;
        }

        private void LoadData()
        {
            SetCbTenNhanVien();
            string query = "select * from NhanVien";
            dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void ReSet()
        {
            txtMaNhanVien.ResetText();
            txtTenNhanVien.ResetText();
            txtNgaySinh.ResetText();
            txtCMND.ResetText();
            cbGioiTinh.ResetText();
            txtEmail.ResetText();
            txtDiaChi.ResetText();
            txtSoDienThoai.ResetText();
            cbChucVu.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    string query = "EXEC dbo.NhapNhanVien @MaNhanVien=N'" + txtMaNhanVien.Text + "'," +
                        "@TenNhanVien=N'" + txtTenNhanVien.Text + "'," +
                        "@NgaySinh=N'" + txtNgaySinh.Text + "'," +
                        "@CMND=N'" + txtCMND.Text + "'," +
                        "@GioiTinh=N'" + cbGioiTinh.Text + "'," +
                        "@EmailNhanVien=N'" + txtEmail.Text + "'," +
                        "@DiaChi=N'" + txtDiaChi.Text + "'," +
                        "@SDT=N'" + txtSoDienThoai.Text + "'," +
                        "@ChucVu=N'" + cbChucVu.Text + "'";
                    DataProvider.Instance.ExecuteQuery(query);
                    MessageBox.Show("Thêm thành công!!");
                    LoadData();
                    panelNhanVien.Visible = false;
                    Add = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã tồn tại nhân viên trên!");
                }
            }
            else
            {
                
                string query = "EXEC dbo.SuaNhanVien @MaNhanVien=N'" + txtMaNhanVien.Text + "'," +
                        "@TenNhanVien=N'" + txtTenNhanVien.Text + "'," +
                        "@NgaySinh=N'" + txtNgaySinh.Text + "'," +
                        "@CMND=N'" + txtCMND.Text + "'," +
                        "@GioiTinh=N'" + cbGioiTinh.Text + "'," +
                        "@EmailNhanVien=N'" + txtEmail.Text + "'," +
                        "@DiaChi=N'" + txtDiaChi.Text + "'," +
                        "@SDT=N'" + txtSoDienThoai.Text + "'," +
                        "@ChucVu=N'" + cbChucVu.Text + "'";
                DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Sửa thành công!!");
                LoadData();
                panelNhanVien.Visible = false;
                txtMaNhanVien.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "EXEC dbo.XoaNhanVien @MaNhanVien = N'" + txtMaNhanVien.Text + "'";
            DataProvider.Instance.ExecuteQuery(query);
            MessageBox.Show("Xóa thành công!!");
            LoadData();
            panelNhanVien.Visible = false;
            txtMaNhanVien.Enabled = true;
        }

        private void cbTenNhanVien_TextChanged(object sender, EventArgs e)
        {
            string connectionSTR = "Data Source = (local);Initial Catalog =LibraryManagement; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                string query = "Select *From NhanVien Where TenNhanVien=N'" + cbTenNhanVien.Text + "'";
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dtGridView.DataSource = dt;
                connection.Close();
                if (cbTenNhanVien.Text == "")
                {
                    string querystaff = "select * from NhanVien";
                    dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(querystaff);
                }
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

        private void FormNhanVien_Load(object sender, EventArgs e)
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
