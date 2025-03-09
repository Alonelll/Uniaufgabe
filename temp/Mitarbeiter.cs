namespace temp;

public class Mitarbeiter : Gehalt
{
    public bool IstBeamter { get; set; }
    public int PersNr { get; set; }
    public double ArbeitszeitProMonat { get; set; }

    public override double BerechneGehalt()
    {
        var temp = new List<string> { "W1", "W2", "W3" };
        const int w1 = 4500;
        const int w2 = 5900;
        const int w3 = 6700;

        
        for (var i = 0; i < temp.Count; i++)
        {
            return temp[i] switch
            {
                "W1" => w1,
                "W2" => w2,
                "W3" => w3,
                _ => 0
            };
        }
        return 0;
        
    }
    
    public Hochschullehrer? Hochschullehrer;
    public WissenschaftlicherMitarbeiter? WissenschaftlicherMitarbeiter;
}

public abstract class Gehalt
{
    public abstract double BerechneGehalt();
    
}