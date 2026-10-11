using UnityEditor;
using UnityEngine;

public class Sesion4BUCLEFOR : MonoBehaviour
{
    
    void Start()
    {
        Ej1();
        Ej2();
        Ej3();
    }

    
    void Ej1()
    {
        //Escribe el código para sumar la secuencia de números del 1 al n, siendo n una variable entera. Ej: n=5; 1+2+3+4+5=15.

        int n = Random.Range (1,101);
        int suma = 0;

        for (int i = 1 ; i<=n ; i++)
        {
            suma = suma + i;
        }

        Debug.Log("La suma de la secuencia del 1 al " + n + " es igual a " + suma);
    }

    void Ej2()
    {
        //Escribe el código para mostrar la cuenta atrás de un explosivo, empezando por un valor almacenado en initial_time, y mostrando "EXPLOSIÓN" cuando la cuenta termine.
        //Diremos que cuando llegue a 0 mostrará directamente EXPLOSIÓN por pantalla

        int initial_time = 5;

        for (int i = initial_time; i >= 0; i--)
        {
            if (i == 0)
            {
                Debug.Log("EXPLOSIÓN");
            }
            else
            {
                Debug.Log(i);
            }
        }
    }

    void Ej3()
    {
        //Escribe un programa que muestre los números pares de 1 hasta n_pares, que almacenará el límite máximo.

        int n_pares = 8;

        for (int i = 0; i <= n_pares; i += 2)
        {
            Debug.Log(i);
        }
    }
}
