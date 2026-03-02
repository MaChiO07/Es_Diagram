namespace DLibrary;

public class Materia
{
    public Guid Id { get; set; }
    public string Descrizione { get; set; }

    public override string ToString()
    {
        return $"{Id} {Descrizione}";
    }
}