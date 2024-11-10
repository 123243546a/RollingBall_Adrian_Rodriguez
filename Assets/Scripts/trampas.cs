using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampas : MonoBehaviour
{
    public float rotationSpeed = 100f; // Velocidad de rotación en grados por segundo.

    private void Update()
    {
        // Rota el objeto alrededor del eje Y a la velocidad definida.
        transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
    }
}
