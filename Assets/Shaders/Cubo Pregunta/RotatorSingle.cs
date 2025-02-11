using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorSingle : MonoBehaviour
{
    [Range(0, 1)]
    public float RotationSpeed = 0.2f;

    void Update()
    {
        transform.Rotate(Time.deltaTime * RotationSpeed * 300,  // Rotación en X
                         Time.deltaTime * RotationSpeed * 200,  // Rotación en Y
                         0);                                 
    }
}
