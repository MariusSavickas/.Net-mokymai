// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Operatoriai!");

//Reliaciniai operatoriai == > < >= <=

var skaicius = 10;
var nelyginisskaicius = 5;
var lyginisskaicius = 10;
Console.WriteLine( " == patikrina ar kintamieji yra lygus");
Console.WriteLine($" {skaicius}=={lyginisskaicius}yra {skaicius==lyginisskaicius}  ");
bool ar10yraLygu5 = skaicius == nelyginisskaicius;
Console.WriteLine($"{skaicius}=={nelyginisskaicius} yra {ar10yraLygu5}");
Console.WriteLine("-----------------\n");
Console.WriteLine(" != patikrina ar kintamieji yra nelygus");
Console.WriteLine($" {skaicius}!={lyginisskaicius}yra {skaicius != lyginisskaicius}  ");
Console.WriteLine($"{skaicius}!={nelyginisskaicius} yra {skaicius!=nelyginisskaicius}");
Console.WriteLine("-----------------\n");
Console.WriteLine(" > patikrina ar kaireje esanti reiksme didesne uz esancia desineje");
Console.WriteLine($" {skaicius}>{lyginisskaicius}yra {skaicius > lyginisskaicius}  ");
Console.WriteLine($"{skaicius}>{nelyginisskaicius} yra {skaicius > nelyginisskaicius}");
Console.WriteLine("-----------------\n");
Console.WriteLine(" < patikrina ar kaireje esanti reiksme mazesne uz esancia desineje");
Console.WriteLine($" {skaicius}<{lyginisskaicius}yra {skaicius < lyginisskaicius}  ");
Console.WriteLine($"{skaicius}<{nelyginisskaicius} yra {skaicius < nelyginisskaicius}");
Console.WriteLine("-----------------\n");
Console.WriteLine(" >= patikrina ar kaireje esanti reiksme didesne arba lygi uz esancia desineje");
Console.WriteLine($" {skaicius}>={lyginisskaicius}yra {skaicius >= lyginisskaicius}  ");
Console.WriteLine($"{skaicius}>={nelyginisskaicius} yra {skaicius >= nelyginisskaicius}");
Console.WriteLine("-----------------\n");
Console.WriteLine(" <= patikrina ar kaireje esanti reiksme mazesne arba lygi uz esancia desineje");
Console.WriteLine($" {skaicius}<={lyginisskaicius}yra {skaicius <= lyginisskaicius}  ");
Console.WriteLine($"{skaicius}<={nelyginisskaicius} yra {skaicius <= nelyginisskaicius}");

//Uzduotys

/*
sukurkite naują kintamajį long ir prskirkite didžiausią reikšmę.
sukurkite naują kintamajį short ir prskirkite didžiausią reikšmę
- padalinkite didesnį skaičių iš mažesnio
- iš rezultato atimkite maksimalų long skaičių
- ir pridėkite maksimalų int skaičių

*/
long naujassk = long.MaxValue;
short naujassort = short.MaxValue;


Console.WriteLine($" dalyba = {naujassk / naujassort}");
Console.WriteLine($"dalybos rez - lon.maxvalue {naujassk / naujassort - naujassk}");

int naujasint = int.MaxValue;
Console.WriteLine($"dalybos rez - lon.maxvalue {naujassk / naujassort - naujassk + naujasint}");

/*PARAŠYTI PROGRAMĄ KURI DIDELĮ 10 ŽENKLĮ SKAIČIŲ DOUBLE, KONVERTUOJA Į
INT , SHORT , BYTE
STEBĖTI REZULTATĄ.
*/
/* mano
double Didelisskaicius = 2121212121;
Console.WriteLine(Didelisskaicius);
long longdidelis = Convert.ToInt64(Didelisskaicius);
Console.WriteLine(longdidelis);
short shortdidelis = Convert.ToInt32(Didelisskaicius);
Console.WriteLine(shortdidelis);
*/

//destytojo
/*
Console.WriteLine("------------------------");
double didelisskaicius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($" INT = {(int)didelisskaicius}");
Console.WriteLine($" SHORT = {(short)didelisskaicius}");
Console.WriteLine($" BYTE = {(byte)didelisskaicius}");
*/

//Console.WriteLine(Convert.ToInt32(didelisskaicius)); //Luzta

/*
 * Para6yti Programa kur praso ivesti rutulio diametra ir isveda plota ir turi
 * V = 4/3πr^3, V - tūris, r - spindulys
S = 4πr^2, S - plotas
 */
/*
Console.WriteLine("Iveskite rutulo diametra");
var sphereDiameter = double.Parse(Console.ReadLine());
var sphereRadius = sphereDiameter / 2;
var spherearea = 4 * 3.14 * sphereRadius * sphereRadius;
var sphereVolume = (4/3) *3.14 *(sphereRadius * sphereRadius*sphereRadius);
Console.WriteLine($" Plotas = {spherearea}");
Console.WriteLine($" Turis = {sphereVolume}");
*/
/*
 * PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI ATSTUMĄ (METRAIS) IR LAIKĄ (SEKUNDĖMIS),
- IŠVEDA GREITĮ km/h.
- IŠVEDA GREITĮ km/s.
*/ /*
Console.WriteLine("Iveskite atstuma metrais");
var atstumas = double.Parse(Console.ReadLine());
Console.WriteLine("Iveskite laika sekundemis");
var laikas = double.Parse(Console.ReadLine());

Console.WriteLine($" km/h = {(atstumas/1000)/(laikas/3600)}"); //1000 ir 3600 reiktu apsirasyti kaip kintamuosius
Console.WriteLine($" km/s = {(atstumas / 1000) / laikas }");
*/
/*
//Nuskaitykite 2 sk. (x ir y)
//isveskite i ekrana funkcija y+2y+x+1 ir apskaiciuoti rezultata

Console.WriteLine("x");
var xsk = double.Parse(Console.ReadLine());
Console.WriteLine("Iveskite y");
var ysk = double.Parse(Console.ReadLine());
Console.WriteLine($" y+2y+x+1 = {ysk + 2*ysk + xsk +1}");
Console.WriteLine($" y²+x/2 = {(ysk*ysk)+xsk/2}");
*/

/*
 PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI PENKIAŽENKLĮ SVEIKĄ SKAIČIŲ
VISUS ĮVESTUS 1 PAKEISKITE Į 0 IR GAUTĄ SKAIČIŲ PADALINKITE IŠ 2
PVZ BUVO ĮVESTA 12345
REZULTATAS 2345/2=1172,5
<HINT> naudokite replace
*/
/*
Console.WriteLine("Iveskite penkiazenkli skaiciu");
var penksk = Convert.ToDouble(Console.ReadLine().Replace("1", "0"));
Console.WriteLine($" Buvo ivesta {penksk}");
Console.WriteLine($" Rezultatas = { penksk/2}");
*/
/*
PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI PENKIAŽENKLĮ SVEIKĄ SKAIČIŲ
VISUS ĮVESTUS išskyrus 1 PAKEISKITE Į 0 IR GAUTĄ SKAIČIŲ PADALINKITE IŠ 2
PVZ BUVO ĮVESTA 12345
REZULTATAS 10000/2=5000
<HINT> naudokite replace
*/
/*
Console.WriteLine("Iveskite penkiazenkli skaiciu");
var penksk1 = Convert.ToDouble(Console.ReadLine()
    .Replace("2", "0")
    .Replace("3", "0")
.Replace("4", "0")
.Replace("5", "0")
.Replace("6", "0")
.Replace("7", "0")
.Replace("8", "0")
.Replace("9", "0"));
    
Console.WriteLine($" Buvo ivesta {penksk1}");
Console.WriteLine($" Rezultatas = {penksk1 / 2}");
*/
/*
 PARAŠYTI PROGRAMĄ KURI NAUDOTOJO PAPRAŠO ĮVESTI SVEIKĄ SKAIČIŲ
VIENOJE EILUTĖJE IŠVESKITE ŠĮ SKAIČIŲ 5 KARTUS VIS PADIDINAMI VIENETU.
PVZ BUVO ĮVESTA 5
REZULTATAS 6 7 8 9 10
 */

Console.WriteLine("Iveskite sveika skaiciu");
var sveikas = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($" Rezultatas: {++sveikas},{++sveikas},{++sveikas},{++sveikas},{++sveikas}") ;