namespace tp_agence_logement;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Logement l1 = new Logement("REF001", "123 Rue de la Paix", 50, 500, true);
        l1.afficher();
        l1.calculerLoyer();
        Logement l2 = new Logement("REF002", "456 Avenue des Champs", -1, 700, false);
    }
}
