using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonRotation : MonoBehaviour
{
    public Transform Earth;
    public float rotateSpeed;
    
    void Update()
    {
        transform.RotateAround(Earth.position, Vector3.up, rotateSpeed* Time.deltaTime);
    }
}
