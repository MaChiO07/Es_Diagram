namespace DLibrary;

public class Voto
{
    public DateTime Data { get; set; }
    public Materia Materia { get; set; }
    public double Valore { get; set; }


    public override string ToString()
    {
        return $"{Materia} {Valore}";
    }
}