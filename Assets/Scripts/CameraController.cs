using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject bird;

    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        Vector3 birdPosition = bird.transform.position;
        Vector3 currentPosition = transform.position;

        currentPosition.x = offset.x;
        currentPosition.y = offset.y;
        currentPosition.z = birdPosition.z;

        transform.position = currentPosition;
    }
}
