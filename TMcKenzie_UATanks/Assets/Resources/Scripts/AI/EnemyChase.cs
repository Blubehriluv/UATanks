using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform player;
    public float turnSpeed = 5.0f;
    public float speed = 4f;
    public float distanceToStop = 5f;
    public float step;
        

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 vector = player.position - transform.position;
            //Vector3.RotateTowards(transform.forward, vector, 1 * Time.deltaTime, 0.0f);
            Quaternion LookAtRotation = Quaternion.LookRotation(vector);
            Quaternion LookAtRotationOnly_Y = Quaternion.Euler(transform.rotation.eulerAngles.x, LookAtRotation.eulerAngles.y + 90, transform.rotation.eulerAngles.z);


            step = speed * Time.deltaTime;
            //transform.position = Vector3.MoveTowards(transform.position, player.position, step);

            //Turn towards/Look at
            transform.LookAt(player);
        }

        if (Vector3.Distance(transform.position, player.position) > distanceToStop && player != null)
        {
            //Move torwards the player's position
            transform.position = Vector3.MoveTowards(transform.position, player.position, step);
            //Debug.Log(Vector3.Distance(transform.position, player.position));
        }
        else 
        {
            //Look at the player, and start shooting
            //Debug.Log("Done");
        }

        
        
    }

}
