using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemiToJson.Models
{
    public class TestObject
    {
        public string AccountType { get; set; } //AccountType : Företag
        public string AccountNumber { get; set; } //AccountNumber : 54551234567
        public List<QVab> QVabs { get; set; } = new List<QVab>(); //QVabs : 1 KIR, 2 KONTO, 3 KALLE, 4 PELLE, 5 NISSE, osv.
         
        public TestObject() { }

        public TestObject(string accountType, string accountNumber, List<QVab> qvabs)
        {
            AccountType = accountType;
            AccountNumber = accountNumber;
            foreach (QVab qvab in qvabs)
            {
                QVabs.Add(qvab);
            }
        }
    }
}
