using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mains();

        }

        static void Mains()
        {
            int opition = 0;
            Console.Clear();
            while (true)
            {
                Console.WriteLine("features:\n[1]Basic\n[2]Intermediate Features\n[3]Creative Features\n[4]Math Game");
                opition = int.Parse(Console.ReadLine());
                if (opition == 1)
                {
                    Basic();
                }
                if (opition == 2)
                {
                    inter();
                }
                if (opition == 3)
                {
                    create();
                }
                if (opition == 4)
                {
                    game();
                }
            }
        }

        static void game()
        {
            int vic = 0;
            int op = 0;
            float res;
            Console.WriteLine("let's start the games:");
            float num1, num2;
            Random random = new Random();
            res = 0;
            while (true)
            {

                op = random.Next(0, 5);
                if (res == 11111)
                {
                    break;

                }
                switch (op)
                {
                    case 0:
                        if (vic > 30)
                        {
                            num1 = random.Next(-500, 501);
                            num2 = random.Next(-500, 501);
                        }
                        else if (vic > 20)
                        {
                            num1 = random.Next(-100, 251);
                            num2 = random.Next(-100, 251);
                        }
                        else if (vic > 10)
                        {
                            num1 = random.Next(-50, 101);
                            num2 = random.Next(-50, 101);
                        }
                        else
                        {
                            num1 = random.Next(0, 101);
                            num2 = random.Next(0, 101);
                        }
                        Console.WriteLine("type 11111 to exit\nnumber of wins:" + vic + "\nhow much is it:" + num1 + "+" + num2);
                        res = float.Parse(Console.ReadLine());
                        if (res == 11111)
                        {
                            break;
                        }
                        if (res == (num1 + num2))
                        {
                            Console.WriteLine("got it right!");
                            vic += 1;
                        }
                        else
                        {
                            Console.WriteLine("made a mistake!");
                        }
                        break;
                    case 1:
                        if (vic > 30)
                        {
                            num1 = random.Next(-500, 501);
                            num2 = random.Next(-500, 501);
                        }
                        else if (vic > 20)
                        {
                            num1 = random.Next(-100, 251);
                            num2 = random.Next(-100, 251);
                        }
                        else if (vic > 10)
                        {
                            num1 = random.Next(-50, 101);
                            num2 = random.Next(-50, 101);
                        }
                        else
                        {
                            num1 = random.Next(0, 101);
                            num2 = random.Next(0, 101);
                        }
                        Console.WriteLine("type 11111 to exit\nnumber of wins:" + vic + "\nhow much is it:" + num1 + "-" + num2);
                        res = float.Parse(Console.ReadLine());
                        if (res == 11111)
                        {
                            break;

                        }
                        if (res == (num1 - num2))
                        {
                            Console.WriteLine("got it right!");
                            vic += 1;
                        }
                        else
                        {
                            Console.WriteLine("made a mistake!");
                        }

                        break;
                    case 2:
                        if (vic > 30)
                        {
                            num1 = random.Next(-500, 501);
                            num2 = random.Next(-500, 501);
                        }
                        else if (vic > 20)
                        {
                            num1 = random.Next(-100, 251);
                            num2 = random.Next(-100, 251);
                        }
                        else if (vic > 10)
                        {
                            num1 = random.Next(-50, 101);
                            num2 = random.Next(-50, 101);
                        }
                        else
                        {
                            num1 = random.Next(0, 101);
                            num2 = random.Next(0, 101);
                        }
                        Console.WriteLine("type 11111 to exit\nnumber of wins:" + vic + "\nhow much is it:" + num1 + "x" + num2);
                        res = float.Parse(Console.ReadLine());
                        if (res == 11111)
                        {
                            break;
                        }
                        if (res == (num1 * num2))
                        {
                            Console.WriteLine("got it right!");
                            vic += 1;
                        }
                        else
                        {
                            Console.WriteLine("made a mistake!");
                        }
                        break;
                    case 3:
                        if (vic > 30)
                        {
                            num1 = random.Next(-500, 501);
                            num2 = random.Next(-500, 501);
                        }
                        else if (vic > 20)
                        {
                            num1 = random.Next(-100, 251);
                            num2 = random.Next(-100, 251);
                        }
                        else if (vic > 10)
                        {
                            num1 = random.Next(-50, 101);
                            num2 = random.Next(-50, 101);
                        }
                        else
                        {
                            num1 = random.Next(0, 101);
                            num2 = random.Next(0, 101);
                        }
                        Console.WriteLine("type 11111 to exit\nnumber of wins:" + vic + "\nhow much is it:" + num1 + "/" + num2);
                        res = float.Parse(Console.ReadLine());
                        if (res == 11111)
                        {
                            break;

                        }
                        if (res == Math.Round(num1 / num2))
                        {
                            Console.WriteLine("got it right!!");
                            vic += 1;
                        }
                        else
                        {
                            Console.WriteLine("made a mistake!");
                        }
                        break;

                }
            }
        }

        static void create()
        {
            double basic = 0;
            Console.Clear();
            while (true)
            {
                Console.WriteLine("[1]Geometric Calculator \n[2]Unit Converter \n[3]Quadratic Equation\n[4]clear \n[5]return to menu.");
                basic = double.Parse(Console.ReadLine());
                if (basic == 1)
                {
                    CalgeoM();
                }
                if (basic == 2)
                {
                    Converso();
                }
                if (basic == 3)
                {
                    EcoaC();
                }
                if (basic == 4)
                {
                    Console.Clear();
                }
                if (basic == 5)
                {
                    Console.Clear();
                    break;
                }
            }
        }

        static void EcoaC()
        {
            Console.WriteLine("Enter the coefficients a, b and c of the quadratic equation (ax^2+bx+ c= 0):");
            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double discri = b * b - 4 * a * c;

            if (discri > 0)
            {
                double x1 = (-b + Math.Sqrt(discri)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discri)) / (2 * a);

                Console.WriteLine($"Two solutions : x1 = " + x1 + ", x2 = " + x2);
            }
        }
        static void Converso()
        {
            Console.Clear();
            double count1;
            double count2;
            double basico;
            Console.WriteLine("indicate which value you want to convert:\n[7]MM [6]CM [5]DM [4]M [3]DAM [2]HM [1]KM");
            count1 = double.Parse(Console.ReadLine());
            Console.WriteLine("indicate which value you want to convert to:\n[7]MM [6]CM [5]DM [4]M [3]DAM [2]HM [1]KM");
            count2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Now indicate the value you want to convert:");
            basico = double.Parse(Console.ReadLine());
            if (basico == 0 || (count1 - count2) == 0)
            {
                Console.WriteLine("you did something wrong, check the values.");
            }
            else
            {
                if ((count1 - count2) > 0)
                {
                    for (int i = 0; i < (count1 - count2); i++)
                    {
                        basico = basico / 10;
                    }
                    Console.WriteLine("The converted value is:" + basico);
                }
                else if ((count1 - count2) < 0)
                {
                    for (int i = 0; i < (count2 - count1); i++)
                    {
                        basico = basico * 10;
                    }
                    Console.WriteLine("The converted value is:" + basico);
                }
            }

        }
        static void CalgeoM()
        {
            Console.Clear();
            double basic;
            Console.WriteLine("Do you want to calculate the area of: [1] square [2] rectangle [3] circle [4] triangle");
            basic = double.Parse(Console.ReadLine());
            if (basic == 1 || basic == 2)
            {
                double side1 = 0;
                double side2 = 0;
                double total = 0;
                Console.WriteLine("indicate a side:");
                side1 = double.Parse(Console.ReadLine());
                Console.WriteLine("indicate another side:");
                side2 = double.Parse(Console.ReadLine());
                total = (side1 * side2);
                Console.WriteLine("the area is:" + total);
            }
            if (basic == 3)
            {
                double pi = Math.PI;
                double total;
                double raio;
                Console.WriteLine("enter the radius:");
                raio = double.Parse(Console.ReadLine());
                double radiusQ = Math.Pow(raio, 2);
                total = pi * radiusQ;
                Console.WriteLine("the total area is:" + total);
            }
            if (basic == 4)
            {
                double total, SS;
                double side1, side2, side3;
                Console.WriteLine("put one side of the triangle:");
                side1 = double.Parse(Console.ReadLine());
                Console.WriteLine("put another side of the triangle:");
                side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("put the last side of the triangle:");
                side3 = double.Parse(Console.ReadLine());
                if (side1 > side2 + side3 || side2 > side1 + side3 || side3 > side2 + side1)
                {
                    Console.WriteLine("This is not a triangle, check the size of the sides.");
                }
                else
                {
                    SS = (side1 + side2 + side3) / 2;
                    total = Math.Sqrt(SS * (SS - side1) * (SS - side2) * (SS - side3));
                    Console.WriteLine("the total area is:" + total);
                }

            }

        }


        static void inter()
        {
            double basic;
            Console.Clear();
            while (true)
            {
                Console.WriteLine("[1]Factorial [2]check prime number [3]clear [4]return to menu.");
                basic = double.Parse(Console.ReadLine());
                if (basic == 1)
                {
                    Console.WriteLine(factorial());
                }
                if (basic == 2)
                {
                    primo();

                }
                if (basic == 3)
                {
                    Console.Clear();
                }
                if (basic == 4)
                {
                    Console.Clear();
                    break;
                }

            }

        }

        static void primo()
        {
            double num, sum = 0;
            Console.WriteLine("Enter the number you want to check:");
            num = double.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum - 1 == num)
            {
                Console.WriteLine("esse numero é primo.");
            }
            else
            {
                Console.WriteLine("this number is not prime.");
            }
        }

        static string factorial()
        {
            int num;
            int total = 1;
            Console.WriteLine("indique o numero que fara o fatorial:");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                total *= i;
            }
            return "o fatorial de " + num + " é " + total;

        }




        static void Basic()
        {
            Console.Clear();
            while (true)
            {

                double basic, num1, num2;
                Console.WriteLine("Enter the operation you want to do: [1]addition [2]subtraction [3]multiplication [4]division [5]clear [6]return to menu.");
                basic = int.Parse(Console.ReadLine());
                if (basic == 1 || basic == 2 || basic == 3 || basic == 4)
                {
                    Console.WriteLine("insert the first number:");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("enter the second number:");
                    num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine(Operacao(num1, num2, basic));
                }
                else if (basic == 6)
                {
                    Console.Clear();
                    break;
                }
                else if (basic == 5)
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("invalid operation, try again");
                }


            }

        }

        static string Operacao(double n1, double n2, double op)
        {
            if (op == 1)
            {
                return "the result of the sum is: " + (n1 + n2);
            }
            if (op == 2)
            {
                return "the result of the subtraction is: " + (n1 - n2);
            }
            if (op == 3)
            {
                return "the result of multiplication is: " + (n1 * n2);
            }
            if (op == 4)
            {
                if (n1 == 0 || n2 == 0)
                {
                    return "invalid operation, a number is equal to 0, try again.";
                }
                else
                {
                    return "the result of the division is: " + (n1 / n2);
                }
            }

            return " ";
        }

    }
}
