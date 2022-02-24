using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    private Rigidbody rb;
    private Animator anim;

    public float jumpforce = 10f;
    public float fallMultiplier = 2.5f;
    public float lowJumpMultiplier = 2f;

    public float speed = 5f; // negative because I fucked up direction in unity

    public GameObject gameOverCanvas;
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        gameOverCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Flap");

            FindObjectOfType<AudioManager>().Play("TappingSound");

            rb.velocity = Vector3.up * jumpforce;
        }

        if(rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        } else if (rb.velocity.y > 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }


        // could use this for moving forward but somehow too slow;
        //Vector3 position = transform.position;
        //position.z += speed * Time.deltaTime;

        //rb.MovePosition(position);
    }


    //code to move bird forward
    //private void FixedUpdate()
    //{
    //    // using this to move forward
    //    if (Mathf.Abs(rb.velocity.z) < 10f)
    //    {
    //        rb.AddRelativeForce(Vector3.forward * speed, ForceMode.VelocityChange);
    //    }
    //}

    private void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 0;
        FindObjectOfType<AudioManager>().Play("PlayerDeath");
        gameOverCanvas.SetActive(true);
    }
}
