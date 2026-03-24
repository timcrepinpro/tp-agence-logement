class Loccataire
{
    private string nom{ get; set; }
    private string prenom{ get; set; }

    private string telephone{ get; set; }

    public Loccataire(string nom, string prenom, string telephone)
    {
        this.nom = nom;
        this.prenom = prenom;
        this.telephone = telephone;
    }
    public Loccataire()
    {
    }

    public void afficher()
    {
        Console.WriteLine($"Locataire: {prenom} {nom}, Téléphone: {telephone}");
    }
}
