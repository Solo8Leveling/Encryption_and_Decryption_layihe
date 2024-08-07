using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;




namespace Encryption_and_Decryption_layihe
{
    public partial class layihe : Form
    {
        public layihe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }


        public static string sifreleme(string metin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] btr = Encoding.UTF8.GetBytes(metin);
            btr = md5.ComputeHash(btr);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string str = sifreleme(md5_txt1.Text);
            md5_txt2.Text = str;
        }


        string textToReverse;
        char[] Letters;
        private void btn_reverse_Click(object sender, EventArgs e)
        {
            textToReverse = reverse_text1.Text;
            Letters = textToReverse.ToCharArray();
            Array.Reverse(Letters);
            string ReverseText = new string(Letters, 0, Letters.Length);
            reverse_text2.Text = ReverseText;
        }


        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


       


        private void btn_sezar_Click(object sender, EventArgs e)
        {


            
             
            string input = sezar_txt1.Text;
            int key = Convert.ToInt32(sezar_key.Text);
            char[] alphabet = { 'a', 'b', 'c', 'ç', 'd', 'e', 'ə', 'f', 'g', 'ğ', 'h', 'x', 'ı', 'i', 'j', 'k', 'q', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
            char[] alphabet2 = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'Ə', 'F', 'G', 'Ğ', 'H', 'X', 'I', 'İ', 'J', 'K', 'Q', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };

            string encyrpt = "";
            if (key >= 32)
            {
                key = key % 32;
            }
            for (int j = 0; j < input.Length; j++)
            {
                for (int Z = 0; Z < alphabet2.Length; Z++)
                {
                   

                    if (input[j] == alphabet2[Z])
                    {
                        int count = Z + key;

                        if (count >= alphabet2.Length)
                        {
                            int mod = count - alphabet2.Length;
                            encyrpt += alphabet2[mod];
                            sezar_txt2.Text = encyrpt;
                        }
                        else encyrpt += alphabet2[Z + key];
                        sezar_txt2.Text = encyrpt;
                    }
                    if (input[j] == alphabet[Z])
                    {
                        int count = Z + key;

                        if (count >= alphabet.Length)
                        {
                            int mod = count - alphabet.Length;
                            encyrpt += alphabet[mod];
                            sezar_txt2.Text = encyrpt;
                        }
                        else encyrpt += alphabet[Z + key];
                        sezar_txt2.Text = encyrpt;
                    }

                }

            }

            
            


        }

        private void ceaser_Click(object sender, EventArgs e)
        {

        }

        private void btn_sezar2_Click(object sender, EventArgs e)
        {

            string input = sezar_txt2.Text;
            int key = Convert.ToInt32(sezar_key.Text);
            char[] alphabet = { 'a', 'b', 'c', 'ç', 'd', 'e', 'ə', 'f', 'g', 'ğ', 'h', 'x', 'ı', 'i', 'j', 'k', 'q', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
            char[] alphabet2 = { 'A', 'B', 'C', 'Ç', 'D', 'E', 'Ə', 'F', 'G', 'Ğ', 'H', 'X', 'I', 'İ', 'J', 'K', 'Q', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
           
            string encyrpt = "";
            if (key >= 32)
            {
                key = key % 32;
            }
            for (int j = 0; j < input.Length; j++)
            {
                for (int Z = 0; Z < alphabet2.Length; Z++)
                   
                    if (input[j] == alphabet2[Z])
                    {
                        int count = Z - key;

                        if (count < 0)
                        {
                            int mod = count + alphabet2.Length;
                            encyrpt += alphabet2[mod];
                            sezar_txt1.Text = encyrpt;
                        }
                        else encyrpt += alphabet2[Z - key];
                        sezar_txt1.Text = encyrpt;
                    }
                    else if (input[j] == alphabet[Z])
                    {
                        int count = Z - key;
                        if (count < 0)
                        {
                            int mod = count + alphabet2.Length;
                            encyrpt += alphabet[mod];
                            sezar_txt1.Text = encyrpt;
                        }
                        else encyrpt += alphabet[Z - key];
                        sezar_txt1.Text = encyrpt;
                    }
            }

        }


        public static string Base64Encode( string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodeData)
        {
            var base64EncodeBytes = System.Convert.FromBase64String(base64EncodeData);
            return System.Text.Encoding.UTF8.GetString(base64EncodeBytes);
        }


        private void base_btn1_Click(object sender, EventArgs e)
        {
            base_txt2.Text = Base64Encode(base_txt1.Text);

        }

        private void base_btn2_Click(object sender, EventArgs e)
        {
            base_txt3.Text = Base64Decode(base_txt2.Text);
        }
    }





}
