class ContratLocation
{
    protected string numero { get; set; }
    protected Locataire locataire { get; set; }
    protected Logement logement { get; set; }
    protected int duree { get; set; }
    protected double tarifJournalier { get; set; }

    public ContratLocation(string numero, Locataire locataire, Logement logement, int duree, double tarifJournalier)
    {
        if(duree > 0)
        {
            if(tarifJournalier > 0)
            {
                if(logement.getdisponible() == true)
                {
                    this.numero = numero;
                    this.locataire = locataire;
                    this.logement = logement;
                    this.duree = duree;
                    this.tarifJournalier = tarifJournalier;
                    this.logement.setdisponible(false);
                    
                }
                
            }
        }
    
    }
    public ContratLocation()
    {
    }

    public void afficher()
    {        Console.WriteLine($"Contrat de location numéro: {numero}");
        locataire.afficher();
        logement.afficher();
        Console.WriteLine($"Durée: {duree} jours");
        Console.WriteLine($"Tarif journalier: {tarifJournalier}");
    }

}