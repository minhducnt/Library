
namespace BTChuong_5
{
    partial class FormNhaXuatBan
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
            this.txtTenNhaXuatBan = new System.Windows.Forms.TextBox();
            this.txtMaNhaXuatBan = new System.Windows.Forms.TextBox();
            this.lblTenKhach = new System.Windows.Forms.Label();
            this.lblMaKhach = new System.Windows.Forms.Label();
            this.lblTimKhachHang = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panelNhaXuatBan = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.cbTenNhaXuatBan = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelNhaXuatBan.SuspendLayout();
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
            this.btnXoa.Location = new System.Drawing.Point(399, 294);
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
            this.btnLuu.Location = new System.Drawing.Point(92, 294);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(185, 63);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTenNhaXuatBan
            // 
            this.txtTenNhaXuatBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhaXuatBan.Location = new System.Drawing.Point(459, 162);
            this.txtTenNhaXuatBan.Name = "txtTenNhaXuatBan";
            this.txtTenNhaXuatBan.Size = new System.Drawing.Size(218, 32);
            this.txtTenNhaXuatBan.TabIndex = 12;
            // 
            // txtMaNhaXuatBan
            // 
            this.txtMaNhaXuatBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhaXuatBan.Location = new System.Drawing.Point(459, 92);
            this.txtMaNhaXuatBan.Name = "txtMaNhaXuatBan";
            this.txtMaNhaXuatBan.Size = new System.Drawing.Size(218, 32);
            this.txtMaNhaXuatBan.TabIndex = 11;
            // 
            // lblTenKhach
            // 
            this.lblTenKhach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTenKhach.AutoSize = true;
            this.lblTenKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhach.Location = new System.Drawing.Point(251, 168);
            this.lblTenKhach.Name = "lblTenKhach";
            this.lblTenKhach.Size = new System.Drawing.Size(196, 26);
            this.lblTenKhach.TabIndex = 7;
            this.lblTenKhach.Text = "Tên Nhà Xuất Bản:";
            // 
            // lblMaKhach
            // 
            this.lblMaKhach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaKhach.AutoSize = true;
            this.lblMaKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhach.Location = new System.Drawing.Point(251, 98);
            this.lblMaKhach.Name = "lblMaKhach";
            this.lblMaKhach.Size = new System.Drawing.Size(190, 26);
            this.lblMaKhach.TabIndex = 6;
            this.lblMaKhach.Text = "Mã Nhà Xuất Bản:";
            // 
            // lblTimKhachHang
            // 
            this.lblTimKhachHang.AutoSize = true;
            this.lblTimKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKhachHang.Location = new System.Drawing.Point(39, 31);
            this.lblTimKhachHang.Name = "lblTimKhachHang";
            this.lblTimKhachHang.Size = new System.Drawing.Size(196, 26);
            this.lblTimKhachHang.TabIndex = 10;
            this.lblTimKhachHang.Text = "Tên Nhà Xuất Bản:";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(726, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(256, 77);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm Nhà Xuất Bản";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelNhaXuatBan
            // 
            this.panelNhaXuatBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelNhaXuatBan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelNhaXuatBan.Controls.Add(this.btnThoat);
            this.panelNhaXuatBan.Controls.Add(this.btnXoa);
            this.panelNhaXuatBan.Controls.Add(this.btnLuu);
            this.panelNhaXuatBan.Controls.Add(this.txtTenNhaXuatBan);
            this.panelNhaXuatBan.Controls.Add(this.txtMaNhaXuatBan);
            this.panelNhaXuatBan.Controls.Add(this.lblTenKhach);
            this.panelNhaXuatBan.Controls.Add(this.lblMaKhach);
            this.panelNhaXuatBan.Controls.Add(this.pictureBox1);
            this.panelNhaXuatBan.Location = new System.Drawing.Point(141, 132);
            this.panelNhaXuatBan.Name = "panelNhaXuatBan";
            this.panelNhaXuatBan.Size = new System.Drawing.Size(700, 400);
            this.panelNhaXuatBan.TabIndex = 9;
            this.panelNhaXuatBan.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.Image = global::BTChuong_5.Properties.Resources.images__3_;
            this.pictureBox1.Location = new System.Drawing.Point(31, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.Location = new System.Drawing.Point(40, 114);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.Size = new System.Drawing.Size(900, 500);
            this.dtGridView.TabIndex = 8;
            this.dtGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridView_CellDoubleClick);
            // 
            // cbTenNhaXuatBan
            // 
            this.cbTenNhaXuatBan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTenNhaXuatBan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTenNhaXuatBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenNhaXuatBan.FormattingEnabled = true;
            this.cbTenNhaXuatBan.Location = new System.Drawing.Point(257, 23);
            this.cbTenNhaXuatBan.Name = "cbTenNhaXuatBan";
            this.cbTenNhaXuatBan.Size = new System.Drawing.Size(309, 34);
            this.cbTenNhaXuatBan.TabIndex = 6;
            this.cbTenNhaXuatBan.TextChanged += new System.EventHandler(this.cbTenNXB_TextChanged);
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcel.Image = global::BTChuong_5.Properties.Resources.excel;
            this.btnExcel.Location = new System.Drawing.Point(572, 0);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(149, 77);
            this.btnExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExcel.TabIndex = 18;
            this.btnExcel.TabStop = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel 2003|.xls|Excel 2007|.xlsx";
            // 
            // FormNhaXuatBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.lblTimKhachHang);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelNhaXuatBan);
            this.Controls.Add(this.dtGridView);
            this.Controls.Add(this.cbTenNhaXuatBan);
            this.Name = "FormNhaXuatBan";
            this.Text = "FormNhaXuatBan";
            this.Load += new System.EventHandler(this.FormNhaXuatBan_Load);
            this.panelNhaXuatBan.ResumeLayout(false);
            this.panelNhaXuatBan.PerformLayout();
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
        private System.Windows.Forms.TextBox txtTenNhaXuatBan;
        private System.Windows.Forms.TextBox txtMaNhaXuatBan;
        private System.Windows.Forms.Label lblTenKhach;
        private System.Windows.Forms.Label lblMaKhach;
        private System.Windows.Forms.Label lblTimKhachHang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panelNhaXuatBan;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.ComboBox cbTenNhaXuatBan;
        private System.Windows.Forms.PictureBox btnExcel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}