using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    
    Vector3 direction;
    public float minSpeed = 5f;
    public float shootingSpeed = 20f;
    float speed;

    bool shooting;

    Vector3 newDirection;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3 (0, 0, -10);
        
    }

    private void Update()
    {
        direction = rb.velocity;

        if (Input.GetButtonDown("Fire2"))
        {
            shooting = true;
            
        } else if (Input.GetButtonUp("Fire2"))
        {
            shooting = false;
            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("wall"))
        {
            speed = direction.magnitude;
            newDirection = Vector3.Reflect(direction.normalized, collision.contacts[0].normal);

            rb.velocity = newDirection * Mathf.Max(speed, minSpeed);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            if (shooting)
            {
                speed = direction.magnitude;
                newDirection = Vector3.Reflect(direction.normalized, collision.contacts[0].normal);

                rb.velocity = newDirection * Mathf.Max(speed + shootingSpeed, minSpeed);
            }
            if (!shooting)
            {
                speed = direction.magnitude;
                newDirection = Vector3.Reflect(direction.normalized, collision.contacts[0].normal);

                rb.velocity = newDirection * Mathf.Max(speed, minSpeed);
            }
            
        }
        
    }

    
}
