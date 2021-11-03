using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smootSpeed = 0.125f;
    public bool gameOver;
    Vector2 velocity = Vector2.zero;

    private void LateUpdate()
    {
        if (target != null) { 
            transform.position = new Vector3(target.position.x, (target.position.y +7 ), transform.position.z);

        if (gameOver == true)
        {
            transform.position = new Vector3(0, 0, 0);
        }

        if (gameOver == false)
        {
            transform.position = new Vector3(target.position.x, (target.position.y +7 ), transform.position.z);
        }
    }
    }
}
