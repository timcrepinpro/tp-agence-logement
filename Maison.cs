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

}