using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinish : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.tag == "Player") 
        {
            Debug.Log("Finish");
            Rigidbody floor = GameObject.FindWithTag("Floor").AddComponent<Rigidbody>();
            gameObject.AddComponent<Rigidbody>();
            // other.gameObject.GetComponent<Rigidbody>().freezeRotation = false;
            other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            other.gameObject.GetComponent<Rigidbody>().drag = 5;
        }
    }
}
