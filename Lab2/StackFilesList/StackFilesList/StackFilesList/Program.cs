using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackFileViewer
{
    class Program
    {
        static void ShowFilesList(string path, int depth = 0)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] dirs = dir.GetDirectories();

            Stack<string> stack = new Stack<string>();

            foreach (DirectoryInfo d in dirs)
            {
                stack.Push(d.Name);
                for (int i = 0; i < depth; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(stack.Pop());
                ShowFilesList(d.FullName, depth + 5);
            }

            foreach (FileInfo f in files)
            {
                stack.Push(f.Name);
                for (int i = 0; i < depth; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(stack.Pop());
            }
        }

        static void Main(string[] args)
        {
            ShowFilesList(@"C:\Users\Админ\Desktop\Procedural Buildings in UE4 with Houdini_files");
            Console.ReadKey();
        }
    }
}
