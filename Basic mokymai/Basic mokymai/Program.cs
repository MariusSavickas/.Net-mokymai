﻿namespace Basic_mokymai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.Write("išvedimas ");
            Console.Write("vienoje ");
            Console.Write("eiluteje ");
            Console.WriteLine();
            Console.WriteLine("tekstas kitoje eilutėje");
            Console.Write("tekstas");

            Console.WriteLine("--------------------------");
            Console.WriteLine("išvedimas "+ "vienoje " + "eilutėje "); //konkatinacija
            Console.WriteLine("{0} {1} {2}", "išvedimas", "vienoje", "eilutėje"); //kompozicija
            Console.WriteLine($"{"išvedimas "}{"vienoje "}{"eilutėje "}"); //interpoliacija
            Console.WriteLine("--------------------------");


            Console.WriteLine("tekstas įdedamas į \"kabutes\" ");
            Console.WriteLine($"tekstas {Environment.NewLine}\nįdedamas \r\nį \n\"kabutes\" ");
            Console.WriteLine("tekstas \tįdedamas \tį \t\"kabutes\" ");


            Console.WriteLine("-----Press any key to continue------");
            Console.ReadKey();
            Console.Clear();

            //Console.WriteLine("Įveskite savo vardą, o aš jį pakartosiu");
            //Console.WriteLine("o štai mano pakartojimas: " + Console.ReadLine());
            //Console.WriteLine("o štai mano pakartojimas: {0} ",  Console.ReadLine());
            //Console.WriteLine($"o štai mano pakartojimas: {Console.ReadLine()}");

            //Console.WriteLine("Įveskitę raidę ");
            //var key = Console.ReadKey();
            //Console.WriteLine("Įvestas simbolis {0}", key.KeyChar);
            //Console.WriteLine("Įvestas simbolis {0}", key.Key);
            //Console.WriteLine("Įvestas simbolis {0}", (int)key.KeyChar);

            //Console.WriteLine("Įvestas simbolis {0}", Console.ReadKey().KeyChar);
            //Console.WriteLine("Įvestas simbolis {0}", (int)Console.ReadKey().KeyChar);

            Console.WriteLine("Įveskite savo vardą, o aš atspėsiu pirmą raidę ");
            Console.WriteLine("o štai mano pakartojimas:" + Console.ReadLine()[0]);



            Console.ReadKey();
        }
    }
}