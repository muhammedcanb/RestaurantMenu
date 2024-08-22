using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace RestaurantMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection BaglantiKur = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source= YemekListesiDB.accdb; Persist Security Info = False;");

        private void p1buttonLogin_Click(object sender, EventArgs e)
        {
            string enterName = p1textBoxName.Text;
            string enterPassword = p1textBoxPassword.Text;

            try
            {
                BaglantiKur.Open();
                OleDbCommand KomutUygula = new OleDbCommand();
                KomutUygula.Connection = BaglantiKur;
                KomutUygula.CommandText = "SELECT Username, UserPassword FROM LoginInfo WHERE Username= @tryName and UserPassword = @tryPassword";
                KomutUygula.Parameters.AddWithValue("@tryName", enterName);
                KomutUygula.Parameters.AddWithValue("@tryPassword", enterPassword);
                OleDbDataReader TutulanDegisken = KomutUygula.ExecuteReader();

                if (TutulanDegisken.Read())
                {
                    MessageBox.Show("You have successfully logged in !");
                    this.Hide();
                    MainPage goMainPage = new MainPage();
                    goMainPage.Show();
                }

                else
                {
                    MessageBox.Show("You entered an incorrect username or password !");
                }
            }

            catch
            {
                MessageBox.Show("An unexpected error occurred.");
            }

            finally
            {
                if (BaglantiKur.State == ConnectionState.Open)
                {
                    BaglantiKur.Close();
                }
            }
        }

        private void p1buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void p1linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            CreateAccount goCreatePage = new CreateAccount();
            goCreatePage.Show();
        }
    }
}
