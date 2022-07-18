namespace P020_MasyvuKartojimas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Masyvu kartojimas");
int[] mas = { 5, 3, 7, 16, 8, 7, 10 };
            Console.WriteLine(RastiMaziausia(mas));
            Console.WriteLine(RastiDidziausia(mas));
            Console.WriteLine(RikiuotiSkaiciusDidejimoTvarka(mas));
            
        }
        /*
## 1. Rasti mažiausią ##
        Duotas vienatis sveikų skaičių masyvas.
        Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
        { 5, 3, 7, 6, 8, 7, 10 }
        rezultatas:  3*/

        /*
        public static int PirmaUzduotis(int[] skaiciai)
        {
            int maziausias = skaiciai[0];
            for (int i = 0; i < skaiciai; i++)

            {
                if (skaiciai[i] < maziausias)
                {
                    maziausias = skaiciai[i];

                }
            }
            return maziausias;
        }*/
        public static int RastiMaziausia(int[] mas)
        {
            int maziausias = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (maziausias > mas[i])
                {
                    maziausias = mas[i];
                }
            }
            return maziausias;
        }

        /*2. ## Rasti didžiausią ##
       Duotas vienatis sveikų skaičių masyvas.
       Parašykite programą, kuri į ekraną išves mažiausią skaičių masyve
        { 5, 3, 7, 6, 8, 7, 10 }
        rezultatas:  10*/
        public static int RastiDidziausia(int[] mas)
        {
            int didziausias = mas[0];
            for (int i = 0; i < mas.Length; i++)
            {
                if (didziausias < mas[i])
                {
                    didziausias = mas[i];
                }
            }
            return didziausias;
        }

        /*3. ## RIKIUOTI SKAICIUS DIDĖJIMO TVARKA ##
       Duotas vienmatis sveikų skaičių masyvas.
       Parašykite programą, kuri į ekraną išves surikiuotusskaičius nuo
        mažiausio iki didžiausio
        { 5, 1, 7, 6, 8, 7, 10 }
        rezultatas:  1, 5, 6, 7, 7, 8, 10*/

        public static int[] RikiuotiSkaiciusDidejimoTvarka(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        int temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }

                }
            }


            Console.WriteLine(string.Join(",", mas));
            return mas;
        }











    }
}