﻿namespace P020_MasyvuKartojimas
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
/*
## RIKIUOTI TRIS RAIDES ##
        Parašykite programą kurioje vienas metodas.
  - Naudotojo paprašome įvesti 3 raides(atskirai). 
    Būtina validacija kad įvesta tik vienas simbolis.
  - Metodas priima masyvą iš char ir grąžina masyvą iš char - surikiuotas raides pagal abecelę.
  Pvz: 
  > Iveskite pirma raide:
  _ C
  > Iveskite antra raide:
  _ D
  > Iveskite trecia raide:
  _ B
  >  B, C, D*/

        public static char[ ] RikiuotiTrisRaides(char[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        char temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }

                }
            }
            return mas;
        }
        /*
## RIKIUOTI KETURIAS RAIDES ## 
        Parašykite programą kurioje vienas metodas.
            - Naudotojo paprašome įvesti 4 raides(atskirai). 
              Būtina validacija kad įvesta tik vienas simbolis.
            - Metodas priima masyvą iš string (su prielaidai kad kiekvienas string yra tik 1 raide) 
              ir grąžina string (NB! ne masyvą) - surikiuotas raides pagal abecelę atskirtas -. 
            Pvz: 
            > Iveskite pirma raide:
            _ C
            > Iveskite antra raide:
            _ A
            > Iveskite trecia raide:
            _ B
            > Iveskite ketvirtą raide:
            _ E
            > A-B-C-E*/

        public static string RikiuotiKeturiasRaides(string[] raides)
        {
            char[] mas = new char[raides.Length];
            for (int i = 0; i < raides.Length; i++)
            {
                mas[i] = raides[i][0]; //rasome 0, kad string butu char
                //string raide = raides[i];
                //mas[i] = raide[0];
            }

            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        char temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }

                }
            }
            return string.Join("-", mas);
        }











    }
}