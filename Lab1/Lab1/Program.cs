using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //#1
        //Вивести вміст списку по 10 елементів в рядку так, щоб висновок відбувався по спіралі, тобто кожен другий рядок повинен виводитись задом наперед.
        List<int> list = new List<int>();
        for (int i = 1; i <= 100; i++)
        {
            list.Add(i);
        }
        int row = 10;
        int count = 0;
        bool reverse = false;
        for (int i = 0; i < list.Count; i++)
        {
            if (i != 0 && (decimal)i / row % 1 == 0)
            {
                reverse = !reverse;
                count++;
                Console.WriteLine();
            }
            if (!reverse)
            {
                Console.Write(list[i] + " ");
            }
            else
            {
                int index = 2 * (row * count) - i - 1 + row;
                Console.Write(list[index] + " ");
            }
        }
        Console.ReadKey();
        Console.Clear();

        //#2
        //Дано словник з масивами літер у значеннях ключа. Вивести на екран комбінації усіх літер, перебравши всі можливі комбінації літер різних ключів словника.
        //Вхідний словник : {'1':['A','d'], '2':['C','B']}. Вихідний результат ACAB dCdB

        var dict = new Dictionary<int, List<char>>()
        {
            { 1, new List<char> {'A', 'd'} },
            { 2, new List<char> {'C', 'B'} }
        };

        List<string> combinations = new List<string>();
        GenerateCombinations(dict, "", 1, combinations);

        foreach (string value in combinations)
        {
            Console.Write(value + " ");
        }

        Console.ReadKey();
        Console.Clear();

        //#3
        //Дана послідовність непустих рядків A. Отримати послідовність символів, кожен елемент якої є початковим символом відповідного рядка з A.
        //Порядок символів повинен бути зворотним до порядку елементів вихідної послідовності. (3)

        List<string> strings = new List<string>()
        {
            "Hello",
            "my",
            "name",
            "is",
            "Tim"
        };

        var symbols = strings.Select(x => x[0]).Reverse();
        
        foreach (var x in symbols)
        {
            Console.Write(x + " ");
        }
        Console.ReadKey();
    }

    public static void GenerateCombinations(Dictionary<int, List<char>> dictionary, string current, int index, List<string> combinations)
    {
        if (index > dictionary.Count)
        {
            combinations.Add(current);
            return;
        }

        foreach (char c in dictionary[index])
        {
            GenerateCombinations(dictionary, current + c, index + 1, combinations);
        }
    }
}