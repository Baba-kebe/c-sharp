using System.Collections;

namespace TrouverUnNombre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Une methode pour representer la logique du code
            static int TrouverNombre(int debut, int fin)
            {
                Random random = new Random();
                int nbreCacher = random.Next(debut, fin);
                int proposition = 0;
                int nbreTentativeRestante =  5;
                int tentative = 0;
                ArrayList choices = new ArrayList();

                int marge = fin - debut;

                // si les elements de I > 10 le joueur aura des chances supplementaires
                if (marge > 10)
                {
                    nbreTentativeRestante += Convert.ToInt32(marge / 10);
                }
  
                Console.WriteLine($"Vous avez {nbreTentativeRestante} tentatives");

                do
                {
                    Console.Write("Proposer un nombre : ");
                    string pro = Console.ReadLine();
                    try
                    {
                        proposition = Convert.ToInt32(pro);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Veuillez choisir un nombre entier valide");
                        continue;
                    }
                    if(nbreCacher == proposition)
                    {
                        Console.WriteLine($"Felicitation le nombre cacher etait : {nbreCacher}" +
                            $" vous avez gagner");
                    }
                    else if (proposition < debut || proposition >= fin)
                    {
                        Console.WriteLine("Vous avez choisi un nombre hors de l'intervalle");
                    }
                    else
                    {
                        if(nbreTentativeRestante > 1)
                        {
                            Console.Write("Echouer Nouvelle tentative :");
                        }
                        nbreTentativeRestante--;
                        tentative++;
                        choices.Add(proposition);

                    }
                    
                    if(nbreTentativeRestante > 1)
                    {
                        Console.WriteLine($"Il vous reste {nbreTentativeRestante} tentatives");
                    }
                    else if(nbreTentativeRestante == 1)
                    {
                        Console.WriteLine("une derniere chance");
                    }

                } while (proposition != nbreCacher && nbreTentativeRestante >= 1);

                if(nbreTentativeRestante < 1)
                {
                    Console.WriteLine($"Vous avez Echouer le nombre cacher etait : {nbreCacher}");
                }
                double note = (fin - debut) / tentative;
                Console.WriteLine($"Vous avez une note de : {note}");
                Console.Write("Vos choix : ");
                foreach(int i in choices)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
                
                return nbreCacher;
            }

            int choice = 0;
            do
            {
                Console.WriteLine("1.Chercher un nombre dans l'intervalle 1 a 10 inclus");
                Console.WriteLine("2.Chercher un nombre dans un intervalle que vous voulez");
                Console.WriteLine("3.Pour quitter le programme");
                Console.Write("Voici les nombres que vous avez proposer : ");
                String choix = Console.ReadLine();
                
                try
                {
                    choice = Convert.ToInt32(choix);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Veuillez choisir un nombre entier valide");
                    continue;
                }
                if(choice != 0)
                {
                    switch (choice)
                    {
                        case 1:
                            TrouverNombre(1, 11);
                            break;
                        case 2:
                            int indexDebut;
                            int indexFin;
                            Console.Write("Veuillez renseigner l'index de debut : ");
                            string strDebut = Console.ReadLine();
                            Console.Write("Veuillez renseigner l'index de fin : ");
                            string strFin = Console.ReadLine();

                            try
                            {
                                indexDebut = Convert.ToInt32(strDebut);
                                indexFin = Convert.ToInt32(strFin);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Veuillez choisir des entier valide");
                                continue;
                            }
                            //je permites les valeurs si debut>fin 
                            if(indexDebut > indexFin)
                            {
                                int newDebut = indexFin;
                                indexFin = indexDebut;
                                indexDebut = newDebut;
                            }
                            //Pour cette option l'intervalle doit contenir au moins 10 elements
                            if (indexFin -indexDebut <=10) Console.WriteLine("Interval non valide " +
                                "au moins un intervalle de 11 element");
                            else
                            {
                                TrouverNombre(indexDebut, indexFin+1);
                            }
                            break;
                        case 3:
                            Console.WriteLine("3");
                            break;
                        default:
                            Console.WriteLine("choix non valide.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("choix non valide.");
                }
            } while (choice != 3);
        }
    }
}
