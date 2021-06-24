using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldManager : MonoBehaviour
{
    public float rotateSpeed = 50.0f;
    public GameObject player; 

    void Update()
    {
        // Rotates world about the Y axis by the rotate speed
        transform.RotateAround(player.transform.position, Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
