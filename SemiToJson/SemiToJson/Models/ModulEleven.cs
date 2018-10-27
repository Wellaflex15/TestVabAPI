using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemiToJson.Models
{
    public class ModulEleven
    {
        int nr1, nr2, nr3, nr4, nr5, nr6, nr7, nr8, nr9, nrA, nrB;
        string newAccountNumber;

        public ModulEleven(string accountNumber)
        {
            nr1 = accountNumber[0];
            nr2 = accountNumber[1];
            nr3 = accountNumber[2];
            nr4 = accountNumber[3];
            nr5 = accountNumber[4];
            nr6 = accountNumber[5];
            nr7 = accountNumber[6];
            nr8 = accountNumber[7];
            nr9 = accountNumber[8];
            nrA = accountNumber[9];
            nrB = accountNumber[10];

        }

        // Checks if account is Modul 11, if it's not it will change it.
        public string ModulElevenChecker()
        {

            return newAccountNumber;
        }
    }
}
