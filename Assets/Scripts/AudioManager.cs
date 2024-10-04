using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;        // Reference to the Audio Source
    public AudioClip introMusic;           // Intro music AudioClip
    public AudioClip ghostNormalMusic;     // Ghost normal state music AudioClip

    void Start()
    {
        // Start by playing the intro music
        audioSource.clip = introMusic;
        audioSource.Play();
        
        // Schedule the normal music to play after the intro finishes
        Invoke("PlayGhostNormalMusic", introMusic.length);
    }

    void PlayGhostNormalMusic()
    {
        // Switch to the ghost normal music and play it
        audioSource.clip = ghostNormalMusic;
        audioSource.Play();
    }
}
