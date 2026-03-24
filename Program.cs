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
        s1.setloyerbase(350);
        s1.calculerLoyer();


        List<Logement> logements = new List<Logement> { 
            new Logement("REF006", "123 Rue de la Paix", 50, 500, true),
            new Appartement("REF007", "456 Avenue des Champs", 80, 800, true, 3),
            new Maison("REF008", "789 Boulevard Saint-Michel", 120, 1200, true, 50),
            new Studio("REF009", "321 Rue de la République", 30, 400, true, true)
        };

        List<Locataire> locataires = new List<Locataire>
        {
            new Locataire("coton eyes","joe", "john.doe@example.com"),
            new Locataire("colpin,","alex", "alex@mail.com"),
            new Locataire("alex","colpin", "colpin@mail.com")
        };

        List<ContratLocation> contrats = new List<ContratLocation>
        {
            new ContratLocation("CONTRAT001", new Locataire("coton eyes","joe", "john.doe@example.com"), l1, 30, 50),
            new ContratLocation("CONTRAT002", new Locataire("colpin,","alex", "alex@mail.com"), a1, 30, 50),
            new ContratLocation("CONTRAT003", new Locataire("alex","colpin", "colpin@mail.com"), m1, 30, 50),
            new ContratLocation("CONTRAT004", new Locataire("coton eyes","joe", "john.doe@example.com"), s1, 0, 50)
        };
        Agence agence = new Agence();
        agence.AjouterLogement(l1);
        agence.AjouterLogement(a1);
        agence.AjouterLogement(m1);
        agence.AjouterLogement(s1);
        agence.AfficherLogements();
        agence.AjouterLocataire(new Locataire("coton eyes","joe", "john.doe@example.com"));
        agence.AjouterLocataire(new Locataire("colpin,","alex", "alex@mail.com"));
        agence.AjouterLocataire(new Locataire("alex","colpin", "colpin@mail.com"));
        agence.AjouterContrat(new ContratLocation("CONTRAT001", new Locataire("coton eyes","joe", "john.doe@example.com"), l1, 30, 50));
        agence.AjouterContrat(new ContratLocation("CONTRAT002", new Locataire("colpin,","alex", "alex@mail.com"), a1, 30, 50));
        agence.AjouterContrat(new ContratLocation("CONTRAT003", new Locataire("alex","colpin", "colpin@mail.com"), m1, 30, 50));
        agence.AjouterContrat(new ContratLocation("CONTRAT004", new Locataire("coton eyes","joe", "john.doe@example.com"), s1, 0, 50));
        agence.AjouterContrat(new ContratLocation("CONTRAT004", new Locataire("coton eyes","iyuriuqhg", "john.doe@example.com"), s1, 0, 50));


        foreach (var logement in logements)
        {
            if(logement is Appartement appartement)
            {
                appartement.afficher();
                appartement.calculerLoyer();
                appartement.getnbrpiece();
            }
            else if(logement is Maison maison)
            {
                maison.afficher();
                maison.calculerLoyer();
                maison.getsurfaceexterieur();
            }
            else if(logement is Studio studio)
            {
                studio.afficher();
                studio.calculerLoyer();
                studio.getmeuble();
            }

        }
        

        }
}
