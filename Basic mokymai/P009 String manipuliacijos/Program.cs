// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, string!");

//Console.WriteLine("kazkas");
//string b = Console.ReadLine();

//ConsoleKeyInfo c = Console.ReadKey();

Console.WriteLine("******** string constructor");
Console.WriteLine("String manipuliacijos");
char[] letters = { 'H', 'e', 'l', 'l', 'o' }; //array-masyvas
string greetings = new string(letters); //string constructor

Console.WriteLine(greetings);
Console.WriteLine(greetings[1]); //jei isvesti viena raide arba letters[]

//pvz
string vardas = "Petras";
Console.WriteLine(vardas[2]);

//************

Console.WriteLine("******** string concatination");
var pilnasVardas = vardas + " Pavardenis";
Console.WriteLine(pilnasVardas);

//************

Console.WriteLine("******** string composition");
DateTime siandien = DateTime.Today;
var vardasIrData = string.Format("{0} data = {1}", vardas, siandien);
Console.WriteLine(vardasIrData);

//************
Console.WriteLine("******** string interpolation");
var vardasIrData1 = $"{vardas} data = {siandien}";
Console.WriteLine(vardasIrData1);

//************
string? nullas = null;
string baltaErdve = "                                 ";
string tuscia = "";
string tuscia1 = string.Empty;

Console.WriteLine($" ar \"\" yra tapatu string.Empty {tuscia == tuscia1}" );
// is destytojo P009_strin 43-55

//************
Console.WriteLine("------------------------------------");
string aa1 = "kabute = \"";
string aa2 = "kabute = \\";
string aa3 = "kabute = \n";
string aa4 = $"eilute {Environment.NewLine} nauja";
string aa5 = $"kelias diskineje sistemoje {Path.DirectorySeparatorChar}program files{Path.DirectorySeparatorChar}windows";
string aa6 = $"{{}}";
string aa7 = @" galime
rasyti teksta
per \ { @ ""
kelias eilutes";

//************
Console.WriteLine("------------------------------------");
double skaicius = 666.544654655656555;
string skaiciusSuApribotuKiekiuPoKablelio = skaicius.ToString("0.00"); //gaunasi tekstine reiksme
Console.WriteLine(skaiciusSuApribotuKiekiuPoKablelio); //su ja negalime atlikti veiksmo

