public class Paquete{
public string Hotel {get; private set;}
public string Aereo {get; private set;}
public string Excursion {get; private set;}

public Paquete (string hotel, string excursion, string aereo)
{
    Hotel = hotel;
    Excursion = excursion;
    Aereo = aereo;
}
}