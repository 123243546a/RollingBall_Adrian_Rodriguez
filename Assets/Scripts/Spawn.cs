using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform posRespawn;
    public Transform posPlayer;
   
    void Update()
    {
        
    }

    public void DeadPlayer()
    {
        posPlayer.position = posRespawn.position;
    }
}
