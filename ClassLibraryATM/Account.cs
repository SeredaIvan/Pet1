using System.Runtime.CompilerServices;

namespace ProgramLibraryATM
{
    public class Account
    {

        public Account(int id,string name, string phonenumber, string numbercard, string pin, int costincard)
        {
            ID = id;
            Name = name;
            Phonenumber = phonenumber;
            Numbercard = numbercard;
            Pin = pin;
            Costincard = costincard;
            LastOperation = 0;
        }
        private int ID { get; set; }
        private string Name { get;set; }

        private string Phonenumber{ get;set; }
   
        private string Numbercard { get;set; }

        private string Pin{ get;set; }

        private int Costincard{ get;set; }
        private int LastOperation { get; set; }
        public void SetCost(int cost)
        {
            Costincard += cost;
            LastOperation = cost;
        }
        public void MinusCost(int cost)
        {
            Costincard -= cost;
            LastOperation = -cost;
        }
        public int GetLastOperation()
        {
            return LastOperation;
        }
        public int GetID()
        {
            return ID;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetPhoneNumber()
        {
            return Phonenumber;
        }
        public string GetNumberCard()
        {
            return Numbercard;
        }
        public string GetPin()
        {
            return Pin;
        }
        public int GetCostInCard()
        {
            return Costincard;
        }

        
    }
}