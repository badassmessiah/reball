using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    float horizontalMovement = 0f;
    float fire = 0f;
    public float speed = 10f;
    public float increasedSpeed = 20f;
    private Vector3 m_Velocity = Vector3.zero;
    [Range(0, .3f)][SerializeField] private float m_MovementSmoothing = .07f;
    [Range(0, .3f)][SerializeField] private float stop_MovementSmoothing = .07f;
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        fire = Input.GetAxis("Fire1");
        Debug.Log(fire + "speeding");

    }

    private void FixedUpdate()
    {

        if (horizontalMovement > 0.1 || horizontalMovement < -0.1)
        {
            if (fire < 0.1)
            {
                Vector3 targetVelocity = new Vector3(horizontalMovement * speed, 0, 0);

                rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);

            } else if (fire > 0.1)
            {
                Vector3 targetVelocity = new Vector3(horizontalMovement * increasedSpeed, 0, 0);

                rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
            }


            //rb.velocity += new Vector3(horizontalMovement * speed, 0, 0);
        } else if (horizontalMovement < 0.1 || horizontalMovement > -0.1)
        {
            rb.velocity = Vector3.SmoothDamp(rb.velocity, Vector3.zero, ref m_Velocity, stop_MovementSmoothing);
        }
        
    }
}
