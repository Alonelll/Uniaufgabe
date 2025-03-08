namespace temp;

public class Person
{
    public string Vorname { get; set; }
    public string Nachname { get; set; }
    public string Strasse { get; set; }
    public string Plz { get; set; }
    public string Ort { get; set; }
    public string Land { get; set; }
    
    protected Student? Student;
    protected Mitarbeiter? Mitarbeiter;
}