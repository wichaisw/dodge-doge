using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class ObjectHIt : MonoBehaviour
{
    public const string audioName = "Eustace.mp3";

    [Header("Audio Stuff")]
    public AudioSource eustaceSound;
    public AudioClip audioClip;
    public string soundPath;
    // this is a Unity's callback method. Doesn't need to be put in the Update() method.

    private void Start() {
        eustaceSound = gameObject.AddComponent<AudioSource>();
        soundPath = @"file://" + @Application.streamingAssetsPath + "/Sound/";
        StartCoroutine(LoadAudio());
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Wall got bumped");
        // eustaceSound.Play();
        PlayAudioFile();
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    private IEnumerator LoadAudio() {     
        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(soundPath + audioName, AudioType.MPEG))
        {
            yield return www.SendWebRequest();
            audioClip = DownloadHandlerAudioClip.GetContent(www);

            if (www.result == UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log(www.error);
            }
            else
            {
                AudioClip myClip = DownloadHandlerAudioClip.GetContent(www);
            }
        }
    }

    private void PlayAudioFile()
    {
        eustaceSound.clip = audioClip;
        eustaceSound.Play();
    }
    
}
