using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;      //Array of Sound objects

    public static AudioManager instance;    //References to current instance of audio manager

    void Awake()
    {  
        
        if(instance == null)
            instance = this;
        else{
            Destroy(gameObject);
            return;
        }

        //Music will not restart after the next level
        DontDestroyOnLoad(gameObject);

        //Loops through each sound in the 'sounds' array
        foreach (Sound s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
        
    }


    public void Play(string name){
        //Locates the sound clip using the name of the sound file
        Sound s = Array.Find(sounds, sound => sound.name == name);
        
        //Checks if the sound file exists
        if(s == null){
            Debug.LogWarning("The sound file for " + name + " is missing.");
            return;
        }

        s.source.Play(); 
    }

    public void StopPlaying (string name){
        Sound s = Array.Find(sounds, sound => sound.name == name);
        
        if (s == null){
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        s.source.Stop ();
    }

}
