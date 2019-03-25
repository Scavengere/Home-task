using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Task3
{
    class WorkingWithFile
    {
        public static Product[] ReadFromFile(string fileName)           
        {
            string[][] inputLine = null;
            try
            {
                inputLine = File.ReadAllLines(fileName, Encoding.Default).Select(e => e.Split(new char[] { '|' })).ToArray();
            }
            catch(FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"~~~File {fileName} is not found~~~\n~~~The program will be closed~~~");
                Console.ResetColor();
                Console.ReadKey();
                Environment.Exit(-1);
            }
            int numberOfPruduct = 0;
            int i = 0;
            Product[] array = new Product[numberOfPruduct];
            foreach (string[] tmp in inputLine)
            {
                numberOfPruduct++;
                Array.Resize(ref array, numberOfPruduct);
                array[i] = new Product();
                array[i].NameOfProduct = tmp[0];
                array[i].AmountOfProduct = Int32.Parse(tmp[1]);
                array[i].PriceOfProduct = Int32.Parse(tmp[2]);
                i++;
            }
            return array;
        }
        public void WriteToFile(Product[] array, string fileName)           
        {
            int i = 0;
            string[] output = new string[array.Length];
            foreach (Product tmp in array)
            {
                output[i] = tmp.NameOfProduct + "|" + tmp.AmountOfProduct + "|" + tmp.PriceOfProduct;
                i++;
            }
            File.WriteAllLines(fileName, output, Encoding.Default);
        }
    }
}
