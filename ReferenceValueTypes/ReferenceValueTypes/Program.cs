using System;

namespace ReferenceValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework

            //Console.WriteLine("Input reversed text:");
            //string text = Console.ReadLine();
            //Console.WriteLine(ReverseString(text));

            #endregion

            #region Value types

            //int a = 10;
            //int b = a;
            //b = 5;

            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");

            #endregion

            #region Reference types

            //arr - a101
            //arr2 - a101
            //int[] arr = { 1, 2, 3, 4 };
            //int[] arr2 = arr;
            //arr2[0] = 10;

            //Console.WriteLine($"Arr[0] = {arr[0]}");
            //Console.WriteLine($"Arr2[0] = {arr2[0]}");

            #endregion

            #region Ref keyword

            //int a = 10;
            //ChangeNumber(ref a);
            //Console.WriteLine($"Main: {a}");

            #endregion

            #region Out keyword

            //int a;
            //ChangeNumber2(out a);
            //ChangeNumber2(out int a);
            //Console.WriteLine($"Main: {a}");

            #endregion

            #region String

            //string text = "Hello P320!";
            //Console.WriteLine(text.ToUpper());
            //Console.WriteLine(text.ToLower());

            //string name = "Orkhan";
            //string name2 = "orkhan";
            //string name3 = $"{name2[0]}";

            //Console.WriteLine(name.ToLower().Equals(name2.ToLower()));

            //string text = "    Hello     ";
            //Console.WriteLine(text.Trim());
            //Console.WriteLine(text.TrimEnd());
            //Console.WriteLine(text.TrimStart());

            //string text = "Hello";
            //Console.WriteLine(text.Contains("a"));
            //Console.WriteLine(text.Contains('e'));

            //string names = "Elnur, Orkhan, Perviz";
            //string[] result = names.Split(", ");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item + " P320");
            //}

            //Ekrandan bir uzun string daxil edirsiz
            //Meselen: Hello P320 Qrupu!
            //Netice: olleH 023P upurQ

            #endregion
        }

        #region Ref keyword

        static void ChangeNumber(ref int number)
        {
            number = 5;
            Console.WriteLine($"ChangeNumber: {number}");
        }

        #endregion

        #region Out keyword

        static void ChangeNumber2(out int number)
        {
            number = 5;
            Console.WriteLine($"ChangeNumber2: {number}");
        }

        #endregion

        #region Homework

        static string ReverseString(string text)
        {
            string result = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                result += text[i];
            }

            return result;
        }

        #endregion
    }
}
