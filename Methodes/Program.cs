namespace Methodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Renvoie_distincts(int a, int b, int c)
            {
                int somme = a + b + c;

                
                if(somme < 10)
                {
                    int min = Minimum(a, b);
                    return Minimum(min, c);

                }else if(somme >= 10 && somme <= 15)
                {
                    if((a>b && a < c) || (a<b && a>c))
                    {
                        return a;
                    }else if((b>a && b < c) || (b>c && b<a))
                    {
                        return b;
                    }
                    else
                    {
                        return c;
                    }

                }else if(somme > 15)
                {
                    int max = Maximum(a, b);
                    return Maximum(max, c);
                }
                return 0;
            }
            int Maximum(int a , int b)
            {
                if (a > b) return a;
                return b;
            }
            int Minimum(int a, int b)
            {
                if (a > b) return b;
                return a;
            }

            Console.Write("Entrer le premier nombre: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrer le deuxieme nombre : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrer le troisieme nombre : ");
            int c = Convert.ToInt32(Console.ReadLine());

            int s = Renvoie_distincts(a, b, c);
            Console.WriteLine("Resultat : "+s);

        }
    }
}
