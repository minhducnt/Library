
namespace BTChuong_5
{
    partial class FormTongKet
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
            this.pnlBtn = new System.Windows.Forms.Panel();
            this.btnLietKe = new System.Windows.Forms.Button();
            this.btnTop10KhachHang = new System.Windows.Forms.Button();
            this.btnTop10NXB = new System.Windows.Forms.Button();
            this.btnTop10TacGia = new System.Windows.Forms.Button();
            this.btnTop10DauSach = new System.Windows.Forms.Button();
            this.dtGridView = new System.Windows.Forms.DataGridView();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btn = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBtn
            // 
            this.pnlBtn.Controls.Add(this.btnLietKe);
            this.pnlBtn.Controls.Add(this.btnTop10KhachHang);
            this.pnlBtn.Controls.Add(this.btnTop10NXB);
            this.pnlBtn.Controls.Add(this.btnTop10TacGia);
            this.pnlBtn.Controls.Add(this.btnTop10DauSach);
            this.pnlBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBtn.Location = new System.Drawing.Point(0, 0);
            this.pnlBtn.Name = "pnlBtn";
            this.pnlBtn.Size = new System.Drawing.Size(217, 653);
            this.pnlBtn.TabIndex = 0;
            // 
            // btnLietKe
            // 
            this.btnLietKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLietKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLietKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLietKe.Location = new System.Drawing.Point(0, 480);
            this.btnLietKe.Name = "btnLietKe";
            this.btnLietKe.Size = new System.Drawing.Size(217, 120);
            this.btnLietKe.TabIndex = 0;
            this.btnLietKe.Text = "Top 10 Sách Trả Quá Hạn Nhất";
            this.btnLietKe.UseVisualStyleBackColor = false;
            this.btnLietKe.Click += new System.EventHandler(this.btnLietKe_Click);
            // 
            // btnTop10KhachHang
            // 
            this.btnTop10KhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTop10KhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTop10KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop10KhachHang.Location = new System.Drawing.Point(0, 360);
            this.btnTop10KhachHang.Name = "btnTop10KhachHang";
            this.btnTop10KhachHang.Size = new System.Drawing.Size(217, 120);
            this.btnTop10KhachHang.TabIndex = 0;
            this.btnTop10KhachHang.Text = "Top 10 Khách Hàng Mượn Nhiều Sách Nhất";
            this.btnTop10KhachHang.UseVisualStyleBackColor = false;
            this.btnTop10KhachHang.Click += new System.EventHandler(this.btnTop10KhachHang_Click);
            // 
            // btnTop10NXB
            // 
            this.btnTop10NXB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTop10NXB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTop10NXB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop10NXB.Location = new System.Drawing.Point(0, 240);
            this.btnTop10NXB.Name = "btnTop10NXB";
            this.btnTop10NXB.Size = new System.Drawing.Size(217, 120);
            this.btnTop10NXB.TabIndex = 0;
            this.btnTop10NXB.Text = "Top 10 Nhà Xuất Bản Nhiều Sách Nhất";
            this.btnTop10NXB.UseVisualStyleBackColor = false;
            this.btnTop10NXB.Click += new System.EventHandler(this.btnTop10NXB_Click);
            // 
            // btnTop10TacGia
            // 
            this.btnTop10TacGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTop10TacGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTop10TacGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop10TacGia.Location = new System.Drawing.Point(0, 120);
            this.btnTop10TacGia.Name = "btnTop10TacGia";
            this.btnTop10TacGia.Size = new System.Drawing.Size(217, 120);
            this.btnTop10TacGia.TabIndex = 0;
            this.btnTop10TacGia.Text = "Top 10 Tác Giả Viết Nhiều Sách Nhất\r\n";
            this.btnTop10TacGia.UseVisualStyleBackColor = false;
            this.btnTop10TacGia.Click += new System.EventHandler(this.btnTop10TacGia_Click);
            // 
            // btnTop10DauSach
            // 
            this.btnTop10DauSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnTop10DauSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTop10DauSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop10DauSach.Location = new System.Drawing.Point(0, 0);
            this.btnTop10DauSach.Name = "btnTop10DauSach";
            this.btnTop10DauSach.Size = new System.Drawing.Size(217, 120);
            this.btnTop10DauSach.TabIndex = 0;
            this.btnTop10DauSach.Text = "Top 10 Đầu Sách Có Nhiều Cuốn Sách Nhất";
            this.btnTop10DauSach.UseVisualStyleBackColor = false;
            this.btnTop10DauSach.Click += new System.EventHandler(this.btnTop10DauSach_Click);
            // 
            // dtGridView
            // 
            this.dtGridView.AllowUserToAddRows = false;
            this.dtGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtGridView.Location = new System.Drawing.Point(17, 12);
            this.dtGridView.Name = "dtGridView";
            this.dtGridView.RowHeadersWidth = 51;
            this.dtGridView.RowTemplate.Height = 24;
            this.dtGridView.Size = new System.Drawing.Size(736, 539);
            this.dtGridView.TabIndex = 4;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.btn);
            this.pnlData.Controls.Add(this.dtGridView);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(217, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(765, 653);
            this.pnlData.TabIndex = 1;
            // 
            // btn
            // 
            this.btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn.Image = global::BTChuong_5.Properties.Resources.excel;
            this.btn.Location = new System.Drawing.Point(579, 571);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(174, 70);
            this.btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn.TabIndex = 5;
            this.btn.TabStop = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Excel 2003|.xls|Excel 2007|.xlsx";
            // 
            // FormTongKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlBtn);
            this.Name = "FormTongKet";
            this.Text = "FormTongKet";
            this.pnlBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView)).EndInit();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBtn;
        private System.Windows.Forms.Button btnLietKe;
        private System.Windows.Forms.Button btnTop10KhachHang;
        private System.Windows.Forms.Button btnTop10DauSach;
        private System.Windows.Forms.Button btnTop10TacGia;
        private System.Windows.Forms.Button btnTop10NXB;
        private System.Windows.Forms.DataGridView dtGridView;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.PictureBox btn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}