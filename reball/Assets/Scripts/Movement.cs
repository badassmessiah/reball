using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    float horizontalMovement = 0;
    float speed = 50;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;

        rb.AddForce(horizontalMovement, 0, 0, ForceMode.Impulse);

        Debug.Log(horizontalMovement);
    }
}
