using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnableKeywords : MonoBehaviour
{
    public List<string> keywords = null;

    public AudioClip audioClip = null;
    
    public List<string> getKeywords()
    {
        return keywords;
    }

    public AudioClip GetAudioClip()
    {
        if(audioClip != null) return audioClip;
        Debug.Log("loading default spawn sound");
        return Resources.Load<AudioClip>("Assets/Spawnables/Sounds/Spawning_Default.wav");
    }
}
