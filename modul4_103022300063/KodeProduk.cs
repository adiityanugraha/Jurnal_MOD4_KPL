using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300063
{
    class KodeProduk
    {
        private static Dictionary<string, string> kodeProduk = new Dictionary<string, string>
        {
            {"Laptop", "E100"},
            {"Smartphone", "E101" },
            {"Tablet", "E102" },
            {"Headset", "E103" },
            {"Keyboard", "E104" },
            {"Mouse", "E105" },
            {"Printer", "E106" },
            {"Monitor", "E107" },
            {"Smartwatch", "E108" },
            {"Kamera", "E109" }
        };

        public static string GetKodeProduk(string namaProduk)
        {
            if (kodeProduk.TryGetValue(namaProduk, out string KodeProduk))
            {
                return KodeProduk;
            }
            else
            {
                return "Produk tidak ditemukan";
            }
        }
    }
}
