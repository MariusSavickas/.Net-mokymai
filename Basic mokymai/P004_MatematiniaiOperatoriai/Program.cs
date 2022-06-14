using System.Text;
namespace P004_MatematiniaiOperatoriai
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Hello, Priskyrimo operatoriai = += -= *= /=");
            int skaicius;
            int kitasSkaicius = 20;
            int nelyginisSkaicius = 5;
            skaicius = 10;
            kitasSkaicius = skaicius;
            Console.WriteLine($" skaicius = {skaicius}, kitas skaicius = {kitasSkaicius}");

            kitasSkaicius += nelyginisSkaicius;
            Console.WriteLine($" kitasSkaicius = {kitasSkaicius}");

            kitasSkaicius -= nelyginisSkaicius;
            Console.WriteLine($" kitasSkaicius = {kitasSkaicius}");

            kitasSkaicius *= nelyginisSkaicius;
            Console.WriteLine($" kitasSkaicius = {kitasSkaicius}");

            kitasSkaicius = 21;

            kitasSkaicius /= nelyginisSkaicius;
            Console.WriteLine($" kitasSkaicius = {kitasSkaicius}");

            double doubleSkaicius = 21;
            doubleSkaicius /= nelyginisSkaicius;    
            Console.WriteLine($" kitasSkaicius = {doubleSkaicius}");

            Console.WriteLine();
            Console.WriteLine("Hello, matematiniai operatoriai + - * / % ++ -- ");

            //sudetis
            int suma = skaicius + kitasSkaicius;

            Console.WriteLine($" suma =skaicius+kitasSkaicius = {suma}");

            //atimitis
            int atimtis = skaicius - kitasSkaicius;

            Console.WriteLine($" atimtis =skaicius-kitasSkaicius = {atimtis}");


            //daugyba
            int daugyba = skaicius * kitasSkaicius;

            Console.WriteLine($" daugyba =skaicius*kitasSkaicius = {daugyba}");

            //dalyba
            double dalyba = (double)skaicius / kitasSkaicius;

            Console.WriteLine($" dalyba =skaicius/kitasSkaicius = {dalyba}");

            int matematinisRezultatas = 1 + 2 - 3 + 4 + nelyginisSkaicius - skaicius;
            Console.WriteLine(matematinisRezultatas);

            var dalybaSuLiekana = nelyginisSkaicius % 2;
            Console.WriteLine($" dalybasuliekana = nelyginisskaicius {dalybaSuLiekana}");

            skaicius++; //vienu dideja
            Console.WriteLine($" skaicius ={skaicius}");

            skaicius--; //vienu sumazeja
                Console.WriteLine($"skaicius = {skaicius}");

            //area of a trapezoid
            double side1 = 5.5;
            double side2 = 3.25;
            double height = 4.6;
            double area = (side1 + side2) / 2 * height;
            Console.WriteLine(area);

            Console.OutputEncoding = Encoding.UTF8; //Encoding.UTF8;
            int nulis = 0;
            int int10 = 10;
            long long10 = 10;
            double double10 = 10;

            //Console.WriteLine($" int10/nulis = {int10/nulis}"); //Luzta
            //Console.WriteLine($" long10/nulis = {long10/nulis}"); //Luzta
            Console.WriteLine($" double10/nulis = {double10/nulis}"); //grazina 

            //***** )verflow and Underflow
            short s1 = 30_000;
            short s2 = 30_000;
            short s3 = (short)(s1 + s2);
            Console.WriteLine($" s3={s3}");

            /*PARAŠYTI PROGRAMĄ, KURIOJE VARTOTOJO PRAŠOMA ĮVESTI 2 SKAIČIUS.PROGRAMA TURI IŠVESTI
• SKAIČIŲ SUMĄ
• SKAIČIŲ SKIRTUMĄ
• SANDAUGĄ
• DALYBĄ
*/
            /* Mano variantas
            string skaicius1 = Console.ReadLine();
            string skaicius2 = Console.ReadLine();
            int skaiciuspo1 = Convert.ToInt16(skaicius1);
            int skaiciuspo2 = Convert.ToInt16(skaicius2);

            Console.WriteLine($" Suma= {skaiciuspo1+skaiciuspo2}");
            Console.WriteLine($" atimtis= {skaiciuspo1 - skaiciuspo2}");
            Console.WriteLine($" daugyba= {skaiciuspo1 * skaiciuspo2}");
            Console.WriteLine($" dalyba= {skaiciuspo1 / skaiciuspo2}");
            */

            Console.WriteLine( "Iveskite pirma sk");
            int skaicius1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra sk");
            int skaicius2 = int.Parse(Console.ReadLine());
            Console.WriteLine($" {skaicius1} + {skaicius2} = {skaicius1 + skaicius2}");
            Console.WriteLine($" {skaicius1} - {skaicius2} = {skaicius1 - skaicius2}");
            Console.WriteLine($" {skaicius1} * {skaicius2} = {skaicius1 * skaicius2}");
            Console.WriteLine($" {skaicius1} / {skaicius2} = {skaicius1 / skaicius2}");

            // 3 sk. vidurkis
            Console.WriteLine("Iveskite pirma sk");
            int skaicius3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra sk");
            int skaicius4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite trecia sk");
            int skaicius5 = int.Parse(Console.ReadLine());

            Console.WriteLine($" {(double)(skaicius3+skaicius4+skaicius5)/3}");

            /*
sukurkite naują kintamajį long ir prskirkite didžiausią reikšmę.
sukurkite naują kintamajį short ir prskirkite didžiausią reikšmę
- padalinkite didesnį skaičių iš mažesnio
- iš rezultato atimkite maksimalų long skaičių
- ir pridėkite maksimalų int skaičių

*/
            long naujassk = long.MaxValue;
            short naujassort = short.MaxValue;


            Console.WriteLine($" dalyba = {naujassk/naujassort}"    );
            Console.WriteLine($"dalybos rez - lon.maxvalue {naujassk/naujassort-naujassk}");

            int naujasint = int.MaxValue;
            Console.WriteLine($"dalybos rez - lon.maxvalue {naujassk / naujassort - naujassk+naujasint}");



        }
    }
}