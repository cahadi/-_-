using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace что_это
{
    class Program
    {
        static void Main(string[] args)
        {
            //Страшно, очень страшно, мы не знаем что это такое, если бы мы знали что это такое, мы бы знали, что это такое 6L.до42   117I.до136   160P до 170; цифр в первом столбце, вроде, 389.
            //я не поняла, что имелось ввиду в 3-й части, поэтому вывела названия спеллов классов

            
            //1
            int k1 = 0, k2 = 0, k3 = 0, k4=0, k5=0,n=0, b=0, c=0, d=0, r=0, ws=0;
            string path = @"C:\Users\user\Desktop\spells.2da";
            string line1 = File.ReadAllLines(path).First();
            string line2 = File.ReadAllLines(path).Skip(1).First();
            string line = File.ReadAllLines(path).Skip(2).First();
            char[] s = new char[] {' ' };
            string[] subs = line.Split(s, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < subs.Length; i++)
            {
                if (subs[i] == "Label")
                {
                    Console.Write($"{subs[i]}    ");
                    k1 = i;
                }
                if (subs[i] == "ImpactScript")
                {
                    Console.Write($"{subs[i]}    ");
                    k2 = i;
                }
                if (subs[i] == "Paladin")
                {
                    Console.Write($"{subs[i]}    ");
                    k3 = i;
                }
                if (subs[i] == "ImmunityType")
                    k5 = i;
                if (subs[i] == "Acid")
                    k4 = i;
                if (subs[i] == "Name")
                    n = i;
                if (subs[i] == "Bard")
                    b = i;
                if (subs[i] == "Cleric")
                    c = i;
                if (subs[i] == "Druid")
                    d = i;
                if (subs[i] == "Ranger")
                    r = i;
                if (subs[i] == "Wiz_Sorc")
                    ws = i;
            }
            Console.WriteLine();
            for (int i = 3; i<line.Length; i++)
            {
                line = File.ReadAllLines(path).Skip(i).First();
                char[] s1 = new char[] {' '};
                string[] sub = line.Split(s1, StringSplitOptions.RemoveEmptyEntries);
                if (sub[k3 + 1] != "****")
                {
                    Console.Write($"{sub[k1 + 1]}    ");
                    Console.Write($"{sub[k2 + 1]}    ");
                    Console.Write($"{sub[k3 + 1]}    ");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string path1 = @"C:\Users\user\Desktop\spells2.2da";
            //File.Create(path1);
            string[] lines = new string[] { $"{line1}\n{line2}"};
            File.WriteAllLines(path1, lines);
            File.ReadAllLines(path1);
            for (int g = 3; g < line.Length; g++)
            {
                line = File.ReadAllLines(path).Skip(g).First();
                char[] s1 = new char[] { ' ' };
                string[] sub = line.Split(s1, StringSplitOptions.RemoveEmptyEntries);
                if (sub[k5 + 1] != "****")
                {
                    Console.Write($"{sub[k4 + 1]}    ");
                    Console.Write($"{sub[k5 + 1]}    ");
                    File.AppendAllText(path1, $"{sub[k4 + 1]}    {sub[k5 + 1]}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            string Bard = @"C:\Users\user\Desktop\Bard.2da";     //b
            //File.Create(Bard);
            for (int g = 3; g < line.Length; g++)
            {
                line = File.ReadAllLines(path).Skip(g).First();
                char[] s1 = new char[] { ' ' };
                string[] sub = line.Split(s1, StringSplitOptions.RemoveEmptyEntries);
                if (sub[b + 1] != "****")
                {
                    Console.Write($"{sub[n + 1]}    ");
                    Console.Write($"{sub[b + 1]}    ");
                    File.AppendAllText(Bard, $"{sub[n + 1]}    {sub[b + 1]}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            string Cleric = @"C:\Users\user\Desktop\Cleric.2da";      //c
            //File.Create(Cleric);
            for (int g = 3; g < line.Length; g++)
            {
                line = File.ReadAllLines(path).Skip(g).First();
                char[] s1 = new char[] { ' ' };
                string[] sub = line.Split(s1, StringSplitOptions.RemoveEmptyEntries);
                if (sub[c + 1] != "****")
                {
                    Console.Write($"{sub[n + 1]}    ");
                    Console.Write($"{sub[c + 1]}    ");
                    File.AppendAllText(Cleric, $"{sub[n + 1]}    {sub[c + 1]}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            string Druid = @"C:\Users\user\Desktop\Druid.2da";     //d
            //File.Create(Druid);
            for (int g = 3; g < line.Length; g++)
            {
                line = File.ReadAllLines(path).Skip(g).First();
                char[] s1 = new char[] { ' ' };
                string[] sub = line.Split(s1, StringSplitOptions.RemoveEmptyEntries);
                if (sub[d + 1] != "****")
                {
                    Console.Write($"{sub[n + 1]}    ");
                    Console.Write($"{sub[d + 1]}    ");
                    File.AppendAllText(Druid, $"{sub[n + 1]}    {sub[d + 1]}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            string Paladin = @"C:\Users\user\Desktop\Paladin.2da";   //k3
            //File.Create(Paladin);
            for (int g = 3; g < line.Length; g++)
            {
                line = File.ReadAllLines(path).Skip(g).First();
                char[] s1 = new char[] { ' ' };
                string[] sub = line.Split(s1, StringSplitOptions.RemoveEmptyEntries);
                if (sub[k3 + 1] != "****")
                {
                    Console.Write($"{sub[n + 1]}    ");
                    Console.Write($"{sub[k3 + 1]}    ");
                    File.AppendAllText(Paladin, $"{sub[n + 1]}    {sub[k3 + 1]}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            string Ranger = @"C:\Users\user\Desktop\Ranger.2da";     //r
            //File.Create(Ranger);
            for (int g = 3; g < line.Length; g++)
            {
                line = File.ReadAllLines(path).Skip(g).First();
                char[] s1 = new char[] { ' ' };
                string[] sub = line.Split(s1, StringSplitOptions.RemoveEmptyEntries);
                if (sub[r + 1] != "****")
                {
                    Console.Write($"{sub[n + 1]}    ");
                    Console.Write($"{sub[r + 1]}    ");
                    File.AppendAllText(Ranger, $"{sub[n + 1]}    {sub[r + 1]}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            string Wiz_Sorc = @"C:\Users\user\Desktop\Wiz_Sorc.2da";     //ws
            //File.Create(Wiz_Sorc);
            for (int g = 3; g < line.Length; g++)
            {
                line = File.ReadAllLines(path).Skip(g).First();
                char[] s1 = new char[] { ' ' };
                string[] sub = line.Split(s1, StringSplitOptions.RemoveEmptyEntries);
                if (sub[ws + 1] != "****")
                {
                    Console.Write($"{sub[n + 1]}    ");
                    Console.Write($"{sub[ws + 1]}    ");
                    File.AppendAllText(Wiz_Sorc, $"{sub[n + 1]}    {sub[ws + 1]}");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}

