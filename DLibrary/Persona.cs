namespace DLibrary;

public class Persona
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public DateTime DataDiNascita { get; set; }

    

    public override string ToString()
    {
        return $"{Nome} {Cognome}";
    }
}