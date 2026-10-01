using Unity.VisualScripting;
using UnityEngine;

public class Sesion3 : MonoBehaviour
{

    void Start()
    {
        //Generacion de Personaje

        int fue = ( Random.Range(1,7) + Random.Range(1,7) + Random.Range(1,7) ) * 5;
        int cou = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int des = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int apa = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int pod = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int sue = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int sueReroll;

        int tam = (Random.Range(1,7) + Random.Range(1,7) + 6) * 5;
        int inte = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int edu = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;
        int D100;

        int edad = Random.Range(15, 91);
        int mov = 0;


        if (15 >= edad && edad >= 20)
        {
            fue = fue - 5;
            tam = tam - 5;
            edu = edu - 5;

            sueReroll = (Random.Range(1, 7) + Random.Range(1, 7) + Random.Range(1, 7)) * 5;

            if (sueReroll > sue) 
            { 
                sue = sueReroll;
            }

        }
            else if (20 >= edad && edad <= 39)
            {
                //Mejora de Educacion
                D100 = Random.Range(1, 101);

                if (D100 > edu)
                { 
                    edu = edu + Random.Range(1, 11);
                }
            }


        if (des<tam && fue < tam)
        {
            mov = 7;
        }
            else if (des>tam || fue>tam)
            {
                mov = 8;
            }
                else if (des>tam && fue>tam)
                {
                    mov = 9;
                }

        if (40 <= edad && 49 > edad)
        {
            mov = mov - 1;
        }
        else if (50 <= edad && 59 >= edad)
        {
            mov = mov - 2;
        }
        else if (60 <= edad && 69 >= edad)
        {
            mov = mov - 3;
        }
        else if (70 <= edad && 79 >= edad)
        {
            mov = mov - 4;
        }
        else if (80 <= edad && 90 >= edad)
        {
            mov = mov - 5;
        }

    }
    
}

   