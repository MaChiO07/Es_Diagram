namespace DLibrary;

public class Materia
{
    public Guid Id { get; set; }
    public string Descrizione { get; set; }

    public Materia(string descrizione)
    {
        Id = Guid.NewGuid();
        Descrizione = descrizione;
    }


    public override string ToString()
    {
        return $"{Id} {Descrizione}";
    }
}