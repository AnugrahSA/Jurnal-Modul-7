using System.Text.Json;
using System.Diagnostics;

namespace modul7_1302204047
{
    public class BankTransferConfig
    {
        public string CONFIG1 { get; set; } = "en";
        public int CONFIG2 { get; set; } = 150000;
        public int CONFIG3 { get; set; } = 6500;
        public int CONFIG4 { get; set; } = 25000000;
        public string CONFIG5 { get; set; } = "RTO(real-time)";
        public string CONFIG6 { get; set; } = "yes";
        public string CONFIG7 { get; set; } = "no";

        public string lang { get; set; }
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
        public string methods { get; set; }
        public string en { get; set; }
        public string id { get; set; }
        public void ReadJSON()
        {
            string jsonText = File.ReadAllText("bank_transfer_config.json");
            BankTransferConfig json = JsonSerializer.Deserialize<BankTransferConfig>(jsonText);
            Debug.Assert(json != null);

            this.lang = json.lang;
            this.threshold = json.threshold;
            this.low_fee = json.low_fee;
            this.high_fee = json.high_fee;
            this.methods = json.methods;
            this.en = json.en;
            this.id = json.id;
        }
    }
}
