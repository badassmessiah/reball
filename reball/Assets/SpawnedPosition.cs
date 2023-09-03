using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnedPosition : MonoBehaviour
{
    public GameObject spawnManager;

    private void Awake()
    {
        spawnManager = GameObject.Find("SpawnManager");
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("spawnPos1"))
        {
            spawnManager.GetComponent<SpawnThePlayer>().occupied = true;
        }

        if (col.gameObject.CompareTag("spawnPos2"))
        {
            spawnManager.GetComponent<SpawnThePlayer>().occupied2 = true;
        }
    }
}
