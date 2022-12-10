using Cairo;
using System;
using System.IO;
using System.Text.RegularExpressions;
using VisioForge.Libs.MediaFoundation.OPM;

namespace lr5
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^(a|a{5}|a aa a)$");
            string[] input = File.ReadAllLines(@"test.txt");
            for (int i = 0; i < input.Length; i++)
            {
                if (regex.IsMatch(input[i]))
                {
                    Console.WriteLine(" OK ");
                }
                else
                {
                    Console.WriteLine("Not OK ");
                }
            }


            Regex regex2 = new Regex(@"[a-zA-Z0-9]{5,}");
            string[] input2 = File.ReadAllLines(@"test.txt");
            for (int i = 0; i < input2.Length; i++)
            {
                if (regex2.IsMatch(input2[i]))
                {
                    Console.WriteLine(" OK,введено не менее 5 алфавитно-цифровых символов. ");
                }
                else
                {
                    Console.WriteLine(" Not OK, введено менее 5 алфавитно-цифровых символов. ");
                }
            }


            Regex regex3 = new Regex(@"^[A-Z0-9a-z._%+-]+@[A-Z0-9a-z-]+.+.[A-Za-z]{2,4}$");
            string[] input3 = File.ReadAllLines(@"test.txt");
            for (int i = 0; i < input3.Length; i++)
            {
                if (regex3.IsMatch(input3[i]))
                {
                    Console.WriteLine("OK, корректный адрес почты");
                }
                else
                {
                    Console.WriteLine("Not OK, не корректный адрес почты");
                }
            }

            Regex regex4 = new Regex(@"\s?([^\d]+\s)\s?(\d+.*)*");
            string[] input4 = File.ReadAllLines(@"test.txt");
            for (int i = 0; i < input4.Length; i++)
            {
                if (regex4.IsMatch(input4[i]))
                {
                    Console.WriteLine("Ул: ,дом: ");
                }
                else
                {
                    Console.WriteLine("Не найдено!");
                }
            }


        }
    }
}