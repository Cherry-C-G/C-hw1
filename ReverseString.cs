﻿using System;
public class ReverseString
{
    public static void Main()
    {
        string str, str1 = "";
        int i, l;

        Console.Write("Input  A String : ");
        str = Console.ReadLine();

        l = str.Length - 1;
        for (i = l; i >= 0; i--)
        {

            str1 = str1 + str[i];


        }

        Console.WriteLine("The string in Reverse  Order Is : {0}", str1);
        Console.Write("\n");

    }
}
