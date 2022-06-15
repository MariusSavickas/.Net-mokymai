// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Loginiai operatoriai");

Console.WriteLine("&&  (AND), ||(OR), ! (NOT), ^(XOR)");

Console.WriteLine("Neigimas !");
bool tiesa = true;
bool melas = !tiesa;

Console.WriteLine($" tiesa {tiesa}");
Console.WriteLine($" !melas = {melas}");
Console.WriteLine($" !melas = {!melas}");

Console.WriteLine(" AND &&");
Console.WriteLine($" tiesa AND tiesa {tiesa && tiesa}");
Console.WriteLine($" tiesa AND melas {tiesa && melas}");
Console.WriteLine($" melas AND tiesa {melas && tiesa}");
Console.WriteLine($" melas AND melas {melas && melas}");

Console.WriteLine(" OR || ");
Console.WriteLine($" tiesa OR tiesa {tiesa || tiesa}");
Console.WriteLine($" tiesa OR melas {tiesa || melas}");
Console.WriteLine($" melas OR tiesa {melas || tiesa}");
Console.WriteLine($" melas OR melas {melas || melas}");

Console.WriteLine(" XOR ^ ");
Console.WriteLine($" tiesa XOR tiesa {tiesa ^ tiesa}");
Console.WriteLine($" tiesa XOR melas {tiesa ^ melas}");
Console.WriteLine($" melas XOR tiesa {melas ^ tiesa}");
Console.WriteLine($" melas XOR melas {melas ^ melas}");

Console.WriteLine(" NAND ! && ");
Console.WriteLine($" tiesa NAND tiesa {!(tiesa && tiesa)}");
Console.WriteLine($" tiesa NAND melas {!(tiesa && melas)}");
Console.WriteLine($" melas NAND tiesa {!(melas && tiesa)}");
Console.WriteLine($" melas NAND melas {!(melas && melas)}");


Console.WriteLine(" NOR ! OR ");
Console.WriteLine($" tiesa NOR tiesa {!(tiesa || tiesa)}");
Console.WriteLine($" tiesa NOR melas {!(tiesa || melas)}");
Console.WriteLine($" melas NOR tiesa {!(melas || tiesa)}");
Console.WriteLine($" melas NOR melas {!(melas || melas)}");

Console.WriteLine(" NXOR ! ^ ");
Console.WriteLine($" tiesa NXOR tiesa {!(tiesa ^ tiesa)}");
Console.WriteLine($" tiesa NXOR melas {!(tiesa ^ melas)}");
Console.WriteLine($" melas NXOR tiesa {!(melas ^ tiesa)}");
Console.WriteLine($" melas NXOR melas {!(melas ^ melas)}");

Console.WriteLine($" melas OR melas OR tiesa {melas || melas || tiesa}");

int a = 5;
int b = 5;
int c = 6;
bool s = a >= b && a > c;
Console.WriteLine(s);

/*
 * PARAŠYTI PROGRAMĄ KURI
PRAŠO ĮVESTI 2 SKAIČIUS.
JEI ABU LYGŪS,
PROGRAMA TURI IŠVESTI
TRUE , JEI NE FALSE
*/
/*
Console.WriteLine("Iveskite pirma skaiciu");
var vienas = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Iveskite antra skaiciu");
var antras = Convert.ToInt32(Console.ReadLine());
*/
//lyginimas
/*
Console.WriteLine($" ar lygus {vienas == antras}");
*/
/*
 * PARAŠYTI PROGRAMĄ KURI
PRAŠO ĮVESTI 2 SKAIČIUS.
JEI ABU LYGINIAI,
PROGRAMA TURI IŠVESTI
TRUE , JEI NE FALSE
*/
/* reik nusikopinti is destytojo 
Console.WriteLine("Iveskite pirma skaiciu");
var ant = Convert.ToInt32(Console.ReadLine());
var ivestas = ant  % 2;
Console.WriteLine("Iveskite antra skaiciu");
var ant2 = Convert.ToInt32(Console.ReadLine());
var ivestas2 = ant2  % 2;
Console.WriteLine($" ar lygus {ivestas == ivestas2}");
*/
/*
Tikriausiai žinote, kad elektronikoje signalai koduojami dviejų bitų kodu. Ty 0(low) ir 1(high).
išsivaizduokite du ryšio kanalus kurie atsiunčia štai tokią informaciją:
kanalas A __---___---___---___---___
kanalas B ____---___---___---___---_
Apatinis brūkšnys (_) reiškia false, o paprastas(-) true.
Parašykite progamą kuri atvazduoja šių kanalų logines operacijas:
a) A AND B
b) A OR B
c) A XOR B
d) A NAND B
e) A NOR B
f) NOT A
g) NOT A OR B
e) (A OR B) NAND A

atsakymas:
a) ____ - _____ - _____ - _____ - ___
b) __---- - _---- - _---- - _---- - _
c) __--_--_--_--_--_--_--_--_
*/



//A
Console.WriteLine("kanalas A \n");
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));

Console.WriteLine("\nkanalas B \n");
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false}".ToString().Replace("False", "_").Replace("True", "-"));

Console.WriteLine("\n \n");

Console.Write("\n a)  "); // A && B
Console.Write($"{false && false && false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false && false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true && false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true && false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true && true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false && true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false && true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false && false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true && false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true && false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true && true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false && true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false && true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false && false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true && false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true && false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true && true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false && true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false && true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false && false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true && false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true && false && false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true && true && true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false && true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false && true && true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false && false && false && false}".ToString().Replace("False", "_").Replace("True", "-"));

Console.Write("\n b)  "); //A OR B
Console.Write($"{false || false || false || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false || false || false || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true || true || false || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true || true || false || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true || true || true || true}".ToString().Replace("False", "_").Replace("True", "-")); //5
Console.Write($"{false || false || true || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false || false || true || true}".ToString().Replace("False", "_").Replace("True", "-"));//7
Console.Write($"{false || false || false || false}".ToString().Replace("False", "_").Replace("True", "-"));//8
Console.Write($"{true || true || false || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true || true || false || false}".ToString().Replace("False", "_").Replace("True", "-"));//10
Console.Write($"{true || true || true || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false || false || true || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false || false || true || true}".ToString().Replace("False", "_").Replace("True", "-"));//13
Console.Write($"{false || false || false || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true || true || false || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true || true || false || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true || true || true || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false || false || true || true}".ToString().Replace("False", "_").Replace("True", "-"));//18
Console.Write($"{false || false || true || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false || false || false || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true || true || false || false}".ToString().Replace("False", "_").Replace("True", "-"));//21
Console.Write($"{true || true || false || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true || true || true || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false || false || true || true}".ToString().Replace("False", "_").Replace("True", "-")); //24
Console.Write($"{false || false || true || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false || false || false || false}".ToString().Replace("False", "_").Replace("True", "-"));

Console.Write("\n c)  "); //A XOR B
Console.Write($"{false ^  false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false ^ false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true ^ false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true ^ false}".ToString().Replace("False", "_").Replace("True", "-")); //4
Console.Write($"{true ^ true }".ToString().Replace("False", "_").Replace("True", "-")); //5
Console.Write($"{false ^ true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false ^ true}".ToString().Replace("False", "_").Replace("True", "-"));//7
Console.Write($"{false ^ false}".ToString().Replace("False", "_").Replace("True", "-"));//8
Console.Write($"{true ^ false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true ^  false}".ToString().Replace("False", "_").Replace("True", "-"));//10
Console.Write($"{true ^ true }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false  ^ true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false  ^ true}".ToString().Replace("False", "_").Replace("True", "-"));//13
Console.Write($"{false  ^ false}".ToString().Replace("False", "_").Replace("True", "-"));//14
Console.Write($"{true ^ false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true  ^ false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true  ^ true}".ToString().Replace("False", "_").Replace("True", "-"));//17
Console.Write($"{false  ^ true}".ToString().Replace("False", "_").Replace("True", "-"));//18
Console.Write($"{false  ^ true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false  ^ false}".ToString().Replace("False", "_").Replace("True", "-")); //20
Console.Write($"{true  ^ false}".ToString().Replace("False", "_").Replace("True", "-"));//21
Console.Write($"{true  ^ false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{true  ^ true}".ToString().Replace("False", "_").Replace("True", "-")); //23
Console.Write($"{false  ^ true}".ToString().Replace("False", "_").Replace("True", "-"));//24
Console.Write($"{false^ true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{false  ^ false}".ToString().Replace("False", "_").Replace("True", "-")); //26

Console.Write("\n d)  "); //A NAND B
Console.Write($"{!(false && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false && false)}".ToString().Replace("False", "_").Replace("True", "-"));

Console.Write("\n e)  "); //A NOR B
Console.Write($"{!(false || false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false || false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true || false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true || false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true || true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false || true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false || true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false || false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true || false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true || false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true || true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false || true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false || true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false || false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true || false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true || false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true || true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false || true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false || true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false || false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true || false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true || false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(true || true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false || true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false || true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!(false || false)}".ToString().Replace("False", "_").Replace("True", "-"));

Console.Write("\n f)  "); // NOT A
Console.Write($"{!false }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false }".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false }".ToString().Replace("False", "_").Replace("True", "-"));

Console.Write("\n g)  "); // NOT A OR B
Console.Write($"{!false || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true || false}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!true || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false || true}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!false || false}".ToString().Replace("False", "_").Replace("True", "-"));

Console.Write("\n g)  "); // A OR B NAND A
Console.Write($"{!((false || false)&&false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((false || false)&&false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((true || false)&&true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((true || false)&&true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((true || true) && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((false || true) && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((false || true) && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((false || false) && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((true || false) && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((true || false) && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((true || true) && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((false || true) && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((false || true) && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((false || false) && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((true || false) && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((true || false) && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((true || true) && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((false || true) && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((false || true) && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((false || false) && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((true || false) && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((true || false) && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((true || true) && true)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((false || true) && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((false || true) && false)}".ToString().Replace("False", "_").Replace("True", "-"));
Console.Write($"{!((false || false) && false)}".ToString().Replace("False", "_").Replace("True", "-"));





