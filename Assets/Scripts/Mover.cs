using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 8.0f;
    public Rigidbody body; 

    // Start is called before the first frame update
    void Start()
    {
        // transform.Translate(1, 1, 1);
        body = GetComponent<Rigidbody>();
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction() 
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Press arrow keys or WASD to move around");
        Debug.Log("Btw, don't touch the wall!");
    }

    void MovePlayer() {
        // Basic move
        // Make the game framerate independent with Time.deltaTime
        // float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        // float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        // transform.Translate(xValue, 0, zValue);

        // applying physic with rigidbody, this way the block won't glitched through wall
        Vector3 oldPosition = body.position;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        float moveH = Input.GetAxis ("Horizontal");
        float moveV = Input.GetAxis ("Vertical");
        body.velocity = new Vector3(moveH  * moveSpeed, body.velocity.y,  moveV * moveSpeed);
    }
}
