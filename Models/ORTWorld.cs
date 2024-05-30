public class ORTWorld
{
    public static List<string> ListaDestinos { get; private set; } = new List<string>();
    public static List<string> ListaHoteles { get; private set; } = new List<string>();
    public static List<string> ListaAereos { get; private set; } = new List<string>();
    public static List<string> ListaExcursiones { get; private set; } = new List<string>();
    public static Dictionary<string, Paquete> Paquetes { get; private set; } = new Dictionary<string, Paquete>();

    public static bool IngresarPaquete(string destinoSeleccionado, Paquete paquete)
    {
        bool esValido;
        if (Paquetes.Keys.Contains(destinoSeleccionado))
        {
            esValido = false;
        }
        else
        {
            Paquetes.Add(destinoSeleccionado, paquete);
            esValido = true;
        }
        return esValido;
    }
    public ORTWorld()
    {
        //Hoteles
ListaHoteles.Add("Hotel 1.webp");
ListaHoteles.Add("Hotel 2.webp");
ListaHoteles.Add("Hotel 3.webp");
ListaHoteles.Add("Hotel 4.webp");
ListaHoteles.Add("Hotel 5.webp");
ListaHoteles.Add("Hotel 6.webp");
ListaHoteles.Add("Hotelk 7.webp");
ListaHoteles.Add("Hotel 8.webp");
ListaHoteles.Add("Hotel 9.webp");
ListaHoteles.Add("Hotel 10.webp");
//Destinos
ListaDestinos.Add("París");
ListaDestinos.Add("Tokio");
ListaDestinos.Add("Roma");
ListaDestinos.Add("Nueva York");
ListaDestinos.Add("Barcelona");
ListaDestinos.Add("Sidney");
ListaDestinos.Add("Ciudad del Cabo");
ListaDestinos.Add("Buenos Aires");
ListaDestinos.Add("Praga");
ListaDestinos.Add("Cancu");
//Lista Aereos
ListaAereos.Add("");
ListaAereos.Add("");
ListaAereos.Add("");
ListaAereos.Add("");
ListaAereos.Add("");
ListaAereos.Add("");
ListaAereos.Add("");
ListaAereos.Add("");
ListaAereos.Add("");
ListaAereos.Add("");

    }
    private static void precargarDestinos()
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