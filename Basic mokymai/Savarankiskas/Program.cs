// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Savarankiškos užduotys");
/*
 Paprašykite naudotojo įvesti 1 skaičių - temperatūrą pagal Celsijų. 
   - Paskaičiuokite ir išveskite į ekraną temperatūrą pagal farenheitą.+
   - Paskaičiuokite ir išveskite į ekraną temperatūrą pagal kelviną.+
   - Gautą temperatūrą pagal farenheitą perskaičiuokite į Celsijų ir patikrinkite ar sutampa su įvestu skaičių (išveskite true/false)+
   - Gautą temperatūrą pagal kelviną perskaičiuokite į celsijų ir patikrinkite ar sutampa su įvestu skaičiu (išveskite true/false)+
   - Paskaičiuotą temperatūrą pagal farenheita peverskite į kelviną ir patikrinkite ar sutampa su ankstesniais skaičiavimais (išveskite true/false)
   - Nupieškite termometrą pagal Celsijų 
     a) Atvaizduokite skalę, sugraduotą kas 5 laipsnius C priklausomai nuo įvestos temperatūros pridedant ir atimant 40 laipsnių 
       (tarkime įvesta buvo 10, tuomet skalė bus nuo -30 iki +50)
     b) Grafiškai atvaizduokite įvestą temperatūros stulpelį. 
        <HINT> naudokite .ToString(), palyginimo reliacinius operatorius (==, >, < ir t.t.) ir .Replace(). 
        if naudoti negalima, ternary operator (?) naudoti negalima.
rezultatas gali atrodyti taip:
                            |--------------------|
                            |   ^F     _    ^C   |
                            |  100  - | | -  40  |
                            |   95  - | | -  35  |
                            |   90  - | | -  30  |
                            |   80  - | | -  25  |
                            |   70  - | | -  20  |
                            |   60  - | | -  15  |
                            |   50  - |#| -  10  |
                            |   40  - |#| -   5  |
                            |   30  - |#| -   0  |
                            |   20  - |#| -  -5  |
                            |   10  - |#| - -10  |
                            |    5  - |#| - -15  |
                            |    0  - |#| - -20  |
                            |  -10  - |#| - -25  |
                            |  -20  - |#| - -30  |
                            |  -30  - |#| - -35  |
                            |  -40  - |#| - -40  |
                            |        '***`       |
                            |       (*****)      |
                            |        `---'       |
                            |____________________|
 */

Console.WriteLine("Įveskite 1 sveiką skaičių - temperatūrą pagal Celsijų");
var LaipsniaiC = Convert.ToDouble(Console.ReadLine()); //Vartotojo įvestas skaičius
var LaipsniaiF = LaipsniaiC * 9 / 5 + 32; //F = (C * 9) / 5 + 32; Formulė pasiversti iš Celsijaus į Farenheito skalę
var LaipsniaiK = LaipsniaiC + 273.15;  //Kelvin = Celsius + 273.15 formule


// Paskaičiuokite ir išveskite į ekraną temperatūrą pagal farenheitąir kelviną
Console.WriteLine( $" Temperatūra pagal farenheita:  {LaipsniaiF}" );
Console.WriteLine($" Temperatūra pagal kelviną:  {LaipsniaiK}");
Console.WriteLine("-------------------\n");

//Gautą temperatūrą pagal farenheitą perskaičiuokite į Celsijų ir patikrinkite ar sutampa su įvestu skaičių (išveskite true/false)
//Formulė C = (F – 32) * 5 / 9; iš farenheito į celsijų
var LaipsniaiC1 = (LaipsniaiF - 32) * 5 / 9;
Console.WriteLine($"Vartotojo įveskas sk.= mūsų paverstam iš farenheito į celsijų {LaipsniaiC==LaipsniaiC1} ");//Lyginame ar vartotojo įvestas sk. lygus mūsų paverstam sk. iš farenheito į celsijų
var LaipsniaiC2 = LaipsniaiK - 273.15; //formulė C = K - 273.15   
Console.WriteLine($"Vartotojo įveskas sk.= mūsų paverstam iš kelvino į celsijų {LaipsniaiC==LaipsniaiC2} ");//Lyginame ar vartotojo įvestas sk. lygus mūsų paverstam sk. iš kelvino į celsijų
Console.WriteLine("-------------------\n");

//Paskaičiuotą temperatūrą pagal farenheita peverskite į kelviną ir patikrinkite ar sutampa su ankstesniais skaičiavimais (išveskite true/false)
//Formulė F to K; K = (F-32)*5/9+ 273.15
var LaipsniaiK2 = (LaipsniaiF - 32) * 5 / 9 +273.15;
Console.WriteLine($"Lyginame prieš tai gauto kelvino skales laipsnius su iš farenheito skalės paverstu atgal {LaipsniaiK==LaipsniaiK2}");
Console.WriteLine("-------------------\n");

//Nupieškite termometrą pagal Celsijų 
//kintamieji
var LaipsniaiF40 = (LaipsniaiC+40) * 9 / 5 + 32;
var LaipsniaiF35 = (LaipsniaiC+35) * 9 / 5 + 32;
var LaipsniaiF30 = (LaipsniaiC + 30) * 9 / 5 + 32;
var LaipsniaiF25 = (LaipsniaiC + 25) * 9 / 5 + 32;
var LaipsniaiF20 = (LaipsniaiC + 20) * 9 / 5 + 32;
var LaipsniaiF15 = (LaipsniaiC + 15) * 9 / 5 + 32;
var LaipsniaiF10 = (LaipsniaiC + 10) * 9 / 5 + 32;
var LaipsniaiF5 = (LaipsniaiC + 5) * 9 / 5 + 32;
var LaipsniaiF_5 = (LaipsniaiC - 5) * 9 / 5 + 32;
var LaipsniaiF_10 = (LaipsniaiC -10) * 9 / 5 + 32;
var LaipsniaiF_15 = (LaipsniaiC - 15) * 9 / 5 + 32;
var LaipsniaiF_20 = (LaipsniaiC -20) * 9 / 5 + 32;
var LaipsniaiF_25 = (LaipsniaiC - 25) * 9 / 5 + 32;
var LaipsniaiF_30 = (LaipsniaiC - 30) * 9 / 5 + 32;
var LaipsniaiF_35 = (LaipsniaiC - 35) * 9 / 5 + 32;
var LaipsniaiF_40 = (LaipsniaiC -40) * 9 / 5 + 32;



Console.WriteLine("|--------------------|");
Console.WriteLine("|   ^F     _     ^C  |"); //8 0 8
Console.WriteLine($"|{LaipsniaiF40,6} - |{LaipsniaiC >= LaipsniaiC + 40}| - {LaipsniaiC+40,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine($"|{LaipsniaiF35,6} - |{LaipsniaiC >= LaipsniaiC + 35}| - {LaipsniaiC + 35,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine($"|{LaipsniaiF30,6} - |{LaipsniaiC >= LaipsniaiC + 30}| - {LaipsniaiC + 30,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine($"|{LaipsniaiF25,6} - |{LaipsniaiC >= LaipsniaiC + 25}| - {LaipsniaiC + 25,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine($"|{LaipsniaiF20,6} - |{LaipsniaiC >= LaipsniaiC + 20}| - {LaipsniaiC + 20,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine($"|{LaipsniaiF15,6} - |{LaipsniaiC >= LaipsniaiC + 15}| - {LaipsniaiC + 15,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine($"|{LaipsniaiF10,6} - |{LaipsniaiC >= LaipsniaiC + 10}| - {LaipsniaiC + 10,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine($"|{LaipsniaiF5,6} - |{LaipsniaiC >= LaipsniaiC+5}| - {LaipsniaiC + 5,4} |".ToString().Replace("True", "#").Replace("False"," "));
Console.WriteLine($"|{LaipsniaiF,6} - |{LaipsniaiC >= LaipsniaiC}| - {LaipsniaiC,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine($"|{LaipsniaiF_5,6} - |{LaipsniaiC >= LaipsniaiC - 5}| - {LaipsniaiC-5,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine($"|{LaipsniaiF_10,6} - |{LaipsniaiC >= LaipsniaiC - 10}| - {LaipsniaiC-10,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine($"|{LaipsniaiF_15,6} - |{LaipsniaiC >= LaipsniaiC - 15}| - {LaipsniaiC-15,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine($"|{LaipsniaiF_20,6} - |{LaipsniaiC >= LaipsniaiC - 20}| - {LaipsniaiC-20,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine($"|{LaipsniaiF_25,6} - |{LaipsniaiC >= LaipsniaiC - 25}| - {LaipsniaiC-25,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine($"|{LaipsniaiF_30,6} - |{LaipsniaiC >= LaipsniaiC - 30}| - {LaipsniaiC-30,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine($"|{LaipsniaiF_35,6} - |{LaipsniaiC >= LaipsniaiC - 35}| - {LaipsniaiC-35,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine($"|{LaipsniaiF_40,6} - |{LaipsniaiC >= LaipsniaiC - 40}| - {LaipsniaiC-40,4} |".ToString().Replace("True", "#").Replace("False", " "));
Console.WriteLine("|        '***`       |");
Console.WriteLine("|       (*****)      |");
Console.WriteLine("|        `---'       |");
Console.WriteLine("|____________________|");


Console.WriteLine("\n\n----------------------------------\n\n");




/*
 PARAŠYTI PROGRAMĄ KURI PRAŠO ĮVESTI ATSTUMĄ (KILOMENTRAIS) TARP TAŠKŲ A IR B IR DVIEJŲ TRANSPORTO PRIEMONIŲ GREITĮ (KM/H). 
 VIENA TRANSPORTO PRIEMONĖS PRADEDA VAŽIUOTI IŠ A, KITA IŠ B.STARTUOJA VIENU METU.
  - PASKAIČIUOTI ATSTUMĄ NUO A IKI VIETOS KURIOJE TRASPORTO PRIEMONĖS SUTITIKS METRAIS. 
  - PASKAIČIUOTI LAIKĄ KADA TRASPORTO PRIEMONĖS SUSITIKS SEKUNDĖMIS. 
  - PASKAIČIUOTI LAIKĄ, KADA TRASPORTUO PRIEMONĖS PASIEKS GALIUTINIUS TAŠKUS MINUTĖMIS.
  - PASKAIČIUOTI KIEK GRAMŲ CO2 IŠSKYRĖ ABI TRASPORTO PIEMONĖS KARTU SUDĖJUS. CO2 NORMA YRA 95 g/km.
  - GRAFIŠKAI PAVAIZDUOTI KELIĄ NUO A IKI B SUSKIRSTYTĄ Į 20 LYGIŲ SEGMENTŲ (TARKIME ĮVESTAS ATSTUMAS YRA 100KM, TUOMENT TURĖSIME 20 SEGMENTU PO 5KM).  
    A) PARODYTI VISO KELIO ILGĮ KM
    B) PARODYTI SEGMENTO ILGĮ KM
    C) PARODYTI KURIAME SEGMENTE TRASPORTO PREMONĖS SUTIKS IR ATSTUMĄ IKI SUSITIKIMO (TAŠKAS V)
    D) PARODYTI ABIEJŲ TRANSPORTO PRIEMONIŲ VAŽIAVIMO TRUKMĘ
    REZULTATAS GALI ARTODYTI TAIP:
     
    | 5km  | 5km  | 5km  | 5km   | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  | 5km  |
    |      |      |      |       |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |      |
   _A______|______|______|___V___|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______|______B_
    |-----------22km---------|        
    |----------------------------------------------------------------100km-----------------------------------------------------------------------|        
    >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> 90min >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< 30min <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
 */

Console.WriteLine("Kelias\n");
Console.WriteLine("Įveskite atstumą tarp A ir B kilometrais"); //Vartotojas prašomas įvesti kintamuosius:
var atstumas = Convert.ToDouble(Console.ReadLine()); //atstumą
Console.WriteLine("Įveskite A transporto priemonės greitį (km/h)");
var GreitisA = Convert.ToDouble(Console.ReadLine());  //greitį A
Console.WriteLine("Įveskite B transporto priemonės greitį (km/h)");
var GreitisB = Convert.ToDouble(Console.ReadLine());  //greitį B

Console.WriteLine("------------------------------------\n");

//PASKAIČIUOTI ATSTUMĄ NUO A IKI VIETOS KURIOJE TRASPORTO PRIEMONĖS SUTITIKS METRAIS. 
var atstumasmetrais = atstumas * 1000; //atstumas tarp A ir B metrais
var GreitisAmperS = GreitisA * 1000 / 3600; //Formulė km/h pasiversti į m/s
var GreitisBmperS = GreitisB * 1000 / 3600; //Formulė km/h pasiversti į m/s



var susitikimas = atstumas / (GreitisA + GreitisB);//Trukmė Per kiek laiko abi įveikia atstumą valandomis
var susitikimas1 = susitikimas * GreitisA *1000; // Kada susitiks, kiek atstumo įveiks A transporto priemonė


Console.WriteLine($"Transporto priemonės susitiks. A nuvažiavus {susitikimas1} metrų\n");
Console.WriteLine("------------------------------------\n");

//PASKAIČIUOTI LAIKĄ KADA TRASPORTO PRIEMONĖS SUSITIKS SEKUNDĖMIS.
var susitikimassek = susitikimas * 3600; //valandas verčiam į sekundes
Console.WriteLine($" Transporto priemonės susitiks sekundėmis po: {susitikimassek} sek.");
Console.WriteLine("------------------------------------\n");

//PASKAIČIUOTI LAIKĄ, KADA TRASPORTUO PRIEMONĖS PASIEKS GALIUTINIUS TAŠKUS MINUTĖMIS.

var nuvaziuosAmin = atstumas / GreitisA * 60;
var nuvaziuosBmin = atstumas / GreitisB * 60;

Console.WriteLine($"A transporto priemonė nuvažiuos atstumą per {nuvaziuosAmin} min." );
Console.WriteLine($"B transporto priemonė nuvažiuos atstumą per {nuvaziuosBmin} min.");
Console.WriteLine("------------------------------------\n");

//PASKAIČIUOTI KIEK GRAMŲ CO2 IŠSKYRĖ ABI TRASPORTO PIEMONĖS KARTU SUDĖJUS. CO2 NORMA YRA 95 g/km.

var CO2 = atstumas * 2 * 95;
Console.WriteLine($" CO2 kelionės metu išskyrė: {CO2}");
Console.WriteLine("------------------------------------\n");


var seg = atstumas / 20; //Formulė pasidaryti 20 lygių segmentų

//V ieškojimas segmente
var VKM = susitikimas1 / 1000; //Kiek nuvažiuos A transporto priemonė metrus pasiverčiam į km.

var seg1 = (VKM >= seg).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg2 = (!(seg <= VKM) || (VKM>= seg*2)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg3 = (!(seg*2 <= VKM) ||(VKM >= seg * 3)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg4 = (!(seg*3 <= VKM) ||(VKM >= seg * 4)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg5 = (!(seg*4 <= VKM) ||(VKM >= seg * 5)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg6 = (!(seg*5 <= VKM) ||(VKM >= seg * 6)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg7 = (!(seg*6 <= VKM) || (VKM >= seg * 7)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg8 = (!(seg*7 <= VKM) || (VKM >= seg * 8)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg9 = (!(seg*8 <= VKM) || (VKM >= seg * 9)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg10 = (!(seg*9 <= VKM) || (VKM >= seg * 10)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg11 = (!(seg * 10 <= VKM) || (VKM >= seg * 11)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg12 = (!(seg * 11 <= VKM) || (VKM >= seg * 12)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg13 = (!(seg * 12 <= VKM) || (VKM >= seg * 13)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg14 = (!(seg * 13 <= VKM) || (VKM >= seg * 14)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg15 = (!(seg * 14 <= VKM) || (VKM >= seg * 15)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg16 = (!(seg * 15 <= VKM) || (VKM >= seg * 16)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg17 = (!(seg * 16 <= VKM) || (VKM >= seg * 17)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg18 = (!(seg * 17 <= VKM) || (VKM >= seg * 18)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg19 = (!(seg * 18 <= VKM) || (VKM >= seg * 19)).ToString().Replace("False", "____V___|").Replace("True", "________|");
var seg20 = (!(seg * 19 <= VKM) || (VKM >= seg * 20)).ToString().Replace("False", "____V___|").Replace("True", "________|");

//Kelias ilgis kuriame susitiks
var seg21 = (VKM >= seg).ToString().Replace("False", "        ").Replace("True", "-------");
var seg22 = ((seg <= VKM) || (VKM >= seg * 2)).ToString().Replace("False", "      ").Replace("True", "-------");
var seg23 = ((seg * 2 <= VKM) || (VKM >= seg * 3)).ToString().Replace("False", "        ").Replace("True", "-------");
var seg24 = ((seg * 3 <= VKM) || (VKM >= seg * 4)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg25 = ((seg * 4 <= VKM) || (VKM >= seg * 5)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg26 = ((seg * 5 <= VKM) || (VKM >= seg * 6)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg27 = ((seg * 6 <= VKM) || (VKM >= seg * 7)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg28 = ((seg * 7 <= VKM) || (VKM >= seg * 8)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg29 = ((seg * 8 <= VKM) || (VKM >= seg * 9)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg30 = ((seg * 9 <= VKM) || (VKM >= seg * 10)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg31 = ((seg * 10 <= VKM) || (VKM >= seg * 11)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg32 = ((seg * 11 <= VKM) || (VKM >= seg * 12)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg33 = ((seg * 12 <= VKM) || (VKM >= seg * 13)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg34 = ((seg * 13 <= VKM) || (VKM >= seg * 14)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg35 = ((seg * 14 <= VKM) || (VKM >= seg * 15)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg36 = ((seg * 15 <= VKM) || (VKM >= seg * 16)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg37 = ((seg * 16 <= VKM) || (VKM >= seg * 17)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg38 = ((seg * 17 <= VKM) || (VKM >= seg * 18)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg39 = ((seg * 18 <= VKM) || (VKM >= seg * 19)).ToString().Replace("False", "        ").Replace("True", "---------");
var seg40 = ((seg * 19 <= VKM) || (VKM >= seg * 20)).ToString().Replace("False", "        ").Replace("True", "---------");




//b) segmento ilgis, 20 lygių segmentų
Console.WriteLine($"| {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  | {seg,3}km  |");
Console.WriteLine("|        |        |        |        |        |        |        |        |        |        |        |        |        |        |        |        |        |        |        |        |    ");
Console.WriteLine($"A{seg1}{seg2}{seg3}{seg4}{seg5}{seg6}{seg7}{seg8}{seg9}{seg10}{seg11}{seg12}{seg13}{seg14}" +
    $"{seg15}{seg16}{seg17}{seg18}{seg19}{seg20}");
Console.WriteLine($"|{seg21}{seg22}{VKM}km{seg23}{seg24}{seg25}{seg26}{seg27}{seg28}{seg29}{seg30}{seg31}{seg32}{seg33}" +
    $"{seg34}{seg35}{seg36}{seg37}{seg38}{seg39}{seg40}");
//a) visas kelio ilgis 
Console.WriteLine($"|------------------------------------------------------------------------------------{atstumas}km------------------------------------------------------------------------------------------|");

//d) Transporto važiavimo trukmė
Console.WriteLine($">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> {nuvaziuosAmin}min >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine($"<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< {nuvaziuosBmin}min <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<");