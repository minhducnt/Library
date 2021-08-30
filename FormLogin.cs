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

namespace BTChuong_5
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        string connstr = "Data Source = (local);Initial Catalog =LibraryManagement; Integrated Security = True";
        SqlConnection conn = null;
        SqlDataAdapter adLogin = null;
        DataTable dtLogin = null;
        int countloginfalse = 0;
        private void btSignInClick(object sender, EventArgs e)
        {
            if (txtUName.Text != "" && txtPWord.Text != "")
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT *FROM Account " +
                        "WHERE TenDangNhap =@username  and MatKhau = @password", conn);
                    cmd.Parameters.AddWithValue("@username", txtUName.Text);
                    cmd.Parameters.AddWithValue("@password", txtPWord.Text);
                    adLogin = new SqlDataAdapter(cmd);
                    dtLogin = new DataTable();
                    adLogin.Fill(dtLogin);
                    int count = dtLogin.Rows.Count;
                    if (count == 1)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MainForm mainform = new MainForm();
                        mainform.ShowDialog();
                        this.Close();
                        //this.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        countloginfalse++;
                        if (countloginfalse == 3)
                            this.Close();
                        txtUName.ResetText();
                        txtPWord.ResetText();
                        txtUName.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Không kết nối được cơ sở dữ liệu!");
                }
                finally
                {
                    conn.Close();
                }
            }
            else if (txtUName.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUName.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Cảnh báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPWord.Focus();
                return;
            }
        }
        private void lbExit_Click(object sender, EventArgs e)
        {
            DialogResult CheckExit = MessageBox.Show("Có muốn thoát không?", "Câu hỏi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CheckExit == DialogResult.Yes) this.Close();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            btShow.Visible = false;
            btNotShow.Visible = false;
            conn = new SqlConnection(connstr);
            this.AcceptButton = btSubmit;
        }
        private void btShow_Click(object sender, EventArgs e)
        {
            if (txtPWord.Text != "" && txtPWord.PasswordChar == '*')
            {
                txtPWord.PasswordChar = '\0';
                btShow.Visible = false;
                btNotShow.Visible = true;
            }
        }
        private void btNotShow_Click(object sender, EventArgs e)
        {
            if (txtPWord.Text != "" && txtPWord.PasswordChar == '\0')
            {
                btNotShow.Visible = true;
                txtPWord.PasswordChar = '*';
                btNotShow.Visible = false;
                btShow.Visible = true;
            }
        }
        private void txtPWord_TextChanged(object sender, EventArgs e)
        {
            if (txtPWord.Text != "" && txtPWord.PasswordChar == '*')
                btShow.Visible = true;
            else btShow.Visible = false;
            if (txtPWord.Text == "" && btNotShow.Visible == true)
            {
                btNotShow.Visible = false;
                txtPWord.PasswordChar = '*';
            }
        }
    }
}