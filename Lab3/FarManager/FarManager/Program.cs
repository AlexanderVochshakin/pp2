﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarManager
{
    class Program
    {
        static void ShowFolderContent(DirectoryInfo cur, int pos)
        {
            FileSystemInfo[] data = cur.GetFileSystemInfos();
            for (int i = 0; i < data.Length; i++)
            {
                if (i == pos)
                    Console.BackgroundColor = ConsoleColor.White;
                else
                    Console.BackgroundColor = ConsoleColor.Black;

                if (data[i].GetType() == typeof(DirectoryInfo))
                    Console.ForegroundColor = ConsoleColor.Gray;
                else
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(data[i].Name);
            }
        }

        static void DisplayFiles(string path)
        {

            Console.CursorVisible = false;
            FileStream file = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader readFile = new StreamReader(file);
            string text = readFile.ReadToEnd();

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(text);

            file.Close();
            readFile.Close();

            ConsoleKeyInfo btn = Console.ReadKey();
            while (btn.Key != ConsoleKey.Escape)
            {
                btn = Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int pos = 0;
            DirectoryInfo dir = new DirectoryInfo(@"C:\test");
            while (true)
            {
                Console.Clear();
                ShowFolderContent(dir, pos);
                ConsoleKeyInfo btn = Console.ReadKey();
                switch (btn.Key)
                {

                    case ConsoleKey.UpArrow:
                        pos--;
                        if (pos < 0)
                            pos = dir.GetFileSystemInfos().Length - 1;
                        break;

                    case ConsoleKey.DownArrow:
                        pos++;
                        if (pos >= dir.GetFileSystemInfos().Length)
                            pos = 0;
                        break;

                    case ConsoleKey.Enter:
                        FileSystemInfo f = dir.GetFileSystemInfos()[pos];
                        if (f.GetType() == typeof(DirectoryInfo))
                        {
                            dir = new DirectoryInfo(f.FullName);
                        }
                        else
                        {
                            string v = f.FullName;
                            DisplayFiles(v);
                        }
                        break;

                    case ConsoleKey.Escape:
                        dir = dir.Parent;
                        break;
                }
            }
        }
    }
}