namespace Naujas06._07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("komentarai");
            Console.WriteLine("kokie būna komentarai");
            //Čia paprastas komentas
            /*
             čia multi line
            komentarai
            */
            Console.WriteLine(); //komentaras
            var kintamasis = /*kažkoks komentaras */ "galima taip";

            Console.WriteLine("kodėl reikia rašyti komentarus");
            Console.WriteLine("kaip rašyti gerus komentarus");
            /*
             * 1. reikia rašyti komentarus kodo gabalui, kuris yra funkciškai išbaigtas
             * 2. rašyti komentarus, kurie prideda kodui prasmės, o ne tiesiog pasako ką kodas daro
             */

            //Blogaskomentaras
            //Console.WriteLine naudojamas į ekraną išvesti Hello World
            Console.WriteLine("Hello World");
            /*
             * Juk ir taip aišku ką daro kodas.. išmokime skaityti kodą
             */

            //Geras komentaras
            //išvesti Hello World tai mano pirmoji veikianti programa
            Console.WriteLine("Hello World");

        }
    }
}