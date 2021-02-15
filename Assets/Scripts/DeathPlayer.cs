using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlayer : MonoBehaviour
{
    public GameObject explosionObject;
    public GameObject deathObject;
    public GameObject gameOverObject;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (PlayerController.defensePoints <= 0)
        {
            Instantiate(explosionObject, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
            Instantiate(deathObject, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
            Instantiate(gameOverObject, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerController.kills -= 1;
        Instantiate(explosionObject, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
        Instantiate(deathObject, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
        Instantiate(gameOverObject, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
        Destroy(gameObject);
    }
}
