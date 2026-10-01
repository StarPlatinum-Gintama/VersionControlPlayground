using UnityEngine;

public class Sesion3EJERCICIOSBUCLES : MonoBehaviour
{
   
    void Start()
    {
        //Bucle While Ejercicios

        //Ej4

        //Escribe el código necesario en el método Start para generar y mostrar por consola posiciones aleatorias para la coordenada X e Y
        //de un número de enemigos definido en la variable num_enemies de tipo entero.
        //La pantalla mide 600x480, dejando un margen de 10 unidades por dimensión. (osea será 590x470)

        int num_enemigos = 5;
        int posX = 0;
        int posY = 0;

        int pantallaX = 590;
        int pantallaY = 470;

        int contador = 1;

        while (contador <= num_enemigos)
        {
            posX = Random.Range(0,pantallaX);
            posY = Random.Range(0,pantallaY);

            Debug.Log( "La posicion del enemigo " + contador + " es " + posX + "m en X y " + posY + "m en Y");
            contador = contador + 1;
        }
        


    }
     void Ej1()
     {
         //Escribe el código necesario para imprimir los primeros n numeros naturaes, donde n es una variable en el código que puede almacenar cualquier número natural. 
        int n = Random.Range(1, 100);
        int num = 0;

        while (num < n)
        {
            Debug.Log(num);
        }
     }

     void Ej2()
     {
            //Escribe el código necesario para multiplicar un num por otro, pero sin usar el operador de multiplicación (*)
            //digamos que es n1*n2

            int n1 = 2;
            int n2 = 3;

            int solucion = 0;
            int contador = 0;

            while (contador < n2 )
            {
                solucion = solucion + n1;
                contador = contador + 1;
            }

            Debug.Log ("La solucion de multiplicar " + n1 + " y " + n2 + " es " + solucion);
     }

    void Ej3()
    {
        //Escribe el código necesario para elevar un número (base) a otro (exponente),sin el operador de la librería matemática.
        //Consejo: Elevar una base a un exponente no es más que una multiplicación repetida.

        int Base = 2;
        int exponente = 3;

        int solucion = 1;
        int contador = 0;

        while (contador < exponente)
        {
            solucion = solucion * Base;
            contador = contador + 1;
        }

        Debug.Log( Base + "  elevado a " + exponente + " es " + solucion);
    }

}

   

   

