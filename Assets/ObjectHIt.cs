using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        WWW request = GetAudioFromFile(soundPath, audioName);
        yield return request;

        Debug.Log("audioClip request: " + request);

        audioClip = request.GetAudioClip();
        audioClip.name = audioName;
    }


    private WWW GetAudioFromFile(string path, string filename)
    {
        // string audioToLoad = string.Format(path + "{0}", filename);
        string audioToLoad = string.Format(path + filename);
        Debug.Log("audioToLoad: " + audioToLoad);

        Debug.Log(audioToLoad);
        WWW request = new WWW(audioToLoad);
        return request;
    }

    private void PlayAudioFile()
    {
        eustaceSound.clip = audioClip;
        eustaceSound.Play();
    }
    
}
