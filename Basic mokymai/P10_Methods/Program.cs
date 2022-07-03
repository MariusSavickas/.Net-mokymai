namespace P10_Methods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, Methods!");
            Console.WriteLine("Sukuriam pirma savo metoda");

            IsveskKazkaEkaran(); //metodo kvietimas, kai metodas nieko negrąžina ir nieko nepriima
            Console.WriteLine("-------------------------------");

            float kazkoksSkacius = GautiAtsitiktiniSkaiciu();
            Console.WriteLine($"kazkoks skaicius yra {kazkoksSkacius}"); //metodo kvietimas ir reiksmes priskyrimas



            Console.WriteLine("-------------------------------");
            int a = 2;
            IsveskSkaiciuEkranan(a); //metodas su vienu parametru
            Console.WriteLine($"Skaicius is MAIN {a}");
            Console.WriteLine("-------------------------------");

            int sk1 = 2;
            int sk2 = 2;
            int sudaugintiDuSkaiciai = DaugintiSkaicius(sk1, sk2);
            Console.WriteLine($"Sandauga lygi {sudaugintiDuSkaiciai}"); //Metodas su dviem parametrais grazina int
            Console.WriteLine("-------------------------------");

            int sudaugintiTrysSkaicius = DaugintiSkaicius(sk1, sk2, 2);
                Console.WriteLine( $"Sandauga yra {sudaugintiTrysSkaicius}"); //metodo overloadinimas , metodas priima 3 parametrus
            Console.WriteLine("-------------------------------");

            double sk1d = 2.1;
            double sk2d = 2.1;
            double SudaugintiDuDoubleSkaiciai = DaugintiSkaicius(sk1d, sk2d);
            Console.WriteLine($"Du sudauginti double sk. yra {SudaugintiDuDoubleSkaiciai}");
            Console.WriteLine("-------------------------------");

            double SudaugintiDuDoubleSkaiciai1 = DaugintiSkaicius((double)sk1, sk2d);
            Console.WriteLine($"Du sudauginti double sk. yra {SudaugintiDuDoubleSkaiciai1}");
            Console.WriteLine("-------------------------------");


            IsveskTekstaEranan();
            IsveskTekstaEranan("kazkoks tekstas");

            IsveskSkaiciuIrTekstaEkranan(1);
            IsveskSkaiciuIrTekstaEkranan(1, "kazkoks tekstas");
            Console.WriteLine("-------------------------------");

            int patikrintasSkaicius = SkaiciausPatikrinimas(60, 50, 100);
            Console.WriteLine($"Patikrintas skaicius = {patikrintasSkaicius}");

            int patikrintasSkaicius1 = SkaiciausPatikrinimas(max: 100, min: 50, skaicius: 51);
            Console.WriteLine($"Patikrintas skaicius = {patikrintasSkaicius1}");

            Console.WriteLine("-------------------------------");

            Console.WriteLine("Vidurkis" + Vidurkis(2,3));
            Console.WriteLine("Vidurkis" + Vidurkis(2, 3,8));
            Console.WriteLine("Vidurkis" + Vidurkis(2, 3,545,87, 3, 78,32, 78, 21, 65, 45,121));

            Console.WriteLine("-------------------------------");

            GautiSkaiciu(out int gautasSkaicius);
            Console.WriteLine($"gautas skaicius = {gautasSkaicius}");
            Console.WriteLine("-------------------------------");

            int rsk = 2;
            Console.WriteLine($" rsk = {rsk}");
            ReferenceSkaicius(ref rsk); //reiksmes perdavimas per reference keicia reiksme kvieciant metode
            Console.WriteLine($" po ReferenceSkaicius rsk = {rsk}");
            Console.WriteLine("-------------------------------");

            /*
            //lokalios funkcijos
            int Add(int a, int b)
            {
                return a + b;
            }
            Console.WriteLine(Add(2,2));
            */

            //pvz
            int Add(int a, int b)
            {
                return a + b;
            }
            Console.WriteLine(Add(Convert.ToInt32(Console.ReadLine()), 2));
            Console.WriteLine(Add(10, 2));

            Console.WriteLine("-------------------------------");

        }

        public static void ReferenceSkaicius(ref int skaicius)
        {
            skaicius = 900;
        }




        public static void GautiSkaiciu(out int skaicius)
        {
            skaicius = 2;
        }










        public static double Vidurkis(params int[] skaiciai) //params kai nezinome kiek paduosime parametru
        {
            double total = 0;
                foreach (var skaicius in skaiciai)
                {
                total += skaicius;
            }
                return total/skaiciai.Length;
        }



        public static int SkaiciausPatikrinimas(int skaicius, int min, int max)
        {
            if (skaicius < min)
            {
                return min;
            }
            if (skaicius > max)
            {
                return max;
            }
            return skaicius;

        }

        public static void IsveskTekstaEranan(string tekstas = "tekstas neivestas")
        {
            Console.WriteLine("tekstas " + tekstas);
        }
        public static void IsveskSkaiciuIrTekstaEkranan(int skaicius, string tekstas = "tekstas neivestas")
        {
            Console.WriteLine($"skaicius {skaicius} ir tekstas {tekstas}");
        }



        public static double DaugintiSkaicius(double sk1d, double sk2d)
        {
            return sk1d * sk2d;
        }

        public static int DaugintiSkaicius(int sk1, int sk2, int sk3)
        {
            return sk1 * sk2 * sk3;
        }

        public static int DaugintiSkaicius(int sk1, int sk2)
        {
            return sk1 * sk2;
        }

        public static void IsveskSkaiciuEkranan(int a)
        {
            a = a + 8;
            Console.WriteLine($"skaicius yra {a}");
        }

        public static float GautiAtsitiktiniSkaiciu()
        {
            // return 4.686878f; //Reikia grazinto toki metoda koki apsirasai. Negali grazint int ar string. Sioje situacijoje float turi buti
            float a = 4;
            return a + 4.686878f;
        }

        public static void IsveskKazkaEkaran() //void negrąžina reikšmės
        {
            Console.WriteLine("Isvedu kazka");

        }






    }
}