using System.Runtime.CompilerServices;
using UnityEngine;

public class RotatingObject : MonoBehaviour
{
    [SerializeField] private float rotationspeed = 90f;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(0f, rotationspeed * Time.deltaTime, 0f);

    }
}
