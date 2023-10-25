using System.Net.NetworkInformation;
using System.Text;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using ProgramLibraryATM;

namespace ClassLibraryATM
{
    public class DBMySQL
    {
        string connectionString = "Server=localhost;Database=dblab1;User=root;Password=root;CharSet=utf8mb4;";

        
        public void Send(string table, int id, string name, string phonenumber, string newnumbercard, string pin)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = $"INSERT INTO {table} (id, name, phonenumber, numbercard, pin, costincard) VALUES (@id, @name, @phonenumber, @newnumbercard, @pin, @costincard)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@phonenumber", phonenumber);
                    cmd.Parameters.AddWithValue("@newnumbercard", newnumbercard);
                    cmd.Parameters.AddWithValue("@pin", pin);
                    cmd.Parameters.AddWithValue("@costincard", 0);


                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                       
                    }
                    else
                    {
                        Console.WriteLine("Не вдалося вставити дані в таблицю.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка: " + ex.Message);
                }

            }
        }

        public bool CheckIfNumberCardExists(string numbercard)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE numbercard = @numbercard";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@numbercard", numbercard);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0; 
                }
                catch (Exception ex)
                {
                    
                    return false; 
                }
            }
        }
        public bool CheckIfPinExists(string pin)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE pin = @pin";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@pin", pin);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count > 0;
                }
                catch (Exception ex)
                {
                    
                    return false;
                }
            }
        }

        public int GetRowCount(string table)
        {
            int rowCount = 0;
            string connectionString = "Server=localhost;Database=dblab1;User=root;Password=root;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
          

                    string query = $"SELECT COUNT(*) FROM {table}";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    rowCount = Convert.ToInt32(cmd.ExecuteScalar());

                    Console.WriteLine($"Кількість записів у таблиці {table}: {rowCount}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка: " + ex.Message);
                }
            }

            return rowCount;
        }
        public Account GetUserATM(string table, int id=-1,string selecteditem="",string value = "")
        {
            Account userAtm = null;
            int userId = 0;
            string name = "";
            string phoneNumber = "";
            string numberCard = "";
            string pin = "";
            int costInCard = 0;

            string connectionString = "Server=localhost;Database=dblab1;User=root;Password=root;";
            if (id > 0)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    try
                    {
                        connection.Open();
               

                        string query = $"SELECT * FROM {table} WHERE id = {id}";
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userId = reader.GetInt32("id");
                                name = reader.GetString("name");
                                phoneNumber = reader.GetString("phonenumber");
                                numberCard = reader.GetString("numbercard");
                                pin = reader.GetString("pin");
                                costInCard = reader.GetInt32("costincard");

                                userAtm = new Account(userId, name, phoneNumber, numberCard, pin, costInCard);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Помилка: " + ex.Message);
                        return userAtm;
                    }
                }
                userAtm = new Account(userId, name, phoneNumber, numberCard, pin, costInCard);
                return userAtm;
            }
            if (id==-1)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    try
                    {
                        connection.Open();
          

                        string query = $"SELECT * FROM {table} WHERE {selecteditem} = {value}";
                        MySqlCommand cmd = new MySqlCommand(query, connection);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userId = reader.GetInt32("id");
                                name = reader.GetString("name");
                                phoneNumber = reader.GetString("phonenumber");
                                numberCard = reader.GetString("numbercard");
                                pin = reader.GetString("pin");
                                costInCard = reader.GetInt32("costincard");

                                userAtm = new Account(userId, name, phoneNumber, numberCard, pin, costInCard);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Err User==null");
                        Console.WriteLine("Помилка: " + ex.Message);
                        return userAtm;
                    }
                }
                userAtm = new Account(userId, name, phoneNumber, numberCard, pin, costInCard);
                return userAtm;
            }
            Console.WriteLine("Err User==null");
            return userAtm;
        }
        public static int ReturnId(string numbercard,string pin,string phonenumber="")
        {
            int id = -1; 

            string connectionString = "Server=localhost;Database=dblab1;User=root;Password=root;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
           
                    string query;
                    if (phonenumber == "")
                    {
                         query = $"SELECT id FROM users WHERE numbercard = @numbercard AND pin = @pin;";
                    }
                    else
                    {
                         query = $"SELECT id FROM users WHERE numbercard = @numbercard AND pin = @pin AND phonenumber = @phonenumber";
                    }
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    
                    cmd.Parameters.AddWithValue("@numbercard", numbercard);
                    cmd.Parameters.AddWithValue("@pin", pin);
                    if(phonenumber != "") 
                    cmd.Parameters.AddWithValue("@phonenumber", phonenumber);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        id = Convert.ToInt32(result); 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка: " + ex.Message);
                }
            }
           
            return id;

           
        }
        public static void ReloadDB(Account userATM)
        {
            string connectionString = "Server=localhost;Database=dblab1;User=root;Password=root;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                 

                    string query = $"UPDATE users SET name = @name, phonenumber = @phonenumber, numbercard = @newnumbercard, pin = @pin, costincard = @costincard WHERE id = {userATM.GetID()}";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    
                    cmd.Parameters.AddWithValue("@name", userATM.GetName());
                    cmd.Parameters.AddWithValue("@phonenumber", userATM.GetPhoneNumber());
                    cmd.Parameters.AddWithValue("@newnumbercard", userATM.GetNumberCard());
                    cmd.Parameters.AddWithValue("@pin", userATM.GetPin());
                    cmd.Parameters.AddWithValue("@costincard", userATM.GetCostInCard());


                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
              
                    }
                    else
                    { 
                        Console.WriteLine("Не вдалося оновити дані в таблиці.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка: " + ex.Message);
                }

            }
        }
    }

}

