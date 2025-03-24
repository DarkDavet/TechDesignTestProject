using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    private void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found!");
            return;
        }
        s.source.Play();
    }

    public void Stop(string name)
    {
        if (sounds == null)
        {
            Debug.LogWarning("Sounds array is null! Cannot stop sound.");
            return;
        }

        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null || s.source == null)
        {
            Debug.LogWarning("Sound: " + name + " not found or source is null!");
            return;
        }
        s.source.Stop();
    }

    public void Cleanup()
    {
        foreach (Sound s in sounds)
        {
            if (s.source != null)
            {
                s.source.Stop();
                Destroy(s.source);
            }
        }
        sounds = null; 
    }

    private void OnDestroy()
    {
        Cleanup(); 
    }
}
