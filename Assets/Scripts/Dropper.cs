using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;
    MeshRenderer renderer;
    Rigidbody rigidbody;

    void Start() {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        renderer.enabled = false; 
        rigidbody.useGravity = false;

        timeToWait = Random.Range(2 , 10);
    }

    void Update()
    {
        if(Time.time > timeToWait) 
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
    }
}
