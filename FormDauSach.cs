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
    public partial class FormDauSach : Form
    {
        bool Add = false;
        //string connectionSTR = "Data Source = (local)\\SQLEXPRESS;Initial Catalog =LibraryManagement; Integrated Security = True";
        string connectionSTR = "Data Source = (local);Initial Catalog =LibraryManagement; Integrated Security = True";
        SqlConnection connection = null;
        public FormDauSach()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelDauSach.Visible = true;
            ReSet();
            Add = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            panelDauSach.Visible = false;
            Add = false;
            txtMaSach.Enabled = true;
        }

        private void dtGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelDauSach.Visible = true;
            int r = dtGridView.CurrentCell.RowIndex;
            txtMaSach.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtTuaSach.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            cbMaNXB.Text = dtGridView.Rows[r].Cells[2].Value.ToString();
            txtNgonNgu.Text = dtGridView.Rows[r].Cells[3].Value.ToString();
            txtTheLoai.Text = dtGridView.Rows[r].Cells[4].Value.ToString();
            txtThoiGian.Text = dtGridView.Rows[r].Cells[5].Value.ToString();
            if (!Add)
                txtMaSach.Enabled = false;
        }

        private void LoadData()
        {
            SetCbDauSach();
            SetCbMaNXB();
            string query = "select * from DauSach";
            dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void ReSet()
        {
            txtMaSach.ResetText();
            txtTuaSach.ResetText();
            cbMaNXB.ResetText();
            txtNgonNgu.ResetText();
            txtTheLoai.ResetText();
            txtThoiGian.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    string query = "EXEC dbo.NhapDauSach @MaSach=N'" + txtMaSach.Text + "'," +
                        "@TuaSach=N'" + txtTuaSach.Text + "'," +
                        "@MaNXB=N'" + cbMaNXB.Text + "'," +
                        "@NgonNgu=N'" + txtNgonNgu.Text + "'," +
                        "@TheLoai=N'" + txtTheLoai.Text + "'," +
                        "@ThoiGianMuonToiDa=N'" + int.Parse(txtThoiGian.Text) + "'";
                    DataProvider.Instance.ExecuteQuery(query);
                    MessageBox.Show("Thêm thành công!!");
                    LoadData();
                    panelDauSach.Visible = false;
                    Add = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Không tồn tại nhà xuất bản trên!");
                }
            }
            else
            {
                string query = "EXEC dbo.SuaDauSach @MaSach=N'" + txtMaSach.Text + "'," +
                        "@TuaSach=N'" + txtTuaSach.Text + "'," +
                        "@MaNXB=N'" + cbMaNXB.Text + "'," +
                        "@NgonNgu=N'" + txtNgonNgu.Text + "'," +
                        "@TheLoai=N'" + txtTheLoai.Text + "'," +
                        "@ThoiGianMuonToiDa=N'" + int.Parse(txtThoiGian.Text) + "'";
                DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Sửa thành công!!");
                LoadData();
                panelDauSach.Visible = false;
                txtMaSach.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "EXEC dbo.XoaDauSach @MaSach = N'" + txtMaSach.Text + "'";
            DataProvider.Instance.ExecuteQuery(query);
            MessageBox.Show("Xóa thành công!!");
            LoadData();
            panelDauSach.Visible = false;
            txtMaSach.Enabled = true;
        }

        void SetCbDauSach()
        {
            connection = new SqlConnection(connectionSTR);
            cbTuaSach.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select TuaSach From DauSach", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbTuaSach.Items.Add(dr["TuaSach"].ToString());
            connection.Close();
        }

        void SetCbMaNXB()
        {
            connection = new SqlConnection(connectionSTR);
            cbMaNXB.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select MaNXB From DauSach", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbMaNXB.Items.Add(dr["MaNXB"].ToString());
            connection.Close();
        }

        private void cbDauSach_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionSTR);
            string query = "Select *From DauSach Where TuaSach='" + cbTuaSach.Text + "'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtGridView.DataSource = dt;
            connection.Close();
            if (cbTuaSach.Text == "")
            {
                string querystaff = "select * from DauSach";
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

        private void txtThoiGian_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FormDauSach_Load(object sender, EventArgs e)
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