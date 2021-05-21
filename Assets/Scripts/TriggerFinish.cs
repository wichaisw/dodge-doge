using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.UI;
public class TriggerFinish : MonoBehaviour
{
    GameObject floor;
    GameObject mainCamera;
    CinemachineVirtualCamera followCamera;
    SpriteRenderer gameOverScreen;
    Vector3 gameOverPosition = new Vector3(-0.35f, 9.18f, -19.65f);
    Vector3 gameOverRotation = new Vector3(13.047f, 0, 0);
    // public Button RetryButton;
    public GameObject retryButton;


    void Start() {
        floor = GameObject.FindWithTag("Floor");
        mainCamera = GameObject.FindWithTag("MainCamera");
        followCamera = GameObject.FindWithTag("FollowCamera").GetComponent<CinemachineVirtualCamera>();
        gameOverScreen = GameObject.FindWithTag("GameOverScreen").GetComponent<SpriteRenderer>();
        retryButton = GameObject.FindWithTag("RetryButton");
        
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player") 
        {
            Debug.Log("Finish");
            RemoveObject();
            other.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            other.gameObject.GetComponent<Rigidbody>().drag = 2;

            StartCoroutine(DestroyObjects());
        }
    }

    void RemoveObject() {
        floor.GetComponent<MeshRenderer>().enabled = false;
        floor.GetComponent<MeshCollider>().enabled = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
    }

    void ResetCamera() 
    {
        this.followCamera.enabled = false;
        mainCamera.transform.position = gameOverPosition;
        mainCamera.transform.rotation = Quaternion.Euler(gameOverRotation);
    }

    void ShowGameOverScreen() 
    {
        gameOverScreen.enabled = true;
        // retryButton.SetActive(true);
        retryButton.GetComponent<Image>().enabled = true;
        retryButton.GetComponentsInChildren<Text>()[0].enabled = true;
    }

    IEnumerator DestroyObjects()
    {
        ResetCamera();
        yield return new WaitForSeconds(2f);

        GameObject obstaclesGroup = GameObject.FindWithTag("Obstacles");
        GameObject environmentGroup = GameObject.FindWithTag("Environment");
        GameObject toBeDestroy = GameObject.FindWithTag("ToBeDestroy");
        
        obstaclesGroup.SetActive(false);
        environmentGroup.SetActive(false);
        Destroy(toBeDestroy);
        
        ShowGameOverScreen();
        
    }


}
