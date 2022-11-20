using System;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>{ "H", "J" ,"a", "e"};
            IniFile ini = new IniFile();
            for(int i= 0; i < lst.Count; i++)
            {
                ini["Label"][i.ToString()] = $"{lst[i]}";
            }
            ini.Save("./Setting.ini");

            ini.Load("./Setting.ini");

            foreach (var i in ini["Label"])
                Console.WriteLine(i.Key + i.Value);

            Console.WriteLine("Hello World!");
        }
    }
}
