using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsScript : MonoBehaviour
{
    public float speed = 2f;


    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition += Vector3.forward * speed * Time.deltaTime;
        transform.position = newPosition;

        if(transform.position.z >= 180)
        {
            Destroy(gameObject);
        }
    }
}
