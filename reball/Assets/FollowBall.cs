using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{

    public Transform ball;
    public float smoothing = 0.3f;

    Vector3 botX;
    Vector3 ballx;

    void Update()
    {

        botX = transform.position;
        ballx = new Vector3(ball.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(botX, ballx, smoothing);
    }
}
