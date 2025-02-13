using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100f; // Velocidad de rotación en grados por segundo

    void Update()
    {
        // Rota el objeto en el eje X como si fuera una rueda
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
