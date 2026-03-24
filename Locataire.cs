class Locataire
{
    private string nom{ get; set; }
    private string prenom{ get; set; }

    private string telephone{ get; set; }

    public Locataire(string nom, string prenom, string telephone)
    {
        this.nom = nom;
        this.prenom = prenom;
        this.telephone = telephone;
    }
    public Locataire()
    {
    }

    public void afficher()
    {
        Console.WriteLine($"Locataire: {prenom} {nom}, Téléphone: {telephone}");
    }
}
