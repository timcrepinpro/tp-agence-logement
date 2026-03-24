class Agence
{
    protected string nom;
    protected List<Logement> logements;
    protected List<Locataire> locataires;
    protected List<ContratLocation> contrats;



    public Agence()
    {
        logements = new List<Logement>();
        locataires = new List<Locataire>();
        contrats = new List<ContratLocation>();
    }
    public Agence(string nom)
    {
        this.nom = nom;
        logements = new List<Logement>();
        locataires = new List<Locataire>();
        contrats = new List<ContratLocation>();
    }

    public void AjouterLogement(Logement logement)
    {
        logements.Add(logement);
    }

    public void AjouterLocataire(Locataire locataire)
    {
        locataires.Add(locataire);
    }

    public void AjouterContrat(ContratLocation contrat)
    {
        contrats.Add(contrat);
    }
    public void AfficherLogements()
    {
        foreach (var logement in logements)
        {
            logement.afficher();
            Console.WriteLine();
        }
    }
}