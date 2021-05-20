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
    [SerializeField] float xSpeed = 1f;
    [SerializeField] float ySpeed = 1f;


    void Update() {
        transform.position = new Vector3((Mathf.PingPong(Time.time * xSpeed, t)  * xLength  + xAtStart), transform.position.y, (Mathf.PingPong(Time.time * ySpeed, t)  * zLength  + zAtStart));
    }
}
