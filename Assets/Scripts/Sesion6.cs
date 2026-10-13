using UnityEngine;

public class Sesion6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Modulovectores()
    {
        float posX1 = 2.0f, posY1 = 3.0f;
        float posX2 = 5.0f , posY2 = 1.0f;
        float posX3 = 3.0f, posY3 = 6.0f;

        //Calcula el módulo (la norma) de estos vectores

        float suma1 = posX1*posX1 + posY1*posY1;
        float modulo1 = Mathf.Sqrt(suma1);

        float suma2 = posX2*posX2 + posY2*posY2;
        float modulo2 = Mathf.Sqrt(suma2);

        float suma3 = posX3*posX3 + posY3*posY3;
        float modulo3 = Mathf.Sqrt(suma3);
    }

    void ModuloVectoresEntre2()
    {
        float posX1 = 2.0f, posY1 = 3.0f;
        float posX2 = 5.0f, posY2 = 1.0f;
        float posX3 = 3.0f, posY3 = 6.0f;

        //Calcula la distancia entre ellos (el módulo de la distancia)

        float Vec1y2_X= (posX2-posX1) , Vec1y2_Y = (posY2 - posY1);
        float Vec1y3_X = (posX3 - posX1) , Vec1y3_Y = (posY3 - posY1);
        float Vec2y3_X = (posX3 - posX2), Vec2y3_Y = (posY3 - posY2);

        float Dist_1y2 = Mathf.Sqrt((Vec1y2_X*Vec1y2_X)+(Vec1y2_Y * Vec1y2_Y));
        float Dist_1y3 = Mathf.Sqrt((Vec1y3_X * Vec1y3_X) + (Vec1y3_Y * Vec1y3_Y));
        float Dist_2y3 = Mathf.Sqrt((Vec2y3_X * Vec2y3_X) + (Vec2y3_Y * Vec2y3_Y));
    }
}
