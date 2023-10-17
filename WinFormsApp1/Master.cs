using ClassLibraryATM;
using Newtonsoft.Json;

namespace WinFormsApp1
{
    public partial class Master : Form
    {
        List<Bank> banks = new List<Bank>();
        public Master()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Master_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //comboBox1.Text = "����������";

            banks.Add(CreateBank(@"
        [
            {
                ""IdATM"": 1,
                ""CostsInATM"": 1500,
                ""Adress"": ""�������, ����������� �������, �������, 10002""
            },
            {
                ""IdATM"": 2,
                ""CostsInATM"": 3000,
                ""Adress"": ""�������, ����������� �������, �������, 10002""
            },
            {
                ""IdATM"": 3,
                ""CostsInATM"": 2000,
                ""Adress"": ""������ �����, 64, �������, ����������� �������, �������, 10002""
            },
            {
                ""IdATM"": 4,
                ""CostsInATM"": 4000,
                ""Adress"": ""������ ���������, 58�, �������, ����������� �������, �������, 10002""
            },
            {
                ""IdATM"": 5,
                ""CostsInATM"": 5000,
                ""Adress"": ""�������� �����������, 55, �������, ����������� �������, �������, 10002""
            }
        ]
        ", "����������"));
            banks.Add(CreateBank(@"[
  {
    ""IdATM"": 6,
    ""CostsInATM"": 3000,
    ""Adress"": ""������ �������, 77, �������, ����������� �������, 10002""
  },
  {
    ""IdATM"": 7,
    ""CostsInATM"": 2500,
    ""Adress"": "" ������ �������, 67, �������, ����������� �������, 10014""
  },
  {
    ""IdATM"": 8,
    ""CostsInATM"": 2800,
    ""Adress"": ""������ ������� ����, 13, �������, ����������� �������, 10000""
  },
  {
    ""IdATM"": 9,
    ""CostsInATM"": 3300,
    ""Adress"": ""������ �������, 20, �������, ����������� �������, 10000""
  },
  {
    ""IdATM"": 10,
    ""CostsInATM"": 4500,
    ""Adress"": ""������ �������, 20, �������, ����������� �������, 10000""
  }
]
", "��������"));

        }
        public static Bank CreateBank(string json, string bankname)
        {


            List<AutomatedTellerMachine> atms = JsonConvert.DeserializeObject<List<AutomatedTellerMachine>>(json);

            Bank bank = new Bank(bankname, atms);


            return bank;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem == "��������")
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < banks[0].GetAllATM().Count; i++)
                {

                    comboBox2.Items.Add(banks[0].GetIndexATM(i).GetAdress());

                }

            }
            else
            {
                comboBox2.Items.Clear();
                for (int i = 0; i < banks[1].GetAllATM().Count; i++)
                {

                    comboBox2.Items.Add(banks[1].GetIndexATM(i).GetAdress());
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem == "��������")
            {

                banks.RemoveAt(1);
            }
            else
            {

                banks.RemoveAt(0);
            }
            if (banks != null)
            {
                Registration registration = new Registration(banks);
                registration.Show();
                this.Hide();
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (banks.Count > 0)
            {
                banks[0].SetIndexer(comboBox2.SelectedIndex);
            }

            if (banks.Count > 1)
            {
                banks[1].SetIndexer(comboBox2.SelectedIndex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn(banks);
            this.Hide();
            login.Show();
        }
    }
}