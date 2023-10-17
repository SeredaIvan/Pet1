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

namespace WinFormsApp1
{
    public partial class Registration : Form
    {
        Account userATM = null;
        List<Bank> banksm = null;
        public Registration(List<Bank> banks)
        {
            InitializeComponent();
            banksm = banks;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private bool IsPhone(string phonenumber)
        {
            phonenumber = textBoxPhonenumber.Text;
            string regexPattern = @"^0\d{9}$";
            if (Regex.IsMatch(phonenumber, regexPattern))
            {
                return true;
            }
            else
            {
                textBoxPhonenumber.BackColor = Color.Red;
                textBoxPhonenumber.Text = "Введіть вірний номер телефону";
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userATM == null)
            {
                if (textBoxPIB.Text != "")
                {
                    if (textBoxPhonenumber.Text != "" && IsPhone(textBoxPhonenumber.Text))
                        if (textBoxPin1.Text != "")
                            if (textBoxPin2.Text != "")
                                if (comboBoxTypeOfCard.Text != "")
                                    if (textBoxPin1.Text == textBoxPin2.Text)
                                    {
                                        textBoxNumberCard.Visible = true;
                                        string name = textBoxPIB.Text;
                                        string phonenumber = textBoxPhonenumber.Text;
                                        string pin = textBoxPin2.Text;
                                        int indextypeofcard = comboBoxTypeOfCard.SelectedIndex;
                                        textBoxPin2.BackColor = Color.White;
                                        userATM = RegisterUser(name, phonenumber, indextypeofcard, pin, textBoxNumberCard);
                                        labelIsRegistry.Text = "Ваш номер карти";
                                        labelIsRegistry.Visible = true;

                                        textBoxNumberCard.Text = userATM.GetNumberCard();

                                        button1.Text = "В кабінет";
                                    }
                                    else
                                    {
                                        textBoxPin2.PasswordChar = '\0';
                                        textBoxPin2.BackColor = Color.Coral;
                                        textBoxPin2.Text = "Введіть схожий Pin";
                                    }

                                else { }
                            else { }
                        else { }
                    else
                    {

                        textBoxPhonenumber.BackColor = Color.Red;
                        textBoxPhonenumber.Text = "Введіть вірний номер телефону";

                    }
                }
                else
                {
                    textBoxPIB.Text = "Введіть ПІБ";
                    textBoxPIB.BackColor = Color.Red;
                }
            }
            if (button1.Text == "В кабінет")
            {
                Cabinet cabinet = new Cabinet(banksm, userATM);
                this.Close();
                cabinet.Show();
            }
        }

        private void textBoxPin2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBoxPin2.Text != "")
            {
                textBoxPin2.BackColor = Color.White;
                textBoxPin2.PasswordChar = '*';
                textBoxPin2.Text = "";
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
        public static Account RegisterUser(string name, string phonenumber, int systemcard, string pin, TextBox textBox)
        {
            //textBox.Visible = true;
            string newnumbercard = "";

            switch (systemcard + 1)
            {
                case 1:
                    newnumbercard = GetNewNumberCard("4");
                    break;
                case 2:
                    newnumbercard = GetNewNumberCard("5");
                    break;
                default:
                    break;
            }
            DBMySQL mydb = new DBMySQL();
            int longdb = mydb.GetRowCount("users");
            int id = longdb + 1;
            mydb.Send("users", id, name, phonenumber, newnumbercard, pin);


            Account userATM = new Account(id, name, phonenumber, newnumbercard, pin, 0);

            //textBox.Text = userATM.GetNumberCard();
            return userATM;
        }
        public static string GetNewNumberCard(string systemcard)
        {
            string numbercard = systemcard;
            for (int i = 0; i < 4; i++)
            {
                numbercard += GetFourNumbers();
            }


            return numbercard.Substring(0, numbercard.Length - 1);
        }
        static string GetFourNumbers()
        {
            return Convert.ToString((new Random()).Next(1000, 9999));
        }
        private void textBoxPIB_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPIB.Text = "";
            textBoxPIB.BackColor = Color.White;
        }

        private void textBoxPhonenumber_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxPhonenumber.Text = "";
            textBoxPhonenumber.BackColor = Color.White;
        }

        private void comboBoxTypeOfCard_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void textBoxPin2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
