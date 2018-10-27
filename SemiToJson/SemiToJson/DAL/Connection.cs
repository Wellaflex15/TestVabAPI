using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemiToJson.DAL
{
    public static class Connection
    {

        // In this program I'm reading from a textfile but it could be comming from an API
        // public const string FilePath = @"C:\Users\david\Desktop\testData\test.txt";
        public const string FilePath = @"D:\Skrivbord\JsonTest\testData\zomfsTestData.txt";
        private static string inputHolder;

        public static void CreateFile(List<string> listInput)
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                }

                using (FileStream fs = File.Create(FilePath))
                {
                    
                    foreach(var item in listInput)
                    {
                        inputHolder += item + ';';
                    }
                    inputHolder = inputHolder.TrimEnd(';');
                    byte[] input = new UTF8Encoding(true).GetBytes(inputHolder);
                    fs.Write(input, 0, input.Length);

                    Console.WriteLine($"File created with following text:\n{inputHolder}");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public static void CreateFile(string stringInput)
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    File.Delete(FilePath);
                }

                using (FileStream fs = File.Create(FilePath))
                {

                    byte[] input = new UTF8Encoding(true).GetBytes(stringInput);
                    fs.Write(input, 0, input.Length);

                    Console.WriteLine($"File created with following text:\n{inputHolder}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public static string ReadFile()
        {
            try
            {
                string s;
                string textBack = "";

                // using (StreamReader sr = File.OpenText(FilePath))
                using (StreamReader sr = new StreamReader(FilePath, System.Text.Encoding.Default))
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        textBack += s;
                        // Console.WriteLine(s);
                    }

                }

                return textBack;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error in ReadFile" + ex.ToString());
                return "Error in ReadFile";
            }
        }

    }
}
