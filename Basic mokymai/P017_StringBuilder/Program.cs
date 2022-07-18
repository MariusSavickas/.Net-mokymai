using System.Text;

namespace P017_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, String Builder");

            //StingBuilder sukurimas
            StringBuilder sb = new StringBuilder(); // be teksto
            StringBuilder sb1 = new StringBuilder("Labas pasauli"); //Sukurimo metu irasomas tekstas
            StringBuilder sb2 = new StringBuilder(123456); //sukurimo metu taip pat irasomas tekstas

            //Teksto isgavimas is StringBuilder
            Console.WriteLine(sb.ToString());

            //Teksto pridejimas per StringBuilder
            sb.Append("Labas ");
            sb.Append("pasauli");
            sb.AppendLine();
            sb.AppendLine("Labas C#");
            sb.AppendLine("Labas C#");

            Console.WriteLine(sb.ToString());

            Console.WriteLine("-------------------------");
            //Teksto iterpimas
            sb.Insert(5, "  AAAAA ");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("-------------------------");
            //Teksto pasalinimas
            sb.Remove(6, 8);
            Console.WriteLine(sb.ToString());
            Console.WriteLine("-------------------------");
            //Teksto pakeitimas
            sb.Replace("Labas", "Hello");
            Console.WriteLine(sb.ToString());

            For_StringBuilder();
            For_Concat();

        }

        public static string For_StringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                sb.Append(i);
            }
            return sb.ToString();
        }
        public static string For_Concat()
        {
            string s = string.Empty;
            for(int i = 0; i < 100; i++)
            {
                s += i;
            }
            return s;
        }

    }
}