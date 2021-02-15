using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public int timeToLive = 10;
    private int countdown;
    // Start is called before the first frame update
    void Start()
    {
        countdown = timeToLive;
    }

    // Update is called once per frame
    void Update()
    {
        countdown--;
        if (countdown < 1)
        {
            Destroy(gameObject);
        }
    }
}
