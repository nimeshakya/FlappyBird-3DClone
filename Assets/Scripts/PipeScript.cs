using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        position += Vector3.forward * speed * Time.deltaTime;
        transform.position = position;

        if (transform.position.z >= 180)
        {
            Destroy(gameObject);
        }
    }
}
