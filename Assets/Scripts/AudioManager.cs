using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public Sound[] sounds;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);



        foreach (Sound s in sounds)
        {

            s.audioSource = gameObject.AddComponent<AudioSource>();
            s.audioSource.clip = s.clip;
            s.audioSource.volume = s.volume;
            s.audioSource.pitch = s.pitch;

            s.audioSource.loop = s.loop;
            s.audioSource.playOnAwake = s.playOnAwake;
        }
    }
    private void Start()
    {
        Play("MainTheme");
    }
    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found !!");
            return;

        }
        s.audioSource.Play();
    }


}
