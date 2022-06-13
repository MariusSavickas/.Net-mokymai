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




        }
    }
}