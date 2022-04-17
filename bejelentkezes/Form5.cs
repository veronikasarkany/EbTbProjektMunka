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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

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
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            {

            }
        }

        private void buttonF5K_Click(object sender, EventArgs e)
        {
            //-Összes Gomb-
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from OltasokKezelesek", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            oltasokKezelesekDataGridView.DataSource = dt;

            allatIDTextBox.Clear();
            //datumDateTimePicker.Clear();
            egyebVedooltasokParazitaTextBox.Clear();
        }

        private void buttonF5Back_Click(object sender, EventArgs e)
        {
            //-Törlés Gomb-
            this.Close();
        }

        private void buttonF3K_Click(object sender, EventArgs e)
        {
            //-Keresés Gomb-
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from OltasokKezelesek where AllatID=@AllatID", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.AddWithValue("AllatID", txtSearch.Text);
            da.Fill(dt);
            oltasokKezelesekDataGridView.DataSource = dt;
            labelTotal.Text = $"Találatok Száma: {oltasokKezelesekDataGridView.RowCount}";
        }

        private void oltasokKezelesekBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.oltasokKezelesekBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adatbazisKiskedvDataSet1);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbTabelsDataSet1.OltasokKezelesek' table. You can move, or remove it, as needed.
            this.oltasokKezelesekTableAdapter1.Fill(this.dbTabelsDataSet1.OltasokKezelesek);
            // TODO: This line of code loads data into the 'adatbazisKiskedvDataSet1.OltasokKezelesek' table. You can move, or remove it, as needed.
            this.oltasokKezelesekTableAdapter1.Fill(this.dbTabelsDataSet1.OltasokKezelesek);
            //read connstr from the App.Config 
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["bejelentkezes.Properties.Settings.dbTabelsConnectionString"].ConnectionString;

        }

        private void buttonOUJ_Click(object sender, EventArgs e)
        {
            //-Új bejegyzés Gomb-
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");

            con.Open();
            SqlCommand cmdUjBejgyzes = new SqlCommand("INSERT INTO OltasokKezelesek VALUES (@Datum,@EgyebVedooltasokParazita,@AllatID)", con);
            cmdUjBejgyzes.Parameters.AddWithValue("@Datum", datumDateTimePicker.Text);
            cmdUjBejgyzes.Parameters.AddWithValue("@EgyebVedooltasokParazita", egyebVedooltasokParazitaTextBox.Text);
            cmdUjBejgyzes.Parameters.AddWithValue("@AllatID", allatIDTextBox.Text);

            
            cmdUjBejgyzes.ExecuteNonQuery();
           
            MessageBox.Show("Adatok felvitele megtörtént", "Mentve", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //datumDateTimePicker.Clear();
            egyebVedooltasokParazitaTextBox.Clear();
            con.Close();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //-ÁllatID textSearch Gomb -
            SqlConnection con2 = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");
            string sql2 = "select * from OltasokKezelesek where AllatID = '" + txtSearch.Text + "'; ";
            SqlCommand cmd2 = new SqlCommand(sql2, con2);
            SqlDataReader myreader2;

            try
            {
                con2.Open();
                myreader2 = cmd2.ExecuteReader();
                while (myreader2.Read())

                {
                    string AllatID = myreader2.GetString(3);
                    string Datum = myreader2.GetString(0);
                    string VedooltasokParazitaTextBox = myreader2.GetString(1);
                    

                    allatIDTextBox.Text = AllatID;
                    datumDateTimePicker.Text = Datum;
                    egyebVedooltasokParazitaTextBox.Text = VedooltasokParazitaTextBox;
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con2.Close();
            }
        }

        private void buttonF3Back_Click(object sender, EventArgs e)
        {
            // -módosítás gomb-
            SqlConnection conOltasokKezelesek = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=d:\\bejelentkezes\\bejelentkezes\\dbTabels.mdf;Integrated Security=True");


            conOltasokKezelesek.Open();

            SqlCommand cmdOltKez = new SqlCommand("UPDATE OltasokKezelesek SET " +
                "Datum= '" + datumDateTimePicker.Text + "',EgyebVedooltasokParazita= '" + egyebVedooltasokParazitaTextBox.Text + "',AllatID= '" + allatIDTextBox.Text + "' WHERE AllatID= '" + allatIDTextBox.Text + "'", conOltasokKezelesek);

            cmdOltKez.ExecuteNonQuery();

            MessageBox.Show("Adatok módisítása megtörtént", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //allatIDTextBox.Clear();
            //datumDTP.Clear();
            egyebVedooltasokParazitaTextBox.Clear();
            

            conOltasokKezelesek.Close();
        }

        private void oltasokKezelesekDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // -Sorra katt és adatok megjelenítése- Működik! (az oszlopok sorrendjében kell a []-be beleírni az értéket!!!)
            if (oltasokKezelesekDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                oltasokKezelesekDataGridView.CurrentRow.Selected = true;
                datumDateTimePicker.Text = oltasokKezelesekDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                egyebVedooltasokParazitaTextBox.Text = oltasokKezelesekDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                allatIDTextBox.Text = oltasokKezelesekDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                
            }
        }

        private void datumLabel_Click(object sender, EventArgs e)
        {

        }

        private void egyebVedooltasokParazitaLabel_Click(object sender, EventArgs e)
        {

        }

        private void allatIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void datumDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void oltasokKezelesekBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void allatIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void egyebVedooltasokParazitaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void oltasokKezelesekDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelOlt_Click(object sender, EventArgs e)
        {

        }

        private void oltasokKezelesekBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSeparator2_Click(object sender, EventArgs e)
        {

        }
    }
}
