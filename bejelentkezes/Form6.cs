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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            fillcombobox();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelF6.Controls.Add(childForm);
            panelF6.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            {

            }
        }

        public void fillcombobox()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            string sql = "select * from Gazdik";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;

            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(0);
                    comboBox1.Items.Add(sname);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            string sql = "select * from Gazdik where GazdiId = '" + comboBox1.Text + "'; ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;

            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    // működik a combobox
                    string GazdiID = myreader.GetString(0);
                    string Gazdiname = myreader.GetString(1);
                    string Gazdiaddress = myreader.GetString(2);
                    string Gazditel = myreader.GetString(3);
                    string Gazdiemail = myreader.GetString(4);

                    txtSearch.Text = GazdiID;
                    txtGname.Text = Gazdiname;
                    txtGcim.Text = Gazdiaddress;
                    txtGmail.Text = Gazdiemail;
                    txtGtel.Text = Gazditel;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            // Módosítás még egyenlőre nem működik

            SqlConnection conModGazdi = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");


            conModGazdi.Open();

            SqlCommand cmdModGazdi = new SqlCommand("UPDATE Gazdik SET (GazdiID,Nev,Cim,Telefonszam,Email) Where ('" + txtSearch.Text + "','" + txtGname.Text + "', '" + txtGcim.Text + "', '" + txtGtel.Text + "', '" + txtGmail.Text + "')", conModGazdi);
            
            cmdModGazdi.ExecuteNonQuery();

            MessageBox.Show("Adatok módisítása megtörtént", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            conModGazdi.Close();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Mentés egyenlőre működik, de először az Állat adatait kell felvinni, csak utána lehet a Gazdit, mivel összekötettésben vannak

            SqlConnection conNewGazdi = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");


            conNewGazdi.Open();

            SqlCommand cmdNewGazdi = new SqlCommand("INSERT INTO Gazdik (GazdiID,Nev,Cim,Telefonszam,Email) VAlUES ('" + txtSearch.Text + "','" + txtGname.Text + "', '" + txtGcim.Text + "', '" + txtGtel.Text + "', '" + txtGmail.Text + "')", conNewGazdi);
            cmdNewGazdi.ExecuteNonQuery();

            MessageBox.Show("Adatok mentése megtörtént", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            conNewGazdi.Close();
        }

        private void buttonF3Keres_Click(object sender, EventArgs e)
        {
            // -Gazdi Keresés gomb-
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            //con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Gazdik where GazdiID=@GazdiID", con);
            

            cmd.Parameters.AddWithValue("GazdiID", txtSearch.Text);
            
            SqlDataReader myreader;

            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    // txtSearch box
                    string GazdiID = myreader.GetString(0);
                    string Gazdiname = myreader.GetString(1);
                    string Gazdiaddress = myreader.GetString(2);
                    string Gazditel = myreader.GetString(3);
                    string Gazdiemail = myreader.GetString(4);

                    txtSearch.Text = GazdiID;
                    txtGname.Text = Gazdiname;
                    txtGcim.Text = Gazdiaddress;
                    txtGmail.Text = Gazdiemail;
                    txtGtel.Text = Gazditel;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //read connstr from the App.Config 
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["bejelentkezes.Properties.Settings.dbTabelsConnectionString"].ConnectionString;
        }
    }
}
