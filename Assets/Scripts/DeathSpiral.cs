using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSpiral : MonoBehaviour
{
    public float enemyDeathDelay;
    public float xRotation;
    public float yRotation;
    public float zRotation;
    private float enemyDeathCount;
    public AudioClip soundEffect;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        enemyDeathCount = enemyDeathDelay;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotation, yRotation, zRotation);
        enemyDeathCount -= Time.deltaTime;
        if (enemyDeathCount <= 0)
        {
            audioSource.PlayOneShot(soundEffect, 0.8f);
            Destroy(gameObject);
        }
    }
}
