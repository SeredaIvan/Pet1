using ClassLibraryATM;
using ProgramLibraryATM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class LogIn : Form
    {
        Account userATM = null;
        List<Bank> banks = null;
        public LogIn(List<Bank> banks)
        {

            InitializeComponent();
            this.banks = banks;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Master master = Program.GetMaster();
            this.Close();
            master.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (IsUser(textBox1.Text, textBox2.Text))
            {
                DBMySQL db = new DBMySQL();
                if (db.CheckIfNumberCardExists(textBox1.Text))
                {
                    userATM = db.GetUserATM("users", -1, "numbercard", textBox1.Text);
                    Cabinet cab = new Cabinet(banks, userATM);
                    cab.Show();
                    this.Hide();
                }

            }
            else
            {
                textBox2.PasswordChar = '\0';
                textBox2.Text = "ПІН введено не вірно";
                textBox2.BackColor = Color.Red;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            if (textBox1.Text.Length == 15)
            {
                if (IsCard(textBox1.Text))
                {

                }
                else
                {
                    textBox1.Text = "Карту введено не вірно";
                    textBox1.BackColor = Color.Red;
                }
            }
        }
        public static bool IsUser(string numbercard, string pin)
        {
            string regexPattern = @"^\d{4}-? ?\d{4}-? ?\d{4}-? ?\d{4}$";

            DBMySQL dbMySQL = new DBMySQL();

            return IsCard(numbercard) && dbMySQL.CheckIfPinExists(pin);
        }
        public static bool IsCard(string numbercard)
        {
            string regexPattern = @"^\d{4}-? ?\d{4}-? ?\d{4}-? ?\d{4}$";

            DBMySQL dbMySQL = new DBMySQL();

            return Regex.IsMatch(numbercard, regexPattern) && dbMySQL.CheckIfNumberCardExists(numbercard);
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
            textBox2.PasswordChar = '*';
        }
    }
}
