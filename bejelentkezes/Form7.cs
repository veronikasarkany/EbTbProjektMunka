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
    public partial class Form7 : Form
    {
        public Form7()
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
            panelF7.Controls.Add(childForm);
            panelF7.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonF3K_Click(object sender, EventArgs e)
        {
            //-Keresés Gomb- 
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Befizetesek where GazdiID=@GazdiID", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.AddWithValue("GazdiID", txtSearch.Text);
            da.Fill(dt);
            befizetesekDataGridView.DataSource = dt;
            labelTotal.Text = $"Bejegyzések Száma: {befizetesekDataGridView.RowCount}";

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //-Számla nyomtatás Gomb-
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void befizetesekBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void befizetesekBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.befizetesekBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adatbazisKiskedvDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbTabelsDataSet2.Befizetesek' table. You can move, or remove it, as needed.
            this.befizetesekTableAdapter1.Fill(this.dbTabelsDataSet2.Befizetesek);
            // TODO: This line of code loads data into the 'adatbazisKiskedvDataSet.Befizetesek' table. You can move, or remove it, as needed.
            this.befizetesekTableAdapter1.Fill(this.dbTabelsDataSet2.Befizetesek);
            //read connstr from the App.Config 
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["bejelentkezes.Properties.Settings.dbTabelsConnectionString"].ConnectionString;

        }

        private void befizetesekDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // -Sorra katt és adatok megjelenítése- Működik! (az oszlopok sorrendjében kell a []-be beleírni az értéket!!!)
            if (befizetesekDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                befizetesekDataGridView.CurrentRow.Selected = true;

                datumDateTimePicker.Text = befizetesekDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                gazdiIDTextBox.Text = befizetesekDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                befizetesekOsszTextBox.Text = befizetesekDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                kezelesiKoltsegTextBox.Text = befizetesekDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                rendelkezesreAlloTextBox.Text = befizetesekDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-Módosítás Gomb- Olyan sorrendbe beírni ahogy a táblázat oszlopai vannak! 
            SqlConnection conBefiz = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");


            conBefiz.Open();

            SqlCommand cmdBefizet = new SqlCommand("UPDATE Befizetesek SET " +
                "BefizetesekOssz= '" + befizetesekOsszTextBox.Text + "',KezelesiKoltseg= '" + kezelesiKoltsegTextBox.Text + "',RendelkezesreAllo= '" + rendelkezesreAlloTextBox.Text + "',GazdiID= '" + gazdiIDTextBox.Text + "',Datum='"+ datumDateTimePicker.Text+"' WHERE GazdiID= '" + gazdiIDTextBox.Text + "'", conBefiz);

            cmdBefizet.ExecuteNonQuery();

            MessageBox.Show("Adatok módisítása megtörtént", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            befizetesekOsszTextBox.Clear();
            kezelesiKoltsegTextBox.Clear();
            rendelkezesreAlloTextBox.Clear();
            gazdiIDTextBox.Clear();

            conBefiz.Close();
        }

        private void buttonF3Keres_Click(object sender, EventArgs e)
        {
            //-Új bejegyzés, Mentés gomb- Idegen kulcsot ki kellett venni ahhoz, hogy működjön, így most menti az adatokt az adatbázisba!
            
            SqlConnection conNewBefizet = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");

            //dátum formázást  DateTimePicker -így töltődik be megfelelően az adatbázisba a dátum
            datumDateTimePicker.Format = DateTimePickerFormat.Custom;
            datumDateTimePicker.CustomFormat = "yyyy-MM-dd";


            conNewBefizet.Open();

            SqlCommand cmdNewBefizet = new SqlCommand("INSERT INTO Befizetesek " +
                "VAlUES (@BefizetesekOssz,@KezelesiKoltseg,@RendelkezesreAllo,@GazdiID,@Datum)", conNewBefizet);
            cmdNewBefizet.Parameters.AddWithValue("@BefizetesekOssz", befizetesekOsszTextBox.Text);
            cmdNewBefizet.Parameters.AddWithValue("@KezelesiKoltseg", kezelesiKoltsegTextBox.Text);
            cmdNewBefizet.Parameters.AddWithValue("@RendelkezesreAllo", rendelkezesreAlloTextBox.Text);
            cmdNewBefizet.Parameters.AddWithValue("@GazdiID", gazdiIDTextBox.Text);
            cmdNewBefizet.Parameters.AddWithValue("@Datum", datumDateTimePicker.Text);

            cmdNewBefizet.ExecuteNonQuery();

            MessageBox.Show("Adatok mentése megtörtént", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            gazdiIDTextBox.Clear();
            befizetesekOsszTextBox.Clear();
            kezelesiKoltsegTextBox.Clear();
            rendelkezesreAlloTextBox.Clear();
            

            conNewBefizet.Close();


        }

        private void btnF7All_Click(object sender, EventArgs e)
        {
            //-Összes Gomb-
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Befizetesek", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            befizetesekDataGridView.DataSource = dt;

            gazdiIDTextBox.Clear();
            
            befizetesekOsszTextBox.Clear();
            kezelesiKoltsegTextBox.Clear();
            rendelkezesreAlloTextBox.Clear();
            txtSearch.Clear();

            con.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //-Gazdi textSearch Box-
            SqlConnection con2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            string sql2 = "select * from Befizetesek WHERER GazdiID = '" + txtSearch.Text + "'; ";
            SqlCommand cmd2 = new SqlCommand(sql2, con2);
            SqlDataReader myreader4;

            try
            {
                con2.Open();
                myreader4 = cmd2.ExecuteReader();
                while (myreader4.Read())

                {
                    string BefizOssz = myreader4.GetString(0);
                    string KezelesiKtsg = myreader4.GetString(1);
                    string RendKezAllo = myreader4.GetString(2);
                    string Gazdi = myreader4.GetString(3);
                    string datum = myreader4.GetString(4);

                    befizetesekOsszTextBox.Text = BefizOssz;
                    kezelesiKoltsegTextBox.Text = KezelesiKtsg;
                    rendelkezesreAlloTextBox.Text = RendKezAllo;
                    gazdiIDTextBox.Text = Gazdi;
                    datumDateTimePicker.Text = datum;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con2.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e) 
        {
            //-számol gomb-

            int a = 0;
            int b = 0;
            int c = 0;

            if(int.TryParse(befizetesekOsszTextBox.Text,out a) & int.TryParse(kezelesiKoltsegTextBox.Text, out b))
            {
                c = a - b;
                rendelkezesreAlloTextBox.Text = c.ToString();
            }
            
        }
    }
}
