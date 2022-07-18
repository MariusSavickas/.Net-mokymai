using System.Text;

namespace P017For_Uzduotys
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello, For uzduotys!");
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite laipsni");
            int laipsnis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PakeltiLaipsniu(skaicius, laipsnis));           
            */
            int integerNumber = 45;
            int skaiciukas = 0;

            Console.WriteLine($"orginali reiksme {skaiciukas}");
            var Arpavyko = PaverstiTirsdesimt(out skaiciukas);

            Console.WriteLine("pakeista " + skaiciukas);

            Meniu();


        }
        //----------------------------------------------
        //Out parametro pavyzdys
        public static bool PaverstiTirsdesimt(out int skaiciukas) //su out pakieciam reiksme 
        {
            skaiciukas = 30;
            return true;
        }



        #region 1 uzduotis
        /*UŽDUOTIS 1.
      Sukurti metodą ReadIntNumber, 
      kuris paprašo vartotojo įvesti sveikąjį skaičių ir tą skaičių grąžina.
      Jeigu vartotojas įveda blogą skaičių, tai programa turi informuoti, kad
      įvestas blogas skaičius ir prašyti įvesti vėl. Kol vartotojas
      neįveda tinkamo skaičiaus metodas turi vis prašyti įvesti.
      (Hint) -> Panaudoti int.TryParse metodą ir while ciklą.*/
        #endregion

        public static int ReadIntNumber()
        {
            Console.WriteLine("Įveskite sveikąjį skaičių");

            string skaiciusStr = String.Empty; //arba "";
            bool arSkaiciusTeisingas = false;
            int skaicius = 0;
            while (!arSkaiciusTeisingas)
            {
                skaiciusStr = Console.ReadLine();
                arSkaiciusTeisingas = int.TryParse(skaiciusStr, out skaicius);
                if (!arSkaiciusTeisingas)
                {
                    Console.WriteLine("Ivestas neteisingas skaicius, bandykite dar");
                }
            }
            Console.Write($"Ivestas skaicius {skaiciusStr}");
            return skaicius;
        }

        /*
    Sukurti metodą IntegerToBinary, 
    kuris gautą teigiamą sveikąjį skaičių paverstų į dvejetainį formatą.Reikšmę grąžintų kaip simbolių eilutę.
    2 --> 10
    7 --> 111
    45 --> 101101 
    */
        public static string IntegerToBinary(int integerNumber)
        {
            string binaryNumber = string.Empty;
            while (integerNumber > 0)
            {
                binaryNumber = integerNumber % 2 + binaryNumber;
                integerNumber /= 2;  //integerNumber = integerNumber / 2;

            }
            Console.WriteLine(binaryNumber);
            return binaryNumber;
        }
        /*
     Sukurti metodą PakeltiLaipsniu , kuris duotą skaičių pakelia nurodytu
     laipsniu ir gautą rezultatą grąžina.Pirmas parametras skaičius, kurį
     kelsime, antras laipsnis, kuriuo pakelti.
     NB! kai laipsnis 0 o skaičius > 0 gąžinama 1
     NB! kai skaičius 0 ir laipsnis = 0 gąžinama 0
     NB! kai laipsnis = 1 gąžinamas tas pats skaičius
     */
        public static int PakeltiLaipsniu(int skaicius, int laipsnis)
        {

            if (laipsnis == 0 && skaicius > 0)
            {
                return 1;
            }
            if (skaicius == 0 && laipsnis == 0)
            {
                return 0;
            }
            if (laipsnis == 1)
            {
                return skaicius;
            }
            var rezultatas = skaicius;
            for (int i = 1; i < laipsnis; i++)
            {
                rezultatas = rezultatas * skaicius;
            }
            //Console.WriteLine(rezultatas);
            return rezultatas;
        }
        /* SkaiciuTrikampis
        Sukurti metodą SkaiciuTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 
        (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą). 
        Metodas turi grąžinti atitinkamą statųjį trikampį su tiek eilučių koks skaičius įvestas.
        5
        55
        555
        5555
        55555
        */
        /*
        public static void SkaiciuTrikampis()
        {
           int pabaigostaskas = Convert.ToInt32(Console.ReadLine());
            for (int i =0; i < pabaigostaskas; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(pabaigostaskas);
                    if (i == pabaigostaskas)
                    {
                        break;
                    }

                }
                Console.WriteLine();
            }
        }
        */
        /*
        public static void SkaiciuTrikampis()
        {
            int pabaigostaskas = Convert.ToInt32(Console.ReadLine());
            var builder = new StringBuilder();
            for (int i = 1; i < pabaigostaskas; i++)
            {
                builder.Append(pabaigostaskas);
                Console.WriteLine(builder.ToString());
            }
        }
        */
        /*
        public static void SkaiciuTrikampis()
        {
            while (true)
            {
                Console.WriteLine("Iveskite skaiciu");
                StringBuilder sb = new StringBuilder();

                var input1 = Console.ReadLine();
                var skaiciusBool = int.TryParse(input1, out int skaicius);
                if (skaicius <= 9 && skaicius >= 1)
                {
                    for (int i = 0; i < skaicius; i++)
                    {
                        sb.Append(skaicius);
                        Console.WriteLine(sb.ToString());

                    }
                    break;
                }
                Console.WriteLine("Neteisingas skaicius");
            }
            
        }
        */
        public static void SkaiciuTrikampis()
        {
            var input1 = string.Empty;
            var builder = new StringBuilder();
            var skaicius = 0;
            while (true)
            {
                input1 = Console.ReadLine();
                var arTeisinga = int.TryParse(input1, out skaicius);
                if (skaicius <= 9 && skaicius >= 1)
                {
                    break;
                }
            }
            for (int i = 0; i < skaicius; i++)
            {

            }
        }



        /* SkaiciuPiramide
        Sukurti metodą SkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9
        (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą)
        Metodas turi grąžinti atitinkamą piramide su tiek skaičių centre koks skaičius įvestas.
        7
        77
        777
        7777
        77777
        777777
        7777777
        777777
        77777
        7777
        777
        77
        7
       */
        public static void SkaiciuPiramide()
        {
            var input1 = string.Empty;
            int skaicius = 0;
            while (skaicius < 1 || skaicius > 9)
            {
                Console.WriteLine("Iveskite skaiciu");
                input1 = Console.ReadLine();
                var arTeisinga = int.TryParse(input1, out skaicius);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= skaicius; i++)
            {
                sb.Append(skaicius);
                Console.WriteLine(sb.ToString());
            }
            for (int i = skaicius; i >= 1; i--)
            {
                sb.Remove(0, 1);
                Console.WriteLine(sb.ToString());
            }
            Console.WriteLine("Neteisingas skaicius");
        }
        /*
       Sukurti metodą DidejanciuSkaiciuStatusTrikampis, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 
       (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą )). 
       Metodas turi grąžinti atitinkamą statųjį trikampį.
       1
       22
       333
       4444
       55555
       */


        public static void SkaiciuTrikampis1()
        {
            var input1 = string.Empty;
            int skaicius = 0;
            while (skaicius < 1 || skaicius > 9)
            {
                Console.WriteLine("Iveskite skaiciu");
                input1 = Console.ReadLine();
                var arTeisinga = int.TryParse(input1, out skaicius);
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= skaicius; i++)
            {

                sb.Append(i);// turi būti 1, 22 , 333, 4444, 55555, 666666
                Console.WriteLine(sb.ToString());

            }
        }


        /*
        public static void SkaiciuTrikampis1()
        {
            int pabaigostaskas = Convert.ToInt32(Console.ReadLine());
            var builder = new StringBuilder();
            for (int i = 1; i < pabaigostaskas; i++)
            {
                builder.Append(i);
                Console.WriteLine(builder.ToString());
            }
        }*/

        /*
      Sukurti metodą DidejanciuSkaiciuPiramide, kuri paprašo vartotojo įvesti skaičių nuo 1 iki 9 
      (jeigu įveda netinkamą skaičių prašo įvesti vėl, kol įves tinkamą )). 
      Metodas turi grąžinti atitinkamą lygiašonį trikampį (ivestas skaičius 4).
      1
      22
      333
      4444
      333
      22
      1
      */

        /*NAUJAS
----------------------------
Parašykite metodą SkaiciuEile kuri išv vienoje eilutėje skaičių grupes tokiu principu: -> 1 -> 11 -> 111 -> 1111 -> 11111 -> ....... 
programa turi paprašyti nurodyti skaičių iestur grupių kiekį
naudokite for ir StringBuilder*/

        public static void skaiciuEile()
        {
            var input = 5;
            var sb = new StringBuilder();
            for (int i = 0; i < input; i++)
            {
                Console.Write("->");
                sb.Append("1");
                Console.Write(sb);
            }
        }
        /*NAUJAS
------------------------
2. Sukurkite programa, kuri paprasytu naudotojo ivesti skaiciu.Ivedus skaiciu turetu atspausdinti to skaiciaus daugybos lentele.Pvz
15 X 1 = 15                                                                                                   
15 X 2 = 30                                                                                                   
15 X 3 = 45                                                                                                   
15 X 4 = 60                                                                                                   
15 X 5 = 75                                                                                                   
15 X 6 = 90                                                                                                   
15 X 7 = 105                                                                                                  
15 X 8 = 120                                                                                                  
15 X 9 = 135                                                                                                  
15 X 10 = 150
        */

       
        public static void DaugybosLentele()
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            var sb = new StringBuilder();
            for (int i = 1; i <= 10; i++)
            {
                sb.Append(skaicius).Append(" X ").Append(i).Append(" = ").Append(skaicius * i);
                Console.WriteLine(sb);
                sb.Clear();
                /*
                sb.Append(skaicius);
                sb.Append("X");
                sb.Append(i);
                sb.Append(" = ");
                sb.Append(skaicius * i);
                Console.WriteLine(sb);
                sb.Clear();
                */

            }
        }

        /*NAUJAS
----------------------
3. Sukurti skaiciuotuva.Ijungus programa mes turetume gauti pranesima “1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”. Pasirinkus 1 turetu ismesti ”
1. Sudetis
2. Atimtis
3. Daugyba
4. Dalyba”
Pasirinkus viena is operaciju programa turetu paprasyti naudotoja ivesti pirma ir antra skaicius, o gale isvesti rezultata ant ekrano ir uzklausti ar naudotojas nori atlikti nauja operacija ar testis u rezultatu. Sudeties pvz:
“1
15
45
Rezultatas: 60
1. Nauja operacija 2. Testi su rezultatu 3. Iseiti”
Pasirinkus 2 programa turetu paprasyti ivesti kokia operacija turetu buti atliekama ir paprasyti TIK SEKANCIO SKAITMENS. Pasirinkus 3 programa turetu issijungti.Visa kita turetu veikti tokiu pat budu.
BONUS1: Iskelkite operacijas i metodus
BONUS2: Parasykite operacijoms validacijas pries ivestus neteisingus skaicius.Pvz: dalyba is nulio, neteisingu ivesciu prevencija pvz kada tikimasi gauti skaiciu, bet gaunamas char arba string.
BONUS3: Parasyti unit testus uztikrinant operaciju veikima
BONUS4: Parasyti laipsnio pakelimo ir saknies traukimo operacijas*/

        public static string Meniu()
        {
            Console.WriteLine(@" Programos meniu
1. Nauja operacija
2. Testi su rezultatu
3. Išeiti");
            Console.WriteLine("\n Iveskite savo pasirinkimą");
            var Pasirinkimas = Convert.ToInt32(Console.ReadLine());
            switch (Pasirinkimas)
            {
                case 1:                  
                     return   Submeniu();                   
                case 2:
                    return "Labas";
                    
                    

            }
            return "Tokio pasirinkimo nėra";

        }

        private static string Submeniu()
        {
            Console.WriteLine(@" Programos Sub-meniu
1. Sudetis
2. Atimtis
3. Daugyba
4. Dalyba");
            return "Gerai";
        }
    }
    } 