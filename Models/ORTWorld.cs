public class ORTWorld{
public static List < string > ListaDestinos {get; private set;} = new List<string>();
public static List < string > ListaHoteles {get; private set;} = new List<string>();
public static List< string > ListaAereos {get; private set;} = new List<string>();
public static List< string > ListaExcursiones {get; private set;} = new List<string>();
public static Dictionary<string, Paquete> Paquetes {get; private set;} = new Dictionary<string, Paquete>();

public static bool IngresarPaquete (string destinoSeleccionado, Paquete paquete)
{
    bool esValido;
    if(Paquetes.Keys.Contains(destinoSeleccionado))
    {
        esValido = false;
    }else{
        Paquetes.Add(destinoSeleccionado, paquete);
        esValido = true;
    }
    return esValido;
}
private static void precargarDestinos ()
{
    List<string> destinos = new List<string>{
            "París",
            "Tokio",
            "Roma",
            "Nueva York",
            "Barcelona",
            "Sydney",
            "Ciudad del Cabo",
            "Buenos Aires",
            "Praga",
            "Cancún"
    };
    ListaDestinos = destinos;
    
}
}