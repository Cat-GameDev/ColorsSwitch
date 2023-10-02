using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Jumping : MonoBehaviour
{

    public float jumpForce = 10f;
    protected Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Jump"))
        {
            if(rb.bodyType != RigidbodyType2D.Dynamic)
            {
                rb.bodyType = RigidbodyType2D.Dynamic;
            }
            rb.velocity = Vector2.up * jumpForce;
        }
    }


}
