using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform playerTF;
    public Rigidbody playerRB;
    public float playerForwardSpeed = 0.09f;
    public float playerBackSpeed = 0.03f;
    public float playerTurnSpeed = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        playerTF = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            playerTF.position += Vector3.forward * playerForwardSpeed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            playerTF.position += Vector3.back * playerBackSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Quaternion wantedRotation = playerTF.rotation * Quaternion.Euler(Vector3.up * playerTurnSpeed);
            playerRB.MoveRotation(wantedRotation);
        }
    }
}
