using MicroProcessor;
using System.Globalization;

namespace MicroProcessor
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] dataToCollect = { "AL", "AH", "BL", "BH", "CL", "CH", "DL", "DM" };
            var records = new List<string> { };

            foreach (var data in dataToCollect)
            {
                Console.WriteLine($"Provide record data for {data}");
                string providedData = Console.ReadLine();

                while (!CheckCorrection(providedData))
                {
                    Console.WriteLine($"You provided wrong data for {data}");
                    providedData = Console.ReadLine();
                }
                records.Add(providedData.ToUpper());
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
