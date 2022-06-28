namespace Savarankiskos2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Žaidimas atspėk skaičių");

            /*
             ŽAIDIMAS ATSPĖK SKAIČIŲ
    - ĮHARDKODINAMAS BETKOKS SKAIČIUS NUO 1 IKI 20
    - NAUDOTOJAS 6 KARTUS PRAŠOMAS ĮVESTI SKAIČIŲ NUO 1 IKI 20
    - JEI NAUDOTOJAS ĮVEDĖ TEISINGAI - IŠVEDAMAS SVEIKINIMAS "TEISINGAI" IR PROGRAMA STABDOMA
    - JEI NAUDOTOJAS ĮVEDĖ PER MAŽĄ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA DIDESNIS"
    - JEI NAUDOTOJAS ĮVEDĖ PER DIDELĮ SKAIČIŲ - IŠVEDAMAS PRANEŠIMAS "SKAIČIUS YRA MAŽESNIS"
    nutraukiant programos vykdymą Environment.Exit(0) ar pan. naudoti negalima. Naudoti if.
            */
            /*
            int sk = 12;
            Console.WriteLine("Atspėkite skaičių 1 bandymas");
            var sk1 = Convert.ToInt32(Console.ReadLine());
            if (sk1 == sk)
            {
                Console.WriteLine("Sveikinimas, teisingai");          
            }
            else if (sk1 > sk)
            {
                Console.WriteLine(" Skaicius yra mazesnis");
                Console.WriteLine("Atspėkite skaičių 2 bandymas");
                var sk2 = Convert.ToInt32(Console.ReadLine());
                if (sk2 == sk)
                {
                    Console.WriteLine("Sveikinimas, teisingai");
                }
                else if (sk2 > sk)
                {
                    Console.WriteLine(" Skaicius yra mazesnis");
                    Console.WriteLine("Atspėkite skaičių 3 bandymas");
                    var sk3 = Convert.ToInt32(Console.ReadLine());
                    if (sk2 == sk)
                    {
                        Console.WriteLine("Sveikinimas, teisingai");
                    }
                    else if (sk2 > sk)
                    {
                        Console.WriteLine(" Skaicius yra mazesnis");

                    }
                    else if (sk2 < sk)
                    {
                        Console.WriteLine("skaicius yra didesnis");

                    }

                }
                else if (sk1 < sk)
                {
                    Console.WriteLine("skaicius yra didesnis");
                    Console.WriteLine("Atspėkite skaičių 2 bandymas");
                    var sk2 = Convert.ToInt32(Console.ReadLine());
                }*/

            /* *SKAIČIUOTUVAS *
 Paprašykite naudotojo įvesti du skaičius ir matematinę operaciją(+, -, *arba / )
 - Parašykite programą kuri į ekraną išves skaičių rezultatą
 - naudokite if
 -naudokite switch
            */
            Console.WriteLine("Iveskite pirma skaiciu");
            var pirmas = Convert.ToInt32(Console.ReadLine());        
            Console.WriteLine("Iveskite antra skaiciu");
            var antras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Matematine operacija");
            var op = Console.ReadLine();

            if ( op == "+")
            {
                Console.WriteLine($"{pirmas + antras}");
            }
            else if ( op == "/")
            { 
                Console.WriteLine($"{pirmas / (double)antras}");
            }
            else if (op == "-")
            {
                Console.WriteLine($"{pirmas - antras}");
            }
            else if (op == "*")
            {
                Console.WriteLine($"{pirmas * antras}");
            }

            /*
             * Trys draugai *
- Sukurti metodą, kuris paprašytų vartotojo įvesti tris jo draugų vardus bei kiekvieno amžių.
- Nuskaičius duomenis atskirose eilutėse atspausdinti draugo vardą ir amžių.
- Atspausdinti draugų amžiaus vidurkį
- Surasti ir atspausdinti jauniausią draugą (vardą ir amžių).
- Surasti ir atspausdinti vyriausią draugą (vardą ir amžių).
<Hint> ieškant jauniausio, seniausio naudoti if sąlygos sakinius ir naudoti tik elementus ir
konstrukcijas kurias iki šiol išėjome.
            */

            Console.WriteLine("Iveskite pirmo draugo vardą");
            var vardas1 = Console.ReadLine();
            Console.WriteLine("Iveskite pirmo draugo amziu");
            var amzius1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antro draugo vardą");
            var vardas2 = Console.ReadLine();
            Console.WriteLine("Iveskite antro draugo amziu");
            var amzius2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite trecio draugo vardą");
            var vardas3 = Console.ReadLine();
            Console.WriteLine("Iveskite trecio draugo amziu");
            var amzius3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{vardas1}{amzius1}");
            Console.WriteLine($"{vardas2}{amzius2}");
            Console.WriteLine($"{vardas3}{amzius3}");

            Console.WriteLine($"Amziaus vidurkis: {(amzius1+amzius2+amzius3)/3}");

            //jauniausio draugo paieska
            if (amzius1 < amzius2)
            {
                if (amzius1 < amzius3)
                {
                    Console.WriteLine($"Jauniausias yra {vardas1} {amzius1}");
                }
                else if (amzius1 > amzius3)
                {
                    Console.WriteLine($"Jauniausias yra {vardas3}  {amzius3}");
                }
            }
            if (amzius1 > amzius2)
            {
                if (amzius2 < amzius3)
                {
                    Console.WriteLine($"Jauniausias yra {vardas2}  {amzius2}");
                }
                else if (amzius2 > amzius3)
                {
                    Console.WriteLine($"Jauniausias yra {vardas3}  {amzius3}");
                }
            }

            //Vyriausio draugo paieskos
            if (amzius1 > amzius2)
            {
                if (amzius1 > amzius3)
                {
                    Console.WriteLine($"Vyriausias yra {vardas1} {amzius1}");
                }
                else if (amzius1 < amzius3)
                {
                    Console.WriteLine($"Vyriausias yra {vardas3}  {amzius3}");
                }
            }
            if (amzius1 < amzius2)
            {
                if (amzius2 > amzius3)
                {
                    Console.WriteLine($"Vyriausias yra {vardas2}  {amzius2}");
                }
                else if (amzius2 < amzius3)
                {
                    Console.WriteLine($"Vyriausias yra {vardas3}  {amzius3}");
                }
            }


            /*
             * ** Kalėdų sausainiai **
- Paprašykite vartotojo įvesti betkokias 4 datas (tarkim 2013-12-24, 2020-12-22, 3000-12-24, 2021-03-03)
- Parašykite programą kuri nustato ar tarp įvestų datų yra kalėdos (gruodžio 24).
- Ir jei yra kalėdų data, išveda - "Jums priklauso nemokami kalėdiniai sausainiai"
- Jei nėra išveda - "Palaukite kalėdų"
Pavyzdzio atsakymas: "Jums priklauso nemokami kalėdų sausainiai"
<Hint> metodai data.Month ir data.Day
            */

            Console.WriteLine("Iveskite pirmo datą yyyy-mm--dd");
            var data1 = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite antra datą yyyy-mm--dd");
            var data2 = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite trecia datą yyyy-mm--dd");
            var data3 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite ketvirta datą yyyy-mm--dd");
            var data4 = DateTime.Parse(Console.ReadLine()); // DateTime arba DateOnly


            Console.WriteLine($"Ivesta {data1.ToString("yyyy-MM-dd")}, {data2.ToString("yyyy-MM-dd")}, {data3.ToString("yyyy-MM-dd")}, {data4.ToString("yyyy-MM-dd")}");

            if (data1.Month == 12 && data1.Day == 24)
            {
                Console.WriteLine("Jums priklauso nemokami sausainiai");
            }
            else if (data2.Month == 12 && data2.Day == 24)
            {
                Console.WriteLine("Jums priklauso nemokami sausainiai");
            }
            else if (data3.Month == 12 && data3.Day == 24)
            {
                Console.WriteLine("Jums priklauso nemokami sausainiai");
            }
            else if (data4.Month == 12 && data4.Day == 24)
            {
                Console.WriteLine("Jums priklauso nemokami sausainiai");
            }
            else
            {
                Console.WriteLine("Palaukite kaledu");
            }







        }
    }
}