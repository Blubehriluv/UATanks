using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject[] spawnLocations;
    public GameObject player;
    public GameObject redEnemy;
    public GameObject yellowEnemy;
    public GameObject greenEnemy;

    private Vector3 respawnLocation;

    private void Awake()
    {
        //spawnLocations = GameObject.FindGameObjectsWithTag("SpawnPoint");

    }
    void Start()
    {
        respawnLocation = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlayer()
    {
        int spawn = Random.Range(0, spawnLocations.Length);
        GameObject.Instantiate(player, spawnLocations[spawn].transform.position, Quaternion.identity);
    }

    public void SpawnRed()
    {
        int spawn2 = Random.Range(0, spawnLocations.Length);
        GameObject.Instantiate(redEnemy, spawnLocations[spawn2].transform.position, Quaternion.identity);
    }

    public void SpawnYellow()
    {
        int spawn3 = Random.Range(0, spawnLocations.Length);
        GameObject.Instantiate(yellowEnemy, spawnLocations[spawn3].transform.position, Quaternion.identity);
    }

    public void SpawnGreen()
    {
        int spawn4 = Random.Range(0, spawnLocations.Length);
        GameObject.Instantiate(greenEnemy, spawnLocations[spawn4].transform.position, Quaternion.identity);
    }
    
}
