using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DoAnCuoiKyDBMS.DAO;

namespace BTChuong_5
{
    public partial class FormChiTiet : Form
    {
        //string connectionSTR = "Data Source = (local)\\SQLEXPRESS;Initial Catalog =LibraryManagement; Integrated Security = True";
        string connectionSTR = "Data Source = (local);Initial Catalog =LibraryManagement; Integrated Security = True";
        SqlConnection connection = null;
        public FormChiTiet()
        {
            InitializeComponent();
        }

        private void btnSachVoiTinhTrang_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Add(panelSachVoiTinhTrang);
            panelHome.Tag = panelSachVoiTinhTrang;
            panelSachVoiTinhTrang.BringToFront();
            panelSachVoiTinhTrang.Show();
        }

        private void cbTinhTrang1_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From LietKeSachVoiTinhTrang ('" + cbTinhTrang1.Text + "')";
            dtGridView1.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnSachVoiTacGia_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Add(panelSachVoiTacGia);
            panelHome.Tag = panelSachVoiTacGia;
            panelSachVoiTacGia.BringToFront();
            panelSachVoiTacGia.Show();
            SetCbTacGia2();
        }

        private void SetCbTacGia2()
        {
            connection = new SqlConnection(connectionSTR);
            cbTacGia2.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select TenTacGia From TacGia", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbTacGia2.Items.Add(dr["TenTacGia"].ToString());
            connection.Close();
        }

        private void cbTacGia2_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From LietKeSachVoiTenTacGia (N'" + cbTacGia2.Text + "')";
            dtGridView2.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnSachVoiNXBVaTacGia_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Add(panelSachVoiNXBVaTacGia);
            panelHome.Tag = panelSachVoiNXBVaTacGia;
            panelSachVoiNXBVaTacGia.BringToFront();
            panelSachVoiNXBVaTacGia.Show();
            SetCbTacGia3();
            SetCbNXB3();
        }

        private void SetCbTacGia3()
        {
            connection = new SqlConnection(connectionSTR);
            cbTacGia3.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select TenTacGia From TacGia", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbTacGia3.Items.Add(dr["TenTacGia"].ToString());
            connection.Close();
        }

        private void SetCbNXB3()
        {
            connection = new SqlConnection(connectionSTR);
            cbNXB3.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select TenNXB From NXB", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbNXB3.Items.Add(dr["TenNXB"].ToString());
            connection.Close();
        }

        private void cbNXB3_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From LietKeSachVoiVaoNXBVaTacGia ('" + cbTacGia3.Text + "','" + cbNXB3.Text + "')";
            dtGridView3.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void cbTacGia3_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From LietKeSachVoiVaoNXBVaTacGia ('" + cbTacGia3.Text + "','" + cbNXB3.Text + "')";
            dtGridView3.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnNhanVienVoiChucVu_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Add(panelNhanVienVoiChucVu);
            panelHome.Tag = panelNhanVienVoiChucVu;
            panelNhanVienVoiChucVu.BringToFront();
            panelNhanVienVoiChucVu.Show();
        }

        private void cbChucVu4_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From LietKeNhanVienVoiChucVu('" + cbChucVu4.Text + "')";
            dtGridView4.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnSachVoiKeSach_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Add(panelSachVoiKeSach);
            panelHome.Tag = panelSachVoiKeSach;
            panelSachVoiKeSach.BringToFront();
            panelSachVoiKeSach.Show();
            SetCbKeSach5();
        }

        private void SetCbKeSach5()
        {
            connection = new SqlConnection(connectionSTR);
            cbKeSach5.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT KeSach FROM dbo.CuonSach GROUP BY KeSach", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbKeSach5.Items.Add(dr["KeSach"].ToString());
            connection.Close();
        }

        private void cbKeSach5_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From LietKeSachVoiKeSach(" + cbKeSach5.Text + ")";
            dtGridView5.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnNhanVienVoiKhachHang_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Add(panelNhanVienVoiKhachHang);
            panelHome.Tag = panelNhanVienVoiKhachHang;
            panelNhanVienVoiKhachHang.BringToFront();
            panelNhanVienVoiKhachHang.Show();
            SetCbKhachHang6();
        }

        private void SetCbKhachHang6()
        {
            connection = new SqlConnection(connectionSTR);
            cbKhachHang6.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT TenKhach FROM dbo.KhachHang", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbKhachHang6.Items.Add(dr["TenKhach"].ToString());
            connection.Close();
        }

        private void cbKhachHang6_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From LietKeNhanVienVoiKhach('" + cbKhachHang6.Text + "')";
            dtGridView6.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnSachVoiGiaMua_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Add(panelGiaMuaTrongKhoang);
            panelHome.Tag = panelGiaMuaTrongKhoang;
            panelGiaMuaTrongKhoang.BringToFront();
            panelGiaMuaTrongKhoang.Show();
        }

        private void txtMax7_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From LietKeSachVoiGiaMuaTrongKhoang(" + txtMin7.Text + "," + txtMax7.Text + ")";
            if (!txtMax7.Text.Equals("") && !txtMin7.Text.Equals(""))
            {
                dtGridView7.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
        }

        private void btnSachVoiGiaThue_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Add(panelGiaThueTrongKhoang);
            panelHome.Tag = panelGiaThueTrongKhoang;
            panelGiaThueTrongKhoang.BringToFront();
            panelGiaThueTrongKhoang.Show();
        }

        private void txtMax8_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From LietKeSachVoiGiaThueTrongKhoang(" + txtMin8.Text + "," + txtMax8.Text + ")";
            if (!txtMin8.Text.Equals("") && !txtMax8.Text.Equals(""))
            {
                dtGridView8.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
        }

        private void btnKhachHangVoiDiaChi_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Add(panelKhachHangVoiDiaChi);
            panelHome.Tag = panelKhachHangVoiDiaChi;
            panelKhachHangVoiDiaChi.BringToFront();
            panelKhachHangVoiDiaChi.Show();
            SetCbDiaChiKhach9();
        }

        private void SetCbDiaChiKhach9()
        {
            connection = new SqlConnection(connectionSTR);
            cbDiaChi9.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT DiaChiKhach FROM dbo.KhachHang", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbDiaChi9.Items.Add(dr["DiaChiKhach"].ToString());
            connection.Close();
        }

        private void cbDiaChi9_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From LietKeKhachHangVoiDiaChi('" + cbDiaChi9.Text + "')";
            dtGridView9.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void btnNXBVoiTheLoai_Click(object sender, EventArgs e)
        {
            panelHome.Controls.Add(panelNXBVoiTheLoai);
            panelHome.Tag = panelNXBVoiTheLoai;
            panelNXBVoiTheLoai.BringToFront();
            panelNXBVoiTheLoai.Show();
            SetCbTheLoai10();
        }

        private void SetCbTheLoai10()
        {
            connection = new SqlConnection(connectionSTR);
            cbTheLoai10.Items.Clear();
            SqlCommand cmd = new SqlCommand("SELECT TheLoai FROM dbo.DauSach GROUP BY TheLoai", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbTheLoai10.Items.Add(dr["TheLoai"].ToString());
            connection.Close();
        }

        private void cbTheLoai10_TextChanged(object sender, EventArgs e)
        {
            string query = "Select * From LietKeNhaXuatBanVoiTheLoai('" + cbTheLoai10.Text + "')";
            dtGridView10.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
