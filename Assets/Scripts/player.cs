using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBall : MonoBehaviour
{
    public float fuerzaMovimiento = 3f; // La fuerza para mover la bola a los lados
    public float velocidadConstante = 1.5f; // Velocidad constante hacia adelante
    public float fuerzaSalto = 8f;

    private Rigidbody rb;

    void Start()
    {
        // Obtenemos el Rigidbody del objeto
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Mantener una velocidad constante hacia adelante en el eje Z
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, velocidadConstante);

        // Obtener el valor del eje "Horizontal" para moverse lateralmente con A y D
        float movimientoLateral = Input.GetAxis("Horizontal");

        // Crear un vector de fuerza solo en el eje X
        Vector3 fuerzaLateral = new Vector3(movimientoLateral, 0, 0);

        // Aplicar la fuerza lateral al Rigidbody
        rb.AddForce(fuerzaLateral * fuerzaMovimiento, ForceMode.Force);

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
        }
    }
}
