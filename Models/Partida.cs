namespace TP_04_ZIA;
static class Partida
{
static public int intentos {get; private set;}
static public string palabra {get; private set;}
static public List<char> intentosLetra {get; private set;}

    static public void inicializarPartida (){
        intentos = 0;
        intentosLetra = new List<char> ();
        palabra = "";
        Random randomNum = new Random();
        int randomNumber = randomNum.Next();
        int randomNumberInRange = randomNum.Next(1, 6);
        switch(randomNumberInRange)
            {   
                case 1:{
                    palabra = "almendra";
                    break;
                }
                case 2:{
                    palabra = "trabajo";
                    break;
                }
                case 3:{
                    palabra = "pantalon";
                    break;
                    }
                case 4:{
                    palabra = "mochila";
                    break;
                }
                case 5:{
                    palabra = "claustrofobia";
                    break;
                }
            }
    }
    static public void actualizarIntento(char intentoLetra){
        intentos++;
        intentosLetra.Add(intentoLetra);
    } 

}