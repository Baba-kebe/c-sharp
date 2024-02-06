namespace Ter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            Ter unTrain = new Ter("Senegal Emergent", 500);
            bool isElectrique = unTrain.isELctrique();
            int coutDeMaintenace = unTrain.coutDeMaintenance();

            Console.WriteLine($"Electrique : {isElectrique} maintenace : {coutDeMaintenace}");
        }
        public class Ter
        {
            string nom;
            int nombreDePlaces;
            bool isElectrique = true;
           

            public Ter(string nom, int nombreDeplaces)
            {
                this.nom = nom;
                this.nombreDePlaces = nombreDeplaces;
            }

            public bool isELctrique()
            {
                return true;
            }
            public int coutDeMaintenance()
            {
                return 100;
            }
            
        }
    }
}
