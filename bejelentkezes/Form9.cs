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
    public partial class FormNewA : Form
    {
        public FormNewA()
        {
            InitializeComponent();
            fillcombobox();
        }

        public void fillcombobox()
        {
            //Állatok ID mező rész
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            string sql = " select * from Allatok";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();

                while (myreader.Read())
                {
                    //itt kell kiválasztani, hogy a táblázat melyik oszlopát akarom a görgető sávban megjeleníteni ()-ben adom meg az oszlop számát
                    string aname = myreader.GetString(0); //0-val az ID számot adja
                    comboBox1.Items.Add(aname);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void btnMod_Click(object sender, EventArgs e)
            {
            // A módosítás már működik, (Állatok tábla visszaállítva)

            dTpBdate.Format = DateTimePickerFormat.Custom;
            dTpBdate.CustomFormat = "yyyy-MM-dd";
            

            SqlConnection conModAllat = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");


                conModAllat.Open();

            SqlCommand cmdModAllat = new SqlCommand("UPDATE Allatok SET " +
                "AllatID= '" + txtID.Text + "',Neve= '" + txtName.Text + "',SzuletesiIdo= '" + dTpBdate.Text + "',Faj= '" + txtFaj.Text + "',Fajta= '" + txtFajta.Text + "',Ivar= '" + txtIvar.Text + "',Szine= '" + txtSzine.Text + "',KulonlegesIsmertetoJele= '" + txtKIJ.Text + "',IvartalanitasIdopontja='" + dTpIvDate.Text + "',Torzskonyvezett='" + txtTorzs.Text + "' WHERE AllatID= '" + txtID.Text + "'", conModAllat);
                   

                cmdModAllat.ExecuteNonQuery();

                MessageBox.Show("Adatok módisítása megtörtént", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtID.Clear();
            txtName.Clear();
            
            txtFaj.Clear();
            txtFajta.Clear();
            txtIvar.Clear();
            txtSzine.Clear();
            txtKIJ.Clear();
            
            txtTorzs.Clear();

            conModAllat.Close();
            }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Mentés úgy néz ki működik

            SqlConnection conNewAllat = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            dTpIvDate.Format = DateTimePickerFormat.Custom;
            dTpIvDate.CustomFormat = "yyyy-MM-dd";
            dTpBdate.Format = DateTimePickerFormat.Custom;
            dTpBdate.CustomFormat = "yyyy-MM-dd";

            conNewAllat.Open();

            SqlCommand cmdNewAllat = new SqlCommand("INSERT INTO Allatok " +
                "VAlUES (@AllatID,@Neve,@SzuletesiIdo,@Faj,@Fajta,@Ivar,@Szine,@KulonlegesIsmertetoJele,@IvartalanitasIdopontja,@Torzskonyvezett)", conNewAllat);
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

            conNewAllat.Close();

            MessageBox.Show("Adatok mentése megtörtént", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Clear();
            txtName.Clear();
            
            txtFaj.Clear();
            txtFajta.Clear();
            txtIvar.Clear();
            txtSzine.Clear();
            txtKIJ.Clear();
            
            txtTorzs.Clear();

            conNewAllat.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            //Itt tölti be az adatbázist, majd keresi ki az Állatok adatait.
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            string sql = "select * from Allatok where AllatID = '" + comboBox1.Text + "'; ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;

            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    //

                    string allatid = myreader.GetString(0);
                    string name = myreader.GetString(1);
                    string bdate = myreader.GetString(2);
                    string faj = myreader.GetString(3);
                    string fajta = myreader.GetString(4);
                    string ivar = myreader.GetString(5);
                    string szine = myreader.GetString(6);
                    string KulonlegesIsmertetoJele = myreader.GetString(7);
                    string IvartalanitasIdopontja = myreader.GetString(8);
                    string Torzskonyvezett = myreader.GetString(9);
                    txtID.Text = allatid;
                    txtName.Text = name;
                    dTpBdate.Text = bdate;
                    txtFaj.Text = faj;
                    txtFajta.Text = fajta;
                    txtIvar.Text = ivar;
                    txtSzine.Text = szine;
                    txtKIJ.Text = KulonlegesIsmertetoJele;
                    dTpIvDate.Text = IvartalanitasIdopontja;
                    txtTorzs.Text = Torzskonyvezett;

                    dTpIvDate.Format = DateTimePickerFormat.Custom;
                    dTpIvDate.CustomFormat = "yyyy-MM-dd";
                    dTpBdate.Format = DateTimePickerFormat.Custom;
                    dTpBdate.CustomFormat = "yyyy-MM-dd";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonF3Keres_Click(object sender, EventArgs e)
        {
            // -Állat Keresés gomb-
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM Allatok WHERE AllatID=@AllatID", con);


            cmd.Parameters.AddWithValue("AllatID", comboBox1.Text);

            SqlDataReader myreader;

            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string allatid = myreader.GetString(0);
                    string name = myreader.GetString(1);
                    string bdate = myreader.GetString(2);
                    string faj = myreader.GetString(3);
                    string fajta = myreader.GetString(4);
                    string ivar = myreader.GetString(5);
                    string szine = myreader.GetString(6);
                    string KulonlegesIsmertetoJele = myreader.GetString(7);
                    string IvartalanitasIdopontja = myreader.GetString(8);
                    string Torzskonyvezett = myreader.GetString(9);
                    txtID.Text = allatid;
                    txtName.Text = name;
                    dTpBdate.Text = bdate;
                    txtFaj.Text = faj;
                    txtFajta.Text = fajta;
                    txtIvar.Text = ivar;
                    txtSzine.Text = szine;
                    txtKIJ.Text = KulonlegesIsmertetoJele;
                    dTpIvDate.Text = IvartalanitasIdopontja;
                    txtTorzs.Text = Torzskonyvezett;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }
    }
}
