using System.Diagnostics;

namespace CalculePGCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CaluclePGCD(int a, int b)
            {
                int resultat;
                int plusGrand;
                int plusPetit;
                if (a < 0 || b < 0)
                {
                    Console.WriteLine("Entrer des entiers");
                    return 0;
                }
                else if(a == 0 || b == 0)
                {
                    if (a == 0) { return b; } else { return b; }
                }

                else if (a > b)
                {
                    plusGrand = a;
                    plusPetit = b;
                }
                else
                {
                    plusPetit = a;
                    plusGrand = b;
                }
                resultat = plusGrand;
                if(plusGrand % plusPetit == 0) { return plusPetit;}
                else
                {
                    do
                    {
                        resultat -= plusPetit;
                    } while (resultat > plusPetit);
                    do
                    {
                        plusPetit -= resultat;
                    } while (plusPetit > resultat);
                    if (resultat % plusPetit == 0) return plusPetit;
                    do
                    {
                        resultat -= plusPetit;
                    } while (resultat >= plusPetit);
                }

                return plusPetit;
            }
            int Stein(int u, int v)
            {
                int k;

                
                if (u == 0 || v == 0)
                    return u | v;

                
                for (k = 0; ((u | v) & 1) == 0; ++k)
                {
                    u >>= 1;
                    v >>= 1;
                }

              
                while ((u & 1) == 0)
                    u >>= 1;

                do
                {
                    while ((v & 1) == 0) 
                        v >>= 1;

                    
                    if (u < v)
                    {
                        v -= u;
                    }
                    else
                    {
                        int diff = u - v;
                        u = v;
                        v = diff;
                    }
                    v >>= 1;
                 
                } while (v != 0);

                u <<= k;

                return u;
            }
            int intChoix;

            do
            {
                Stopwatch tempsEuclide = new Stopwatch();
                Stopwatch tempsStein = new Stopwatch();

                Console.WriteLine("1.Pour utilisez l'algorithme d'euclide ");
                Console.WriteLine("2.Pour utilisez l'algorithme de Stein ");
                Console.WriteLine("3.Pour Quitter ");
                string choix = Console.ReadLine();
                
                if (!int.TryParse(choix, out intChoix))
                {
                    Console.WriteLine("Veuillez choisir un entier valide");
                    break;
                }
                switch (intChoix)
                {

                    case 1:
                        Console.Write("Entrer le premier nombre : ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Entrer le deuxieme nombre : ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        tempsEuclide.Start();
                        Console.WriteLine($"Le PGCD de {a} et {b} est : {CaluclePGCD(a, b)}");
                        tempsEuclide.Stop();
                        Console.WriteLine($"Temps D'excution : {tempsEuclide.ElapsedMilliseconds} ms");
                        break;
                    case 2:
                        Console.Write("Entrer le premier nombre : ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Entrer le deuxieme nombre : ");
                        int d = Convert.ToInt32(Console.ReadLine());
                        tempsStein.Start();
                        Console.WriteLine($"Le PGCD de {c} et {d} est : {Stein(c, d)}");
                        tempsStein.Stop();
                        Console.WriteLine($"Temps D'excution : {tempsStein.ElapsedMilliseconds} ms");
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Choix non valide");
                        break;


                }
               



            } while (intChoix != 3);

        }
    }
}
