static public class Escape{
    static private string[] incognitasSalas = new string[4];
    static int estadoJuego = 1;
    
    private static void InicializarJuego(){
        incognitasSalas[0] = "87"; incognitasSalas[1] = "40"; incognitasSalas[2] = "jamon"; incognitasSalas[3] = "William Shakespeare";
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
        }
        return false;
    }    
}