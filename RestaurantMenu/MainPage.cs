using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantMenu
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void p3buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void p3buttonDaily_Click(object sender, EventArgs e)
        {
            this.Hide();
            DailyMenu goDailyMenu = new DailyMenu();
            goDailyMenu.Show();
        }

        private void p3buttonMonthly_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonthlyMenu goMonthlyMenu = new MonthlyMenu();
            goMonthlyMenu.Show();
        }

        private void p3buttonWeekly_Click(object sender, EventArgs e)
        {
            this.Hide();
            WeeklyMenu goWeeklyMenu = new WeeklyMenu();
            goWeeklyMenu.Show();
        }

        private void p3buttonAdvancedSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdvancedSearch goAdvancedSearch = new AdvancedSearch();
            goAdvancedSearch.Show();
        }
    }
}
