﻿namespace DemoHomeTask_22_10_23;

public class TaskThirdTen
{
    public static void Run()
    {
        List<string> listChars = new List<string>() { "a", "q", "o", "a", "f", "s" };

        char[] charset1 = { 'X', 'Y', 'Z', 'W' };

        int[] numset1 = { 1, 2, 3, 4 };

        string[] colorset1 = { "Green", "Orange", "Yellow", "Pink" };

        // Task 21
        //listChars.ForEach(x => Console.Write(x + " "));

        //Console.Write("\n\nQancha harfni o'chirib tashlamoqchisiz: ");
        //int nstr21 = int.Parse(Console.ReadLine()!);

        //listChars.RemoveRange(1, nstr21);

        //listChars.ForEach(x => Console.Write(x + " "));

        // Task 22
        //List<string> liststr = new List<string>();
        //string tempList = string.Empty;

        //Console.Write("Nechta kiritmoqchisiz: ");
        //int n22 = int.Parse(Console.ReadLine()!);

        //for (int i = 0; i < n22; i++)
        //{
        //    Console.Write("Element[{0}]: ", i);
        //    liststr.Add(Console.ReadLine()!);
        //}

        //Console.Write("\nQancha uzunlikdagi ma'lumotni qidirmoqchisiz? (eng kami) : ");
        //int intInput = Convert.ToInt32(Console.ReadLine());

        //var result22 = (from x in liststr
        //                where x.Length >= intInput
        //                orderby x
        //                select x).ToList();

        //result22.ForEach(x => Console.WriteLine(x + " "));

        // Task 23
        //var result23 = charset1.SelectMany(x => numset1.Select(y => y + ' ')).ToList();

        //result23.ForEach(x => Console.WriteLine(x + " "));

        // Task 24
        //var result24 = (from letter in charset1
        //                from number in numset1
        //                from color in colorset1
        //                select new { letter, number, color }).ToList();

        //var _result24 = charset1
        //    .SelectMany(letterList => numset1.Select(numList =>
        //    new
        //    {
        //        letterList,
        //        numList
        //    }))
        //    .SelectMany((set1and2) => colorset1.Select(colorList =>
        //    new
        //    {
        //        set1and2.letterList,
        //        set1and2.numList,
        //        colorList
        //    })).ToList();

        //result24.ForEach(x => Console.WriteLine(x + " "));
        ////_result24.ForEach(x => Console.WriteLine(x + " "));

        // Task 25





    }
}
