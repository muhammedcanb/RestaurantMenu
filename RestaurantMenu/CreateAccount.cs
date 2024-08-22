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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        OleDbConnection BaglantiKur = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source= YemekListesiDB.accdb; Persist Security Info = False;");

        private void p2buttonCreate_Click(object sender, EventArgs e)
        {
            string newName = p2textBoxName.Text;
            string newSurname = p2textBoxSurname.Text;
            string newUsername = p2textBoxUsername.Text;
            string newPass = p2textBoxPassword.Text;
            int newAge = Convert.ToInt32(p2numericAge.Value);

            if (newName != "" && newPass != "")
            {
                BaglantiKur.Open();
                OleDbCommand KomutUygula = new OleDbCommand("INSERT INTO LoginInfo (Username, UserPassword, RealName, RealSurname, Age) VALUES(@valueUsername, @valuePassword, @valueName, @valueSurname, @valueAge)", BaglantiKur);
                KomutUygula.Parameters.AddWithValue("@valueUsername", newUsername);
                KomutUygula.Parameters.AddWithValue("@valuePass", newPass);
                KomutUygula.Parameters.AddWithValue("@valueName", newName);
                KomutUygula.Parameters.AddWithValue("@valueSurname", newSurname);
                KomutUygula.Parameters.AddWithValue("@valueAge", newAge);
                KomutUygula.ExecuteNonQuery();
                KomutUygula.Parameters.Clear();
                BaglantiKur.Close();

                MessageBox.Show("The account has been created, you can return to the login page from the bottom right !");
            }

            else
            {
                MessageBox.Show("The account could not be created, please fill in all parameters.");
            }
        }

        private void p2buttonLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 goForm1Page = new Form1();
            goForm1Page.Show();
        }

    }
}
