using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioSource Music;
    public AudioClip Cotton;
    public GameObject MuteIcon;
    public float audiomute = 0f;
    private void Start()
    {
        //Music.clip = Cotton;
        DontDestroyOnLoad(Music);
        //DontDestroyOnLoad(MuteIcon);
    }
    public void MuteToggle(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 0;
            audiomute = 1f;
        }else
        {
            AudioListener.volume = 1;
            audiomute = 0f;
        }
        
    }

    private void Update()
    {
        PlayerPrefs.SetFloat("Mute", audiomute);
        //Debug.Log(audiomute);
    }
}
