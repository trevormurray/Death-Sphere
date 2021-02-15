using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 25.0f;
    public float horizontalInput;
    public float xRange = 17.0f;
    public GameObject projectilePrefab;
    private bool projectileActive = false;
    public float projectileDelay = 50;
    public float projectileCounter = 0;
    public static int kills = 0;
    public static int shotLimit = 3;
    public static int shotCount;
    public AudioClip soundEffect;
    AudioSource audioSource;
    public int maxDefense = 10;
    public static int maxDefenseStatic;
    public static int defensePoints;

    // Start is called before the first frame update
    void Start()
    {
        defensePoints = maxDefense;
        maxDefenseStatic = maxDefense;
        shotCount = shotLimit;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
                
        // Boundary control
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Movement left/right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * horizontalInput);
        // Button to fire - limited by delay period and number of projectiles in play
        if (Input.GetMouseButton(0) && (projectileCounter <= 0) && (shotCount > 0))
        {
            audioSource.PlayOneShot(soundEffect, 0.8f);
            Instantiate(projectilePrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z + 3), projectilePrefab.transform.rotation);
            projectileCounter = projectileDelay;
            Debug.Log("Projectile Active");
            projectileActive = true;
            shotCount -= 1;
        } 
        else if (projectileActive)
        {
            projectileCounter -= Time.deltaTime;
            if (projectileCounter <= 0)
            {
                Debug.Log("Projectile ready.");
                projectileActive = false;
            }
        }
    }
}
