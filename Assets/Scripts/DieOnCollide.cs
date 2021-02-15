using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnCollide : MonoBehaviour
{
    public int hitPoints = 1;
    public int killValue = 1;
    public GameObject deathObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        hitPoints -= 1;
        if(hitPoints < 1)
        {
            Destroy(gameObject);
            Instantiate(deathObject, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
            PlayerController.kills += killValue;
        }
    }
}
