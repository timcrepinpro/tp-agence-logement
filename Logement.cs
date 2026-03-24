class Logement
{
    protected string reference{ get; set; }
    protected string adresse{ get; set; }
    protected int surface{ get; set; }
    protected double loyerbase{ get; set; }
    protected bool disponible{ get; set; }
    public Logement(string reference, string adresse, int surface, double loyerbase, bool disponible)
    {
        if(surface > 0)
        {
            if(loyerbase > 0)
            {
                this.reference = reference;
                this.adresse = adresse;
                this.surface = surface;
                this.loyerbase = loyerbase;
                this.disponible = disponible;
            }
        }
        
        
    }
    public void setdisponible(bool dispo)
    {
        this.disponible = dispo;
    }
    public bool getdisponible()
    {
        return disponible;
    }
    public virtual void calculerLoyer()
    {
        double loyer = loyerbase;
        /*
        if())
        {
           
        }
        */
        Console.WriteLine("Le loyer est: " + loyer);
    }

    public Logement()
    {
    }

    public void afficher()
    {
        Console.WriteLine("Reference: " + reference);
        Console.WriteLine("Adresse: " + adresse);
        Console.WriteLine("Surface: " + surface);
        Console.WriteLine("Loyer de base: " + loyerbase);
        Console.WriteLine("Disponible: " + disponible);
    }
    public void setloyerbase(double loyer)
    {
        if(loyer > 0)
        {
            this.loyerbase = loyer;
        }
    }
    public double getloyerbase()
    {
        return loyerbase;
    }

    
}