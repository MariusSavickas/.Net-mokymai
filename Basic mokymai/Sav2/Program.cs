// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/* 
           Sukurkite programą, kuri pateiktų vartotojo registracijos formą.
           Vartotojas įveda:
            - vardą ir pavardę 
            - asmens kodą (11simb.)
            - amžių (sveiką skaičių metais) ir/arba gimimo datą (galima abu, tik kažkurį vieną, ar neįvesti nei vieno)
          Programa į ekraną išveda ataskatą:
           - šiandienos datą
           - Vardas, pavardė
           - Lytis
              <HINT> asmens kodo pirmasis rodo gimimo šimtmetį ir asmens lytį 
              (1 – XIX a. gimęs vyras, 
               2 – XIX a. gimusi moteris, 
               3 – XX a. gimęs vyras,
               4 – XX a. gimusi moteris, 
               5 – XXI a. gimęs vyras,
               6 – XXI a. gimusi moteris
               tolesni šeši: 
                    metai (du skaitmenys), 
                    mėnuo (du skaitmenys), 
                    diena (du skaitmenys))     
           - Asmens kodas 
              <NEPRIVALOMAS PASUNKINIMAS> asmens kodas validuojamas pagal tokias salygas
                 Paskaičiuojamas Kontrolinis skaičius 
                 a) jei kontrolinis skaičius teisingas išvedamas asmens kodas
                 b) jei neteisingas išvedamas tekstas "kodas neteisingas", 
                    o laukeAmžiaus patikimumas išvedama "patikimumui trūksta duomenų" 
                    <HINT> https://lt.wikipedia.org/wiki/Asmens_kodas
           - Amžius
           - Amžiaus patikimumas - pagal tokias sąlygas:
           -  jei įvestas amžius metais, paskaičiuoti gimimo metus ir sulyginti su įvestu asmens kodu. 
              a) jei sutampa išvesti "amžius patikimas"
              b) jei nesutampa išvesti "amžius pameluotas"
           - jei įvesta gimimo data sulyginti su įvestu asmens kodu. 
              a) jei sutampa išvesti "amžius patikimas" 
              b) jei nesutampa išvesti "amžius pameluotas"
           - jei įvesta ir amžius ir gimimo data sulyginti su įvestu asmens kodu. 
              a) jei viskas sutampa išvesti "amžius tikras" 
              b) jei asmens kodu sutampa tik vienas įvestų, išvesti "amžius nepatikimas" 
              c) jei nesutampa išvesti "amžius pameluotas"
           - jei neįvesta nei amžius nei gimimo data išvesti
              a) "patikimumui trūksta duomenų"
Rezultatas gali atrodyti taip:
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ATASKAITA APIE ASMENĮ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓      2022-06-20       ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓     Vardas, pavardė ▓ Vardenis Pavardenis                 ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓               Lytis ▓ Vyras                               ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓        Asmens kodas ▓ 44012029286                         ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓              Amžius ▓ 82                                  ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓         Gimimo data ▓ 1980-06-20                          ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓ Amžiaus patikimumas ▓ amžius nepatikimas                  ▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓
           */


var Data = DateTime.Now; //Šiandienos data
Console.WriteLine("Iveskite vardą ir pavardę"); //Įvedamas vardas ir pavardė
var vardasIrPavarde = Console.ReadLine();
Console.WriteLine("Iveskite asmens kodą (11 simb.)"); //Įvedamas asmens kodas
string asmenskodas = Console.ReadLine();

string PirmasSkaicius = asmenskodas.Substring(0, 1); //Gaunamas pirmas skaičius iš asmens kodo, kuris reikalingas nustatyti lyčiai
string Lytis = "";

if (PirmasSkaicius == "1" || PirmasSkaicius == "3" || PirmasSkaicius == "5")  //pagal gautą pirmą skaičių patikriname vyras ar moteris nelyginis = Vyras. lyginis = moteris
{
    Lytis = "Vyras";
}
else if (PirmasSkaicius == "2" || PirmasSkaicius == "4" || PirmasSkaicius == "6")
{
   Lytis = "Moteris";
}
else
{
    Lytis = "Blogai įvestas asmens kodas";
}


Console.WriteLine("Parašykite kiek jums metų"); //Įvedamas asmens amžius
string Amzius = Console.ReadLine();
Console.WriteLine("Iveskite savo gimimo datą (yyyy MM dd)"); //Įvedama gimimo data
string GimimoData = Console.ReadLine();

String Metai = asmenskodas.Remove(0, 1).Remove(2); //Vartotojo įvesti gimimo metai pagal asm. kodą
String GimimoMetai = "";
if (PirmasSkaicius == "1" || PirmasSkaicius == "2")
{
    GimimoMetai = ($"18{Metai}");
}
else if (PirmasSkaicius == "3" || PirmasSkaicius == "4")
{
    GimimoMetai = ($"19{Metai}");
}
else if (PirmasSkaicius == "5" || PirmasSkaicius == "6")
{
    GimimoMetai = ($"20{Metai}");
}
else
{
    GimimoMetai = "Blogai įvestas asmens kodas";
}


    String GimimoMenesis = asmenskodas.Remove(0, 3).Remove(2); // mėnesis
String GimimoDiena = asmenskodas.Remove(0, 5).Remove(2);  //diena


String Gimtadienis = $"{GimimoMetai} {GimimoMenesis} {GimimoDiena}"; //Pilna vartotoja gimimo data
// Console.WriteLine($"Gimtadienis yra {Gimtadienis}");

DateTime Gimtadienis1 = Convert.ToDateTime(Gimtadienis); 



int metai1 = Data.Year - Gimtadienis1.Year;
int metai2 = metai1;

if ((Gimtadienis1.Month < Data.Month)) //Sutikriname kiek vartotojui metų pagal gimtadienio dieną ir šiandienos dieną
{ 
        metai2 = metai1;
}
else if ((Gimtadienis1.Month == Data.Month)) //Sutikriname kiek vartotojui metų pagal gimtadienio dieną 
{
    if (Gimtadienis1.Day <= Data.Day)
    {
        metai2 = metai1;
    }
    else if (Gimtadienis1.Day > Data.Day)
    {
        metai2 = (metai1 - 1);
    }

}
else if (Gimtadienis1.Month > Data.Month)
{
    metai2 = (metai1 - 1);
}

string AmziausPatikimumas = "";



if (Amzius != "" && GimimoDiena != "")  //Jei abu parametrai įvesti 
{
        if ((Convert.ToInt32(Amzius) == metai2) && (GimimoData == Gimtadienis))
        {
            AmziausPatikimumas = "Amžius tikras";
        }
        else if ((Convert.ToInt32(Amzius) != metai2) || (GimimoData == Gimtadienis))
        {
            AmziausPatikimumas = "Amžius napatikimas";
        }
        else if ((Convert.ToInt32(Amzius) == metai2) || (GimimoData != Gimtadienis))
        {
            AmziausPatikimumas = "Amžius nepatikimas";
        }
        else
        {
            AmziausPatikimumas = "Amžius pameluotas";
        }                                                                                       //atsakymas lieka 1 if,programa nebetikrina kitų else if.

    }
 else if (Amzius == "" && GimimoDiena == "")                                              // jei neįvesta nei amžius nei gimimo data
    {
        AmziausPatikimumas = "Patikimumui trūksta duomenų";
    }

 else if (GimimoDiena == "" || Amzius != "") //Jei įvestas tik amžius 
    {
        if ((Convert.ToInt32(Amzius) == metai2))
        {
            AmziausPatikimumas = "Amžius patikimas";
        }
        else
        {
            AmziausPatikimumas = "Amžius pameluotas";
        }
    }
 else if (Amzius == "" || GimimoDiena != "") //Jei įvesta tik gimimo data
    {
        if (Gimtadienis == GimimoData)
        {
            AmziausPatikimumas = "Amžius patikimas";
        }
        else
        {
            AmziausPatikimumas = "Amžius pameluotas";
        }
    } 
















    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ ATASKAITA APIE ASMENĮ ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓      {Data.ToShortDateString()}       ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓     Vardas, pavardė ▓ {vardasIrPavarde,21}               ▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓               Lytis ▓ {Lytis,11}                         ▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓        Asmens kodas ▓ {asmenskodas,17}                   ▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓              Amžius ▓ {Amzius,12}                        ▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓         Gimimo data ▓ {GimimoData,16}                    ▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine($"▓ Amžiaus patikimumas ▓ {AmziausPatikimumas,24}            ▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");