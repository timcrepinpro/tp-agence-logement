class Appartement : Logement
{
    public int nbrpiece { get; set; }

    public Appartement(string reference, string adresse, int superficie, double loyer, bool disponible, int nbrpiece)
        : base(reference, adresse, superficie, loyer, disponible)
    {
        
    }

    public void afficher()
    {
        base.afficher();
        Console.WriteLine($"Nombre de pièces: {nbrpiece}");
        
    }


    
}