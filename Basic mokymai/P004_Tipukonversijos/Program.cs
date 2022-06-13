namespace P004_Tipukonversijos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Tipo konversijos");
            //Implicit casting
            int skaiciusInt = 100;
            long skaiciusLong = 100;
            long castintasLong = (long)skaiciusInt;
            long castintasLong1 = skaiciusInt; //tipo konversija daroma automatiskai

            var castintasLong2 = (long)skaiciusInt;

            byte skaiciusByte = 200;
            int skaiciusInt2 = skaiciusByte;
            long skaiciusLong2 = skaiciusByte;
            long skaiciusLong3 = skaiciusInt2;
            float skaiciusFloat = skaiciusByte;
            float skaiciusFloat2 = skaiciusInt2;
            float skaiciusFloat3 = skaiciusLong2;

            double skaiciusDouble = skaiciusByte;
            double skaiciusDouble2 = skaiciusInt2;
            double skaiciusDouble3 = skaiciusLong2;
            double skaiciusDouble4 = skaiciusFloat2;
            decimal skaiciusDecimal = skaiciusByte;
            //Byte>short>int>long>float>double>decimal


            //Explicit casting
            int castintasInt = (int)skaiciusLong;
            //decimal>double>float>long>int>char
            float fl = 5.6f;
            int castintasInt1 = (int)fl;
            Console.WriteLine("i={0}", castintasInt1);

            char skaiciusRaide = 'a';
            int castintasInt2 = skaiciusRaide;
            Console.WriteLine($" castintasInt2= {castintasInt2}");
            long castintasLong3 = skaiciusRaide;
            // char>ushort>int>uint>long>ulong>float>double>decimal

            //negalima
            //string a = "a";
            //int CastintasInt3 = (int)a;

            long skaiciusLongDidesnis = 3_000_000_000;
            int castintasint4 = (int)skaiciusLongDidesnis;
            Console.WriteLine($" castintas4 = {castintasint4}");

            long SkaiciusLongDarDidesnis = long.MaxValue;
            int castintasInt5 = (int)SkaiciusLongDarDidesnis;
            Console.WriteLine($" castintasInt5 = {castintasInt5}");

            //***onversion Methods

            string konvertuotasString = Convert.ToString(skaiciusInt);
            string KonvertuotasString1 = skaiciusInt.ToString();
            long konvertuotasLong = Convert.ToInt64(skaiciusInt);
            double konvertuotasDouble = Convert.ToDouble(skaiciusInt);

            //int konvertuotasInt = Convert.ToInt32(skaiciusLongDidesnis); //Luzta nes netlepa skaicius. per didelis

            //darbas su nullable tipais
            int? skaiciusIntNull = null;
            //long castintasLong5 = (long)skaiciusIntNull; //Luzta.
            long konvertavimasLong1 = Convert.ToInt64(skaiciusIntNull);
            Console.WriteLine($" konvertuotasLong1 ={konvertavimasLong1} ");

            //parsinimas
            string skaiciusString = "100";
            string skaiciusDidelisString = "999999999999999999";
                int skaiciusStringparsintas = int.Parse(skaiciusString);
            Console.WriteLine($" skaiciusString + 1 = {skaiciusString +1}");
            Console.WriteLine($" skaiciusIntparsintas +1 = {skaiciusStringparsintas + 1}");

            //int skaiciusIntParsintas1 = int.Parse(skaiciusDidelisString);
            //int tekstasIntParsintas = int.Parse(tekstas);







        }
    }
}