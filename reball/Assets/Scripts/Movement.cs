using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    float horizontalMovement = 0;
    float speed = 3;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal");

        //rb.AddForce(horizontalMovement, 0, 0, ForceMode.Impulse);

        //rb.velocity += new Vector3(horizontalMovement, 0, 0) * speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        rb.velocity += new Vector3(horizontalMovement, 0, 0) * speed;
    }
}
