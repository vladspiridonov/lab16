using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace склад_товаров
{
    class Товар
    {
        public int КодТовара { get; set; }
        public string НазваниеТовара { get; set; }
        public double Цена { get; set; }
       /* public Товар(int КодТовара, string НазваниеТовара, double Цена)
        {
            this.КодТовара = КодТовара;
            this.НазваниеТовара = НазваниеТовара;
            this.Цена = Цена;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Код Товара: {КодТовара}\nНазваниеТовара: {НазваниеТовара}\nЦена: {Цена}");
        }*/
    }
}
