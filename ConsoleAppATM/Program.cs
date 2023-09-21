using ClassLibraryATM;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace ProgramLibraryATM
{
    public class ConsoleAppATM
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            Console.InputEncoding = Encoding.UTF8;
            System.Console.OutputEncoding = System.Text.Encoding.UTF8;

            MainMenu();

            
           


            //DBMySQL mydb = new DBMySQL();
            
            //mydb.ToGet("users", "id", "surname");
        }
        static string GetFourNumbers()
        {
            return Convert.ToString((new Random()).Next(1000, 9999));
        }
        public static string GetNewNumberCard(string systemcard) {
            string numbercard=systemcard;
            for (int i = 0; i < 4; i++)
            {
                numbercard += GetFourNumbers();
            }
            
            
            return numbercard.Substring(0, numbercard.Length - 1);
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

        public static void LogIn()
        {
             
                    Console.Clear();
            Console.WriteLine("    Введіть номер карти та пін код \n Введіть 0 щоб повернутись\n");
            bool oi;
            do
            {
                Console.WriteLine("Номер карти:");
                string inputText = Console.ReadLine();
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


            
        }
        public static void RegisterUser()
        {
            Console.Clear();
            Console.WriteLine("    Реєстрація");
            Console.WriteLine("Введіть своє Прізвище Ім'я По-батькові");
            string name = " "; 
            name= Console.ReadLine();
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
            DBMySQL mydb=new DBMySQL();
            int longdb = mydb.GetRowCount("users");
            Console.WriteLine($"LongDB {longdb}");
            int id = longdb+1;

            mydb.Send("users", id, name, phonenumber, newnumbercard, pin);
            //if (longdb > 0)
            //{
            //    id = longdb+1;
            //    SenderDB(mydb, id,name,phonenumber,newnumbercard,pin);
                
            //}
            //else if (longdb ==0 ) {
            //    mydb.SendID("users",1);
            //    id = 1;
                

            //}
            //else if(longdb==0)
            //{
            //    mydb.CreateIndex("users", "id", "id");
            //    id = 1;
            //    mydb.Send("users", "id", id);
            //    mydb.Send("users", "name", id, name);
            //    mydb.Send("users", "phonenumber", id, phonenumber);
            //    mydb.Send("users", "numbercard", id, newnumbercard);
            //    mydb.Send("users", "pin", id, pin);

            //}
            Console.ReadKey();
        }

        private static void MainMenu()
        {
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
                    LogIn();
                    break;
                case 2:
                    RegisterUser();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }

        }
       
    }
}


