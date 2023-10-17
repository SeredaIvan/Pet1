using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryATM
{
    public class Bank
    {
        private string NameOfBank { get; set; }

        List<AutomatedTellerMachine>AutomatedTellerMachins { get; set; }
        private int Indexer { get; set; }

        private int SelectedBank { get; set; }
        public Bank(string nameOfBank, List<AutomatedTellerMachine> automatedTellerMachins)
        {
            NameOfBank = nameOfBank;
            AutomatedTellerMachins = automatedTellerMachins;
            Indexer = -1;
            SelectedBank = -1;
        }
        public string GetName()
        {
            return NameOfBank;
        }
        public int GetIndexer()
        {
            return Indexer;
        }
        public int GetSelectedBank()
        {
            return SelectedBank;
        }
        public void SetIndexer(int ind)
        {
            Indexer=ind;
        }
        public void SetSelectedBank(int ind)
        {
            SelectedBank = ind;
        }
        public List<AutomatedTellerMachine> GetAllATM()
        {
            return AutomatedTellerMachins;

        }
        public AutomatedTellerMachine GetIndexATM(int index)
        {
           
            return AutomatedTellerMachins[index];

        }
    }
}
