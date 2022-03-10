using System;
using System.Collections.Generic;
using System.Globalization;

namespace architekturaSystemowKomputerowych
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dataToCollect = new string[] { "AL", "AH", "BL", "BH", "CL", "CH", "DL", "DH" };
            var records = new List<string>() { };
            
            foreach(var data in dataToCollect)
            {
                Console.WriteLine($"Provide record data for {data}");
                string userData = Console.ReadLine();
                while (!CheckCorrection(userData))
                {
                    Console.WriteLine($"You provided wrong data for {data}");
                    userData = Console.ReadLine();
                }
                records.Add(userData);
            }

            var microController = new MicroController(records);
            microController.PrintRecords();
        }

        public static bool CheckCorrection(string valToCheck)
        {
            if (valToCheck.Length != 2) return false;
            if (!Int32.TryParse(valToCheck, NumberStyles.HexNumber, null, out int n)) return false;

            return true;
        }
    }
}
