using System.Text;
using MySql.Data.MySqlClient;

namespace ClassLibraryATM
{
    public class DBMySQL
    {
        string connectionString = "Server=localhost;Database=lab1db;User=root;Password=root;CharSet=utf8mb4;";

        public void ToGet(string table,string selectitem,string selecteditem)
        {
            
           
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connect succes");
                    
                    string query = $"SELECT * FROM {table} WHERE id = 1";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string selected = reader.GetString($"{selecteditem}");


                        Console.WriteLine($"Selected: {selected}");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Помилка: " + ex.Message);
                }
            }
        }
        public void Send(string table, int id, string name, string phonenumber, string newnumbercard, string pin)
        {
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connect successful");



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
                        Console.WriteLine($"Дані успішно вставлені в таблицю {table}");
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
        public void SendID(string table,int id)
        {


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connect successful");



                    string query = $"INSERT INTO {table} (id) VALUES (@value) ";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Додаємо параметр для захисту від SQL-ін'єкцій
                    cmd.Parameters.AddWithValue("@value", id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine($"Дані успішно вставлені в таблицю {table}");
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
                Console.WriteLine($"Колонка id створена");
            } 
        }
            
        public int GetRowCount(string table)
        {
            int rowCount = 0;
            string connectionString = "Server=localhost;Database=lab1db;User=root;Password=root;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Connect successful");

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
    }

}

