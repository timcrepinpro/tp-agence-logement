class Maison : Logement
{
    public int surfacejardin { get; set; }

    public Maison(string reference, string adresse, int surface, double loyerbase, bool disponible, int surfacejardin) : base(reference, adresse, surface, loyerbase, disponible)
    {
        this.surfacejardin = surfacejardin;
    }

    public void afficher()
    {
        base.afficher();
        Console.WriteLine($"Surface du jardin: {surfacejardin} m²");
    }

    public override void calculerLoyer()
    {
        double loyer = loyerbase;
        loyer += surfacejardin * 10;
        Console.WriteLine("Le loyer est: " + loyer);
    }
    public int getsurfaceexterieur()
    {
        return surfacejardin;
    }
    public void setsurfaceexterieur(int surface)
    {
        if(surface > 0)
        {
            this.surfacejardin = surface;
        }
    }
}