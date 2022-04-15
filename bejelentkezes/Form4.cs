﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace bejelentkezes
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel4.Controls.Add(childForm);
            panel4.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonF3K_Click(object sender, EventArgs e)
        {
            //-keresés gomb-
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = C:\\Users\\Süske\\source\\repos\\bejelentkezes\\AdatbazisKiskedv.mdf; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from BejegyzesekKezelesek where AllatID=@AllatID", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.AddWithValue("AllatID", txtSearch.Text);
            da.Fill(dt);
            bejegyzesekKezelesekDataGridView.DataSource = dt;
            labelTotal.Text = $"Találatok Száma: {bejegyzesekKezelesekDataGridView.RowCount}";
        }

        private void buttonF3Back_Click(object sender, EventArgs e)
        {
            // -módosítás gomb-
            SqlConnection conBejegyzesek = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = C:\\Users\\Süske\\source\\repos\\bejelentkezes\\AdatbazisKiskedv.mdf; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");


            conBejegyzesek.Open();

            SqlCommand cmdBejegyKez = new SqlCommand("UPDATE BejegyzesekKezelesek SET " +
                "AllatID= '" + allatIDTextBox.Text + "',Datum= '" + datumDTP.Text + "',Diagnozis= '" + diagnozisTextBox.Text + "',Terapia= '" + terapiaTextBox.Text +  "' WHERE AllatID= '" + allatIDTextBox.Text + "'", conBejegyzesek);

            cmdBejegyKez.ExecuteNonQuery();

            MessageBox.Show("Adatok módisítása megtörtént", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //allatIDTextBox.Clear();
            //datumDTP.Clear();
            diagnozisTextBox.Clear();
            terapiaTextBox.Clear();
            
            conBejegyzesek.Close();
        }

        private void btnF4Keres_Click(object sender, EventArgs e)
        {
            // - összes gomb -
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = C:\\Users\\Süske\\source\\repos\\bejelentkezes\\AdatbazisKiskedv.mdf; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from BejegyzesekKezelesek", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bejegyzesekKezelesekDataGridView.DataSource = dt;

            //datumDTP.Clear();
            diagnozisTextBox.Clear();
            terapiaTextBox.Clear();
            allatIDTextBox.Clear();
            txtSearch.Clear();

            con.Close();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //enter
                btnF4Keres.PerformClick();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // -ÁllatID textSearch Box -
            SqlConnection con2 = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = C:\\Users\\Süske\\source\\repos\\bejelentkezes\\AdatbazisKiskedv.mdf; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            string sql2 = "select * from BejegyzesekKezelesek where AllatID = '" + txtSearch.Text + "'; ";
            SqlCommand cmd2 = new SqlCommand(sql2, con2);
            SqlDataReader myreader3;

            try
            {
                con2.Open();
                myreader3 = cmd2.ExecuteReader();
                while (myreader3.Read())
                
                {
                    string AllatID = myreader3.GetString(3);
                    string Datum = myreader3.GetString(0);
                    string Diagnozis = myreader3.GetString(1);
                    string Terapia = myreader3.GetString(2);

                    allatIDTextBox.Text = AllatID;
                    datumDTP.Text = Datum;
                    diagnozisTextBox.Text = Diagnozis;
                    terapiaTextBox.Text = Terapia;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con2.Close();
            }
        }

        private void bejegyzesekKezelesekBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bejegyzesekKezelesekBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adatbazisKiskedvDataSet2);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adatbazisKiskedvDataSet2.BejegyzesekKezelesek' table. You can move, or remove it, as needed.
            this.bejegyzesekKezelesekTableAdapter.Fill(this.adatbazisKiskedvDataSet2.BejegyzesekKezelesek);

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //-Törlés Gomb-
            this.Close();
        }

        private void buttonFUB_Click(object sender, EventArgs e)
        {
            //-Új bejegyzés, Mentés gomb- Idegen kulcsot ki kellett venni ahhoz, hogy működjön, így most menti az adatokt az adatbázisba!
            

            //dátum formázást  DateTimePicker -így töltődik be megfelelően az adatbázisba a dátum
            datumDTP.Format = DateTimePickerFormat.Custom;
            datumDTP.CustomFormat = "yyyy-MM-dd";

            SqlConnection conNewBejegyKez = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = C:\\Users\\Süske\\source\\repos\\bejelentkezes\\AdatbazisKiskedv.mdf; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

            conNewBejegyKez.Open();

            SqlCommand cmdNewBejegyKez = new SqlCommand("INSERT INTO BejegyzesekKezelesek " +
                "VAlUES (@Datum,@Diagnozis,@Terapia,@AllatID)", conNewBejegyKez);
            cmdNewBejegyKez.Parameters.AddWithValue("@Datum", datumDTP.Text); 
            cmdNewBejegyKez.Parameters.AddWithValue("@Diagnozis", diagnozisTextBox.Text);
            cmdNewBejegyKez.Parameters.AddWithValue("@Terapia", terapiaTextBox.Text);
            cmdNewBejegyKez.Parameters.AddWithValue("@AllatID", allatIDTextBox.Text);

            cmdNewBejegyKez.ExecuteNonQuery();

            MessageBox.Show("Adatok mentése megtörtént", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //allatIDTextBox.Clear();
            //datumDTP.Clear();
            diagnozisTextBox.Clear();
            terapiaTextBox.Clear();

            conNewBejegyKez.Close();

           
        }

        private void bejegyzesekKezelesekDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bejegyzesekKezelesekDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // -Sorra katt és adatok megjelenítése- Működik! (az oszlopok sorrendjében kell a []-be beleírni az értéket!!!)
            if(bejegyzesekKezelesekDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            { 
            bejegyzesekKezelesekDataGridView.CurrentRow.Selected = true;
            allatIDTextBox.Text = bejegyzesekKezelesekDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                datumDTP.Text = bejegyzesekKezelesekDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            diagnozisTextBox.Text = bejegyzesekKezelesekDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            terapiaTextBox.Text = bejegyzesekKezelesekDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            
            }



        }
    }

}   