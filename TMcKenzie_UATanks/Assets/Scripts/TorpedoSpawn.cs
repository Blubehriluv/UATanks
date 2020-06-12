using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoSpawn : MonoBehaviour
{
    public GameObject torpedo;
    public Transform spawnPoint;
    public float thrust = 1.0f;

    void Start()
    {
        spawnPoint = gameObject.GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject BulletHold = Instantiate(torpedo, spawnPoint.position, spawnPoint.rotation) as GameObject;
            Rigidbody temporary_RB = BulletHold.GetComponent<Rigidbody>();
            temporary_RB.AddForce(transform.forward * (thrust  * 2));
            Destroy(BulletHold, 5.0f);
        }
    }
}