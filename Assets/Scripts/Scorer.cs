using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hitCounter = 0;

    private void OnCollisionEnter(Collision other) {
        hitCounter++;
        string message = System.String.Format("You have hit this thing {0} times", (hitCounter).ToString());
        
        Debug.Log(message);
    }
}
