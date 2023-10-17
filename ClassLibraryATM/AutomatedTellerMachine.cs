using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryATM
{
    public class AutomatedTellerMachine
    {
        private int IdATM{ get; set; }
        private int CostsInATM { get; set; }

        private string Adress { get; set; }

        public AutomatedTellerMachine(int idATM, int costsinATM,string adress)
        {
            IdATM = idATM;
            CostsInATM = costsinATM;
            Adress = adress;


        }
        public void SetCostInATM(int costsinATM)
        {
            CostsInATM = costsinATM;
        }
        public void MinusCostInATM(int lastOperation)
        {
            CostsInATM += lastOperation;
        }
        public void PlusCostInATM(int lastOperation)
        {
            CostsInATM += lastOperation;
        }
        public string GetAdress()
        {
            return Adress;
        }
        public int GetCostInATM()
        {
            return CostsInATM;

        }
        public int GetIdATM() {
            return IdATM;
                }
    }
}
