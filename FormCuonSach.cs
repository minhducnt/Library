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
using System.Text.RegularExpressions;

namespace BTChuong_5
{
    public partial class FormCuonSach : Form
    {
        bool Add = false;
        //string connectionSTR = "Data Source = (local)\\SQLEXPRESS;Initial Catalog =LibraryManagement; Integrated Security = True";
        string connectionSTR = "Data Source = (local);Initial Catalog =LibraryManagement; Integrated Security = True";
        SqlConnection connection = null;
        public FormCuonSach()
        {
            InitializeComponent();
            LoadData();
            
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
        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelCuonSach.Visible = true;
            Add = true;
            ReSet();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            panelCuonSach.Visible = false;
            Add = false;
            txtMaCuon.Enabled = true;
        }

        private void dtGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelCuonSach.Visible = true;
            int r = dtGridView.CurrentCell.RowIndex;
            cbMSach.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtMaCuon.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            cbTinhTrangSach.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            cbDoMoi.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtGiaMua.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtGiaThue.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            txtKeSach.Text = dtGridView.Rows[r].Cells[6].Value.ToString();
            txtTang.Text = dtGridView.Rows[r].Cells[7].Value.ToString();
            if (!Add)
                txtMaCuon.Enabled = false;
        }

        private void LoadData()
        {
            SetCbMaCuon(cbMaSach);
            SetCbMaCuon(cbMSach);
            string query = "select * from CuonSach";
            dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void ReSet()
        {
            cbMSach.ResetText();
            txtMaCuon.ResetText();
            cbTinhTrangSach.ResetText();
            cbDoMoi.ResetText();
            txtGiaMua.ResetText();
            txtGiaThue.ResetText();
            txtKeSach.ResetText();
            txtTang.ResetText();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    string query = "EXEC dbo.NhapCuonSach @MaSach=N'" + cbMSach.Text + "'," +
                        "@MaCuon=N'" + txtMaCuon.Text + "'," +
                        "@TinhTrangSach=N'" + cbTinhTrangSach.Text + "'," +
                        "@DoMoiCuaSach=N'" + cbDoMoi.Text + "'," +
                        "@GiaMua=N'" + Double.Parse(txtGiaMua.Text) + "'," +
                        "@GiaThue=N'" + Double.Parse(txtGiaThue.Text) + "'," +
                        "@KeSach=N'" + int.Parse(txtKeSach.Text) + "'," +
                        "@Tang=N'" + int.Parse(txtTang.Text) + "'";
                    DataProvider.Instance.ExecuteQuery(query);
                    MessageBox.Show("Thêm thành công!!");
                    LoadData();
                    panelCuonSach.Visible = false;
                    Add = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Không tồn tại đầu sách trên!");
                }
            }
            else
            {
                string query = "EXEC dbo.SuaCuonSach @MaSach=N'" + cbMSach.Text + "'," +
                        "@MaCuon=N'" + txtMaCuon.Text + "'," +
                        "@TinhTrangSach=N'" + cbTinhTrangSach.Text + "'," +
                        "@DoMoiCuaSach=N'" + cbDoMoi.Text + "'," +
                        "@GiaMua=N'" + Double.Parse(txtGiaMua.Text) + "'," +
                        "@GiaThue=N'" + Double.Parse(txtGiaThue.Text) + "'," +
                        "@KeSach=N'" + int.Parse(txtKeSach.Text) + "'," +
                        "@Tang=N'" + int.Parse(txtTang.Text) + "'";
                DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Sửa thành công!!");
                LoadData();
                panelCuonSach.Visible = false;
                txtMaCuon.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "EXEC dbo.XoaCuonSach @MaCuon = N'" + txtMaCuon.Text + "'";
            DataProvider.Instance.ExecuteQuery(query);
            MessageBox.Show("Xóa thành công!!");
            LoadData();
            panelCuonSach.Visible = false;
            txtMaCuon.Enabled = true;
        }

        void SetCbMaCuon(ComboBox cb)
        {
            connection = new SqlConnection(connectionSTR);
            cb.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select MaSach From CuonSach", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cb.Items.Add(dr["MaSach"].ToString());
            connection.Close();
        }
        private void cbMaSach_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionSTR);
            string query = "Select *From CuonSach Where MaSach= '" + cbMaSach.Text + "'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtGridView.DataSource = dt;
            connection.Close();
            if (cbMaSach.Text == "")
            {
                string querystaff = "select * from CuonSach";
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

        private void txtGiaMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClockLetter(sender, e);
        }

        private void txtGiaThue_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClockLetter(sender, e);
        }

        private void txtKeSach_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClockLetter(sender, e);
        }

        private void txtTang_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClockLetter(sender, e);
        }

        private void FormCuonSach_Load(object sender, EventArgs e)
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
