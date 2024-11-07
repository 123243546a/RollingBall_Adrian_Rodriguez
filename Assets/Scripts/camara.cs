using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguirPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Update()
    {
        
        transform.position = player.position + offset;
        transform.LookAt(player);
    }
}
