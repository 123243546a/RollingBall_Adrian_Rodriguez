using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguirPelota : MonoBehaviour
{
    public Transform pelota;  
    public Vector3 offset = new Vector3(-6.28f, 57.873f, -27.64f); 

    void Update()
    {
        
        transform.position = pelota.position + offset;
        transform.LookAt(pelota);
    }
}
