using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace bejelentkezes
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelF8.Controls.Add(childForm);
            panelF8.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonF8Save_Click(object sender, EventArgs e)
        {
            //Állat - Mentés rész ; MENTI AZ ADATOKAT

            dTpBdate.Format = DateTimePickerFormat.Custom;
            dTpBdate.CustomFormat = "yyyy-MM-dd";
            dTpIvDate.Format = DateTimePickerFormat.Custom;
            dTpIvDate.CustomFormat = "yyyy-MM-dd";



            SqlConnection conRegister = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");


            conRegister.Open();

            SqlCommand cmdNewAllat = new SqlCommand("INSERT INTO Allatok " +
                "VAlUES (@AllatID,@Neve,@SzuletesiIdo,@Faj,@Fajta,@Ivar,@Szine,@KulonlegesIsmertetoJele,@IvartalanitasIdopontja,@Torzskonyvezett)", conRegister);
            cmdNewAllat.Parameters.AddWithValue("@AllatID", txtID.Text);
            cmdNewAllat.Parameters.AddWithValue("@Neve", txtName.Text);
            cmdNewAllat.Parameters.AddWithValue("@SzuletesiIdo", dTpBdate.Text);
            cmdNewAllat.Parameters.AddWithValue("@Faj", txtFaj.Text);
            cmdNewAllat.Parameters.AddWithValue("@Fajta", txtFajta.Text);
            cmdNewAllat.Parameters.AddWithValue("@Ivar", txtIvar.Text);
            cmdNewAllat.Parameters.AddWithValue("@Szine", txtSzine.Text);
            cmdNewAllat.Parameters.AddWithValue("@KulonlegesIsmertetoJele", txtKIJ.Text);
            cmdNewAllat.Parameters.AddWithValue("@IvartalanitasIdopontja", dTpIvDate.Text);
            cmdNewAllat.Parameters.AddWithValue("@Torzskonyvezett", txtTorzs.Text);

            cmdNewAllat.ExecuteNonQuery();

            
            
            txtID.Clear();
            txtName.Clear();
            //dTpBdate.Clear();
            txtFaj.Clear();
            txtFajta.Clear();
            txtIvar.Clear();
            txtSzine.Clear();
            txtKIJ.Clear();
            //dTpIvDate.Clear();
            txtTorzs.Clear();

            //Gazdi - mentés rész ; MENTI AZ ADATOKAT
 
            SqlCommand cmdNewGazdi = new SqlCommand("INSERT INTO Gazdik " +
                "VAlUES (@GazdiID,@Nev,@Cime,@Telefonszam,@Email,@AllatID)", conRegister);
            cmdNewGazdi.Parameters.AddWithValue("@GazdiID", txtGazdID.Text);
            cmdNewGazdi.Parameters.AddWithValue("@Nev", txtGname.Text);
            cmdNewGazdi.Parameters.AddWithValue("@Cime", txtcim.Text);
            cmdNewGazdi.Parameters.AddWithValue("@Telefonszam", txttel.Text);
            cmdNewGazdi.Parameters.AddWithValue("@Email", txtemail.Text);
            cmdNewGazdi.Parameters.AddWithValue("@AllatID", txtGazdID.Text);
            
            

            cmdNewGazdi.ExecuteNonQuery();

            MessageBox.Show("Adatok mentése megtörtént", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conRegister.Close(); //sql kapcsolat bezárása
        }

        private void buttonNewID_Click(object sender, EventArgs e)
        {
            //Random ID generátor

            Random rnd = new Random();
            int randomnum = rnd.Next(999999999);

            textBox14.Text = randomnum.ToString();

            SqlConnection conRegister = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            conRegister.Open();

            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Allatok WHERE (AllatID = @AllatID)", conRegister);
            check_User_Name.Parameters.AddWithValue("@AllatID", textBox14.Text);
            int UserExist = (int)check_User_Name.ExecuteScalar();
            //foreach kellene bejárni, hogy az újonan generált ID létezik már e az adatbázisban.
            
            if (UserExist > 0)
            {

                MessageBox.Show("ID szám már szerepel");
            }


            else
            {

                //SqlCommand cmdNewAllatID = new SqlCommand("INSERT INTO Allatok (AllatID) VAlUES ('" + textBox14.Text + "')", conRegister);
                //cmdNewAllatID.ExecuteNonQuery();

                MessageBox.Show("ID még nem szerepel az adatbázisban", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Adatok mentése megtörtént", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //conRegister.Close();

            }

        }

        private void buttonF8GID_Click(object sender, EventArgs e)
        {
            // -Gazdi Keresés gomb-
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            
            SqlCommand cmd = new SqlCommand("SELECT * from Gazdik where GazdiID=@GazdiID", con);


            cmd.Parameters.AddWithValue("GazdiID", txtGazdID.Text);

            SqlDataReader myreader;

            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                   
                    string GazdiID = myreader.GetString(0);
                    string Gazdiname = myreader.GetString(1);
                    string Gazdiaddress = myreader.GetString(2);
                    string Gazditel = myreader.GetString(3);
                    string Gazdiemail = myreader.GetString(4);

                    txtGazdID.Text = GazdiID;
                    txtGname.Text = Gazdiname;
                    txtcim.Text = Gazdiaddress;
                    txtemail.Text = Gazdiemail;
                    txttel.Text = Gazditel;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            //read connstr from the App.Config 
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["bejelentkezes.Properties.Settings.dbTabelsConnectionString"].ConnectionString;
        }
    }

}
