using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("GameOver"))
        {
            // Reaparece al jugador en la posición inicial
            transform.position = startPosition;
        }
    }
}
