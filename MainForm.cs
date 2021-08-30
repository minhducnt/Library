using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTChuong_5
{
    public partial class MainForm : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int temIndex;
        private Form activateForm;

        //Constuctor
        public MainForm()
        {
            InitializeComponent();
            random = new Random();
            btCloseChildForm.Visible = false;
            

        }

        //Method
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while(temIndex==index)
            {
               index= random.Next(ThemeColor.ColorList.Count);
            }
            temIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender!=null)
            {
                if(currentButton!=(Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font= new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color,-0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btCloseChildForm.Visible = true;
                }              
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelSach.Controls)
            {
                if(previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.DarkGray;
                    previousBtn.Font= new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            foreach (Control previousBtn in panelThongTin.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.DarkGray;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            foreach (Control previousBtn in panelHoaDon.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.DarkGray;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
            foreach (Control previousBtn in panelView.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.DarkGray;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }
       
        private void btCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activateForm != null)
                activateForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            label1.Text = "LIBRARY MANAGEMENT";
            panelTitle.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btCloseChildForm.Visible = false;
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            if (panelThongTin.Visible == true) panelThongTin.Visible = false;
            else panelThongTin.Visible = true;

        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            if (panelSach.Visible == true) panelSach.Visible = false;
            else panelSach.Visible = true;
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (panelHoaDon.Visible == true) panelHoaDon.Visible = false;
            else panelHoaDon.Visible = true;
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormKhachHang(), sender);
        }
  
        private void btnNhaXuatBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhaXuatBan(), sender);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormNhanVien(), sender);
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {           
            OpenChildForm(new FormTacGia(), sender);
        }

        private void btnDauSach_Click(object sender, EventArgs e)
        {           
            OpenChildForm(new FormDauSach(), sender);
        }

        private void btnCuonSach_Click(object sender, EventArgs e)
        {          
            OpenChildForm(new FormCuonSach(), sender);
        }

        private void btnDonMuon_Click(object sender, EventArgs e)
        {           
            OpenChildForm(new FormDonMuon(), sender);
        }

        private void btnDonTra_Click(object sender, EventArgs e)
        {         
            OpenChildForm(new FormDonTra(), sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (activateForm != null)
                activateForm.Close();
            Reset();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTongKet(), sender);
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormChiTiet(), sender);
        }
    }
}
