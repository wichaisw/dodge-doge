using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class StartGame : MonoBehaviour
{
    [SerializeField] float waitTime = 1f;
    CinemachineVirtualCamera followCamera;
    void Start()
    {
        followCamera = GameObject.FindWithTag("FollowCamera").GetComponent<CinemachineVirtualCamera>();

        Vector3 startPosition = new Vector3(-12.68f, 2.81f, -13.23f);
        gameObject.transform.position = startPosition;
        gameObject.transform.rotation = Quaternion.Euler(90, 0, 0);
        StartCoroutine(WaitToStart());
    }

    IEnumerator WaitToStart()
    {
        yield return new WaitForSeconds(waitTime);
        // this.followCamera.enabled = true; 
        gameObject.GetComponent<CinemachineBrain>().enabled = true;
        
    }
}
