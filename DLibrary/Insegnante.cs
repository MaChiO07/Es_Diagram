using System.Runtime.CompilerServices;

namespace DLibrary;

public class Insegnante : Persona
{
    public List<Materia> Materie { get; set; }

    public override string ToString()
    {
        return $"{Nome} {Cognome}";
    }
}