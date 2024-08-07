using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Encryption_and_Decryption_layihe
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\Visual prosesler\Login register\Encryption_and_Decryption_layihe\Encryption_and_Decryption_layihe\bin\Debug\db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + Login_usrname.Text + "' and password= '" + Login_pswrd.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new layihe().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Login_usrname.Text = "";
                Login_pswrd.Text = "";
                Login_usrname.Focus();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Register_form().Show();
            this.Hide();
        }
        private void Login_usrname_Textchanged(object sender, EventArgs e)
        {

        }


        private void Login_pswrd_TextChanged(object sender, EventArgs e)
        {

        }
        private void Face_logo_Click_1(object sender, EventArgs e)
        {

        }

        private void Google_logo_Click_1(object sender, EventArgs e)
        {

        }
        private void Login_usrname_Click(object sender, EventArgs e)
        {
            Login_usrname.Clear();
            Login_panel_usr.ForeColor = Color.FromArgb(78, 184, 206);
            Login_usrname.ForeColor = Color.FromArgb(78, 184, 206);


            Login_panel_pwd.ForeColor = Color.WhiteSmoke;
            Login_pswrd.ForeColor = Color.WhiteSmoke;

        }

        private void Login_pswrd_Click(object sender, EventArgs e)
        {
            Login_pswrd.Clear();
            Login_pswrd.PasswordChar = '*';
            Login_panel_usr.ForeColor = Color.FromArgb(78, 184, 206);
            Login_pswrd.ForeColor = Color.FromArgb(78, 184, 206);


            Login_panel_usr.ForeColor = Color.WhiteSmoke;
            Login_usrname.ForeColor = Color.WhiteSmoke;
        }

        private void Login_eye_Click(object sender, EventArgs e)
        {
            if (Login_pswrd.PasswordChar == '*')
            {
                Login_hide.BringToFront();
                Login_pswrd.PasswordChar = '\0';
            }
        }

        private void Login_hide_Click(object sender, EventArgs e)
        {
            if (Login_pswrd.PasswordChar == '\0')
            {
                Login_eye.BringToFront();
                Login_pswrd.PasswordChar = '*';
            }
        }


    }
}