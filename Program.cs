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

        Appartement a1 = new Appartement("REF003", "789 Boulevard Saint-Michel", 80, 800, true, 3);
        a1.afficher();
        a1.calculerLoyer();
        Maison m1 = new Maison("REF004", "321 Rue de la République", 120, 1200, true, 50);
        m1.afficher();
        m1.calculerLoyer();
        Studio s1 = new Studio("REF005", "654 Avenue de la Liberté", 30, 400, true, true);
        s1.afficher();
        s1.calculerLoyer();
    }
}
