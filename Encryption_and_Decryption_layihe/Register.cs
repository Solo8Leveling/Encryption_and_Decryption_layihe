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
    public partial class Register_form : Form
    {
        public Register_form()
        {
            InitializeComponent();
        }

        


        OleDbConnection con = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\Visual prosesler\Login register\Encryption_and_Decryption_layihe\Encryption_and_Decryption_layihe\bin\Debug\db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void Register_Load(object sender, EventArgs e)
        {
            
        }

        private void Registr_mail_ControlAdded(object sender, ControlEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pswrd_logo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Rgstr_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registr_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_pswrd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_confirm_TextChanged(object sender, EventArgs e)
        {
            if(Registr_pswrd.Text !="" && Registr_confirm.Text==Registr_pswrd.Text)
            {
                errorProvider1.SetError(Registr_confirm, "");
            }
            else
            {
                errorProvider1.SetError(Registr_confirm, "Password and Confirm Password doesn't mached");
            }
        }

        private void Rgstr_name_Click(object sender, EventArgs e)
        {
            Registr_name.Clear();
            Registr_panel_name.ForeColor = Color.FromArgb(78, 184, 206);
            Registr_name.ForeColor = Color.FromArgb(78, 184, 206);

            Registr_panel_mail.ForeColor = Color.WhiteSmoke;
            Registr_mail.ForeColor = Color.WhiteSmoke;

            Registr_panel_pswrd.ForeColor = Color.WhiteSmoke;
            Registr_pswrd.ForeColor = Color.WhiteSmoke;

            Registr_panel_confirm.ForeColor = Color.WhiteSmoke;
            Registr_confirm.ForeColor = Color.WhiteSmoke;
        }

        private void Registr_mail_Click(object sender, EventArgs e)
        {
            Registr_mail.Clear();
            Registr_panel_mail.ForeColor = Color.FromArgb(78, 184, 206);
            Registr_mail.ForeColor = Color.FromArgb(78, 184, 206);

            Registr_panel_name.ForeColor = Color.WhiteSmoke;
            Registr_name.ForeColor = Color.WhiteSmoke;

            Registr_panel_pswrd.ForeColor = Color.WhiteSmoke;
            Registr_pswrd.ForeColor = Color.WhiteSmoke;

            Registr_panel_confirm.ForeColor = Color.WhiteSmoke;
            Registr_confirm.ForeColor = Color.WhiteSmoke;
        }

        private void Registr_pswrd_Click(object sender, EventArgs e)
        {
            Registr_pswrd.Clear();
            Registr_pswrd.PasswordChar = '*';
            Registr_panel_pswrd.ForeColor = Color.FromArgb(78, 184, 206);
            Registr_pswrd.ForeColor = Color.FromArgb(78, 184, 206);

            Registr_panel_name.ForeColor = Color.WhiteSmoke;
            Registr_name.ForeColor = Color.WhiteSmoke;

            Registr_panel_mail.ForeColor = Color.WhiteSmoke;
            Registr_mail.ForeColor = Color.WhiteSmoke;

            Registr_panel_confirm.ForeColor = Color.WhiteSmoke;
            Registr_confirm.ForeColor = Color.WhiteSmoke;
        }

        private void Registr_confirm_Click(object sender, EventArgs e)
        {
            Registr_confirm.Clear();
            Registr_confirm.PasswordChar = '*';
            Registr_panel_confirm.ForeColor = Color.FromArgb(78, 184, 206);
            Registr_confirm.ForeColor = Color.FromArgb(78, 184, 206);

            Registr_panel_mail.ForeColor = Color.WhiteSmoke;
            Registr_mail.ForeColor = Color.WhiteSmoke;

            Registr_panel_name.ForeColor = Color.WhiteSmoke;
            Registr_name.ForeColor = Color.WhiteSmoke;

            Registr_panel_pswrd.ForeColor = Color.WhiteSmoke;
            Registr_pswrd.ForeColor = Color.WhiteSmoke;
        }

        private void Registr_eye_Click(object sender, EventArgs e)
        {   
                if (Registr_pswrd.PasswordChar == '*')
                {
                    Registr_hide.BringToFront();
                    Registr_pswrd.PasswordChar = '\0';
                }
            
        }

        private void Registr_hide_Click(object sender, EventArgs e)
        {
            if (Registr_pswrd.PasswordChar == '\0')
            {
                Registr_eye.BringToFront();
                Registr_pswrd.PasswordChar = '*';
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registr_rgstr_btn_Click(object sender, EventArgs e)
        {
            if (Registr_name.Text == "" && Registr_pswrd.Text == "" && Registr_confirm.Text == "")
            {
                MessageBox.Show("Fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(Registr_pswrd.Text == Registr_confirm.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('"+Registr_name.Text+"','"+Registr_pswrd.Text+"','"+ Registr_mail.Text+ "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                Registr_name.Text = "";
                Registr_mail.Text = "";
                Registr_pswrd.Text = "";
                Registr_confirm.Text = ""; 

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Registr_pswrd.Text = "";
                Registr_confirm.Text = "";
                Registr_pswrd.Focus();
            }
        }

        private void Registr_login_btn_Click(object sender, EventArgs e)
        {
            

            new Login_form().Show();
            this.Hide();
        }

        

       
    }
}
