using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roller : MonoBehaviour
{
    [SerializeField] float t = 3;
    [SerializeField] float xLength = 9;
    [SerializeField] float zLength = 0;
    [SerializeField] float xAtStart = -13.8f;
    [SerializeField] float zAtStart = 0;


    void Update() {
        transform.position = new Vector3((Mathf.PingPong(Time.time, t)  * xLength  + xAtStart), transform.position.y, (Mathf.PingPong(Time.time, t)  * zLength  + zAtStart));
    }
}
