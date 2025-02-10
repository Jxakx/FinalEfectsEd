using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorDouble : MonoBehaviour
{

    [Range(0, 1)]
    public float RotationSpeed = 0.2f;

    void Update()
    {
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * RotationSpeed * 300);
    }
}
