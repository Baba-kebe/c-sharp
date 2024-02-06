namespace DistributeurDeTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choix = "";
            int rangV = 1;
            int rangR = 1;
            int rangI = 1;
            string info = "";
            string nom = "";
            string prenom = "";
            string filePath = "C:/Users/OusmaneKEBE/Desktop/M2-GLSI/C#/fichier.txt";
            do
            {
                if(rangV>1 | rangI >1 |rangR > 1)
                {
                    Console.WriteLine("cliquer sur Q quitter ou n'importe quel caractere " +
                        "pour continuer ");
                    string toExit = Console.ReadLine();
                    if (toExit.ToLower().Equals("q")) break;

                }
                do
                {
                    Console.Write("votre nom svp : ");
                    nom = Console.ReadLine().Trim();

                    if(nom.Length < 2 )
                    {
                        Console.WriteLine("Entrer un nom valide");
                        Console.Write("Cliquer sur Q pour quitter :");
                        string quitte = Console.ReadLine();
                    }
                } while (nom.Length < 2 );

                do
                {
                    Console.Write("votre prenom svp : ");
                    prenom = Console.ReadLine().Trim();
                    if (prenom.Length < 2)
                    {
                        Console.WriteLine("Entrer un prenom valide");
                        Console.Write("Cliquer sur Q pour quitter :");
                        string quitte = Console.ReadLine();
                    }
                } while (nom.Length < 2);

                Console.WriteLine("--- TYPE DE TRANSACTION ---");

                Console.WriteLine("Cliquer sur V pour un ticket pour versement");
                Console.WriteLine("Cliquer sur R pour un ticket pour retrait");
                Console.WriteLine("Cliquer sur I pour un ticket pour prendre des informations");
                Console.WriteLine("Cliquer sur Q pour arreter le programme");
                choix = Console.ReadLine();

                if (choix.ToLower().Equals("v"))
                {
                    Console.WriteLine($"V - {rangV}  votre numero est {rangV} et" +
                        $" il y'a {rangV -1} personne(s) devant vous");
                    info = $"Nom {nom.ToUpper()} Prenom : {prenom} numero V - {rangV}";
                    rangV++;
                    
                }
                else if (choix.ToLower().Equals("r"))
                {
                    Console.WriteLine($"R - {rangR}  votre numero est {rangR} et" +
                        $" il y'a {rangR -1} personne(s) devant vous");
                    info = $"Nom {nom.ToUpper()} Prenom : {prenom} numero R - {rangR}";
                    rangR++;
                }
                else if (choix.ToLower().Equals("i"))
                {
                    Console.WriteLine($"I - {rangI}  votre numero est {rangI} et" +
                        $" il y'a {rangI -1} personne(s) devant vous");
                    info = $"Nom {nom.ToUpper()} Prenom : {prenom} numero V - {rangI}";
                    rangI++;
                }
                else if (choix.ToLower().Equals("q")) break;
                else
                {
                    Console.WriteLine("Votre choix n'est pas valide");
                }

                if(choix.ToLower().Equals("i") | choix.ToLower().Equals("v") | choix.ToLower().Equals("r"))
                {
                    using (StreamWriter writer = File.AppendText(filePath))
                    {
                        writer.WriteLine(info);
                        
                    }
                }

            } while (!choix.ToLower().Equals('q'));

            using (StreamReader reader = File.OpenText(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            try
            {
                
                using (FileStream fileStream = File.Open(filePath, FileMode.Truncate, FileAccess.Write))
                {
                    fileStream.SetLength(0); 
                }

               
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Une erreur s'est produite : {ex.Message}");
            }

            Console.WriteLine("Fin du Programme");

        }
    }
}
