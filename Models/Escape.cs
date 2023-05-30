static public class Escape{
    static private string[] incognitasSalas;
    static int estadoJuego = 1;
    
    private static void InicializarJuego(){
        incognitasSalas = new string[4];
        incognitasSalas[0] = "Ariel"; incognitasSalas[1] = "Cenicienta"; incognitasSalas[2] = "Rapunzel"; incognitasSalas[3] = "Mulán";
    }


    public static int GetEstadoJuego(){
        return estadoJuego;
    }

    public static bool ResolverSala(int Sala, string Incognita){
        if(incognitasSalas == null) InicializarJuego();
        if(estadoJuego == Sala){
            if(Incognita == incognitasSalas[Sala-1]){
                estadoJuego++;
                return true;
            }
        }
        return false;
    }    
}