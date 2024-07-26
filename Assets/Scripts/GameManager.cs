using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject bridge;
    public Transform spawnPoint;
   
    void Start()
    {
        GameStart();
        
    }

    
    void Update()
    {
        
    }
    public void GameStart()
    {
        StartCoroutine("SpawnBridges");
    }
    IEnumerator SpawnBridges()
    {
        while (true)
        {
            float waitTime = Random.Range(0.2f, 2f);
            yield return new WaitForSeconds(waitTime);
            Instantiate(bridge, spawnPoint.position, Quaternion.identity);
        }
    }
}
