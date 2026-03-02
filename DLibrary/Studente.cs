namespace DLibrary;

public class Studente : Persona
{
    public List<Voto> Voti { get; set; }

    public override string ToString()
    {
        return $"{Nome} {Cognome}";
    }
}