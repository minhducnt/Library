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
    public partial class FormTacGia : Form
    {
        bool Add = false;
        //string connectionSTR = "Data Source = (local)\\SQLEXPRESS;Initial Catalog =LibraryManagement; Integrated Security = True";
        string connectionSTR = "Data Source = (local);Initial Catalog =LibraryManagement; Integrated Security = True";
        SqlConnection connection = null;
        public FormTacGia()
        {
            InitializeComponent();
            LoadData();
        }

        void SetCbTenTacGia()
        {

            connection = new SqlConnection(connectionSTR);
            cbTenTacGia.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select TenTacGia From TacGia", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbTenTacGia.Items.Add(dr["TenTacGia"].ToString());
            connection.Close();
        }
        void SetCbMaSach()
        {
            connection = new SqlConnection(connectionSTR);
            cbMaSach.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select MaSach From DauSach", connection);
            connection.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
                cbMaSach.Items.Add(dr["MaSach"].ToString());
            connection.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            panelTacGia.Visible = true;
            ReSet();
            Add = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            panelTacGia.Visible = false;
            Add = false;
            txtTenTacGia.Enabled = true;
        }

        private void dtGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelTacGia.Visible = true;
            int r = dtGridView.CurrentCell.RowIndex;
            cbMaSach.Text = dtGridView.Rows[r].Cells[0].Value.ToString();
            txtTenTacGia.Text = dtGridView.Rows[r].Cells[1].Value.ToString();
            if (!Add)
                txtTenTacGia.Enabled = false;
        }

        private void LoadData()
        {
            SetCbTenTacGia();
            SetCbMaSach();
            string query = "select * from TacGia";
            dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        private void ReSet()
        {
            cbMaSach.ResetText();
            txtTenTacGia.ResetText();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Add)
            {
                try
                {
                    string query = "EXEC dbo.NhapTacGia @MaSach = N'" + cbMaSach.Text + "'," +
                        "@TenTacGia=N'" + txtTenTacGia.Text + "'";
                    DataProvider.Instance.ExecuteQuery(query);
                    MessageBox.Show("Thêm thành công!!");
                    LoadData();
                    panelTacGia.Visible = false;
                    Add = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Không tồn tại đầu sách trên!");
                }
            }
            else
            {
                string query = "EXEC dbo.SuaTacGia @MaSach = N'" + cbMaSach.Text + "'," +
                        "@TenTacGia=N'" + txtTenTacGia.Text + "'";
                DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Sửa thành công!!");
                LoadData();
                panelTacGia.Visible = false;
                txtTenTacGia.Enabled = true;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "EXEC dbo.XoaTacGia @MaSach = N'" + cbMaSach.Text + "'," +
                        "@TenTacGia=N'" + txtTenTacGia.Text + "'";
            DataProvider.Instance.ExecuteQuery(query);
            MessageBox.Show("Xóa thành công!!");
            LoadData();
            panelTacGia.Visible = false;
            txtTenTacGia.Enabled = true;
        }

        private void cbTenTacGia_TextChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionSTR);

            string query = "Select *From TacGia Where TenTacGia='" + cbTenTacGia.Text + "'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtGridView.DataSource = dt;
            connection.Close();
            if (cbTenTacGia.Text == "")
            {
                string querystaff = "select * from TacGia";
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

        private void FormTacGia_Load(object sender, EventArgs e)
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
