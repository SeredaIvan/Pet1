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
            //comboBox1.Text = "ѕриватЅанк";

            banks.Add(CreateBank(@"
        [
            {
                ""IdATM"": 1,
                ""CostsInATM"": 1500,
                ""Adress"": ""∆итомир, ∆итомирська область, ”краина, 10002""
            },
            {
                ""IdATM"": 2,
                ""CostsInATM"": 3000,
                ""Adress"": ""∆итомир, ∆итомирська область, ”краина, 10002""
            },
            {
                ""IdATM"": 3,
                ""CostsInATM"": 2000,
                ""Adress"": ""вулиц€ ’л≥бна, 64, ∆итомир, ∆итомирська область, ”краина, 10002""
            },
            {
                ""IdATM"": 4,
                ""CostsInATM"": 4000,
                ""Adress"": ""вулиц€ ѕушк≥нська, 58ј, ∆итомир, ∆итомирська область, ”краина, 10002""
            },
            {
                ""IdATM"": 5,
                ""CostsInATM"": 5000,
                ""Adress"": ""проспект Ќезалежност≥, 55, ∆итомир, ∆итомирська область, ”краина, 10002""
            }
        ]
        ", "ѕриватЅанк"));
            banks.Add(CreateBank(@"[
  {
    ""IdATM"": 6,
    ""CostsInATM"": 3000,
    ""Adress"": ""вулиц€  ињвська, 77, ∆итомир, ∆итомирська область, 10002""
  },
  {
    ""IdATM"": 7,
    ""CostsInATM"": 2500,
    ""Adress"": "" вулиц€  ињвська, 67, ∆итомир, ∆итомирська область, 10014""
  },
  {
    ""IdATM"": 8,
    ""CostsInATM"": 2800,
    ""Adress"": ""вулиц€ Ќебесноњ —отн≥, 13, ∆итомир, ∆итомирська область, 10000""
  },
  {
    ""IdATM"": 9,
    ""CostsInATM"": 3300,
    ""Adress"": ""вулиц€  ињвська, 20, ∆итомир, ∆итомирська область, 10000""
  },
  {
    ""IdATM"": 10,
    ""CostsInATM"": 4500,
    ""Adress"": ""вулиц€  ињвська, 20, ∆итомир, ∆итомирська область, 10000""
  }
]
", "ќщадЅанк"));

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

            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem == "ќщадЅанк")
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
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem == "ќщадЅанк")
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