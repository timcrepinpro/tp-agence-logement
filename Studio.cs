class Studio : Logement
{
    protected bool meuble{ get; set; }



    public Studio(string reference, string adresse, int surface, double loyerbase, bool disponible, bool meuble) : base(reference, adresse, surface, loyerbase, disponible)
    {
        this.meuble = meuble;
    }
    public void afficher()
    {
        base.afficher();
        if(meuble)
        {
            Console.WriteLine("Le studio est meublé.");
        }
        else
        {
            Console.WriteLine("Le studio n'est pas meublé.");
        }
    }
    public override void calculerLoyer()
    {
        double loyer = loyerbase;
        if(meuble)
        {
            loyer += 50;
        }
        Console.WriteLine("Le loyer est: " + loyer);
    }
    public bool getmeuble()
    {
        return meuble;
    }   
    public void setmeuble(bool meuble)
    {
        this.meuble = meuble;
    }

}