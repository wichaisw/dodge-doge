using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;
    MeshRenderer dropperRenderer;
    Rigidbody rb;

    void Start() {
        dropperRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        dropperRenderer.enabled = false; 
        rb.useGravity = false;

        timeToWait = Random.Range(2 , 8);
    }

    void Update()
    {
        if(Time.time > timeToWait) 
        {
            dropperRenderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
