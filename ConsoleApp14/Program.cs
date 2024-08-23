using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        public static double Convertor(double temp, double start, double end)
        {
            if (temp >= start && temp <= end)
            {
                return temp;
            }
            else
            {
                Console.WriteLine("Помилка!");
            }
            return 0;
        }
        public static double CtoF(double temp)
        {
          return Convertor(temp*9/5+32, 0, 100);
        }
        public static double CtoK(double temp)
        {
            return Convertor(temp + 273, 0, 100);
        }
        public static double FtoK(double temp)
        {
            return Convertor((temp + 459) * 5 / 9, 32, 212);
        }
        public static double FtoC(double temp)
        {
            return Convertor((temp -32) * 5 / 9, 32, 212);
        }
        public static double KtoC(double temp)
        {
            return Convertor(temp-273, 273, 373);
        }
        public static double KtoF(double temp)
        {
            return Convertor(temp*9/5-459, 32, 212);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Вкажіть, з якої температури ви бажаєте здійснити конвертацію \nВаріанти: Цельсій, Фаренгейт, Кельвін ");
            string start = Console.ReadLine();
            Console.WriteLine("Вкажіть, в яку температуру ви бажаєте здійснити конвертацію \nВаріанти: Цельсій, Фаренгейт, Кельвін ");
            string finish = Console.ReadLine();
            Console.WriteLine("Вкажіть температуру, яку ви хотіли б конвертувати");
            double temerature = Convert.ToDouble(Console.ReadLine());

            if (start == "Цельсій" &&  finish == "Фаренгейт")
            {
               Console.WriteLine( CtoF(temerature) + "F");
            }
            else if (start == "Цельсій" && finish == "Кельвін")
            {
                Console.WriteLine(CtoK(temerature) + "K");
            }
            else if (start == "Фаренгейт" && finish == "Кельвін")
            {
                Console.WriteLine(FtoK(temerature) + "K");
            }
            else if(start =="Фаренегейт" &&  finish == "Цельсій")
            {
                Console.WriteLine(FtoC(temerature)+"C");
            }
            else if (start == "Кельвін" && finish == "Цельсій")
            {
                Console.WriteLine(KtoC(temerature) + "C");
            }
            else if (start == "Кельвін" && finish == "Фаренгейт")
            {
                Console.WriteLine(KtoF(temerature) + "F");
            }
            else if (start == finish)
            {
                Console.WriteLine(temerature);
            }
            else
            {
                Console.WriteLine("Помилка");
            }

        }
    }
}
