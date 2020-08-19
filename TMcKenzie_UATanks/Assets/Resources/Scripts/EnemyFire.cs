using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class EnemyFire : MonoBehaviour
{
    public GameObject torpedo;
    public Transform spawnPoint;
    public static float enemyThrust;
    public static float enemyBulletTimeout;

    void Start()
    {
        BeginCode();
    }

    void Update()
    {

    }

    void BeginCode()
    {
        StartCoroutine(nameof(WaitAMinute));
    }

    void Shoot()
    {
        GameObject BulletHold = Instantiate(torpedo, spawnPoint.position, spawnPoint.rotation) as GameObject;
        Rigidbody temporary_RB = BulletHold.GetComponent<Rigidbody>();
        temporary_RB.AddForce(transform.forward * (enemyThrust * 2));
        Destroy(BulletHold, enemyBulletTimeout);
        BeginCode();
    }

    IEnumerator WaitAMinute()
    {
        Debug.Log("Waiting");
        yield return new WaitForSeconds(2);
        Debug.Log("Done waiting");
        Shoot();
    }

}