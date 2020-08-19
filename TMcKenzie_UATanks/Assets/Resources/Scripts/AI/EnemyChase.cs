using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform player;
    public float turnSpeed = 5.0f;
    public float speed = 100f;


    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = player.position - transform.position;
        //Vector3.RotateTowards(transform.forward, vector, 1 * Time.deltaTime, 0.0f)
        Quaternion LookAtRotation = Quaternion.LookRotation(vector);
        Quaternion LookAtRotationOnly_Y = Quaternion.Euler(transform.rotation.eulerAngles.x, LookAtRotation.eulerAngles.y + 90, transform.rotation.eulerAngles.z);

    }

}
