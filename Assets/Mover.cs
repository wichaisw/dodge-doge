using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Make the game framerate independent
    
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0, zValue);
    }
}
