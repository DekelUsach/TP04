public class ORTWorld
{
    public static List<string> ListaDestinos { get; private set; } = new List<string>
    {
        "París", "Londres", "Nueva York", "Tokio", "Roma",
        "Sídney", "Barcelona", "Dubái", "Los Ángeles", "Río de Janeiro"
    };
    public static List<string> ListaHoteles { get; private set; } = new List<string>{
        "Hotel 1.webp",
        "Hotel 2.webp",
        "Hotel 3.webp",
        "Hotel 4.webp",
        "Hotel 5.webp",
        "Hotel 6.webp",
        "Hotel 7.webp",
        "Hotel 8.webp",
        "Hotel 9.webp",
        "Hotel 10.webp"
    };
    public static List<string> ListaAereos { get; private set; } = new List<string>{
        "Avion 1.webp",
        "Avion 2.webp",
        "Avion 3.webp",
        "Avion 4.webp",
        "Avion 5.webp",
        "Avion 6.webp",
        "Avion 7.webp",
        "Avion 8.webp",
        "Avion 9.webp",
        "Avion 10.webp"
    };
    public static List<string> ListaExcursiones { get; private set; } = new List<string>{
        "Excu 1.webp",
        "Excu 2.webp",
        "Excu 3.webp",
        "Excu 4.webp",
        "Excu 5.webp",
        "Excu 6.webp",
        "Excu 7.webp",
        "Excu 8.webp",
        "Excu 9.webp",
        "Excu 10.webp"
    };
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

}