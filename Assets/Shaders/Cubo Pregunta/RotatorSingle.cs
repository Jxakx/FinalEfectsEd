using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorSingle : MonoBehaviour
{
    [Range(0, 1)]
    public float RotationSpeed = 0.2f;

    void Update()
    {
        transform.Rotate(Time.deltaTime * RotationSpeed * 300,  // Rotaci�n en X
                         Time.deltaTime * RotationSpeed * 200,  // Rotaci�n en Y
                         0);                                 
    }
}
