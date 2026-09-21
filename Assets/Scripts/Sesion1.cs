using UnityEngine;

public class Sesion1 : MonoBehaviour
{
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Ej0
        Debug.Log ("Iniciando el curso");

        //Ej0.1
        int solSuma = 0;
        int solMultiplicacion = 0;
        float solDivision = 0f;
        int Numero1=0, Numero2=0;


        solSuma = 20394 + 103931;
        solMultiplicacion = 130 * 340;
        solDivision = 10.5f / 4.0f ;

        Debug.Log ("La solución de la suma es " + solSuma + ", la de la multiplicación es " + solMultiplicacion + " y el de la división es " + solDivision);
        
        /*
         Podria hacerlo con 3 mensajes separados pero es innecesario
        Debug.Log ("La solución de la multiplicación es " + solMultiplicacion);
        Debug.Log("La solución de la división es " + solDivision);
        */

        //Ej1
        int multiplicarDosNumeros = Numero1 * Numero2;

        //Ej2
        int dividirDosNumeros = Numero1 / Numero2;

        //Ej3
        int restoDosNumeros = Numero1 % Numero2;

        //Ej4
        int metros= 2500; //Metros

        int factorConversion = 1609;

        int millas = metros/factorConversion;

        //Ej5 Programa que dado el delta del tiempo y la velocidad, calcula la distancia recorrida 

        int vel = 5;
        int deltaT = 1;

        float distancia = vel * deltaT;

        //Ej6 segundos = minutos y segundos

        int segundosIniciales = 140;

        int minutos = segundosIniciales % 60 ;
        int segundos = segundosIniciales - (minutos * 60);

        Debug.Log (segundosIniciales + "segundos son " + minutos + "minutos y " + segundos + "segundos.");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
