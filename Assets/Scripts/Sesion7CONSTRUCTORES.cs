using System.Globalization;
using UnityEngine;

public class Sesion7FUNCIONES : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Orco
{
    public string name;
    public float fuerza;
    public float resistencia;
    public float daño;
    public float  vida;

    public Orco (string n, float f, float r, float d)
    {
        name = n;
        fuerza = f;
        resistencia = r;
        daño = d;

        vida = 100 + (resistencia * 5);

        d = CalcularDañoBasico();
        Defenderse(40);
    }

    public float Defenderse(float dañoEntrante)
    {
        float dañoRecibido = 0;

        dañoRecibido = dañoEntrante - resistencia * 1.5f;

        vida -= dañoRecibido;

        return dañoRecibido;
    }

    private float CalcularDañoBasico()
    {
        float dañoBase;
        float probCritico;

        dañoBase = fuerza*2 + Random.Range(-2,4) + 5;

        
    }
}