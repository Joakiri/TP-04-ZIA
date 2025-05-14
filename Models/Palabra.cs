namespace TP_04_ZIA;
class Palabra
{
    public List<char> palabra {get; private set;}

    public Palabra ()
    {
        Random randomNum = new Random();
        int randomNumber = randomNum.Next();
        int randomNumberInRange = randomNum.Next(1, 6);
        switch(randomNumberInRange)
        {   
            case 1:{
                palabra = new List<char> ();
                break;
            }
            case 2:{

                break;
            }
            case 3:{

                break;
            }
            case 4:{

                break;
            }
            case 5:{

                break;
            }
        }
    }
}