using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 0f;
    [SerializeField] float timeToWaitRangeStart = 2f;
    [SerializeField] float timeToWaitRangeEnd = 8f;
    
    MeshRenderer dropperRenderer;
    Rigidbody rb;

    void Start() {
        dropperRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();

        dropperRenderer.enabled = false; 
        rb.useGravity = false;
        
        if(timeToWaitRangeStart != -1) {
            timeToWait = Random.Range(timeToWaitRangeStart , timeToWaitRangeEnd);
        }

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
