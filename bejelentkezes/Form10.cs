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

namespace bejelentkezes
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void befizetesekBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.befizetesekBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adatbazisKiskedvDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adatbazisKiskedvDataSet.Befizetesek' table. You can move, or remove it, as needed.
            this.befizetesekTableAdapter.Fill(this.adatbazisKiskedvDataSet.Befizetesek);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog = C:\\Users\\Süske\\source\\repos\\bejelentkezes\\AdatbazisKiskedv.mdf; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * from Befizetesek where GazdiID=@GazdiID", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            cmd.Parameters.AddWithValue("GazdiID", txtSearch.Text);
            da.Fill(dt);
            DataGridView.DataSource = dt;
            labelTotal.Text = $"Rendelkezésre Álló Összeg: {DataGridView.RowCount}";
        }
    }
}
