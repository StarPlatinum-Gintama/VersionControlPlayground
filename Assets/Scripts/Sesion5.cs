using NUnit.Framework;
using UnityEngine;

public class Sesion5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cuadrado();
    }

    void Cuadrado()
    {
        int ladoN = 4;
        string cuadrado = "";

        for (int i=0; i<ladoN; i++)
        {
            for (int j=0; j<ladoN; i++)
            {
                cuadrado += "+";
            }

            cuadrado += "\n";
        }

         Debug.Log(cuadrado);
    }

    void SemiPiramide()
    {
        int N = 4;
        string piramide = "";

        for (int i = 0; i <N; i++)
        {
            for (int j = 0; j < N; i++)
            {
                piramide += "+";
            }

            piramide += "\n";
        }

        Debug.Log(piramide);

    }
}
