using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemiToJson.Models
{
    public enum AccountTypes
    {
        Privat, Företag, Koncern
    }
    public class TestData
    {
        public List<TestObject> GetTestData(string semicolonText)
        {
            List<TestObject> testObjects = new List<TestObject>();

            string[] testDataArray = semicolonText.Split(';');

            for (int i = 0; i < testDataArray.Length; i++)
            {
                if (testDataArray[i] == "Privat" || testDataArray[i] == "Företag" || testDataArray[i] == "Koncern")
                {
                    TestObject testObject = new TestObject();
                    testObject.AccountType = testDataArray[i];
                    i++;
                    testObject.AccountNumber = testDataArray[i];
                    i++;
                    if (testDataArray[i] == "QVABS")
                    {
                        i++;
                        while (testDataArray[i] != "END")
                        {
                            QVab qvab = new QVab();
                            qvab.QvabNumber = Convert.ToInt32(testDataArray[i]);
                            testObject.QVabs.Add(qvab);
                            i++;
                        }
                    }
                    testObjects.Add(testObject);
                }
            }

            return testObjects;
        }

        public string CreateTestData1(int numberOfAccounts)
        {
            string stringBack = "";

            Random numberRandom = new Random();

            for (int i = 0; i < numberOfAccounts; i++)
            {
                string accountNumber = "123456789AB";
                for (int a = 0; a < 11; a++)
                {
                    int newNumber = numberRandom.Next(10);
                    accountNumber = accountNumber.Replace(accountNumber[a].ToString(), newNumber.ToString());
                }

                int typeOfAccount = numberRandom.Next(0, 3);

                if (typeOfAccount == Convert.ToInt32(AccountTypes.Företag))
                {
                    stringBack += AccountTypes.Företag.ToString();
                }else if(typeOfAccount == Convert.ToInt32(AccountTypes.Koncern))
                {
                    stringBack += AccountTypes.Koncern.ToString();
                }else if(typeOfAccount == Convert.ToInt32(AccountTypes.Privat))
                {
                    stringBack += AccountTypes.Privat.ToString();
                }
                else
                {
                    stringBack += "Märkligt konto";
                }

                stringBack += ';' + accountNumber + ';';
            }

            return stringBack;
        }
    }
}
