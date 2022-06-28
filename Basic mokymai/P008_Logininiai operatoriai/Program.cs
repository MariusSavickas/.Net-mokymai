// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, IF");

/*
int nelyginisskaicius = 5;
int lyginisskaicius = 2;
bool tiesa = true;

if (nelyginisskaicius > lyginisskaicius)
{
    Console.WriteLine($" {nelyginisskaicius} yra didesnis uz {lyginisskaicius}");
}
if (nelyginisskaicius < lyginisskaicius)
{
    Console.WriteLine($" {nelyginisskaicius} yra mazesnis uz {lyginisskaicius}");
}

Console.WriteLine("if - else");
if (nelyginisskaicius < lyginisskaicius)
{
    Console.WriteLine($" {nelyginisskaicius} yra mazesnis uz {lyginisskaicius}");
}
else
{
    Console.WriteLine($" {nelyginisskaicius} yra didesnis uz {lyginisskaicius}");

}

Console.WriteLine("if - else if - else");
if (nelyginisskaicius < lyginisskaicius && tiesa)
{
    Console.WriteLine($" {nelyginisskaicius} yra mazesnis uz {lyginisskaicius} ir ties yra true");
}
else if (nelyginisskaicius < lyginisskaicius && !tiesa)
{
    Console.WriteLine($" {nelyginisskaicius} yra mazesnis uz {lyginisskaicius} ir ties yra false");

}
else if (nelyginisskaicius > lyginisskaicius && tiesa)
{
    Console.WriteLine($" {nelyginisskaicius} yra didesnis uz {lyginisskaicius} ir tiesa yra true");    
}
else
{
    Console.WriteLine($" {nelyginisskaicius} yra didesnis uz {lyginisskaicius} ir tiesa yra false");
}

Console.WriteLine("-----------------------------------------");
var score = 45;
int pointNeededToPass = 100;
bool levelComplete;

if (score >= pointNeededToPass)
{
    levelComplete = true;
}
else
{
    levelComplete = false;
}
if (levelComplete)
{
    Console.WriteLine("valio, baigete lygi");
}

Console.WriteLine ( score >= pointNeededToPass ? "valio baigete lygi" : "nevalio bandykite dar kart");
Console.WriteLine("-----------------------------------------");

Console.WriteLine ("if kompozicija nesting");
int shields = 1, armor = 2;
if (shields <= 0)
{
    if (armor <= 0)
    {
        Console.WriteLine("jus mires");
    }
    else
    {
        Console.WriteLine("jus dar turite armor");
    }
    //....
}
else
{
    Console.WriteLine("jus dar turite galimybiu");
}

if (shields <= 0 && armor <=0)
{
    Console.WriteLine("jus mires");
}
else if (shields <= 0 && armor >0)
{
    Console.WriteLine("jus dar turite armor");
}    
else
{
    Console.WriteLine("jus dar turite galimybiu");
}
Console.WriteLine("-----------------------------------------");

/*PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI SKAIČIŲ.
- JEIGU SKAIČIUS YRA LYGINIS IŠVESTI Į EKRANĄ "SKAIČIUS YRA LYGINIS"
- JEIGU SKAIČIUS YRA NEIGIAMAS "SKAIČIUS YRA NEIGIAMAS"
- KITU ATVEJU IŠVESTI PATĮ SKAIČIŲ*/

Console.WriteLine("null-coalescing operator (??)");
bool? nullableBool = true;
bool normalBool;
//normalBool = nullableBool; //Taip negalima
normalBool = nullableBool ?? false;
Console.WriteLine("-----------------------");
nullableBool ??= false;

Console.WriteLine("-----------------------");

Console.WriteLine("iveskite skaiciu");
var skaicius = Convert.ToDouble(Console.ReadLine());
if (skaicius%2 == 0 )
{
    Console.WriteLine("skaicius yra lyginis");
}
if (skaicius <0)
    {
    Console.WriteLine("skaicius yra neigiamas");
}
if (skaicius%2 != 0 && skaicius > 0)
{
    Console.WriteLine(skaicius);
}

/*2 uzduotis
PARAŠYTI PROGRAMĄ, KURI PAPRAŠO
VARTOTOJO ĮVESTI GRUPĖS NARIŲ KIEKĮ.
JEI NARIŲ KIEKIS LYGUS 1 PROGRAMA IŠVEDA
„TAI SOLO ATLIKĖJAS“, JEI NARIŲ KIEKIS 2 --„TAI
DUETAS“, JEI NARIŲ KIEKIS DAUGIAU NEI 2 BET
MAŽIAU NEI 10 ––„TAI ANSAMBLIS“, JEI
DAUGIAU NEI 10 ––„TAI KAMERINIS
ANSAMBLIS“.
*/

Console.WriteLine("iveskite grupes nariu skaiciu");
var kiekis = Convert.ToDouble(Console.ReadLine());

if (kiekis == 1)
{
    Console.WriteLine("Tai solo atlikejas");
}
else if (kiekis == 2)
{
    Console.WriteLine("Tai duetas");
}
else if (kiekis > 2 && kiekis < 10)
{
    Console.WriteLine("Tai ansamblis");
}
else if (kiekis >= 10)
{
    Console.WriteLine("Tai kamerinis ansamblis");
}
else
{
    Console.WriteLine("klaida");
}

/*3 uzduotis
PARAŠYTI PROGRAMĄ, KURI
PAPRAŠO VARTOTOJO ĮVESTI
IŠDIRBTAS VALANDAS.
JEI VALANDŲ YRA MAŽIAU NEI 160,
PROGRAMA TURI PARODYTI, KIEK
DAR REIKIA IŠDIRBTI, JEI LYGIAI 160,
PARODO, KAD IŠDIRBTAS PILNAS
ETATAS, JEI DAUGIAU PARODO
KIEK YRA VIRŠVALANDŽIŲ.
JEI VARTOTOJAS PADARO ĮVEDIMO
KLAIDĄ PRANEŠTI IR UŽBAIGTI
DARBĄ */

Console.WriteLine("iveskite isdirbta valandu sk.");
var val = Convert.ToInt32(Console.ReadLine());

if (val < 160 && val != 0)
 {
    Console.WriteLine($"Dar truksta {160-val} valandu");
 }
else if (val == 160)
 {
    Console.WriteLine("isdirbtas pilnas etatas");
 }
else if (val > 160)
 {
    Console.WriteLine($"Virsvalandziai = {val-160} ");
 }

else
{
    Console.WriteLine("klaida");
}

//
Console.WriteLine("iveskite isdirbta valandu sk.");
bool arGerasSkaicius = int.TryParse(Console.ReadLine(), out int input);
if (arGerasSkaicius)
{
    if (input < 0 && arGerasSkaicius)
    {
        Console.WriteLine($"Dar truksta {160 - input} valandu");
    }
    else if (input == 160)
    {
        Console.WriteLine("isdirbtas pilnas etatas");
    }
    else if (input > 160)
    {
        Console.WriteLine($"Virsvalandziai = {input - 160} ");
    }
}
else
{
    Console.WriteLine("klaida");
}




Console.WriteLine("--Press any key to continue--");



/* PARAŠYTI PROGRAMĄ, KURI PAPRAŠO VARTOTOJO ĮVESTI
EGZAMINO PAŽYMĮ. IŠVESTI:
0 - 4: NEPATEKINAMAI
5: SILPNAI
6: PATENKINAMAI
7: VIDUTINIŠKAI
8: GERAI
9: LABAI GERAI
10: PUIKIAI */

Console.WriteLine("Iveskite pažymi");
var menuChoice = Convert.ToInt32(Console.ReadLine());

switch (menuChoice)
{
    case 0:
    case 1:
    case 2:
    case 3:
    case 4:
        Console.WriteLine("Nepatenkinamai");
        break;
    case 5:
        Console.WriteLine("Silpnai");
        break;
    case 6:
        Console.WriteLine("Patenkinamai");
        break;
    case 7:
        Console.WriteLine("Vidutiniskai");
        break;
    case 8:
        Console.WriteLine("Gerai");
        break;
    case 9:
        Console.WriteLine("Labai gerai");
        break;
    case 10:
        Console.WriteLine("Puikiai");
        break;
}
var isvedamasRezultatas = menuChoice switch
{
    0 => "Nepatenkinamai",
    1 => "Nepatenkinamai",
    2 => "Nepatenkinamai",
    3 => "Nepatenkinamai",
    4 => "Nepatenkinamai",
    5 => "Silpnai",
    6 => "Patenkinamai",
    7 => "Vidutiniskai",
    8 => "Gerai",
    9 => "Labai gerai",
    10 => "Puikiai",
    _ => null

};
Console.WriteLine($" tai yra {isvedamasRezultatas}");

Console.WriteLine("Iveskite pažymi");
var inputas = Convert.ToInt32(Console.ReadLine());

if( inputas >= 0 && inputas <= 4)
{
    Console.WriteLine("Nepatenkinamai");
}
else if (input == 5)
{
    Console.WriteLine("Silpnai");
}
else if (input == 6)
{
    Console.WriteLine("Patenkinamai");
}
else if (input == 7)
{
    Console.WriteLine("Vidutiniskai");
}
else if (input == 8)
{
    Console.WriteLine("Gerai");
}
else if (input == 9)
{
    Console.WriteLine("Labai gerai");
}
else if (input == 10)
{
    Console.WriteLine("Puikiai");
    Console.WriteLine(inputas);
}

/*
**Nemokama kava**
Aprašykite int kintamajį kuriame nurodysite kiek puodelių kavos perkama. (tarkim 7)
Kas 3 puodelis nemokamas.Paskaičiuokite ir išveskite į ekraną ar pirkėjui priklauso nemokama kava
- Pavyzdžio atsakymas: "pirkėjui priklauso 2 nemokami puodeliai"
- Alternatyvus atsakymas: "Pirkėjui nepriklauso nemokama kava"
*/
Console.WriteLine("Iveskite kiek perkate kavos puodeliu");
var kava = Convert.ToInt32(Console.ReadLine());
if (kava >= 3)
{
    Console.WriteLine($"Pirkejui priklauso {kava/3} nemokami puodeliai");
}
else if (kava <= 2)
{
    Console.WriteLine("Pirkejui nepriklauso nemokama kava");
}

//kitas budas isspresti
Console.WriteLine("\n-------------------------\n");
Console.WriteLine("Iveskite kiek perkate kavos puodeliu");
var kava1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(kava1/3 == 0 ?
    "Pirkejui nepriklauso nemokama kava" :
    $"Pirkejui priklauso {kava1 / 3} nemokami puodeliai");

/*
 ** Piešingi skaičiai **
Naudotojas įveda betkokius 4 sveikus skaicius (tarkim 5; 15; -25; 0;)
- Parašykite programą kuri į ekraną išves neigiamą/teigiamą skaičiaus reikšmę
- Pavyzdžio atsakymas 5 -> -5; 15 -> -15; -25 -> 25; 0 -> N/A;
 */

/* kazkas ne taip..
Console.WriteLine("\n-------------------------\n");
Console.WriteLine("pirmą");
var skaicius1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("antrą");
var skaicius2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("trečią");
var skaicius3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ketvirtą");
var skaicius4 = Convert.ToInt32(Console.ReadLine());

if (skaicius1 > 0)
if (skaicius2 > 0)
if (skaicius3 > 0)
if (skaicius4 > 0)
            {
    Console.WriteLine($"{skaicius1} --> {skaicius1 * -1};");
        Console.WriteLine($"{skaicius2} --> {skaicius2 * -1};");
                Console.WriteLine($"{skaicius3} --> {skaicius3 * -1};");
                Console.Write($"{skaicius4} --> {skaicius4 * -1};");

            }
else if (skaicius1 == 0)
        (skaicius2 == 0)
        (skaicius3 == 0)
        (skaicius4 == 0)

            {
    Console.Write($"{skaicius1} --> N/A");
        Console.Write($"{skaicius2} --> N/A");
                Console.Write($"{skaicius3} --> N/A");
                Console.Write($"{skaicius4} --> N/A");


            }

*/
Console.WriteLine("\n-------------------------\n");
Console.WriteLine("pirmą");
var sk1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("antrą");
var sk2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("trečią");
var sk3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ketvirtą");
var sk4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(sk1 != 0 ? $"{sk1} --> {sk1*-1}" : $" 0 => N/A");
Console.WriteLine(sk2 != 0 ? $"{sk2} --> {sk2 * -1}" : $" 0 => N/A");
Console.WriteLine(sk3 != 0 ? $"{sk3} --> {sk3 * -1}" : $" 0 => N/A");
Console.WriteLine(sk4 != 0 ? $"{sk4} --> {sk4 * -1}" : $" 0 => N/A");