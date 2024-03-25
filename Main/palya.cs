﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public static class Palya
    {
        public static char[,] Letrehoz()
        {
            char[,] palya = new char[13,21];
            StreamReader sr = new StreamReader("maze.txt");
            int index = 0;
            while(!sr.EndOfStream)
            {
                var falak = sr.ReadLine().ToArray();
                int helper = 0;
                foreach (var fal in falak)
                {
                    palya[index,helper] = fal;
                    helper++;
                }
                index++;
                helper = 0;
            }
            sr.Close();
            return palya;
        }

        public static void Kiir(char[,] palya)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Clear();
            for (int i = 0; i < palya.GetLength(0); i++)
            {
                for (int j = 0; j < palya.GetLength(1); j++)
                {
                    if(palya[i, j] == '&' || palya[i, j] == '$' ) { Console.Write(" "); }
                    else
                        Console.Write(palya[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
