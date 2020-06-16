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
    private GameObject torpedo;
    private GameObject tree;

    // Start is called before the first frame update
    void Start()
    {
        playerTF = gameObject.GetComponent<Transform>();
        torpedo = GameObject.FindGameObjectWithTag("torpedo");
        tree = GameObject.FindGameObjectWithTag("tree");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 wantedPosition =
                playerTF.position + (playerTF.forward * playerForwardSpeed * Time.deltaTime);
            playerRB.MovePosition(wantedPosition);
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 wantedPosition =
                playerTF.position - (playerTF.forward * playerBackSpeed * Time.deltaTime);
            playerRB.MovePosition(wantedPosition);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Quaternion wantedRotation = playerTF.rotation * Quaternion.Euler(Vector3.up * playerTurnSpeed);
            playerRB.MoveRotation(wantedRotation);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Quaternion wantedRotation = playerTF.rotation * Quaternion.Euler(Vector3.down * playerTurnSpeed);
            playerRB.MoveRotation(wantedRotation);
        }
    }

    public void OnCollisionEnter(Collider other)
    {
        if (other == torpedo)
        {
            Debug.Log("OUCH");
        }

        if (other == tree)
        {
            Debug.Log("who put that tree there");

        }

        if (other != torpedo && other != tree)
        {
            Debug.Log("Gotta watch where I'm goin'!");
        }
    }
}