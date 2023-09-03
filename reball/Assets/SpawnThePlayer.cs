using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnThePlayer : MonoBehaviour
{

    [SerializeField] private GameObject spawnPosition1;
    [SerializeField] private GameObject spawnPosition2;
    [SerializeField] private GameObject player;

    public bool occupied = false;
    public bool occupied2 = false;

    public void SpawnPlayer()
    {
        if (!occupied)
        {
            Instantiate(player, spawnPosition1.transform.position, Quaternion.identity);
        }
        else if (!occupied2)
        {
            Instantiate(player, spawnPosition2.transform.position, Quaternion.identity);
        }
    }

    
}
