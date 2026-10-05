using UnityEngine;

public class Sesion4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SimuladorTiradasDados();
    }

    void SimuladorTiradasDados()
    {
        int mCaras = 6;
        int mDados = 3;
        int mTiradas = 100;
        int [] tiradas = new int [(mDados * mCaras)+1 ];

        for (int i=0; i<mTiradas; i++)
        {
            int sumaResultado = 0;

            for (int j=0; j<mDados; j++)
            {
                sumaResultado += Random.Range(1,mCaras+1);
                tiradas[sumaResultado]++;
            }
        }

        for (int i=mDados; i<tiradas.Length ; i++)
        {
            Debug.Log ("El número " + i + " ha salido " + tiradas[i] + " veces ");
        }

    }



}

