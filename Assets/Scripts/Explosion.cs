using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float timeToLive = 1.2f;
    private float countdown;
    public GameObject soundObject;
    
    // Start is called before the first frame update
    void Start()
    {
        countdown = timeToLive;
        Instantiate(soundObject, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0){
            Destroy(gameObject);
        }
    }
}
