using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{
    [SerializeField] float t = 3;
    [SerializeField] float length = 9;
    [SerializeField] float xAtStart = -13.8f;


    void Update() {
        transform.position = new Vector3((Mathf.PingPong(Time.time, t)  * length  + xAtStart), transform.position.y, transform.position.z);
    }
}
