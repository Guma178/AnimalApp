using AnimalApp.Abstract_classes;
using AnimalApp.Classes;
using AnimalApp.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Group<Insecta> insectas = new Group<Insecta>();
            Group<Ostracoda> ostracodas = new Group<Ostracoda>();
            Group<Mammalia> mammalia = new Group<Mammalia>();

            for (byte i =0; i<10; i++)
            {
                if (i % 2 == 0)
                {
                    insectas.Push(new LucanusСervus(1, 10, 1000000));
                    mammalia.Push(new Human(100, 180, 3000000));
                }
                else
                {
                    insectas.Push(new Geotrupidae(3, 12, 600000));
                    mammalia.Push(new Bear(160, 90, 100000));
                }
            }
            insectas.Push(new LucanusСervus(5, 10, 1000001));
            mammalia.Push(new Bear(161, 90));

            insectas.Print();
            mammalia.Print();

            Console.ReadLine();
        }
    }
}
