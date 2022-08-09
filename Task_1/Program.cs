using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.Угол задан с помощью целочисленных значений gradus - градусов, 
 * min - угловых минут, sec - угловых секунд. 
 * Реализовать класс, в котором указанные значения представлены в виде свойств. 
 * Для свойств предусмотреть проверку 
 * корректности данных. Класс должен содержать конструктор для установки 
 * начальных значений, а также метод ToRadians 
 * для перевода угла в радианы. Создать объект на основе разработанного класса. 
 * Осуществить использование объекта в программе.*/

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Перевод градусов в радианы");
            Console.WriteLine();
            Console.WriteLine("Введите значения угла в градусах");

            Console.Write("\t*градусы - ");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("\t*минуты - ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("\t*секунды - ");
            int sec = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Degrees degrees = new Degrees(gradus, min, sec);

            Console.WriteLine("Значение угла в радианах - {0}", degrees.ToRadians());
            Console.ReadKey();
        }
    }
}
