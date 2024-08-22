using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantMenu
{
    public partial class MonthlyMenu : Form
    {
        public MonthlyMenu()
        {
            InitializeComponent();
        }

        OleDbConnection BaglantiKur = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source= YemekListesiDB.accdb; Persist Security Info = False;");

        private void MonthlyMenu_Load(object sender, EventArgs e)
        {
            BaglantiKur.Open();
            OleDbCommand KomutUygula = new OleDbCommand();
            KomutUygula.Connection = BaglantiKur;
            KomutUygula.CommandText = "SELECT * FROM Menu";
            OleDbDataReader TutulanDegisken = KomutUygula.ExecuteReader();

            while (TutulanDegisken.Read())
            {
                ListViewItem addList = new ListViewItem();
                addList.Text = TutulanDegisken["Day"].ToString();
                addList.SubItems.Add(TutulanDegisken["Soup"].ToString());
                addList.SubItems.Add(TutulanDegisken["MainCourse"].ToString());
                addList.SubItems.Add(TutulanDegisken["Desert"].ToString());
                addList.SubItems.Add(TutulanDegisken["Drink"].ToString());
                p7listViewMonthly.Items.Add(addList);
            }
            BaglantiKur.Close();
        }

        private void p7buttonPreviousPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage goMainPage = new MainPage();
            goMainPage.Show();
        }
    }
}
