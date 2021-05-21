using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadLevel : MonoBehaviour
{

    void Start()
    {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(ReloadLevelOnClick);
    } 

    void ReloadLevelOnClick() {
        foreach (GameObject o in Object.FindObjectsOfType<GameObject>()) {
            Destroy(o);
        }
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Additive);
    }
}
