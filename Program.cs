using System.Numerics;

namespace EnkelMiniräknare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EasyCalcutator();
        }
        static void EasyCalcutator()
        {
            Console.WriteLine("Enkel Miniräknare");
            Console.WriteLine("Välj på menyn räknesätt och skriv två heltal för att räkna ut de");
            Console.WriteLine("[1]Addition");
            Console.WriteLine("[2]Multiplikation");
            Console.WriteLine("[3]Subtraktion");
            Console.WriteLine("[4]Division");

            Console.Write("Välj räknesätt: ");
            int val = Convert.ToInt32(Console.ReadLine());


            if (val >= 1 && val <= 4)
            {
                Console.Write("Skriv första heltalet: ");
                double tal1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Skriv andra heltalet: ");
                double tal2 = Convert.ToDouble(Console.ReadLine());

                switch (val)
                {
                    case 1:
                        Addition(tal1, tal2);
                        break;
                    case 2:
                        Multiplikation(tal1, tal2);
                        break;
                    case 3:
                        Subtraktion(tal1, tal2);
                        break;
                    case 4:
                        Division(tal1, tal2);
                        break;
                }
            }

            else
            {
                Console.WriteLine("Felaktigt val, programmet avslutas");
            }

            static void Addition(double tal1, double tal2)
            {
                double resultat = tal1 + tal2;
                Console.WriteLine("Resultat: " + resultat);
            }

            static void Multiplikation(double tal1, double tal2)
            {
                double resultat = tal1 * tal2;
                Console.WriteLine("Reultat: " + resultat);
            }

            static void Subtraktion(double tal1, double tal2)
            {
                double resultat = tal1 - tal2;
                Console.WriteLine("Resultat: " + resultat);
            }

            static void Division(double tal1, double tal2)
            {
                if (tal2 == 0)
                {
                    Console.WriteLine("Det går inte dividera med 0");
                }

                else
                {
                    double resultat = tal1 / tal2;
                    Console.WriteLine("Resultat: " + resultat);
                }
            } }
    }
}
