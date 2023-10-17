using ClassLibraryATM;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Configuration;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace ProgramLibraryATM
{
    public class ConsoleAppATM
    {

        public delegate void MainDelegate(List<Bank> banks);
        public delegate Account AccountRun();
        public delegate void Cabinet(Account userATM, List<Bank> banks);

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;

            MainDelegate Menu =new MainDelegate(MainMenu);

            List<Bank> banks = new List<Bank>();

            banks.Add(CreateBank(@"
        [
            {
                ""IdATM"": 1,
                ""CostsInATM"": 1500,
                ""Adress"": ""Житомир, Житомирська область, Украина, 10002""
            },
            {
                ""IdATM"": 2,
                ""CostsInATM"": 3000,
                ""Adress"": ""Житомир, Житомирська область, Украина, 10002""
            },
            {
                ""IdATM"": 3,
                ""CostsInATM"": 2000,
                ""Adress"": ""вулиця Хлібна, 64, Житомир, Житомирська область, Украина, 10002""
            },
            {
                ""IdATM"": 4,
                ""CostsInATM"": 4000,
                ""Adress"": ""вулиця Пушкінська, 58А, Житомир, Житомирська область, Украина, 10002""
            },
            {
                ""IdATM"": 5,
                ""CostsInATM"": 5000,
                ""Adress"": ""проспект Незалежності, 55, Житомир, Житомирська область, Украина, 10002""
            }
        ]
        ", "ПриватБанк"));
            banks.Add(CreateBank(@"[
  {
    ""IdATM"": 6,
    ""CostsInATM"": 3000,
    ""Adress"": ""вулиця Київська, 77, Житомир, Житомирська область, 10002""
  },
  {
    ""IdATM"": 7,
    ""CostsInATM"": 2500,
    ""Adress"": "" вулиця Київська, 67, Житомир, Житомирська область, 10014""
  },
  {
    ""IdATM"": 8,
    ""CostsInATM"": 2800,
    ""Adress"": ""вулиця Небесної Сотні, 13, Житомир, Житомирська область, 10000""
  },
  {
    ""IdATM"": 9,
    ""CostsInATM"": 3300,
    ""Adress"": ""вулиця Київська, 20, Житомир, Житомирська область, 10000""
  },
  {
    ""IdATM"": 10,
    ""CostsInATM"": 4500,
    ""Adress"": ""вулиця Київська, 20, Житомир, Житомирська область, 10000""
  }
]
", "ОщадБанк"));

            Console.WriteLine("Виберіть банк : \n1-ПриватБанк \n2-ОщадБанк");
            int inp=Convert.ToInt32(Console.ReadLine());
            List<AutomatedTellerMachine> atms = null;
            int p = 0;
            Console.WriteLine("Виберіть ATM:");

            switch (inp)
            {
                
                case 1:
                    banks.RemoveAt(1);
                    atms = banks[0].GetAllATM();
                   
                    foreach (var atm in atms)
                    {
                        p++;
                        Console.WriteLine($"{p}-Банк{banks[0].GetName()}; Адреса : {atm.GetAdress()}");
                       
                    }

                    int inp2 = Convert.ToInt32(Console.ReadLine());
                    if (inp2-1 < atms.Count)
                    {
                        Console.WriteLine($"{inp2}");
                        banks[0].SetIndexer(inp2-1);
                    }
                    else
                    {
                        Console.WriteLine("Я перевірок не робив!");
                    }
                    break;
                case 2:
                    
                    atms = banks[1].GetAllATM();
                    foreach (var atm in atms)
                    {
                        p++;
                        Console.WriteLine($"{p}-Банк{banks[1].GetName()}; Адреса : {atm.GetAdress()}");
                        
                    }
                    int inp3 = Convert.ToInt32(Console.ReadLine());
                    if (inp3-1 < atms.Count)
                    {
                        Console.WriteLine($"{inp3}");
                        banks[1].SetIndexer(inp3-1);
                        banks.RemoveAt(0);
                    }
                    else
                    {
                        Console.WriteLine("Я перевірок не робив!");
                    }
                    break;
                default:
                    break;
                    
            }
            // Console.Clear();
            
            Console.WriteLine($"{banks[0].GetName()},{banks[0].GetIndexer()}\n{banks[0].GetIndexATM(banks[0].GetIndexer()).GetAdress()}");
            Console.Clear();

            Menu(banks);

        }
        public static Bank CreateBank(string json,string bankname)
        {
             

            List<AutomatedTellerMachine> atms = JsonConvert.DeserializeObject<List<AutomatedTellerMachine>>(json);

            Bank bank = new Bank(bankname, atms);

           
            return bank;
        }
      
        private static void MainMenu(List<Bank> banks)
        {
            Cabinet cabinet;
            cabinet = GoToCabinet;
            AccountRun RunTo ;
            Account userATM = null;
            int input;
      
            Console.WriteLine("             Вітаємо вас в банкінгу!\n" +
                "         Виберіть дію:\n" +
                "   -1 Ввійти в кабінет\n" +
                "   -2 Зареєструватись\n" +
                "   -3 Вийти з програми\n" +
                "                               \n    ");
            input = Convert.ToInt32(Console.ReadLine());


            switch (input)
            {
                case 1:
                    RunTo = LogIn;
                    userATM = RunTo();

                    if (userATM != null)
                    {
                        cabinet(userATM, banks);
                        
                    }
                    break;
                case 2:
                    RunTo = RegisterUser;
                    userATM = RunTo();
                    if (userATM != null)
                    {
                        cabinet(userATM, banks);
                    }
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }


        }


        public static Account LogIn()
        {
            DBMySQL mydb = new DBMySQL();
            string inputText;
            int id;
            Console.Clear();
            Console.WriteLine("    Введіть номер карти та пін код \n Введіть 0 щоб повернутись\n");
            bool oi;
            do
            {
                Console.WriteLine("Номер карти:");
                inputText = Console.ReadLine();
                string regexPattern = @"^\d{4}-? ?\d{4}-? ?\d{4}-? ?\d{4}$";

                if (inputText == "0")
                {
                    Console.WriteLine("Завершення...");
                    break;
                }
                else if (Regex.IsMatch(inputText, regexPattern))
                {
                    Console.WriteLine("Банківська карта введена вірно");
                    oi = true;
                }
                else
                {
                    Console.WriteLine("Це не є номером банківської карти.Перевірте правильність введення");
                    oi = false;
                }
            } while (!oi);

            Console.WriteLine("Пін код :");

            string pin = GetPassword();

            id = DBMySQL.ReturnId(inputText, pin);

            Account userATM = mydb.GetUserATM("users", id);
            return userATM;

        }

        public static Account RegisterUser()
        {
            Console.Clear();
            Console.WriteLine("    Реєстрація");
            Console.WriteLine("Введіть своє Прізвище Ім'я По-батькові");
            string name = " ";
            name = Console.ReadLine();
            bool oi;
            string phonenumber;
            do
            {
                Console.WriteLine("Введіть свій номер телефону:");
                phonenumber = Console.ReadLine();
                string regexPattern = @"^0\d{9}$";


                if (Regex.IsMatch(phonenumber, regexPattern))
                {
                    Console.WriteLine("Номер телефону введена вірно");
                    oi = true;
                }
                else
                {
                    Console.WriteLine("Це не є номером телефону карти.Перевірте правильність введення");
                    oi = false;
                }
            } while (!oi);
            Console.WriteLine("Виберіть платіжну систему");
            Console.WriteLine("1-Visa;2-MasterCard");
            int systemcard = Convert.ToInt32(Console.ReadLine());
            bool carbon = false;
            string newnumbercard = "";
            do
            {
                switch (systemcard)
                {
                    case 1:
                        newnumbercard = GetNewNumberCard("4");
                        carbon = true;
                        break;
                    case 2:
                        newnumbercard = GetNewNumberCard("5");
                        carbon = true;
                        break;
                    default:
                        carbon = false;
                        break;

                }
            } while (!carbon);
            Console.WriteLine($"Номер нової карти : {newnumbercard}");
            Console.WriteLine("Введіть пін");
            string pin = GetPassword();
            DBMySQL mydb = new DBMySQL();
            int longdb = mydb.GetRowCount("users");
            Console.WriteLine($"LongDB {longdb}");
            int id = longdb + 1;

            mydb.Send("users", id, name, phonenumber, newnumbercard, pin);

            Console.ReadKey();
            Account userATM = new Account(id, name, phonenumber, newnumbercard, pin, 0);
            return userATM;
        }

       
        private static void GoToCabinet(Account userATM, List<Bank> banks)
        {
            Console.Clear();
            Console.WriteLine("    Кабінет Користувача");
            Console.WriteLine("Інформація про користувача");
            Console.WriteLine($"ПІБ : {userATM.GetName()}");
            Console.WriteLine($"Номер телефону : {userATM.GetPhoneNumber()}");
            Console.WriteLine($"Номер карти : {userATM.GetNumberCard()}");
            Console.WriteLine($"Баланс : {userATM.GetCostInCard()}");
            Console.WriteLine($"Натисніть цифру для дії : " +
                $"\n1-Внести кошти на карту\n2-Зняти кошти\n3-Перечислити кошти за номером карти");
            Console.WriteLine($"{banks[0].GetIndexATM(banks[0].GetIndexer()).GetCostInATM()}грн. - залишок в банкоматі");
            int inp = Convert.ToInt32(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    userATM = SetCostInCard(userATM);
                    //Console.WriteLine($"class cost{ userATM.GetCostInCard()}");
                    DBMySQL.ReloadDB(userATM);
                    //Console.WriteLine($"ATM cost before{banks[0].GetIndexATM(banks[0].GetIndexer()).GetCostInATM()}");
                    banks[0].GetIndexATM(banks[0].GetIndexer()).PlusCostInATM(userATM.GetLastOperation());
                    //Console.WriteLine($"ATM cost after{banks[0].GetIndexATM(banks[0].GetIndexer()).GetCostInATM()}");
                    Console.ReadKey();
                    GoToCabinet(userATM,banks);
                    break;
                case 2:
                    userATM=MinusCostInCard(userATM);
                    //Console.WriteLine($"class cost{userATM.GetCostInCard()}");
                    DBMySQL.ReloadDB(userATM);
                    banks[0].GetIndexATM(banks[0].GetIndexer()).MinusCostInATM(-userATM.GetLastOperation());
                    Console.ReadKey();
                    GoToCabinet(userATM, banks);
                    break;
                case 3:
                    Console.WriteLine("Введіть номер карти на який хочете відправити кошти");
                    bool oi;
                    string numbercard;
                    do
                    {
                        Console.WriteLine("Номер карти:");
                        numbercard = Console.ReadLine();
                        string regexPattern = @"^\d{4}-? ?\d{4}-? ?\d{4}-? ?\d{4}$";

                       
                        if (Regex.IsMatch(numbercard, regexPattern))
                        {
                            Console.WriteLine("Банківська карта введена вірно");
                            oi = true;
                        }
                        else
                        {
                            Console.WriteLine("Це не є номером банківської карти.Перевірте правильність введення");
                            oi = false;
                        }
                    } while (!oi);
                    
                    DBMySQL db = new DBMySQL();
                    Account userATMsender = db.GetUserATM("users",-1,"numbercard",numbercard);
                    Console.Clear();
                    Console.WriteLine($"Отримувач {userATMsender.GetName()} Номер карти :{numbercard}");
                    Console.WriteLine("Введіть скільки коштів хочете переслати");
                    int sendcost = Convert.ToInt32(Console.ReadLine());
                    userATM.MinusCost(sendcost);
                    userATMsender.SetCost(sendcost);

                    DBMySQL.ReloadDB(userATM); 
                    DBMySQL.ReloadDB(userATMsender);
                    Console.ReadKey();
                    GoToCabinet(userATM, banks);

                    break;

                default:
                    break;
            }
            Console.WriteLine($"");
        }


        public static Account MinusCostInCard(Account userATM)
        {
            Console.WriteLine("Введіть суму яку хочете зняти");
            int cost = Convert.ToInt32(Console.ReadLine());
            userATM.MinusCost(cost);
            return userATM;
        }

        public static Account SetCostInCard(Account userATM)
        {
            Console.WriteLine("Введіть суму яку хочете внести");
            int cost = Convert.ToInt32(Console.ReadLine());
            userATM.SetCost(cost);
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
        
        static string GetPassword()
        {
            string password = "";
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);


                if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Remove(password.Length - 1);
                    Console.Write("\b \b");
                }
            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            return password;
        }

    }
}


