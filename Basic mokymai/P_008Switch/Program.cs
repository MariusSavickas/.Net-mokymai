namespace P_008Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Switch");
            Console.WriteLine("Iveskite meniu punkta");
            int menuChoice = Convert.ToInt32(Console.ReadLine());  
            switch (menuChoice)
            {
                case 1:
                    Console.WriteLine("Vartotojas pasirinko 1");
                    Console.WriteLine("dar kazkokia info");
                    break;
                    case 2:
                    Console.WriteLine("Vartotojas pasirinko 2");
                    break ;
                    case 3:
                    Console.WriteLine("Vartotojas pasirinko 3");
                    break;
                case 4:
                    Console.WriteLine("Vartotojas pasirinko 4");
                    break;
                    default: //jei nei viena salyga nera tenkinama
                    Console.WriteLine("Klaida");
                    break;

                    //-------------------------
                    Console.WriteLine( "-----------------------------");
                    var isvedamasRezultatas = menuChoice switch
                    {
                        1 => "vartotojas pasirinko 1",
                        2 => "Vartotojas pasirinko 2",
                        3 => "Vartotojas pasirinko 3",
                        _ => "Vartotojas nieko nepasirinko"
                    };
                    Console.WriteLine(isvedamasRezultatas);

                    //-----------------
                    Console.WriteLine("---------------------");
                    switch (menuChoice)
                    {
                        case 1:
                        case 2:
                            Console.WriteLine("Vartotojas pasirinko 1 arba 2");
                            break;
                    }

            }

        }
    }
}