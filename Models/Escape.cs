static public class Escape{
    static private string[] incognitasSalas = new string[4];
    static int estadoJuego = 1;
    static int intentos = 0;
    static string nombre;
    
    private static void InicializarJuego(){
        incognitasSalas[0] = "Ariel"; incognitasSalas[1] = "Cenicienta"; incognitasSalas[2] = "Rapunzel"; incognitasSalas[3] = "Mulán";
    }


    public static int GetEstadoJuego(){
        return estadoJuego;
    }

    public static bool ResolverSala(int Sala, string Incognita){
        if(incognitasSalas.Length == 0) InicializarJuego();
        if(estadoJuego == Sala){
            if(Incognita == incognitasSalas[Sala-1]){
                estadoJuego++;
                return true;
            }
            intentos++;
        }
        return false;
    }    
}