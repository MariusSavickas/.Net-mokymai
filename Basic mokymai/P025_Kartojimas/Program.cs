namespace P025_Kartojimas  //<-- namespace declaration
{
    internal class Program // <-- A class
    {

        int a = 21;
        static void Main(string[] args) //<-- A Main method (entry point)
        {
            Console.WriteLine("Hello, World!"); // <-- Statement 
            int counter; // <-- Declaration statement
            counter = 5; // <-- Assignment statement

            double pi = 3.14; // <-- declaration and initialize.

            List<string> strings = new List<string>(); //<-- Ecpression statement (new object creation).
            Random rnd = new Random(); // <-- Expression statement (new object creation).

            int[] radii = { 15, 32, 108, 74, 9 }; // <-- declaration and initialize an array.
            foreach(int radius in radii)
            {
                //Declaration statement with initializer
                double circumference = pi * (2 * radius);
            }

            #region ***C# - Type Conversion***
            double d = 5673.74;
            int i;
            i = (int)d;

            decimal dd = i;
            #endregion

            #region *** C# - Type Conversation***
            string skaiciusTekste = "42";
            Console.WriteLine(Convert.ToByte(skaiciusTekste));

            Console.WriteLine(byte.Parse(skaiciusTekste));
            byte.TryParse(skaiciusTekste, out byte skaicius);
            Console.WriteLine(skaicius);


            #endregion

            //Laipsninis Piesimas su konsole
            //KonsolesValymas();

            //Informacijos perdavimas per ref ir out

            //pvz. kada reiktų naudoti globalius kintamuosius, nes kitaip neišeitų išspręsti problemos

            //pvz. kai turime metodą, kuris priima string[] ir gražina char[]
            //var a = ToCharArray(new string[] { "namas", "auto", "komp" });
            //Console.WriteLine(string.Join(",", a));

            //array vs list, tuščio array užpildymas
            //array jei turim zinoma kieki reiksmiu, list jei norime dinamisko

            // rekursija , kai metodas iskviecia pats save

            //kai turime kintamaji var sukuriua private static object metoda

            //uInt neturi neigiamu reiksmiu

            TuscioListPildymas();
            Console.WriteLine("---------");
            TuscioArrayPildymas();

        }

        #region array vs list, tuščio array užpildymas
        public static void TuscioListPildymas()
        {
            Random rnd = new Random();
            List<int> skaiciai = new List<int>(); //tuscias list
            for (int i = 0; i < 10; i++)
            {
                skaiciai.Add(rnd.Next(10)); //list pildymas
            }
        }
        
        public static void TuscioArrayPildymas()
        {
            Random rnd = new Random();
            int[] skaiciai = new int[10]; //tuscias array
            string[] tekstai = new string[10];
            Console.WriteLine(String.Join(",", skaiciai));
            Console.WriteLine(String.Join(",", tekstai));
            Console.WriteLine(tekstai.Length);

            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = rnd.Next(10); //array pildymA
                
            }
            Console.WriteLine(String.Join(",", skaiciai));
        }
           
        #endregion


        #region for ir forech esminiai skirtumai ir pritaikymo limitacijos
        public static void ForNaudojimas()
        {
            Random rnd = new Random();
            List<int> skaiciai = new List<int>();
            for  (int i = 0; i < 10; i++)
            {
                skaiciai.Add(rnd.Next(10));
            }
        }
        public static void ForEachNaudojimas()
        {
            List<int> skaiciai = new List<int> { 1,2,3,4,5};
            foreach(var skaicius in skaiciai)
            {
                Console.WriteLine(skaicius);
            }

            for (int i = 0; i < skaiciai.Count; i++)
            {
                Console.WriteLine(skaiciai[i]);
            }
        }


        #endregion

        #region Metodo shorthand sintakse
        public static int TrumpasMetodas(int a) => a + a;

        public static int TrumpasMetodasPailgintas(int a)
        {
            var b = a == 0 ? "nulis" : "ne nulis"; //ternary operator
            var c = a switch // switch exspresson
            {
                0 => "nulis",
                _ => "ne nulis"
            };

            int? duomenysIsInterneto = GautiDuomenisIsInterneto();
            var rezultatas = duomenysIsInterneto ?? 0 * 10;
            var rezultatas2 = duomenysIsInterneto != null ? duomenysIsInterneto * 10 : null;

            return a + a;
        }
        private static int? GautiDuomenisIsInterneto()
        {
            return null;
        }

        #endregion

        #region pvz. kai turime metodą, kuris priima string[] ir gražina char[]
       // public static char[] ToCharArray(string[] strArr)
        //{
            // string str = string.Join[]{ "namas", "auto", "komp"});
            //  return str.ToCharArray();
           // return 0;
      //  }
        #endregion


        #region pvz. kada reiktų naudoti globalius kintamuosius, nes kitaip neišeitų išspręsti problemos

        public static void Klasuimas3Metodas(int a)
        {
            Klasuimas3Metodas1(a);
        }
        public static void Klasuimas3Metodas1(int a)
        {
            a = a + 9;
            Klasuimas3Metodas2(a);
        }
        public static void Klasuimas3Metodas2(int a)
        {
            a = 9 - a;
            Console.WriteLine(a);
        }


        #endregion

        #region Informacijos perdavimas per ref ir out
        public static bool TryParseReload(string input, out int result)
        {
            try
            {
                result = int.Parse(input);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }

        }


        #endregion


        public static void KonsolesValymas()
        {
            while (true)
            {
                Console.WriteLine("Iveskite skaiciu arba parasykite exit");
                string input = Console.ReadLine();
                if (input == "exit")
                    break;
                Console.Clear();
                if (int.TryParse(input, out _))
                {
                   // Console.Clear();
                    Console.WriteLine($"Ivedete skaiciu {input}. Bandykite dar karta arba iveskite exit");
                }
                else
                {
                    //Console.Clear();
                    Console.WriteLine("Ivedete neteisingai, bandykite dar karta, bet dabar skaiciu");
                }
            }
        }

        #region
        public static void StateMachine(int state)
        {
            switch (state)
            {
                case 1:
                    Metodas1();
                    break;
                    case 2:
                    Metodas2();
                    break;
                case 3:
                    Metodas3();
                    break;
                    //ir t.t.
            }
        }

        public static void Metodas1()
        {
            //Kazkokia logika
        }
        public static void Metodas2()
        {
            //Kazkokia logika
        }
        public static void Metodas3()
        {
            //Kazkokia logika
        }
        #endregion State MAxhine/Switch


        public static void ManoMetodas() //<-- klases metodas
        {
            //kazkokia logika
            int kintamasis = 5; //<-- Method variables
            void VidinisMetodas() // <-- Internal method
            {
                ManoKintamasis = 50;
                // kazkokia logika
            }
        }
        public static int ManoKintamasis = 5; //<-- Class variables(globalus kintamasis)


    }
}