namespace P021_List
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, List!");

            List<string> stringMasyvas = new List<string> { "zodis1", "zodis2", "....."};

            List<int> intMasyvas = new List<int> { 1, 2, 21, 5, 12};

            List<string> automobiliai = new List<string> { "Audi", "VW", "Opel", "Volvo" };

            
            Console.WriteLine(string.Join(",", automobiliai));

            automobiliai[1] = "Subaru";
            Console.WriteLine(string.Join(",", automobiliai));
            Console.WriteLine(automobiliai[2][1]);
            Console.WriteLine(automobiliai[2]);
            Console.WriteLine(automobiliai[2].Length);

            Console.WriteLine("automobiliu kiekis" + automobiliai.Count); //nereikia po count (), bet nesugriuna ir uzdejus

            Console.WriteLine("Listo talpa" + automobiliai.Capacity);
          
            automobiliai.Add("BMW");
            Console.WriteLine("Listo talpa" + automobiliai.Capacity);

            //Metodai
            //prideti elementa i saraso gala
            automobiliai.Add("Citroen");
            Console.WriteLine(string.Join(",", automobiliai));

            //prideti daug elementu i gala
            List<string> daugiauAutomobiliu = new List<string> { "BMW", "Mercedes", "Toyota" };
            automobiliai.AddRange(daugiauAutomobiliu);
                Console.WriteLine(string.Join(",", automobiliai));

            //isvalyti lista
            //automobiliai.Clear();

            //istrinti elementa
            automobiliai.RemoveAt(4);
            Console.WriteLine(string.Join(",", automobiliai));

            //iterpimas
            Console.WriteLine("--------------------");
            automobiliai.Insert(2, "BMW");
            Console.WriteLine(string.Join(",", automobiliai));

            //paieska
            Console.WriteLine("-------------");
            bool arYraVW = automobiliai.Contains("Opel");
            Console.WriteLine("Ar yra VW ?" + arYraVW);

            //rikiavimas
            automobiliai.Sort();
            Console.WriteLine(string.Join(",", automobiliai));

            automobiliai.Sort((x, y) => y.CompareTo(x));
            Console.WriteLine(string.Join(",", automobiliai));


            intMasyvas.Sort();
            Console.WriteLine(string.Join(",", intMasyvas));
            intMasyvas.Sort((x, y) => y - x);
            Console.WriteLine(string.Join(",", intMasyvas));

            //vertimas i masyva ar is masyvo i sarasa
            string[] automobiliuMAYVAS = automobiliai.ToArray();
            int[] intMasyvas2 = new int[] { 1, 2, 3, 4, 5 };
            List<int> skaiciai = intMasyvas2.ToList();

            //paieska
            automobiliai.Add("VW");
            string pirmasKurYraV = automobiliai.Find(x => x.Contains("V"));
            Console.WriteLine("pirmas kur yra V" + pirmasKurYraV);
            List<string> visiKurYraV = automobiliai.FindAll(x => x.Contains("V"));
            Console.WriteLine(string.Join(",", visiKurYraV));

            List<int> a = intMasyvas.FindAll(x => x > 6);
            Console.WriteLine(string.Join(",", a));

            Console.WriteLine(RastiDidziausia(intMasyvas));


            

        }
       /* DIDŽIAUSIAS SĄRAŠE
     Duotas vienmatis sveikų skaičių sąrašas.
     Parašykite programą, kuri suranda didžiausią skaičių saraše
        { 5, 1, 6, 8, 7 }
        rezultatas:  8*/

        public static int RastiDidziausia(List<int> intMasyvas)
        {
            intMasyvas.Sort((x, y) => y - x);
           // Console.WriteLine(string.Join(",", intMasyvas[0]));
            return intMasyvas[0];

        }

        public static int RastiDidziausiasuCiklu(List<int> lst)
        {
            int max = lst[0];
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] > max)
                {
                    max = lst[i];
                }
            }
            return max;
        }

        /*  DIDESNIS UŽ DIDŽIAUSIĄ
         Duotas vienmatis sveikų skaičių sąrašas.
         Parašykite programą, kuri į sąrašo galą prideda vienetu didesnį skaičių už patį didžiausią
         pvz:
         { 5, 1, 6, 8, 7 }
          rezultatas:  5, 1, 6, 8, 7, 9*/

        

        public static List<int> RastiDidziausiasuuzDidziausia2(List<int> lst)
        {
            int max = lst[0];
            for (int i = 0; i < lst.Count; i++)
            {
                if (lst[i] > max)
                {
                    max = lst[i];
                }
            }
            lst.Add(max + 1);
            return lst;
        }

        public static List<int> DidesniszDidziausia(List<int> lst)
        {
            var max = RastiDidziausia(lst);
            lst.Add(max + 1);
            return lst;
        }
        




        }
}