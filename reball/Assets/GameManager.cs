using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform ballPos;
    [SerializeField] GameObject ballPrefab;
    public void StartGame()
    {
        Instantiate(ballPrefab, ballPos.position, Quaternion.identity);
    }
}
