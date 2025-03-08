namespace temp;

public class Student
{
    public void StudentMethod (int matNr)
    {
        MatNr = matNr;
    }
    public int MatNr { get; set; }
    public int Abschluss { get; set; }
    public Abschluss Schulabschluss { get; set; }
    public double AbschlussNote { get; set; }
}