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
    public partial class WeeklyMenu : Form
    {
        public WeeklyMenu()
        {
            InitializeComponent();
        }

        OleDbConnection BaglantiKur = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source= YemekListesiDB.accdb; Persist Security Info = False;");

        private void WeeklyMenu_Load(object sender, EventArgs e)
        {
            string SelectWeek = "";
            DateTime today = p6Calendar.TodayDate;
            int day = today.Day;

            BaglantiKur.Open();
            OleDbCommand KomutUygula = new OleDbCommand();
            KomutUygula.Connection = BaglantiKur;
            KomutUygula.CommandText = "SELECT * FROM Menu WHERE Day = @daypick";
            KomutUygula.Parameters.AddWithValue("@dayPick", day);
            OleDbDataReader TutulanDegisken = KomutUygula.ExecuteReader();

            if (TutulanDegisken.Read())
            {
                SelectWeek = TutulanDegisken["Week"].ToString();
            }

            OleDbCommand KomutUygula2 = new OleDbCommand();
            KomutUygula2.Connection = BaglantiKur;
            KomutUygula2.CommandText = "SELECT Day, Soup, MainCourse, Desert, Drink FROM Menu WHERE Week = @selectedWeek ";
            KomutUygula2.Parameters.AddWithValue("@selectFood", SelectWeek);
            OleDbDataReader TutulanDegisken2 = KomutUygula2.ExecuteReader();

            while (TutulanDegisken2.Read())
            {
                ListViewItem addList = new ListViewItem();
                addList.Text = TutulanDegisken2["Day"].ToString();
                addList.SubItems.Add(TutulanDegisken2["Soup"].ToString());
                addList.SubItems.Add(TutulanDegisken2["MainCourse"].ToString());
                addList.SubItems.Add(TutulanDegisken2["Desert"].ToString());
                addList.SubItems.Add(TutulanDegisken2["Drink"].ToString());
                p6listViewWeekly.Items.Add(addList);
            }
            BaglantiKur.Close();
        }

        private void p6buttonPreviousPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage goMainPage = new MainPage();
            goMainPage.Show();
        }

        private void p6listViewMonthly_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
