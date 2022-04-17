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
    public partial class Form3 : Form
    {
        public Form3()
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

            /*//GazdiID mező rész
            SqlConnection con2 = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = C:\\Users\\Süske\\source\\repos\\bejelentkezes\\AdatbazisKiskedv.mdf; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            string sql2 = " select * from Gazdik";
            SqlCommand cmd2 = new SqlCommand(sql2, con2);
            SqlDataReader myreader2;

            try
            {
                con2.Open();
                myreader2 = cmd2.ExecuteReader();

                while (myreader2.Read())
                {
                    //itt GazdiID szeretném megjeleníteni, hozzákapcsolni majd az ÁllatID-hoz amelyeik állat hozzá tartozik
                    string gazdiname = myreader2.GetString(0); //0-val az ID számot adja
                    comboBox2.Items.Add(gazdiname);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dateTPIvDate.Format = DateTimePickerFormat.Custom;
            dateTPIvDate.CustomFormat = "yyyy-MM-dd";

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
                    dateTPdate.Text = bdate;
                    txtFaj.Text = faj;
                    txtFajta.Text = fajta;
                    txtIvar.Text = ivar;
                    txtSzine.Text = szine;
                    txtKIJ.Text = KulonlegesIsmertetoJele;
                    dateTPIvDate.Text = IvartalanitasIdopontja;
                    txtTorzs.Text = Torzskonyvezett;



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // elvileg betölti a Gazdi adatokat
            // itt ki akarom próbálni, hogy a Gazdik adatait is betölti e
            SqlConnection con2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            string sql2 = "select * from Gazdik where GazdiID = '" + comboBox1.Text + "'; ";
            SqlCommand cmd2 = new SqlCommand(sql2, con2);
            SqlDataReader myreader2;

            try
            {
                con2.Open();
                myreader2 = cmd2.ExecuteReader();
                while (myreader2.Read())
                {
                    string GazdiID = myreader2.GetString(0);
                    string Gazdiname = myreader2.GetString(1);
                    string Gazdiaddress = myreader2.GetString(2);
                    string Gazditel = myreader2.GetString(3);
                    string Gazdiemail = myreader2.GetString(4);

                    txtGID.Text = GazdiID;
                    txtGname.Text = Gazdiname;
                    txtGcim.Text = Gazdiaddress;
                    txtGmail.Text = Gazdiemail;
                    txtGtel.Text = Gazditel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con2.Close();
            }
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void buttonF3Keres_Click(object sender, EventArgs e)
        {
            
        }

        private void panelF3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //read connstr from the App.Config 
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["bejelentkezes.Properties.Settings.dbTabelsConnectionString"].ConnectionString;
        }
    }
}
    

