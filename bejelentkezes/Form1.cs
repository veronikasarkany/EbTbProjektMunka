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

namespace bejelentkezes
{
    public partial class Bejelentkezes : Form
    {
        public Bejelentkezes()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            //Első variácó a bejelentkezésre
            
            if (txtUserName.Text == "Diak" && txtpassword.Text == "Almafa")
            {
                new Form2().Show();
                this.Hide();
                
            }

            else
            {
                MessageBox.Show("Érvénytelen felhasználónév vagy jelszó, Kérlek próbáld újra", "Bejelentkezés sikertelen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Text = "";
                txtpassword.Text = "";
                txtUserName.Focus();


                /*MessageBox.Show("A megadott felhasználónév vagy jelszó helytelen, próbálja újra");
                txtUserName.Clear();
                txtpassword.Clear();
                txtUserName.Focus();*/
            }
            

            //Második variációs bejelentkezés
            /*
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + txtUserName.Text + "' and password= '" + txtpassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                //The Form which will appear after loggin in
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Érvénytelen felhasználónév vagy jelszó, Kérlek próbáld újra", "Bejelentkezés sikertelen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Text = "";
                txtpassword.Text = "";
                txtUserName.Focus();
            }
            */


        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtpassword.Clear();
            txtUserName.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            //Első variáns - nem működött megfelelően
            /*
            if (checkbxShowPas.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
        
            }
            */

            //Második variáns

            if (checkbxShowPas.Checked)
            {
                txtpassword.PasswordChar = '\0';

            }
            else
            {
                txtpassword.PasswordChar = '•';

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormRegiszter().Show();
            this.Hide();
        }
    }
}
