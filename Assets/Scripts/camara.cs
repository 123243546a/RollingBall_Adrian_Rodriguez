using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeguirPlayer : MonoBehaviour
{
    public Transform target;
    public float xOffset, yOffset, zOffset;

    private void Start()
    {
        
    }

    void Update()
    {

        transform.position = target.transform.position + new Vector3(xOffset, yOffset, zOffset);

        transform.LookAt(target.transform.position);
    }
}
