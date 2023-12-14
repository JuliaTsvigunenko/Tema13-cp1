using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1 способ
            //Phone phone = new Phone();
            //phone.manufacturer = "Apple";
            //phone.model = "iPhone";
            //phone.price = 7000;
            //Console.WriteLine(phone.ToString());

            ////2 способ
            //Phone phone1 = new Phone("Xiaomi", "Redmi", 3500);
            //Console.WriteLine(phone1.ToString());

            ////3 способ 
            //Console.Write("Введите производителя телефона: ");
            //string manufacturer = Console.ReadLine();
            //Console.Write("Введите модель телефона: ");
            //string model = Console.ReadLine();
            //Console.Write("Введите цену телефона: ");
            //double price =Convert.ToDouble( Console.ReadLine());
            //Phone phone2 = new Phone(manufacturer, model, price);
            //Console.WriteLine(phone2.ToString());




            Student student = new Student();
            student.Fam = "Иванов";
            student.Kurs = -4;
            Console.WriteLine(student.ShowInfo());

            Student student1 = new Student("", -7);
            Console.WriteLine(student1.ShowInfo());


            Console.ReadKey();





        }
    }
}
