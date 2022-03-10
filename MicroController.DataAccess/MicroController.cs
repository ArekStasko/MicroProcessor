namespace MicroController.DataAccess
{
    public class MicroController : IMicroController
    {
        public string AL { get; }
        public string AH { get; }
        public string BL { get; }
        public string BH { get; }
        public string CL { get; }
        public string CH { get; }
        public string DL { get; }
        public string DH { get; }

        public MicroController(List<string> recordsData)
        {
            AL = recordsData[0];
            AH = recordsData[1];
            BL = recordsData[2];
            BH = recordsData[3];
            CL = recordsData[4];
            CH = recordsData[5];
            DL = recordsData[6];
            DH = recordsData[7];
        }
    }
}