using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Waypoint : MonoBehaviour
{
    public List<Transform>Waypoints = new List<Transform>();
    public Transform target;
    public float speed = 5;
    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject taggedObject in GameObject.FindGameObjectsWithTag("Waypoint")) {
            Waypoints.Add(taggedObject.transform);
        }
        target = Waypoints[index];
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(index);
        float step = speed * Time.deltaTime;
        //transform.position = Vector3.MoveTowards(transform.position, player.position, step);

        //Stops the AI before reaching the Player's position
        if (Vector3.Distance(transform.position, target.position) > .001f && target != null)
        {
            //Move torwards the player's position
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);

        }
        else
        {
            //Look at the player, and start shooting
            index += 1;
            Debug.Log("Done navigating");
            if (index == Waypoints.Count)
            {
                index = 0;
            }
            if (Vector3.Distance(transform.position, target.position) > 20f)
            {
                index -= 1;
            }
            target = Waypoints[index];
            Debug.Log(index + " is the place");
        }

        //Turn towards/Look at
        transform.LookAt(target);
    }

}
