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
using ClassLibraryATM;
using ProgramLibraryATM;

namespace WinFormsApp1
{
    public partial class Cabinet : Form
    {
        List<Bank> banks = null;
        Account userATM = null;
        public Cabinet(List<Bank> banksm, Account userATMm)
        {
            InitializeComponent();
            banks = banksm;
            userATM = userATMm;
        }

        private void Cabinet_Load(object sender, EventArgs e)
        {
            
            labelCostsInATM.Text = Convert.ToString(banks[0].GetIndexATM(banks[0].GetIndexer()).GetCostInATM());
            labelBankName.Text = Convert.ToString(banks[0].GetName());
            labelATMName.Text = Convert.ToString(banks[0].GetIndexATM(banks[0].GetIndexer()).GetAdress());
            labelPIB.Text = Convert.ToString(userATM.GetName());
            labelCostInCard.Text = Convert.ToString(userATM.GetCostInCard());
            labelNumberCard.Text = Convert.ToString(userATM.GetNumberCard());

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonPerekazCost_Click(object sender, EventArgs e)
        {
            labelNumberCardPerekaz.Visible = true;
            labelNumberCard.Visible = true;
            button3.Visible = true;
            label9.Visible = true;
            textBoxNumberCardPerekaz.Visible = true;
            textBoxCostPerecaz.Visible = true;
            labelNumberCardPerekaz.Text = userATM.GetNumberCard();

        }
        public static Account SetCostInCard(Account userATM, TextBox textBox)
        {

            int cost = Convert.ToInt32(textBox.Text);
            userATM.SetCost(cost);
            return userATM;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            button4.Visible = true;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxNumberCardPerekaz.Text!=""&& textBoxCostPerecaz.Text!=""&&textBoxNumberCardPerekaz.Text!= "Введіть номер карти" && textBoxCostPerecaz.Text!= "Введіть суму переказу") {
                if (IsCard(textBoxNumberCardPerekaz.Text))
                {
                    DialogResult result = MessageBox.Show("Підтвердити операцію", "Підтвердження", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        labelNumberCardPerekaz.Visible = false;
                        button3.Visible = false;
                        label9.Visible = false;
                        textBoxNumberCardPerekaz.Visible = false;
                        textBoxCostPerecaz.Visible = false;
                        DBMySQL db = new DBMySQL();
                        Account userATMsender = db.GetUserATM("users", -1, "numbercard", textBoxNumberCardPerekaz.Text);
                        label8.Text = userATMsender.GetName();
                        userATM.MinusCost(Convert.ToInt32(textBoxCostPerecaz.Text));
                        userATMsender.SetCost(Convert.ToInt32(textBoxCostPerecaz.Text));
                        DBMySQL.ReloadDB(userATM);
                        DBMySQL.ReloadDB(userATMsender);
                        labelCostInCard.Text = Convert.ToString(userATM.GetCostInCard());
                    }
                }
                else
                {
                    textBoxNumberCardPerekaz.Text = "Введіть ввірну карту";
                    textBoxNumberCardPerekaz.BackColor = Color.Red;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != ""&&textBox2.Text != "Введіть скільки хочете зняти")
            {
                DialogResult result = MessageBox.Show("Підтвердити операцію", "Підтвердження", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    userATM = MinusCostInCard(userATM, textBox2);
                    DBMySQL.ReloadDB(userATM);
                    banks[0].GetIndexATM(banks[0].GetIndexer()).MinusCostInATM(userATM.GetLastOperation());
                    textBox2.Visible = false;
                    button4.Visible = false;
                    labelCostsInATM.Text = Convert.ToString(banks[0].GetIndexATM(banks[0].GetIndexer()).GetCostInATM());
                    labelCostInCard.Text = Convert.ToString(userATM.GetCostInCard());
                }
            }
        }
        public static Account MinusCostInCard(Account userATM, TextBox textBox)
        {

            int cost = Convert.ToInt32(textBox.Text);
            userATM.MinusCost(cost);
            return userATM;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != ""&&textBox3.Text != "Введіть скільки хочете внести")
            {
                DialogResult result = MessageBox.Show("Підтвердити операцію", "Підтвердження", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    userATM = SetCostInCard(userATM, textBox3);
                    DBMySQL.ReloadDB(userATM);
                    banks[0].GetIndexATM(banks[0].GetIndexer()).PlusCostInATM(userATM.GetLastOperation());
                    labelCostsInATM.Text = Convert.ToString(banks[0].GetIndexATM(banks[0].GetIndexer()).GetCostInATM());
                    textBox3.Visible = false;
                    button5.Visible = false;
                    labelCostInCard.Text = Convert.ToString(userATM.GetCostInCard());
                }
            }
        }

        private void textBoxNumberCardPerekaz_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNumberCardPerekaz.Text != labelNumberCard.Text)
            {
                if (textBoxNumberCardPerekaz != null)
                {
                    if (textBoxNumberCardPerekaz.Text != "Введіть номер карти")
                    {
                        DBMySQL db = new DBMySQL();
                        Account userATMsender = db.GetUserATM("users", -1, "numbercard", textBoxNumberCardPerekaz.Text);
                        if (label8 != null && userATMsender != null)
                        {
                            label8.Text = userATMsender.GetName();
                        }
                    }
                }
            }
            else
            {
                textBoxNumberCardPerekaz.Text = "Це ваша карта";
            }
        }



        private void textBoxNumberCardPerekaz_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (textBoxNumberCardPerekaz.Text == "Введіть номер карти")
                textBoxNumberCardPerekaz.Text = "";
        }

       

        private void textBoxCostPerecaz_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (textBoxCostPerecaz.Text == "Введіть суму переказу")
                textBoxCostPerecaz.Text = "";
        }

        private void textBox2_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (textBox2.Text == "Введіть скільки хочете зняти")
                textBox2.Text = "";
        }

        private void textBox3_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (textBox3.Text == "Введіть скільки хочете внести")
                textBox3.Text = "";
        }
        public static bool IsCard(string numbercard)
        {
            string regexPattern = @"^\d{4}-? ?\d{4}-? ?\d{4}-? ?\d{4}$";

            DBMySQL dbMySQL = new DBMySQL();

            return Regex.IsMatch(numbercard, regexPattern) && dbMySQL.CheckIfNumberCardExists(numbercard);
        }
    }
}
