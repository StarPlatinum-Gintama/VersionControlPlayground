using UnityEngine;

public class Sesion2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        //Evaluar una f(X)= 10*x^[3] + 5*x^[2] + 10*x + 15

        int x = 2;

        float funcion = 10 * Mathf.Pow(x, 3) + 5 * Mathf.Pow(x, 2) + 10 * x + 15;

        //Escribir un codigo con condicional

        int edad = 20;

        if (edad > 18)  
        {
            Debug.Log("Puedes aceder");
        }

        Debug.Log("Fin del Programa");

        //Escribir un codigo donde detecte si flapppy bird se ha salido de la pantalla 0m abajo y 700m arriba es el límite

        int upperLimitY = 700;
        int lowerLimitY = 0;

        int posYFlappy = 60;

        if (posYFlappy > upperLimitY | posYFlappy < lowerLimitY)
        {
            Debug.Log("Te has muerto");
        }

        //Escribe un programa que dado el indice del dia de la semana (entre 1 y 7) indique si es lunes, martes, miercoles...

        int indiceDia = 1;

        if (indiceDia == 1)
        {
            Debug.Log("Lunes");
        }
            else if (indiceDia == 2)
            {
                Debug.Log("Martes");
            }
                else if (indiceDia == 3)
                {
                    Debug.Log("Miercoles");
                }
                    else if (indiceDia == 4)
                    {
                        Debug.Log("Jueves");
                    }
                        else if (indiceDia == 5)
                        {
                            Debug.Log("Viernes");
                        }
                            else if (indiceDia == 6)
                            {
                                Debug.Log("Sabado");
                            }
                                else 
                                {
                                    Debug.Log("Domingo");
                                }

        //Escribe un programa que dado un punto con sus coordenadas x e y determine el cuadrante en el q se encuentra (lo de la grafica x e y)

        int coordX = 2, coordY= -1;

        if (coordX == 0 | coordY == 0)
        {
            Debug.Log ("No se encuentra en ningún cuadrante");
        }
            else if (coordX > 0 & coordY > 0)
            {
                Debug.Log("Primer Cuadrante");
            }
                else if (coordX > 0 & coordY < 0)
                {
                    Debug.Log("Segundo Cuadrante");
                }
                    else if (coordX < 0 & coordY < 0)
                    {
                        Debug.Log("Tercer Cuadrante");
                    }
                        else if (coordX < 0 & coordY > 0)
                        {
                            Debug.Log("Cuarto Cuadrante");
                        }
        //Escribe un programa que determine el ganador de una partida en piedra, papel o tijeras, quién es el ganador


        int Jugador1=0;
        int Jugador2=0;

        int piedra = 1, papel = 2, tijeras = 3;


        if (Jugador1 == piedra && Jugador2 == papel)
        {
            Debug.Log ("Gana Jugador 2");
        }
            else if (Jugador1 == piedra && Jugador2 == tijeras)
            {
                Debug.Log ("Gana Jugador 1");
            }
                else if (Jugador1 == piedra && Jugador2 == piedra)
                {
                    Debug.Log ("Empate");
                }
                    else if (Jugador1 == papel && Jugador2 == piedra)
                    {
                        Debug.Log ("Gana Jugador 1");
                    }
                        else if (Jugador1 == papel && Jugador2 == tijeras)
                        {
                            Debug.Log ("Gana Jugador 2");
                        }
                            else if (Jugador1 == papel && Jugador2 == papel)
                            {
                                Debug.Log ("Empate");
                            }
                                else if (Jugador1 == tijeras && Jugador2 == piedra)
                                {
                                    Debug.Log ("Gana Jugador 2");
                                }
                                    else if (Jugador1 == tijeras && Jugador2 == tijeras)
                                    {
                                        Debug.Log ("Empate");
                                    }
                                        else if (Jugador1 == tijeras && Jugador2 == papel)
                                        {
                                            Debug.Log ("Gana Jugador 1");
                                        }






        /* 
         int VictoriasJugador1 = 0;
         int VictoriasJugador2 = 0;

         int 


         if (VictoriasJugador2 < VictoriasJugador1)
         {
             Debug.Log ("Gana el Jugador1");
         }
             else if (VictoriasJugador2 > VictoriasJugador1)

             {
                 Debug.Log("Gana el Jugador2");
             }
                 else
                 {
                     Debug.Log("Es un empate");
                 }
        */

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
