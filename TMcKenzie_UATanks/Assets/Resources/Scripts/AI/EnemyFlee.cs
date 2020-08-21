using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlee : MonoBehaviour
{
    public Transform player;
    public float turnSpeed = 5.0f;
    public float speed = 100f;
    public float distanceToStop = 5f;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = player.position - transform.position;
        //Vector3.RotateTowards(transform.forward, vector, 1 * Time.deltaTime, 0.0f);
        Quaternion LookAtRotation = Quaternion.LookRotation(vector);
        Quaternion LookAtRotationOnly_Y = Quaternion.Euler(transform.rotation.eulerAngles.x, LookAtRotation.eulerAngles.y + 90, transform.rotation.eulerAngles.z);


        float step = speed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, player.position, step);

        //Stops the AI before reaching the Player's position
        if (Vector3.Distance(transform.position, player.position) > distanceToStop)
        {
            //Move torwards the player's position
            transform.position = Vector3.MoveTowards(transform.position, -player.position, step);
            //Debug.Log(Vector3.Distance(transform.position, player.position));
        }
        else
        {
            //Look at the player, and start shooting
            //Debug.Log("Done");
        }

        //Turn towards/Look at
       // transform.LookAt(player.position.x * -1,);

    }

}
