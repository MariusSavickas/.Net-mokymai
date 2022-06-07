namespace Kintamieji_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("String (tekstinio) tipo kintamieji");
            string kintamasis = "Hello World";
            Console.WriteLine(kintamasis);

            var stringkintamasis = "belekoks tekstas";
            string tuščias = "";
            string mulas = null;
            string laisvaerdvė = "   ";

            String tekstas = "";

            String konkatinacija = stringkintamasis + kintamasis;
            Console.WriteLine(konkatinacija);
            string kompozicija = string.Format("{0}", stringkintamasis);
            String interpoliacija = $"{stringkintamasis}";

            kintamasis1 = "tekstas belekoks";
            Console.WriteLine(kintamasis);
             




        }
    }
}