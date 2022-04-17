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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelAlladID.Visible = false;
            panelGazdi.Visible = false;
            panelNew.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelAlladID.Visible = true)
                panelAlladID.Visible = false;
            if (panelGazdi.Visible = true)
                panelGazdi.Visible = false;
            if (panelNew.Visible = true)
                panelNew.Visible = false;
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Bejegyzések és Kezelések
            openChildForm(new Form4());
            //menü elrejtése
            //hideSubMenu();
        }

        private void btnAllatID_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAlladID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //itt nyílik meg a Alapadatok
            openChildForm(new Form3());
            //menü elrejtése
            //hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Gazdi alapadatok
            openChildForm(new Form6());
            //menü elrejtése
            //hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Gazdi Befizetések
            openChildForm(new Form7());
            //menü elrejtése
            //hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form10());
            //egyenlőre inaktív
            //menü elrejtése
            //hideSubMenu();
        }

        private void btnGazdiID_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelGazdi);
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
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelNew);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            //menü elrejtése
            //hideSubMenu();
            openChildForm(new Register());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            //menü elrejtése
            //hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            //menü elrejtése
            //hideSubMenu();
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonOlt_Click(object sender, EventArgs e)
        {
            //Oltások
            openChildForm(new Form5());
        }

        private void btnNewA_Click(object sender, EventArgs e)
        {
            openChildForm(new FormNewA());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelHelp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //email küldés

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //read connstr from the App.Config 
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["bejelentkezes.Properties.Settings.dbTabelsConnectionString"].ConnectionString;
        }
    }
}
