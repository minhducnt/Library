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
    public partial class FormDonMuon : Form
    {
        bool Add = false;
        string connectionSTR = "Data Source = (local);Initial Catalog =LibraryManagement; Integrated Security = True";
        SqlConnection connection = null;
        public FormDonMuon()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelDonMuon.Visible = true;
            Add = true;
            ReSet();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            panelDonMuon.Visible = false;
            Add = false;
            txtMaDonMuon.Enabled = true;
        }

        private void LoadData()
        {
            SetCBMaDonMuon();
            SetCbMaCuon();
            SetCbMaKhach();
            SetCbMaNhanVien();
            string query = "SELECT ChiTietDonMuon.MaDonMuon,MaCuon,MaNhanVien,MaKhach,NgayMuon " +
                "FROM dbo.ChiTietDonMuon,dbo.DonMuon WHERE ChiTietDonMuon.MaDonMuon=DonMuon.MaDonMuon";
            dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void ReSet()
        {
            txtMaDonMuon.ResetText();
            cbMaCuon.ResetText();
            cbMaKhach.ResetText();
            cbMaNhanVien.ResetText();
            txtNgayMuon.ResetText();
        }

        private void dtGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelDonMuon.Visible = true;
            int r = dtGridView.CurrentCell.RowIndex;
            txtMaDonMuon.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            cbMaCuon.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            cbMaNhanVien.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            cbMaKhach.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtNgayMuon.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            if (!Add)
                txtMaDonMuon.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    string query1 = "EXEC dbo.NhapDonMuon @MaDonMuon=N'" + txtMaDonMuon.Text + "'," +
                        "@MaNhanVien=N'" + cbMaNhanVien.Text + "'," +
                        "@MaKhach=N'" + cbMaKhach.Text + "'," +
                        "@NgayMuon=N'" + txtNgayMuon.Text + "'";
                    string query2 = "EXEC dbo.NhapChiTietDonMuon @MaDonMuon=N'" + txtMaDonMuon.Text + "'," +
                        "@MaCuon=N'" + cbMaCuon.Text + "'";
                    DataProvider.Instance.ExecuteQuery(query1);
                    DataProvider.Instance.ExecuteQuery(query2);
                    MessageBox.Show("Thêm thành công!!");
                    LoadData();
                    panelDonMuon.Visible = false;
                    Add = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Không tồn tại cuốn sách hoặc đơn mượn hoặc khách hàng hoặc nhân viên trên!");
                }
            }
            else
            {
                string query1 = "EXEC dbo.SuaDonMuon @MaDonMuon=N'" + txtMaDonMuon.Text + "'," +
                        "@MaNhanVien=N'" + cbMaNhanVien.Text + "'," +
                        "@MaKhach=N'" + cbMaKhach.Text + "'," +
                        "@NgayMuon=N'" + txtNgayMuon.Text + "'";
                string query2 = "EXEC dbo.SuaChiTietDonMuon @MaDonMuon=N'" + txtMaDonMuon.Text + "'," +
                    "@MaCuon=N'" + cbMaCuon.Text + "'";
                DataProvider.Instance.ExecuteQuery(query1);
                DataProvider.Instance.ExecuteQuery(query2);
                MessageBox.Show("Sửa thành công!!");
                LoadData();
                panelDonMuon.Visible = false;
                txtMaDonMuon.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query1 = "EXEC dbo.XoaDonMuon @MaDonMuon=N'" + txtMaDonMuon.Text + "'";
            string query2 = "EXEC dbo.XoaChiTietDonMuon @MaDonMuon=N'" + txtMaDonMuon.Text + "',@MaCuon=N'"+cbMaCuon.Text+"'";
            DataProvider.Instance.ExecuteQuery(query1);
            DataProvider.Instance.ExecuteQuery(query2);
            MessageBox.Show("Xoá thành công!!");
            LoadData();
            panelDonMuon.Visible = false;
            txtMaDonMuon.Enabled = true;
        }

        void SetCBMaDonMuon()
        {
            connection = new SqlConnection(connectionSTR);
            cbDonMuon.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select MaDonMuon From DonMuon", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbDonMuon.Items.Add(dr["MaDonMuon"].ToString());
            connection.Close();
        }

        void SetCbMaCuon()
        {
            connection = new SqlConnection(connectionSTR);
            cbMaCuon.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select MaCuon From ChiTietDonMuon", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbMaCuon.Items.Add(dr["MaCuon"].ToString());
            connection.Close();
        }

        void SetCbMaKhach()
        {
            connection = new SqlConnection(connectionSTR);
            cbMaKhach.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select MaKhach From DonMuon", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbMaKhach.Items.Add(dr["MaKhach"].ToString());
            connection.Close();
        }

        void SetCbMaNhanVien()
        {
            connection = new SqlConnection(connectionSTR);
            cbMaNhanVien.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select MaNhanVien From DonMuon", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbMaNhanVien.Items.Add(dr["MaNhanVien"].ToString());
            connection.Close();
        }

        private void cbDonMuon_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionSTR);
            string query = "SELECT ChiTietDonMuon.MaDonMuon,MaCuon,MaNhanVien,MaKhach,NgayMuon " +
                           "FROM dbo.ChiTietDonMuon,dbo.DonMuon WHERE ChiTietDonMuon.MaDonMuon=DonMuon.MaDonMuon and " +
                           "DonMuon.MaDonMuon='" + cbDonMuon.Text + "'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtGridView.DataSource = dt;
            connection.Close();
            if (cbDonMuon.Text == "")
            {
                string querystaff = "SELECT ChiTietDonMuon.MaDonMuon,MaCuon,MaNhanVien,MaKhach,NgayMuon " +
                "FROM dbo.ChiTietDonMuon,dbo.DonMuon WHERE ChiTietDonMuon.MaDonMuon=DonMuon.MaDonMuon";
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

        private void FormDonMuon_Load(object sender, EventArgs e)
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
