using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    public float projectileSpeed;
    public float outOfBounds = -20;
    public GameObject defenseEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * projectileSpeed);
        if (transform.position.z < outOfBounds)
        {
            PlayerController.defensePoints -= 1;
            Instantiate(defenseEffect, new Vector3(transform.position.x, transform.position.y, -20), transform.rotation);
            Destroy(gameObject);
        }
    }
}
