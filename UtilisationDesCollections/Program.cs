using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilisationsCollections
{
    internal class Etudiant
    {
        public string Nom { get; set; }
        public int Age { get; set; }
        public double NoteCC { get; set; }
        public double NoteDevoir { get; set; }

        public Etudiant(string nom, int age, double noteCC, double noteDevoir)
        {
            Nom = nom;
            Age = age;
            NoteCC = noteCC;
            NoteDevoir = noteDevoir;
        }
        public void AfficherEtudiant()
        {
            Console.WriteLine($"Nom :{this.Nom}, Age : {this.Age}, Moyenne : {this.Moyenne()}");
        }
        public double Moyenne()
        {
            double moyenne = (NoteDevoir * 0.67) + (NoteCC * 0.33);
            return moyenne;
        }


    }
    public class Program
    {
        public static void Main()
        {
            List<Etudiant> listEtudiants = new List<Etudiant>();

           /* Etudiant e1 = new Etudiant("Farmata", 21, 12, 14);
            Etudiant e2 = new Etudiant("Faty", 19, 14, 17);

            listEtudiants.Add(e1);
            listEtudiants.Add(e2);*/

            void SaisirDonnéesEtudiants()
            {
                string reponse;
                do
                {
                    Console.Write("Renseiger le nom de l'etudiant :");
                    string nom = Console.ReadLine();

                    Console.Write("Renseiger l'age de l'etudiant: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Renseiger la note du controle continue :");
                    double noteCC = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Renseiger la note du devoir :");
                    double noteDevoir = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Taper sur OUI pour saisir un autre etudiant ou sur " +
                        "n'importe quel caractere pour arreter le programme : ");
                    reponse = Console.ReadLine();

                    Etudiant etudiant = new Etudiant(nom, age, noteCC, noteDevoir);
                    listEtudiants.Add(etudiant);

                } while (reponse.ToLower().Equals("oui"));
            }

             void AfficherEtudiants()
            {
                foreach(Etudiant e in listEtudiants)
                {
                    e.AfficherEtudiant();
                }
            }
            SaisirDonnéesEtudiants();
            

            AfficherEtudiants();
        }
    }
}
