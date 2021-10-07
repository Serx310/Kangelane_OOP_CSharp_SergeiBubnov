using System;
using System.Collections.Generic;
using System.IO;

namespace OOP_Kangelane
{
    class Program
    {
        private static List<Kangelane> kangelased = new();
        private static void LaeKangelased(string failinimi)
        {
            Console.WriteLine(File.ReadAllText(failinimi));
            string[] nimedLinnad = File.ReadAllLines(failinimi);
            foreach(var rida in nimedLinnad)
            {
                string nimi = rida.Substring(0, rida.IndexOf("/")-1);
                string asukoht = rida.Substring(rida.IndexOf("/")+2);
                if (nimi.EndsWith("*"))
                {
                    kangelased.Add(new Superkangelane(nimi.Substring(0, nimi.Length-1), asukoht));
                }
                else
                {
                    kangelased.Add(new Kangelane(nimi, asukoht));
                }
            }
        }
        static void Main(string[] args)
        {
            Kangelane batman = new Kangelane("Batman", "Gotham");
            Console.WriteLine(batman.ToString());

            Superkangelane superman = new Superkangelane("Superman", "Metropolis");
            Console.WriteLine(superman.ToString());
            LaeKangelased("Kangelased.txt");
            foreach(var hero in kangelased)
            {
                Console.WriteLine(hero + "\n Päästis 1000/" + hero.Päästa(1000));
            }
        }
    }
}
