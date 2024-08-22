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
    public partial class AdvancedSearch : Form
    {
        public AdvancedSearch()
        {
            InitializeComponent();
        }


        OleDbConnection BaglantiKur = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source= YemekListesiDB.accdb; Persist Security Info = False;");


        private void p5buttonFoodFilter_Click(object sender, EventArgs e)
        {
            p5listViewDaily.Items.Clear();
            string SelectedFood = p5textBoxSelectedFood.Text;

            BaglantiKur.Open();
            OleDbCommand KomutUygula = new OleDbCommand();
            KomutUygula.Connection = BaglantiKur;
            KomutUygula.CommandText = "SELECT Day, Soup, MainCourse, Desert, Drink FROM Menu WHERE Soup = @selectFood OR MainCourse = @selectFood OR Desert = @selectFood OR Drink = @selectFood ";
            KomutUygula.Parameters.AddWithValue("@selectFood", SelectedFood);
            OleDbDataReader TutulanDegisken = KomutUygula.ExecuteReader();

            while (TutulanDegisken.Read())
            {
                ListViewItem addList = new ListViewItem();
                addList.Text = TutulanDegisken["Day"].ToString();
                addList.SubItems.Add(TutulanDegisken["Soup"].ToString());
                addList.SubItems.Add(TutulanDegisken["MainCourse"].ToString());
                addList.SubItems.Add(TutulanDegisken["Desert"].ToString());
                addList.SubItems.Add(TutulanDegisken["Drink"].ToString());
                p5listViewDaily.Items.Add(addList);
            }
            BaglantiKur.Close();
        }

        private void p5datePickAdvanced_ValueChanged(object sender, EventArgs e)
        {
            p5listViewDaily.Items.Clear();
            DateTime WantedDate = p5datePickAdvanced.Value;
            int WantedDay = Convert.ToInt32(WantedDate.Day);

            BaglantiKur.Open();
            OleDbCommand KomutUygula = new OleDbCommand();
            KomutUygula.Connection = BaglantiKur;
            KomutUygula.CommandText = "SELECT Day, Soup, MainCourse, Desert, Drink FROM Menu WHERE Day = @daypick";
            KomutUygula.Parameters.AddWithValue("@dayPick", WantedDay);
            OleDbDataReader TutulanDegisken = KomutUygula.ExecuteReader();

            if (TutulanDegisken.Read())
            {
                ListViewItem addList = new ListViewItem();
                addList.Text = TutulanDegisken["Day"].ToString();
                addList.SubItems.Add(TutulanDegisken["Soup"].ToString());
                addList.SubItems.Add(TutulanDegisken["MainCourse"].ToString());
                addList.SubItems.Add(TutulanDegisken["Desert"].ToString());
                addList.SubItems.Add(TutulanDegisken["Drink"].ToString());
                p5listViewDaily.Items.Add(addList);
            }
            BaglantiKur.Close();
        }

        private void p5buttonPreviousPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage goMainPage = new MainPage();
            goMainPage.Show();
        }
    }
}
