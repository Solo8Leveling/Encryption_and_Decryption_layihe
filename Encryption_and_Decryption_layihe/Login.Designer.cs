
namespace Encryption_and_Decryption_layihe
{
    partial class Login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_form));
            this.Login_usrname = new System.Windows.Forms.TextBox();
            this.Login_panel_usr = new System.Windows.Forms.Panel();
            this.Login_panel_pwd = new System.Windows.Forms.Panel();
            this.Login_pswrd = new System.Windows.Forms.TextBox();
            this.Login_login_btn = new System.Windows.Forms.Button();
            this.Login_rgstr_btn = new System.Windows.Forms.Button();
            this.Login_login_with = new System.Windows.Forms.Label();
            this.Google_logo = new System.Windows.Forms.Button();
            this.Face_logo = new System.Windows.Forms.Button();
            this.pswrd_logo = new System.Windows.Forms.PictureBox();
            this.usr_logo = new System.Windows.Forms.PictureBox();
            this.Login_eye = new System.Windows.Forms.Button();
            this.Login_hide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pswrd_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usr_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_usrname
            // 
            this.Login_usrname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_usrname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Login_usrname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_usrname.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_usrname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Login_usrname.HideSelection = false;
            this.Login_usrname.Location = new System.Drawing.Point(100, 130);
            this.Login_usrname.Margin = new System.Windows.Forms.Padding(4);
            this.Login_usrname.MaximumSize = new System.Drawing.Size(187, 150);
            this.Login_usrname.MinimumSize = new System.Drawing.Size(19, 25);
            this.Login_usrname.Name = "Login_usrname";
            this.Login_usrname.Size = new System.Drawing.Size(186, 26);
            this.Login_usrname.TabIndex = 1;
            this.Login_usrname.TabStop = false;
            this.Login_usrname.Text = "Username";
            this.Login_usrname.Click += new System.EventHandler(this.Login_usrname_Click);
            this.Login_usrname.TextChanged += new System.EventHandler(this.Login_usrname_Textchanged);
            // 
            // Login_panel_usr
            // 
            this.Login_panel_usr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_panel_usr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Login_panel_usr.ForeColor = System.Drawing.Color.White;
            this.Login_panel_usr.Location = new System.Drawing.Point(53, 160);
            this.Login_panel_usr.Name = "Login_panel_usr";
            this.Login_panel_usr.Size = new System.Drawing.Size(279, 1);
            this.Login_panel_usr.TabIndex = 3;
            this.Login_panel_usr.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Login_panel_pwd
            // 
            this.Login_panel_pwd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_panel_pwd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Login_panel_pwd.ForeColor = System.Drawing.Color.White;
            this.Login_panel_pwd.Location = new System.Drawing.Point(53, 228);
            this.Login_panel_pwd.Name = "Login_panel_pwd";
            this.Login_panel_pwd.Size = new System.Drawing.Size(279, 1);
            this.Login_panel_pwd.TabIndex = 6;
            // 
            // Login_pswrd
            // 
            this.Login_pswrd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_pswrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Login_pswrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login_pswrd.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_pswrd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Login_pswrd.HideSelection = false;
            this.Login_pswrd.Location = new System.Drawing.Point(102, 199);
            this.Login_pswrd.Margin = new System.Windows.Forms.Padding(4);
            this.Login_pswrd.MaximumSize = new System.Drawing.Size(187, 150);
            this.Login_pswrd.MinimumSize = new System.Drawing.Size(19, 25);
            this.Login_pswrd.Name = "Login_pswrd";
            this.Login_pswrd.Size = new System.Drawing.Size(186, 26);
            this.Login_pswrd.TabIndex = 5;
            this.Login_pswrd.TabStop = false;
            this.Login_pswrd.Text = "Password";
            this.Login_pswrd.Click += new System.EventHandler(this.Login_pswrd_Click);
            this.Login_pswrd.TextChanged += new System.EventHandler(this.Login_pswrd_TextChanged);
            // 
            // Login_login_btn
            // 
            this.Login_login_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.Login_login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_login_btn.Location = new System.Drawing.Point(69, 251);
            this.Login_login_btn.Name = "Login_login_btn";
            this.Login_login_btn.Size = new System.Drawing.Size(257, 33);
            this.Login_login_btn.TabIndex = 7;
            this.Login_login_btn.Text = "LOGIN";
            this.Login_login_btn.UseVisualStyleBackColor = false;
            this.Login_login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login_rgstr_btn
            // 
            this.Login_rgstr_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_rgstr_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Login_rgstr_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_rgstr_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_rgstr_btn.ForeColor = System.Drawing.Color.White;
            this.Login_rgstr_btn.Location = new System.Drawing.Point(69, 301);
            this.Login_rgstr_btn.Name = "Login_rgstr_btn";
            this.Login_rgstr_btn.Size = new System.Drawing.Size(257, 33);
            this.Login_rgstr_btn.TabIndex = 10;
            this.Login_rgstr_btn.Text = "REGISTER";
            this.Login_rgstr_btn.UseVisualStyleBackColor = false;
            this.Login_rgstr_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login_login_with
            // 
            this.Login_login_with.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_login_with.AutoSize = true;
            this.Login_login_with.Cursor = System.Windows.Forms.Cursors.Default;
            this.Login_login_with.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Login_login_with.Location = new System.Drawing.Point(160, 376);
            this.Login_login_with.Name = "Login_login_with";
            this.Login_login_with.Size = new System.Drawing.Size(88, 21);
            this.Login_login_with.TabIndex = 11;
            this.Login_login_with.Text = "login with";
            // 
            // Google_logo
            // 
            this.Google_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Google_logo.BackColor = System.Drawing.Color.Black;
            this.Google_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Google_logo.BackgroundImage")));
            this.Google_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Google_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Google_logo.Location = new System.Drawing.Point(221, 411);
            this.Google_logo.Name = "Google_logo";
            this.Google_logo.Size = new System.Drawing.Size(47, 48);
            this.Google_logo.TabIndex = 13;
            this.Google_logo.UseVisualStyleBackColor = false;
            this.Google_logo.Click += new System.EventHandler(this.Google_logo_Click_1);
            // 
            // Face_logo
            // 
            this.Face_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Face_logo.BackColor = System.Drawing.Color.Black;
            this.Face_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Face_logo.BackgroundImage")));
            this.Face_logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Face_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Face_logo.Location = new System.Drawing.Point(132, 411);
            this.Face_logo.Name = "Face_logo";
            this.Face_logo.Size = new System.Drawing.Size(47, 48);
            this.Face_logo.TabIndex = 12;
            this.Face_logo.UseVisualStyleBackColor = false;
            this.Face_logo.Click += new System.EventHandler(this.Face_logo_Click_1);
            // 
            // pswrd_logo
            // 
            this.pswrd_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pswrd_logo.Image = ((System.Drawing.Image)(resources.GetObject("pswrd_logo.Image")));
            this.pswrd_logo.Location = new System.Drawing.Point(50, 179);
            this.pswrd_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pswrd_logo.Name = "pswrd_logo";
            this.pswrd_logo.Size = new System.Drawing.Size(45, 48);
            this.pswrd_logo.TabIndex = 4;
            this.pswrd_logo.TabStop = false;
            // 
            // usr_logo
            // 
            this.usr_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usr_logo.Image = ((System.Drawing.Image)(resources.GetObject("usr_logo.Image")));
            this.usr_logo.Location = new System.Drawing.Point(50, 111);
            this.usr_logo.Margin = new System.Windows.Forms.Padding(4);
            this.usr_logo.Name = "usr_logo";
            this.usr_logo.Size = new System.Drawing.Size(45, 48);
            this.usr_logo.TabIndex = 0;
            this.usr_logo.TabStop = false;
            this.usr_logo.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Login_eye
            // 
            this.Login_eye.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_eye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Login_eye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_eye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Login_eye.Image = ((System.Drawing.Image)(resources.GetObject("Login_eye.Image")));
            this.Login_eye.Location = new System.Drawing.Point(297, 193);
            this.Login_eye.Name = "Login_eye";
            this.Login_eye.Size = new System.Drawing.Size(31, 32);
            this.Login_eye.TabIndex = 14;
            this.Login_eye.UseVisualStyleBackColor = false;
            this.Login_eye.Click += new System.EventHandler(this.Login_eye_Click);
            // 
            // Login_hide
            // 
            this.Login_hide.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_hide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Login_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_hide.Image = ((System.Drawing.Image)(resources.GetObject("Login_hide.Image")));
            this.Login_hide.Location = new System.Drawing.Point(297, 193);
            this.Login_hide.Name = "Login_hide";
            this.Login_hide.Size = new System.Drawing.Size(31, 32);
            this.Login_hide.TabIndex = 15;
            this.Login_hide.UseVisualStyleBackColor = false;
            this.Login_hide.Click += new System.EventHandler(this.Login_hide_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 40);
            this.label1.TabIndex = 16;
            this.label1.Text = "Log In";
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(400, 482);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Google_logo);
            this.Controls.Add(this.Face_logo);
            this.Controls.Add(this.Login_login_with);
            this.Controls.Add(this.Login_rgstr_btn);
            this.Controls.Add(this.Login_login_btn);
            this.Controls.Add(this.Login_panel_pwd);
            this.Controls.Add(this.Login_pswrd);
            this.Controls.Add(this.pswrd_logo);
            this.Controls.Add(this.Login_panel_usr);
            this.Controls.Add(this.Login_usrname);
            this.Controls.Add(this.usr_logo);
            this.Controls.Add(this.Login_eye);
            this.Controls.Add(this.Login_hide);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pswrd_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usr_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox usr_logo;
        private System.Windows.Forms.TextBox Login_usrname;
        private System.Windows.Forms.Panel Login_panel_usr;
        private System.Windows.Forms.Panel Login_panel_pwd;
        private System.Windows.Forms.TextBox Login_pswrd;
        private System.Windows.Forms.PictureBox pswrd_logo;
        private System.Windows.Forms.Button Login_login_btn;
        private System.Windows.Forms.Button Login_rgstr_btn;
        private System.Windows.Forms.Label Login_login_with;
        private System.Windows.Forms.Button Face_logo;
        private System.Windows.Forms.Button Google_logo;
        private System.Windows.Forms.Button Login_eye;
        private System.Windows.Forms.Button Login_hide;
        private System.Windows.Forms.Label label1;
    }
}

