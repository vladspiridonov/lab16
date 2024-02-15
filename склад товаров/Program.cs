using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace склад_товаров
{
    class Program
    {
        static void Main(string[] args)
        {
            const int N = 2;
            Товар[] товар = new Товар[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Товар [{0}]", i);
                Console.Write("Код: ");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.Write("Название: ");
                string name = Console.ReadLine();
                Console.Write("Цена: ");
                double cost = Convert.ToDouble(Console.ReadLine());
                товар[i] = new Товар() { КодТовара = code, НазваниеТовара = name, Цена = cost };
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(товар, options);
            Console.WriteLine(jsonString);
            string path = @"C:\Users\Aorus\YandexDisk\Прога курс\Проги\lab16\goods.json";
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine(jsonString);
            }

            //товар[0].ShowInfo();
            //товар[1].ShowInfo();
            Console.ReadKey();


            //Товар[] товар = new Товар(Convert.ToInt32(Console.ReadLine()), Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));
        }
    }
}
