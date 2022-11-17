using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]   //Makes this custom function appear in inspector
public class Sound
{
    public string name;     //Name of clip

    public AudioClip clip;  //Clip file
    
    [Range(.1f, 3f)]     //Adds a slider to pitch (.1-3) 
    public float pitch;     //Pitch setting

    [Range(0f, 1)]     //Adds a slider to volume (0-1)
    public float volume;    //Volume setting

    public bool loop; 

    [HideInInspector]   //Won't show in inspector
    public AudioSource source;
}
