using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Goods;
using System.Text.Json;

namespace check
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Aorus\YandexDisk\Прога курс\Проги\lab16\goods.json";
            string str = File.ReadAllText(path);
            
            Товар[] товар = JsonSerializer.Deserialize<Товар[]>(str);
            Товар МахЦена = товар[0];
            foreach(Товар t in товар)
            {
                if (t.Цена > МахЦена.Цена)
                    МахЦена = t;
            }
            Console.WriteLine($"Код Товара: {МахЦена.КодТовара}\nНазваниеТовара: {МахЦена.НазваниеТовара}\nЦена: {МахЦена.Цена}");
            Console.ReadKey();
        }
    }
}
