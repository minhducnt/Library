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
    public partial class FormDonTra : Form
    {
        bool Add = false;
        string connectionSTR = "Data Source = (local);Initial Catalog =LibraryManagement; Integrated Security = True";
        SqlConnection connection = null;
        public FormDonTra()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelDonTra.Visible = true;
            Add = true;
            ReSet();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            panelDonTra.Visible = false;
            Add = false;
            txtMaDonTra.Enabled = true;
        }

        private void LoadData()
        {
            SetCBDonTra();
            SetCBMaDonMuon();
            SetCbMaCuon();
            string query = " SELECT ChiTietDonTra.MaDonTra,MaDonMuon,MaCuon,NgayTra,TienPhat " +
                "FROM dbo.DonTra,dbo.ChiTietDonTra WHERE ChiTietDonTra.MaDonTra=DonTra.MaDonTra";
            dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void ReSet()
        {
            txtMaDonTra.ResetText();
            cbMaDonMuon.ResetText();
            cbMaCuon.ResetText();
            txtNgayTra.ResetText();
            txtTienPhat.ResetText();
        }

        private void dtGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelDonTra.Visible = true;
            int r = dtGridView.CurrentCell.RowIndex;
            txtMaDonTra.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            cbMaDonMuon.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            cbMaCuon.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtNgayTra.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtTienPhat.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            if (!Add)
                txtMaDonTra.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    string query1 = "EXEC dbo.NhapChiTietDonTra @MaDonTra=N'" + txtMaDonTra.Text + "'," +
                        "@MaCuon=N'" + cbMaCuon.Text + "'," +
                        "@NgayTra=N'" + txtNgayTra.Text + "'," +
                        "@TienPhat=N'" + Double.Parse(txtTienPhat.Text) + "'";
                    string query2 = "EXEC dbo.NhapDonTra @MaDonTra=N'" + txtMaDonTra.Text + "'," +
                        "@MaDonMuon=N'" + cbMaDonMuon.Text + "'";
                    DataProvider.Instance.ExecuteQuery(query2);
                    DataProvider.Instance.ExecuteQuery(query1);
                    MessageBox.Show("Thêm thành công!!");
                    LoadData();
                    panelDonTra.Visible = false;
                    Add = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Không tồn tại đơn mượn hoặc đơn trả trên!");
                }
            }
            else
            {
                string query1 = "EXEC dbo.SuaChiTietDonTra @MaDonTra=N'" + txtMaDonTra.Text + "'," +
                        "@MaCuon=N'" + cbMaCuon.Text + "'," +
                        "@NgayTra=N'" + txtNgayTra.Text + "'," +
                        "@TienPhat=N'" + Double.Parse(txtTienPhat.Text) + "'";
                string query2 = "EXEC dbo.SuaDonTra @MaDonTra=N'" + txtMaDonTra.Text + "'," +
                    "@MaDonMuon=N'" + cbMaDonMuon.Text + "'";
                DataProvider.Instance.ExecuteQuery(query2);
                DataProvider.Instance.ExecuteQuery(query1);
                MessageBox.Show("Sửa thành công!!");
                LoadData();
                panelDonTra.Visible = false;
                txtMaDonTra.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query1 = "EXEC dbo.XoaDonTra @MaDonTra=N'" + txtMaDonTra.Text + "'";
            string query2 = "EXEC dbo.XoaChiTietDonTra @MaDonTra=N'" + txtMaDonTra.Text + "',@MaCuon=N'"+cbMaCuon.Text+"'";
            DataProvider.Instance.ExecuteQuery(query1);
            DataProvider.Instance.ExecuteQuery(query2);
            MessageBox.Show("Xóa thành công!!");
            LoadData();
            panelDonTra.Visible = false;
            txtMaDonTra.Enabled = true;
        }

        void SetCBDonTra()
        {
            connection = new SqlConnection(connectionSTR);
            cbDonTra.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select MaDonTra From DonTra", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbDonTra.Items.Add(dr["MaDonTra"].ToString());
            connection.Close();
        }

        void SetCbMaCuon()
        {
            connection = new SqlConnection(connectionSTR);
            cbMaCuon.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select MaCuon From ChiTietDonTra", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbMaCuon.Items.Add(dr["MaCuon"].ToString());
            connection.Close();
        }

        void SetCBMaDonMuon()
        {
            connection = new SqlConnection(connectionSTR);
            cbMaDonMuon.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select MaDonMuon From DonTra", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbMaDonMuon.Items.Add(dr["MaDonMuon"].ToString());
            connection.Close();
        }    

        private void cbDonTra_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionSTR);
            string query = "SELECT ChiTietDonTra.MaDonTra,MaDonMuon,MaCuon,NgayTra,TienPhat " +
                "FROM dbo.DonTra,dbo.ChiTietDonTra WHERE ChiTietDonTra.MaDonTra=DonTra.MaDonTra And " +
                "DonTra.MaDonTra='" + cbDonTra.Text + "'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtGridView.DataSource = dt;
            connection.Close();
            if (cbDonTra.Text == "")
            {
                string querystaff = "SELECT ChiTietDonTra.MaDonTra,MaDonMuon,MaCuon,NgayTra,TienPhat " +
                "FROM dbo.DonTra,dbo.ChiTietDonTra WHERE ChiTietDonTra.MaDonTra=DonTra.MaDonTra";
                dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(querystaff);
            }
        }

        private void ClockLetter(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) /*&& (e.KeyChar != '.')*/)
            {
                e.Handled = true;
            }
        }

        private void txtTienPhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClockLetter(sender, e);
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

        private void FormDonTra_Load(object sender, EventArgs e)
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
