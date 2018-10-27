using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SemiToJson.DAL;
using SemiToJson.Models;

namespace SemiToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO - Create random file with information for example: Privat;52233152522;QVABS;1;2;3;4;5;END;

            //List<QVab> qvabList = new List<QVab>
            //{
            //    new QVab(1),
            //    new QVab(2)
            //};

            //TestObject testObject = new TestObject("Företag", "55551234567", qvabList);

            TestData testData = new TestData();
            //string stringOfTestObjects = Connection.ReadFile();
            //var listOfObjects = testData.GetTestData(stringOfTestObjects);
            
            string output4 = "";

            //foreach (var a in listOfObjects)
            //{
            //    output4 += JsonConvert.SerializeObject(a, Formatting.Indented);
            //}

            output4 = JsonConvert.SerializeObject(testData.GetTestData(Connection.ReadFile()), Formatting.Indented);

            Console.WriteLine(output4);

            Console.ReadLine();

            // Connection.CreateFile(testData.GetTestData(20));

            string dataStringToFix = Connection.ReadFile();

            string[] arrayStringToFix = dataStringToFix.Split(';');

            // dataStringToFix.Trim(); -> test if this one could have been used instead of TrimEnd in Connection.

            string dataStringToFix2 = testData.CreateTestData1(20);
            dataStringToFix2 = dataStringToFix2.TrimEnd(';');

            
            string[] arrayStringToFix2 = dataStringToFix2.Split(';');

            // Read random file and create JSON-string

            string output = JsonConvert.SerializeObject(arrayStringToFix, Formatting.Indented);
            string output2 = JsonConvert.SerializeObject(arrayStringToFix2, Formatting.Indented);
            // string output3 = JsonConvert.SerializeObject(testObject, Formatting.Indented);

            // Print example on console
            Console.WriteLine(output);
            Console.WriteLine(output2);
            // Console.WriteLine(output3);


            // Randomizer and 11-modul


        }
    }
}
