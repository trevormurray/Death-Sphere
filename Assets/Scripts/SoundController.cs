using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioClip audioClip;
    public static AudioClip thisSound;
    
    // Start is called before the first frame update
    void Start()
    {
        thisSound = audioClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound()
    {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(thisSound);
    }
}
