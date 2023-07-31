using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    Rigidbody rb;
    public float pushingForce = 5;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "wall") 
        {
            Debug.Log("player or wall");

            rb.AddForce(-transform.forward * pushingForce);


        }
    }
}
