
namespace BTChuong_5
{
    partial class FormCuonSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtGiaMua = new System.Windows.Forms.TextBox();
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.panelCuonSach = new System.Windows.Forms.Panel();
            this.cbDoMoi = new System.Windows.Forms.ComboBox();
            this.cbTinhTrangSach = new System.Windows.Forms.ComboBox();
            this.cbMSach = new System.Windows.Forms.ComboBox();
            this.txtTang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKeSach = new System.Windows.Forms.TextBox();
            this.txtGiaThue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaCuon = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.lblMaKhach = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.lblTimKhachHang = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelCuonSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnThoat.FlatAppearance.BorderSize = 5;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(592, 0);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(108, 44);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnXoa.FlatAppearance.BorderSize = 5;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(406, 408);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(185, 63);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLuu.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnLuu.FlatAppearance.BorderSize = 5;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(101, 408);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(185, 63);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGiaMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaMua.Location = new System.Drawing.Point(179, 299);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.Size = new System.Drawing.Size(176, 32);
            this.txtGiaMua.TabIndex = 14;
            this.txtGiaMua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaMua_KeyPress);
            // 
            // cbMaSach
            // 
            this.cbMaSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMaSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(180, 22);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(350, 34);
            this.cbMaSach.TabIndex = 11;
            this.cbMaSach.TextChanged += new System.EventHandler(this.cbMaSach_TextChanged);
            // 
            // panelCuonSach
            // 
            this.panelCuonSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCuonSach.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCuonSach.Controls.Add(this.cbDoMoi);
            this.panelCuonSach.Controls.Add(this.cbTinhTrangSach);
            this.panelCuonSach.Controls.Add(this.cbMSach);
            this.panelCuonSach.Controls.Add(this.txtTang);
            this.panelCuonSach.Controls.Add(this.label3);
            this.panelCuonSach.Controls.Add(this.txtKeSach);
            this.panelCuonSach.Controls.Add(this.txtGiaThue);
            this.panelCuonSach.Controls.Add(this.label2);
            this.panelCuonSach.Controls.Add(this.label1);
            this.panelCuonSach.Controls.Add(this.btnThoat);
            this.panelCuonSach.Controls.Add(this.btnXoa);
            this.panelCuonSach.Controls.Add(this.btnLuu);
            this.panelCuonSach.Controls.Add(this.txtGiaMua);
            this.panelCuonSach.Controls.Add(this.txtMaCuon);
            this.panelCuonSach.Controls.Add(this.lblDiaChi);
            this.panelCuonSach.Controls.Add(this.lblEmail);
            this.panelCuonSach.Controls.Add(this.lblSoDienThoai);
            this.panelCuonSach.Controls.Add(this.lblTenKhach);
            this.panelCuonSach.Controls.Add(this.lblMaKhach);
            this.panelCuonSach.Controls.Add(this.pictureBox1);
            this.panelCuonSach.Location = new System.Drawing.Point(141, 132);
            this.panelCuonSach.Name = "panelCuonSach";
            this.panelCuonSach.Size = new System.Drawing.Size(700, 500);
            this.panelCuonSach.TabIndex = 14;
            this.panelCuonSach.Visible = false;
            // 
            // cbDoMoi
            // 
            this.cbDoMoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDoMoi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDoMoi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDoMoi.FormattingEnabled = true;
            this.cbDoMoi.Items.AddRange(new object[] {
            "Old ",
            "New"});
            this.cbDoMoi.Location = new System.Drawing.Point(448, 235);
            this.cbDoMoi.Name = "cbDoMoi";
            this.cbDoMoi.Size = new System.Drawing.Size(218, 34);
            this.cbDoMoi.TabIndex = 26;
            // 
            // cbTinhTrangSach
            // 
            this.cbTinhTrangSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTinhTrangSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTinhTrangSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTinhTrangSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTinhTrangSach.FormattingEnabled = true;
            this.cbTinhTrangSach.Items.AddRange(new object[] {
            "Lost",
            "Unavailable",
            "Available"});
            this.cbTinhTrangSach.Location = new System.Drawing.Point(448, 179);
            this.cbTinhTrangSach.Name = "cbTinhTrangSach";
            this.cbTinhTrangSach.Size = new System.Drawing.Size(218, 34);
            this.cbTinhTrangSach.TabIndex = 25;
            // 
            // cbMSach
            // 
            this.cbMSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbMSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbMSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMSach.FormattingEnabled = true;
            this.cbMSach.Location = new System.Drawing.Point(448, 64);
            this.cbMSach.Name = "cbMSach";
            this.cbMSach.Size = new System.Drawing.Size(218, 34);
            this.cbMSach.TabIndex = 16;
            // 
            // txtTang
            // 
            this.txtTang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTang.Location = new System.Drawing.Point(490, 354);
            this.txtTang.Name = "txtTang";
            this.txtTang.Size = new System.Drawing.Size(176, 32);
            this.txtTang.TabIndex = 24;
            this.txtTang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTang_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(363, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 26);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tầng:";
            // 
            // txtKeSach
            // 
            this.txtKeSach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKeSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeSach.Location = new System.Drawing.Point(179, 354);
            this.txtKeSach.Name = "txtKeSach";
            this.txtKeSach.Size = new System.Drawing.Size(176, 32);
            this.txtKeSach.TabIndex = 22;
            this.txtKeSach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeSach_KeyPress);
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGiaThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaThue.Location = new System.Drawing.Point(490, 296);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Size = new System.Drawing.Size(176, 32);
            this.txtGiaThue.TabIndex = 21;
            this.txtGiaThue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaThue_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Giá Thuê:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Độ Mới Của Sách:";
            // 
            // txtMaCuon
            // 
            this.txtMaCuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaCuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCuon.Location = new System.Drawing.Point(448, 122);
            this.txtMaCuon.Name = "txtMaCuon";
            this.txtMaCuon.Size = new System.Drawing.Size(218, 32);
            this.txtMaCuon.TabIndex = 12;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(66, 360);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(101, 26);
            this.lblDiaChi.TabIndex = 10;
            this.lblDiaChi.Text = "Kệ Sách:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(66, 302);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 26);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Giá Mua:";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(249, 187);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(176, 26);
            this.lblSoDienThoai.TabIndex = 8;
            this.lblSoDienThoai.Text = "Tình Trạng Sách:";
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhach.Location = new System.Drawing.Point(249, 128);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(106, 26);
            this.lblTenKhach.TabIndex = 7;
            this.lblTenKhach.Text = "Mã Cuốn:";
            // 
            // lblMaKhach
            // 
            this.lblMaKhach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaKhach.AutoSize = true;
            this.lblMaKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhach.Location = new System.Drawing.Point(249, 72);
            this.lblMaKhach.Name = "lblMaKhach";
            this.lblMaKhach.Size = new System.Drawing.Size(104, 26);
            this.lblMaKhach.TabIndex = 6;
            this.lblMaKhach.Text = "Mã Sách:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Image = global::BTChuong_5.Properties.Resources._19_194629_clip_art_stack_of_books_school_books_icon;
            this.pictureBox1.Location = new System.Drawing.Point(37, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(748, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(233, 77);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Thêm Cuốn Sách";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(39, 113);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.Size = new System.Drawing.Size(900, 500);
            this.dtGridView.TabIndex = 13;
            this.dtGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellDoubleClick);
            // 
            // lblTimKhachHang
            // 
            this.lblTimKhachHang.AutoSize = true;
            this.lblTimKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKhachHang.Location = new System.Drawing.Point(38, 30);
            this.lblTimKhachHang.Name = "lblTimKhachHang";
            this.lblTimKhachHang.Size = new System.Drawing.Size(104, 26);
            this.lblTimKhachHang.TabIndex = 15;
            this.lblTimKhachHang.Text = "Mã Sách:";
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Image = global::BTChuong_5.Properties.Resources.excel;
            this.btnExcel.Location = new System.Drawing.Point(583, 0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(149, 77);
            this.btnExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExcel.TabIndex = 16;
            this.btnExcel.TabStop = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel 2003|.xls|Excel 2007|.xlsx";
            // 
            // FormCuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.cbMaSach);
            this.Controls.Add(this.panelCuonSach);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.lblTimKhachHang);
            this.Name = "FormCuonSach";
            this.Text = "FormCuonSach";
            this.Load += new System.EventHandler(this.FormCuonSach_Load);
            this.panelCuonSach.ResumeLayout(false);
            this.panelCuonSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtGiaMua;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.Panel panelCuonSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaCuon;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label lblMaKhach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.Label lblTimKhachHang;
        private System.Windows.Forms.TextBox txtTang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKeSach;
        private System.Windows.Forms.TextBox txtGiaThue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDoMoi;
        private System.Windows.Forms.ComboBox cbTinhTrangSach;
        private System.Windows.Forms.ComboBox cbMSach;
        private System.Windows.Forms.PictureBox btnExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}