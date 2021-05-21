using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
public class PlayEustaceSound : MonoBehaviour
{
    public const string audioName = "Eustace.mp3";

    [Header("Audio Stuff")]
    public AudioSource eustaceSound;
    public AudioClip audioClip;
    public string soundPath;
    SpriteRenderer gameOverScreen;

    void Start()
    {
        // gameOverScreen = GameObject.FindWithTag("GameOverScreen").GetComponent<SpriteRenderer>();
        eustaceSound = gameObject.AddComponent<AudioSource>();
        soundPath = @"file://" + @Application.streamingAssetsPath + "/Sound/";
        StartCoroutine(LoadAudio());
    }

    void Update()
    {
        if(gameObject.GetComponent<SpriteRenderer>().enabled == true) {
            // Debug.Log(gameObject.GetComponent<SpriteRenderer>().enabled);
            PlayAudioFile();
        }
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
