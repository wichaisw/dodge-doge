using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHIt : MonoBehaviour
{
    // this is a Unity's callback method. Doesn't need to be put in the Update() method.
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Ouch: " + other);
    }
}
