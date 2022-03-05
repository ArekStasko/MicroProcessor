using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroProcessor
{
    public class MicroController
    {
        public string AL { get; set; }
        public string AH { get; set; }
        public string BL { get; set; }
        public string BH { get; set; }
        public string CL { get; set; }
        public string CH { get; set; }
        public string DL { get; set; }
        public string DM { get; set; }

        public MicroController(List<string> recordsData)
        {
            AL = recordsData[0];
            AH = recordsData[1];
            BL = recordsData[2];
            BH = recordsData[3];
            CL = recordsData[4];
            CH = recordsData[5];  
            DL = recordsData[6];
            DM = recordsData[7];
        }

        public void PrintRecords()
        {
            Console.WriteLine($"AL : {AL}; AH : {AH}; BL: {BL}; BH : {BH}; CL : {CL}; CH: {CH}; DL: {DL}; DM : {DM}");
        }

    }
}
