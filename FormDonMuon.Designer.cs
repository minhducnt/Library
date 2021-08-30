
namespace BTChuong_5
{
    partial class FormDonMuon
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
            this.cbDonMuon = new System.Windows.Forms.ComboBox();
            this.txtNgayMuon = new System.Windows.Forms.TextBox();
            this.panelDonMuon = new System.Windows.Forms.Panel();
            this.cbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.cbMaKhach = new System.Windows.Forms.ComboBox();
            this.cbMaCuon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMaDonMuon = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.lblMaKhach = new System.Windows.Forms.Label();
            this.lblTimKhachHang = new System.Windows.Forms.Label();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelDonMuon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDonMuon
            // 
            this.cbDonMuon.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDonMuon.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDonMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDonMuon.FormattingEnabled = true;
            this.cbDonMuon.Location = new System.Drawing.Point(181, 22);
            this.cbDonMuon.Name = "cbDonMuon";
            this.cbDonMuon.Size = new System.Drawing.Size(350, 34);
            this.cbDonMuon.TabIndex = 21;
            this.cbDonMuon.TextChanged += new System.EventHandler(this.cbDonMuon_TextChanged);
            // 
            // txtNgayMuon
            // 
            this.txtNgayMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayMuon.Location = new System.Drawing.Point(239, 324);
            this.txtNgayMuon.Name = "txtNgayMuon";
            this.txtNgayMuon.Size = new System.Drawing.Size(409, 32);
            this.txtNgayMuon.TabIndex = 21;
            // 
            // panelDonMuon
            // 
            this.panelDonMuon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDonMuon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDonMuon.Controls.Add(this.cbMaNhanVien);
            this.panelDonMuon.Controls.Add(this.cbMaKhach);
            this.panelDonMuon.Controls.Add(this.cbMaCuon);
            this.panelDonMuon.Controls.Add(this.txtNgayMuon);
            this.panelDonMuon.Controls.Add(this.label2);
            this.panelDonMuon.Controls.Add(this.label1);
            this.panelDonMuon.Controls.Add(this.btnThoat);
            this.panelDonMuon.Controls.Add(this.btnXoa);
            this.panelDonMuon.Controls.Add(this.btnLuu);
            this.panelDonMuon.Controls.Add(this.txtMaDonMuon);
            this.panelDonMuon.Controls.Add(this.lblSoDienThoai);
            this.panelDonMuon.Controls.Add(this.lblTenKhach);
            this.panelDonMuon.Controls.Add(this.lblMaKhach);
            this.panelDonMuon.Location = new System.Drawing.Point(141, 132);
            this.panelDonMuon.Name = "panelDonMuon";
            this.panelDonMuon.Size = new System.Drawing.Size(700, 500);
            this.panelDonMuon.TabIndex = 24;
            this.panelDonMuon.Visible = false;
            // 
            // cbMaNhanVien
            // 
            this.cbMaNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNhanVien.FormattingEnabled = true;
            this.cbMaNhanVien.Location = new System.Drawing.Point(239, 264);
            this.cbMaNhanVien.Name = "cbMaNhanVien";
            this.cbMaNhanVien.Size = new System.Drawing.Size(409, 34);
            this.cbMaNhanVien.TabIndex = 28;
            // 
            // cbMaKhach
            // 
            this.cbMaKhach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMaKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKhach.FormattingEnabled = true;
            this.cbMaKhach.Location = new System.Drawing.Point(239, 205);
            this.cbMaKhach.Name = "cbMaKhach";
            this.cbMaKhach.Size = new System.Drawing.Size(409, 34);
            this.cbMaKhach.TabIndex = 27;
            // 
            // cbMaCuon
            // 
            this.cbMaCuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMaCuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaCuon.FormattingEnabled = true;
            this.cbMaCuon.Location = new System.Drawing.Point(239, 148);
            this.cbMaCuon.Name = "cbMaCuon";
            this.cbMaCuon.Size = new System.Drawing.Size(409, 34);
            this.cbMaCuon.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Ngày Mượn:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.BackColor = System.Drawing.Color.LightCoral;
            this.btnThoat.FlatAppearance.BorderSize = 5;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(593, -2);
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
            this.btnXoa.Location = new System.Drawing.Point(407, 406);
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
            this.btnLuu.Location = new System.Drawing.Point(102, 406);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(185, 63);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMaDonMuon
            // 
            this.txtMaDonMuon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaDonMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDonMuon.Location = new System.Drawing.Point(239, 92);
            this.txtMaDonMuon.Name = "txtMaDonMuon";
            this.txtMaDonMuon.Size = new System.Drawing.Size(409, 32);
            this.txtMaDonMuon.TabIndex = 11;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDienThoai.Location = new System.Drawing.Point(53, 213);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(116, 26);
            this.lblSoDienThoai.TabIndex = 8;
            this.lblSoDienThoai.Text = "Mã Khách:";
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhach.Location = new System.Drawing.Point(53, 154);
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
            this.lblMaKhach.Location = new System.Drawing.Point(53, 98);
            this.lblMaKhach.Name = "lblMaKhach";
            this.lblMaKhach.Size = new System.Drawing.Size(154, 26);
            this.lblMaKhach.TabIndex = 6;
            this.lblMaKhach.Text = "Mã Đơn Mượn:";
            // 
            // lblTimKhachHang
            // 
            this.lblTimKhachHang.AutoSize = true;
            this.lblTimKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKhachHang.Location = new System.Drawing.Point(39, 30);
            this.lblTimKhachHang.Name = "lblTimKhachHang";
            this.lblTimKhachHang.Size = new System.Drawing.Size(118, 26);
            this.lblTimKhachHang.TabIndex = 25;
            this.lblTimKhachHang.Text = "Đơn Mượn:";
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(40, 113);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.Size = new System.Drawing.Size(900, 500);
            this.dtGridView.TabIndex = 23;
            this.dtGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellDoubleClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(749, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(233, 77);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Thêm Đơn Mượn";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Image = global::BTChuong_5.Properties.Resources.excel;
            this.btnExcel.Location = new System.Drawing.Point(584, 0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(149, 77);
            this.btnExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExcel.TabIndex = 26;
            this.btnExcel.TabStop = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel 2003|.xls|Excel 2007|.xlsx";
            // 
            // FormDonMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.cbDonMuon);
            this.Controls.Add(this.panelDonMuon);
            this.Controls.Add(this.lblTimKhachHang);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormDonMuon";
            this.Text = "FormDonMuon";
            this.Load += new System.EventHandler(this.FormDonMuon_Load);
            this.panelDonMuon.ResumeLayout(false);
            this.panelDonMuon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDonMuon;
        private System.Windows.Forms.TextBox txtNgayMuon;
        private System.Windows.Forms.Panel panelDonMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMaDonMuon;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label lblMaKhach;
        private System.Windows.Forms.Label lblTimKhachHang;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbMaNhanVien;
        private System.Windows.Forms.ComboBox cbMaKhach;
        private System.Windows.Forms.ComboBox cbMaCuon;
        private System.Windows.Forms.PictureBox btnExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}