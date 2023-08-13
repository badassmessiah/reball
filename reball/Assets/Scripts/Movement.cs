using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    float horizontalMovement = 0;
    public float speed = 3;

    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");

        
    }

    private void FixedUpdate()
    {

        if(horizontalMovement > 0.1 || horizontalMovement < -0.1)
        {
            

            rb.velocity += new Vector3(horizontalMovement * speed, 0, 0);
        }
        
    }
}
