
namespace BTChuong_5
{
    partial class FormLogin
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
            this.btShow = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbExit = new System.Windows.Forms.Label();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btNotShow = new FontAwesome.Sharp.IconButton();
            this.txtPWord = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btShow
            // 
            this.btShow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btShow.IconColor = System.Drawing.Color.Black;
            this.btShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btShow.IconSize = 35;
            this.btShow.Location = new System.Drawing.Point(311, 317);
            this.btShow.Name = "btShow";
            this.btShow.Size = new System.Drawing.Size(40, 40);
            this.btShow.TabIndex = 157;
            this.btShow.UseVisualStyleBackColor = false;
            this.btShow.Click += new System.EventHandler(this.btShow_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 497);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(394, 3);
            this.panel4.TabIndex = 147;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 3);
            this.panel3.TabIndex = 146;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(397, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 500);
            this.panel2.TabIndex = 145;
            // 
            // btSubmit
            // 
            this.btSubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSubmit.FlatAppearance.BorderSize = 0;
            this.btSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSubmit.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F);
            this.btSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btSubmit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSubmit.Location = new System.Drawing.Point(51, 393);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(300, 48);
            this.btSubmit.TabIndex = 153;
            this.btSubmit.Text = "Login";
            this.btSubmit.UseVisualStyleBackColor = false;
            this.btSubmit.Click += new System.EventHandler(this.btSignInClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 500);
            this.panel1.TabIndex = 144;
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F);
            this.lbExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbExit.Location = new System.Drawing.Point(180, 455);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(42, 29);
            this.lbExit.TabIndex = 156;
            this.lbExit.Text = "Exit";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // txtUName
            // 
            this.txtUName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUName.Location = new System.Drawing.Point(123, 259);
            this.txtUName.Multiline = true;
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(182, 22);
            this.txtUName.TabIndex = 148;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(51, 287);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(300, 1);
            this.pictureBox4.TabIndex = 149;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(51, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 1);
            this.pictureBox1.TabIndex = 150;
            this.pictureBox1.TabStop = false;
            // 
            // btNotShow
            // 
            this.btNotShow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btNotShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btNotShow.IconColor = System.Drawing.Color.Black;
            this.btNotShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btNotShow.IconSize = 35;
            this.btNotShow.Location = new System.Drawing.Point(311, 317);
            this.btNotShow.Name = "btNotShow";
            this.btNotShow.Size = new System.Drawing.Size(40, 40);
            this.btNotShow.TabIndex = 158;
            this.btNotShow.UseVisualStyleBackColor = false;
            this.btNotShow.Click += new System.EventHandler(this.btNotShow_Click);
            // 
            // txtPWord
            // 
            this.txtPWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPWord.Location = new System.Drawing.Point(123, 335);
            this.txtPWord.Multiline = true;
            this.txtPWord.Name = "txtPWord";
            this.txtPWord.PasswordChar = '*';
            this.txtPWord.Size = new System.Drawing.Size(187, 22);
            this.txtPWord.TabIndex = 151;
            this.txtPWord.TextChanged += new System.EventHandler(this.txtPWord_TextChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 35;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.Location = new System.Drawing.Point(51, 312);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(50, 50);
            this.iconButton1.TabIndex = 159;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 35;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton2.Location = new System.Drawing.Point(51, 236);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(50, 50);
            this.iconButton2.TabIndex = 160;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 185;
            this.iconPictureBox1.Location = new System.Drawing.Point(107, 39);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(185, 188);
            this.iconPictureBox1.TabIndex = 161;
            this.iconPictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btShow);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btNotShow);
            this.Controls.Add(this.txtPWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btShow;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btNotShow;
        private System.Windows.Forms.TextBox txtPWord;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}