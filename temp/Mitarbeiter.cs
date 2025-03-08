namespace temp;

public class Mitarbeiter : Gehalt
{
    public bool IstBeamter { get; set; }
    public int PersNr { get; set; }
    public double ArbeitszeitProMonat { get; set; }

    public override double BerechneGehalt()
    {
        //Berechne Gehalt
        return 0;
    }
    
    public Hochschullehrer? Hochschullehrer;
    public WissenschaftlicherMitarbeiter? WissenschaftlicherMitarbeiter;
}

public abstract class Gehalt
{
    public abstract double BerechneGehalt();
}