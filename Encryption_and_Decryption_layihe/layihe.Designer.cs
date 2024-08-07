
namespace Encryption_and_Decryption_layihe
{
    partial class layihe
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
            this.tab_botton = new System.Windows.Forms.TabControl();
            this.md5 = new System.Windows.Forms.TabPage();
            this.btn_md5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.md5_txt2 = new System.Windows.Forms.TextBox();
            this.md5_txt1 = new System.Windows.Forms.TextBox();
            this.reverse = new System.Windows.Forms.TabPage();
            this.btn_reverse = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reverse_text2 = new System.Windows.Forms.TextBox();
            this.reverse_text1 = new System.Windows.Forms.TextBox();
            this.ceaser = new System.Windows.Forms.TabPage();
            this.btn_sezar2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.sezar_key = new System.Windows.Forms.TextBox();
            this.btn_sezar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sezar_txt2 = new System.Windows.Forms.TextBox();
            this.sezar_txt1 = new System.Windows.Forms.TextBox();
            this.base64 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.base_btn2 = new System.Windows.Forms.Button();
            this.base_txt3 = new System.Windows.Forms.TextBox();
            this.base_btn1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.base_txt2 = new System.Windows.Forms.TextBox();
            this.base_txt1 = new System.Windows.Forms.TextBox();
            this.tab_botton.SuspendLayout();
            this.md5.SuspendLayout();
            this.reverse.SuspendLayout();
            this.ceaser.SuspendLayout();
            this.base64.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_botton
            // 
            this.tab_botton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_botton.Controls.Add(this.md5);
            this.tab_botton.Controls.Add(this.reverse);
            this.tab_botton.Controls.Add(this.ceaser);
            this.tab_botton.Controls.Add(this.base64);
            this.tab_botton.Location = new System.Drawing.Point(-3, 0);
            this.tab_botton.Name = "tab_botton";
            this.tab_botton.SelectedIndex = 0;
            this.tab_botton.Size = new System.Drawing.Size(810, 458);
            this.tab_botton.TabIndex = 0;
            // 
            // md5
            // 
            this.md5.AutoScroll = true;
            this.md5.AutoScrollMinSize = new System.Drawing.Size(802, 432);
            this.md5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.md5.Controls.Add(this.btn_md5);
            this.md5.Controls.Add(this.label2);
            this.md5.Controls.Add(this.label1);
            this.md5.Controls.Add(this.md5_txt2);
            this.md5.Controls.Add(this.md5_txt1);
            this.md5.Location = new System.Drawing.Point(4, 22);
            this.md5.Name = "md5";
            this.md5.Padding = new System.Windows.Forms.Padding(3);
            this.md5.Size = new System.Drawing.Size(802, 432);
            this.md5.TabIndex = 0;
            this.md5.Text = "MD5";
            this.md5.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btn_md5
            // 
            this.btn_md5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_md5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_md5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_md5.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_md5.ForeColor = System.Drawing.Color.White;
            this.btn_md5.Location = new System.Drawing.Point(375, 190);
            this.btn_md5.Name = "btn_md5";
            this.btn_md5.Size = new System.Drawing.Size(109, 38);
            this.btn_md5.TabIndex = 4;
            this.btn_md5.Text = "Encryption";
            this.btn_md5.UseVisualStyleBackColor = false;
            this.btn_md5.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(93, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cipher Text";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(93, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plain Text";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // md5_txt2
            // 
            this.md5_txt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.md5_txt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.md5_txt2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.md5_txt2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.md5_txt2.Location = new System.Drawing.Point(223, 267);
            this.md5_txt2.Multiline = true;
            this.md5_txt2.Name = "md5_txt2";
            this.md5_txt2.Size = new System.Drawing.Size(409, 100);
            this.md5_txt2.TabIndex = 1;
            // 
            // md5_txt1
            // 
            this.md5_txt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.md5_txt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.md5_txt1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.md5_txt1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.md5_txt1.Location = new System.Drawing.Point(223, 49);
            this.md5_txt1.Multiline = true;
            this.md5_txt1.Name = "md5_txt1";
            this.md5_txt1.Size = new System.Drawing.Size(409, 100);
            this.md5_txt1.TabIndex = 0;
            this.md5_txt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // reverse
            // 
            this.reverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.reverse.Controls.Add(this.btn_reverse);
            this.reverse.Controls.Add(this.label3);
            this.reverse.Controls.Add(this.label4);
            this.reverse.Controls.Add(this.reverse_text2);
            this.reverse.Controls.Add(this.reverse_text1);
            this.reverse.Location = new System.Drawing.Point(4, 22);
            this.reverse.Name = "reverse";
            this.reverse.Padding = new System.Windows.Forms.Padding(3);
            this.reverse.Size = new System.Drawing.Size(802, 432);
            this.reverse.TabIndex = 1;
            this.reverse.Text = "Reverse";
            // 
            // btn_reverse
            // 
            this.btn_reverse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_reverse.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reverse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_reverse.Location = new System.Drawing.Point(358, 356);
            this.btn_reverse.Name = "btn_reverse";
            this.btn_reverse.Size = new System.Drawing.Size(133, 46);
            this.btn_reverse.TabIndex = 9;
            this.btn_reverse.Text = "Reverse";
            this.btn_reverse.UseVisualStyleBackColor = false;
            this.btn_reverse.Click += new System.EventHandler(this.btn_reverse_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(50, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cipher Text";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(50, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Plain Text";
            // 
            // reverse_text2
            // 
            this.reverse_text2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reverse_text2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.reverse_text2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverse_text2.Location = new System.Drawing.Point(184, 203);
            this.reverse_text2.Multiline = true;
            this.reverse_text2.Name = "reverse_text2";
            this.reverse_text2.Size = new System.Drawing.Size(485, 130);
            this.reverse_text2.TabIndex = 6;
            // 
            // reverse_text1
            // 
            this.reverse_text1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reverse_text1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.reverse_text1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverse_text1.Location = new System.Drawing.Point(184, 24);
            this.reverse_text1.Multiline = true;
            this.reverse_text1.Name = "reverse_text1";
            this.reverse_text1.Size = new System.Drawing.Size(485, 130);
            this.reverse_text1.TabIndex = 5;
            // 
            // ceaser
            // 
            this.ceaser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ceaser.Controls.Add(this.btn_sezar2);
            this.ceaser.Controls.Add(this.label7);
            this.ceaser.Controls.Add(this.sezar_key);
            this.ceaser.Controls.Add(this.btn_sezar);
            this.ceaser.Controls.Add(this.label5);
            this.ceaser.Controls.Add(this.label6);
            this.ceaser.Controls.Add(this.sezar_txt2);
            this.ceaser.Controls.Add(this.sezar_txt1);
            this.ceaser.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceaser.Location = new System.Drawing.Point(4, 22);
            this.ceaser.Name = "ceaser";
            this.ceaser.Size = new System.Drawing.Size(802, 432);
            this.ceaser.TabIndex = 2;
            this.ceaser.Text = "Ceaser";
            this.ceaser.Click += new System.EventHandler(this.ceaser_Click);
            // 
            // btn_sezar2
            // 
            this.btn_sezar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sezar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_sezar2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sezar2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sezar2.Location = new System.Drawing.Point(329, 266);
            this.btn_sezar2.Name = "btn_sezar2";
            this.btn_sezar2.Size = new System.Drawing.Size(116, 38);
            this.btn_sezar2.TabIndex = 12;
            this.btn_sezar2.Text = "Decryption";
            this.btn_sezar2.UseVisualStyleBackColor = false;
            this.btn_sezar2.Click += new System.EventHandler(this.btn_sezar2_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(367, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "key";
            // 
            // sezar_key
            // 
            this.sezar_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sezar_key.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.sezar_key.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sezar_key.Location = new System.Drawing.Point(352, 121);
            this.sezar_key.Multiline = true;
            this.sezar_key.Name = "sezar_key";
            this.sezar_key.Size = new System.Drawing.Size(70, 36);
            this.sezar_key.TabIndex = 10;
            this.sezar_key.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_sezar
            // 
            this.btn_sezar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sezar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btn_sezar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sezar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sezar.Location = new System.Drawing.Point(329, 208);
            this.btn_sezar.Name = "btn_sezar";
            this.btn_sezar.Size = new System.Drawing.Size(116, 38);
            this.btn_sezar.TabIndex = 9;
            this.btn_sezar.Text = "Encryption";
            this.btn_sezar.UseVisualStyleBackColor = false;
            this.btn_sezar.Click += new System.EventHandler(this.btn_sezar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(551, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cipher Text";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(84, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Plain Text";
            // 
            // sezar_txt2
            // 
            this.sezar_txt2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sezar_txt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.sezar_txt2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sezar_txt2.Location = new System.Drawing.Point(459, 69);
            this.sezar_txt2.Multiline = true;
            this.sezar_txt2.Name = "sezar_txt2";
            this.sezar_txt2.Size = new System.Drawing.Size(305, 290);
            this.sezar_txt2.TabIndex = 6;
            // 
            // sezar_txt1
            // 
            this.sezar_txt1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sezar_txt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.sezar_txt1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sezar_txt1.Location = new System.Drawing.Point(11, 69);
            this.sezar_txt1.Multiline = true;
            this.sezar_txt1.Name = "sezar_txt1";
            this.sezar_txt1.Size = new System.Drawing.Size(305, 290);
            this.sezar_txt1.TabIndex = 5;
            // 
            // base64
            // 
            this.base64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.base64.Controls.Add(this.label10);
            this.base64.Controls.Add(this.base_btn2);
            this.base64.Controls.Add(this.base_txt3);
            this.base64.Controls.Add(this.base_btn1);
            this.base64.Controls.Add(this.label8);
            this.base64.Controls.Add(this.label9);
            this.base64.Controls.Add(this.base_txt2);
            this.base64.Controls.Add(this.base_txt1);
            this.base64.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.base64.Location = new System.Drawing.Point(4, 22);
            this.base64.Name = "base64";
            this.base64.Size = new System.Drawing.Size(802, 432);
            this.base64.TabIndex = 3;
            this.base64.Text = "Base64";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(45, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Plain Text";
            // 
            // base_btn2
            // 
            this.base_btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.base_btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.base_btn2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.base_btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.base_btn2.Location = new System.Drawing.Point(326, 267);
            this.base_btn2.Name = "base_btn2";
            this.base_btn2.Size = new System.Drawing.Size(236, 38);
            this.base_btn2.TabIndex = 11;
            this.base_btn2.Text = "Decode";
            this.base_btn2.UseVisualStyleBackColor = false;
            this.base_btn2.Click += new System.EventHandler(this.base_btn2_Click);
            // 
            // base_txt3
            // 
            this.base_txt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.base_txt3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.base_txt3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.base_txt3.Location = new System.Drawing.Point(175, 311);
            this.base_txt3.Multiline = true;
            this.base_txt3.Name = "base_txt3";
            this.base_txt3.Size = new System.Drawing.Size(536, 100);
            this.base_txt3.TabIndex = 10;
            // 
            // base_btn1
            // 
            this.base_btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.base_btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.base_btn1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.base_btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.base_btn1.Location = new System.Drawing.Point(326, 117);
            this.base_btn1.Name = "base_btn1";
            this.base_btn1.Size = new System.Drawing.Size(236, 38);
            this.base_btn1.TabIndex = 9;
            this.base_btn1.Text = "Encode";
            this.base_btn1.UseVisualStyleBackColor = false;
            this.base_btn1.Click += new System.EventHandler(this.base_btn1_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(45, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Cipher Text";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(45, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Plain Text";
            // 
            // base_txt2
            // 
            this.base_txt2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.base_txt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.base_txt2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.base_txt2.Location = new System.Drawing.Point(175, 161);
            this.base_txt2.Multiline = true;
            this.base_txt2.Name = "base_txt2";
            this.base_txt2.Size = new System.Drawing.Size(536, 100);
            this.base_txt2.TabIndex = 6;
            // 
            // base_txt1
            // 
            this.base_txt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.base_txt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.base_txt1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.base_txt1.Location = new System.Drawing.Point(175, 11);
            this.base_txt1.Multiline = true;
            this.base_txt1.Name = "base_txt1";
            this.base_txt1.Size = new System.Drawing.Size(536, 100);
            this.base_txt1.TabIndex = 5;
            // 
            // layihe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_botton);
            this.Name = "layihe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "layihe";
            this.tab_botton.ResumeLayout(false);
            this.md5.ResumeLayout(false);
            this.md5.PerformLayout();
            this.reverse.ResumeLayout(false);
            this.reverse.PerformLayout();
            this.ceaser.ResumeLayout(false);
            this.ceaser.PerformLayout();
            this.base64.ResumeLayout(false);
            this.base64.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_botton;
        private System.Windows.Forms.TabPage md5;
        private System.Windows.Forms.TabPage reverse;
        private System.Windows.Forms.Button btn_md5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox md5_txt2;
        private System.Windows.Forms.TextBox md5_txt1;
        private System.Windows.Forms.Button btn_reverse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox reverse_text2;
        private System.Windows.Forms.TextBox reverse_text1;
        private System.Windows.Forms.TabPage ceaser;
        private System.Windows.Forms.TextBox sezar_key;
        private System.Windows.Forms.Button btn_sezar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sezar_txt2;
        private System.Windows.Forms.TextBox sezar_txt1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_sezar2;
        private System.Windows.Forms.TabPage base64;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button base_btn2;
        private System.Windows.Forms.TextBox base_txt3;
        private System.Windows.Forms.Button base_btn1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox base_txt2;
        private System.Windows.Forms.TextBox base_txt1;
    }
}