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

namespace BTChuong_5
{
    public partial class FormTongKet : Form
    {
        public FormTongKet()
        {
            InitializeComponent();
        }
        private void btnTop10NXB_Click(object sender, EventArgs e)
        {
            string query = " SELECT * FROM dbo.Top10NXBXuatBanNhieuDauSachNhat";
            dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtGridView.GridColor = System.Drawing.Color.FromArgb(255, 255, 128);
        }

        private void btnTop10TacGia_Click(object sender, EventArgs e)
        {   
            string query = " SELECT * FROM dbo.Top10TacGiaVietNhieuSachNhat";
            dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtGridView.GridColor = System.Drawing.Color.FromArgb(255, 192, 128);
        }

        private void btnTop10DauSach_Click(object sender, EventArgs e)
        {
            string query = " SELECT * FROM dbo.Top10DauSachCoNhieuCuonSachNhat";
            dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtGridView.GridColor = System.Drawing.Color.FromArgb(255, 128, 128);
        }

        private void btnTop10KhachHang_Click(object sender, EventArgs e)
        {
            string query = " SELECT *  FROM dbo.Top10KhachHangMuonNhieuSachNhat";
            dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtGridView.GridColor = System.Drawing.Color.FromArgb(128, 255, 128);
        }

        private void btnLietKe_Click(object sender, EventArgs e)
        {
            string query = " SELECT * FROM dbo.Top10SachTraQuaHanNhat";
            dtGridView.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dtGridView.GridColor = System.Drawing.Color.FromArgb(128, 255, 255);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel.Instance.ToExcel(dtGridView, saveFileDialog1.FileName);
            }
        }
    }
}
