using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    
    Vector3 direction;
    public float minSpeed = 5f;
    float speed;

    Vector3 newDirection;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3 (0, 0, -10);
        
    }

    private void FixedUpdate()
    {
        
    }

    private void Update()
    {
        direction = rb.velocity;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("wall") || collision.gameObject.CompareTag("Player"))
        {
            speed = direction.magnitude;
            newDirection = Vector3.Reflect(direction.normalized, collision.contacts[0].normal);

            rb.velocity = newDirection * Mathf.Max(speed, minSpeed);
        }
        
    }
}
