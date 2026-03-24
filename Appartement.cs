class Appartement : Logement
{
    protected int nbrpiece { get; set; }

    public Appartement(string reference, string adresse, int superficie, double loyer, bool disponible, int nbrpiece)
        : base(reference, adresse, superficie, loyer, disponible)
    {
        
    }

    public void afficher()
    {
        base.afficher();
        Console.WriteLine($"Nombre de pièces: {nbrpiece}");
        
    }
    public override void calculerLoyer()
    {
        double loyer = loyerbase;
        loyer += nbrpiece * 100;
        Console.WriteLine("Le loyer est: " + loyer);
    }
    public int getnbrpiece()
    {
        return nbrpiece;
    }
    public void setnbrpiece(int nbr)
    {
        if(nbr > 0)
        {
            this.nbrpiece = nbr;
        }
    }

    
}